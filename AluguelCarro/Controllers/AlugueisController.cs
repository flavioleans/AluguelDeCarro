﻿using AluguelCarro.AcessoDados.Interfaces;
using AluguelCarro.Models;
using AluguelCarro.Models.ViewModels;
using AluguelCarro.Servicos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.Controllers
{
    [Authorize]
    public class AlugueisController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IContaRepositorio _contaRepositorio;
        private readonly IAluguelRepositorio _aluguelRepositorio;
        private readonly ILogger<AlugueisController> _logger;
        private readonly IEmail _email;
        public AlugueisController(IUsuarioRepositorio usuarioRepositorio, IContaRepositorio contaRepositorio, IAluguelRepositorio aluguelRepositorio, ILogger<AlugueisController> logger, IEmail email)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _contaRepositorio = contaRepositorio;
            _aluguelRepositorio = aluguelRepositorio;
            _logger = logger;
            _email = email;
        }
        public IActionResult Alugar(int carroId, int precoDiaria)
        {
            _logger.LogInformation("Começando o aluguel do carro");

            var aluguel = new AluguelViewModel
            {
                CarroId = carroId,
                PrecoDiaria = precoDiaria
            };
            return View(aluguel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alugar(AluguelViewModel aluguel)
        {
            if (ModelState.IsValid)
            {
                var usuario = await _usuarioRepositorio.PegarUsuarioLogado(User);
                var saldo =  _contaRepositorio.PegarSaldoPeloId(usuario.Id);

                if (await _aluguelRepositorio.VerificarReserva(usuario.Id, aluguel.CarroId, aluguel.Inicio, aluguel.Fim))
                {
                    _logger.LogInformation("Usuário já possui essa reserva");
                    TempData["Aviso"] = "Você já possui essa reserva";
                    return View(aluguel);
                }
                else if(aluguel.PrecoTotal > saldo)
                {
                    _logger.LogInformation("Saldo insuficiente");
                    TempData["Aviso"] = "Saldo insuficiente";
                    return View(aluguel);
                }
                else
                {
                    Aluguel a = new Aluguel
                    {
                        UsuarioId = usuario.Id,
                        CarroId = aluguel.CarroId,
                        Inicio = aluguel.Inicio,
                        Fim = aluguel.Fim,
                        PrecoTotal = aluguel.PrecoTotal
                    };

                    _logger.LogInformation("Enviando e-mail com detalhes da reserva");
                    string assunto = "reserva concluida com sucesso";

                    string mensagem = string.Format("Seu veículo já o aguarda. Você podera pega-lo dia {0}" +
                        " e devara deveolve-lo dia {1}. o preço será de R${2},00. Divirta-se!!!", aluguel.Inicio, aluguel.Fim, aluguel.PrecoTotal);

                    await _email.EnviarEmail(usuario.Email, assunto, mensagem);

                    await _aluguelRepositorio.Inserir(a);
                    _logger.LogInformation("Reserva feita");

                    _logger.LogInformation("Atualizando saldo usuario");
                    var saldoUsuario = await _contaRepositorio.PegarSaldoPeloUsuarioId(usuario.Id);
                    saldoUsuario.Saldo = saldoUsuario.Saldo - aluguel.PrecoTotal;
                    await _contaRepositorio.Atualizar(saldoUsuario);
                    _logger.LogInformation("Saldo Atualizado");


                    return RedirectToAction("index", "Carros");
                }
            }
            _logger.LogInformation("Informações inválidas");
            return View(aluguel);

        }
    }
}
