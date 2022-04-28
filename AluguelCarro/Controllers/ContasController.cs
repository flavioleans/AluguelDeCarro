using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AluguelCarro.Models;
using AluguelCarro.AcessoDados.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace AluguelCarro.Controllers
{
    [Authorize]
    public class ContasController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IContaRepositorio _contaRepositorio;
        private readonly ILogger<ContasController> _logger;

        public ContasController(IUsuarioRepositorio usuarioRepositorio, IContaRepositorio contaRepositorio, ILogger<ContasController> logger)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _contaRepositorio = contaRepositorio;
            _logger = logger;
        }

        // GET: Contas
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Listando os saldos");
            return View(await _contaRepositorio.PegarTodos());
        }

        // GET: Contas/Create
        public IActionResult Create()
        {
            _logger.LogInformation("Criar novo saldo");
            ViewData["UsuarioId"] = new SelectList(_usuarioRepositorio.PegarTodos(), "Id", "Email");
            return View();
        }

        // POST: Contas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContaId,UsuarioId,Saldo")] Conta conta)
        {
            if (ModelState.IsValid)
            {
                await _contaRepositorio.Inserir(conta);
                _logger.LogInformation("Novo saldo criado");
                return RedirectToAction(nameof(Index));
            }
            _logger.LogError("Informações inválidas");
            ViewData["UsuarioId"] = new SelectList(_usuarioRepositorio.PegarTodos(), "Id", "Email", conta.UsuarioId);
            return View(conta);
        }

        // GET: Contas/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            _logger.LogInformation("Atualizar conta");
            var conta = await _contaRepositorio.PegarPeloId(id);
            if (conta == null)
            {
                _logger.LogError("Conta não encontrada");
                return NotFound();
            }
            _logger.LogError("informações invalidas");
            ViewData["UsuarioId"] = new SelectList(_usuarioRepositorio.PegarTodos(), "Id", "Email", conta.UsuarioId);
            return View(conta);
        }

        // POST: Contas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContaId,UsuarioId,Saldo")] Conta conta)
        {
            if (id != conta.ContaId)
            {
                _logger.LogError("informações invalidas");
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _contaRepositorio.Atualizar(conta);
                _logger.LogInformation("Atualizando conta");
                return RedirectToAction(nameof(Index));
            }
            _logger.LogInformation("Informações inválidas");
            ViewData["UsuarioId"] = new SelectList(await _contaRepositorio.PegarTodos(), "Id", "Email", conta.UsuarioId);
            return View(conta);
        }

        // POST: Contas/Delete/5
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            _logger.LogInformation("Exluindo Conta");
            await _contaRepositorio.Excluir(id);
            _logger.LogInformation("Conta excluida");
            return Json("Conta excluída");
        }
    }
}
