using AluguelCarro.AcessoDados.Interfaces;
using AluguelCarro.Models;
using AluguelCarro.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ILogger<UsuariosController> _logger;

        public UsuariosController(IUsuarioRepositorio usuarioRepositorio, ILogger<UsuariosController> logger)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Listando informações");
            return View(await _usuarioRepositorio.PegarUsuarioLogado(User));
        }

        [AllowAnonymous]
        public async Task<IActionResult> Registro()
        {
            //deslogar usuario caso esteja logado
            if (User.Identity.IsAuthenticated)
                await _usuarioRepositorio.EfetuarLogOut();

            _logger.LogInformation("Entrando na página de registro");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Registro(RegistroViewModel registro)
        {
            if (ModelState.IsValid)
            {
                var usuario = new Usuario
                {
                    UserName = registro.NomeUsuario,
                    Email = registro.Email,
                    CPF = registro.CPF,
                    Telefone = registro.Telefone,
                    Nome = registro.Nome,
                    PasswordHash = registro.Senha
                };

                _logger.LogInformation("Tetando criar um usuario");
                //status da criação do usuario
                var resultado = await _usuarioRepositorio.SalvarUsuario(usuario, registro.Senha);
               
                //verificando se cadastro esta ok.
                if (resultado.Succeeded)
                {
                    _logger.LogInformation("Novo Usuário criado");
                    _logger.LogInformation("Atribuindo nível de acesso ao usuário");
                    var nivelAcesso = "Cliente";

                    await _usuarioRepositorio.AtribuirNivelAcesso(usuario, nivelAcesso);
                    _logger.LogInformation("Atribuição concluida");

                    _logger.LogInformation("Logando o usuário");
                    await _usuarioRepositorio.EfetuarLogin(usuario, false);
                    _logger.LogInformation("Usuario logado com sucesso");

                    return RedirectToAction("Index", "Usuarios");
                }
                else
                {
                    _logger.LogError("Erros ao criar o usuário");

                    foreach (var erro in resultado.Errors)
                        ModelState.AddModelError("", erro.Description.ToString());
                }
            }

            _logger.LogError("Informações de usuário inválidas");
            return View(registro);
        }

        //action login
        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            if (User.Identity.IsAuthenticated)
                await _usuarioRepositorio.EfetuarLogOut();
            
            _logger.LogInformation("Entrando na página de login");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation("Pegando usuario pelo e-mail");
                var usuario = await _usuarioRepositorio.PegarUsuarioPeloEmail(login.Email);
                PasswordHasher<Usuario> passwordHasher = new PasswordHasher<Usuario>();

                if (usuario != null)
                {
                    _logger.LogInformation("Vefificando informações do usuário");
                    if (passwordHasher.VerifyHashedPassword(usuario, usuario.PasswordHash, login.Senha) != PasswordVerificationResult.Failed)
                    {
                        _logger.LogInformation("informações corretas. logando o usuário");
                        await _usuarioRepositorio.EfetuarLogin(usuario, false);

                        return RedirectToAction("Index", "Usuarios");
                    }

                    _logger.LogError("Informações inválidas");
                    ModelState.AddModelError("", "Email e/ou senha inválidos");
                }

                _logger.LogError("Informações inválidas");
                ModelState.AddModelError("", "Email e/ou senha inválidos");

            }

            return View(login);
        }

        public async Task<IActionResult> LogOut()
        {
            await _usuarioRepositorio.EfetuarLogOut();

            return RedirectToAction("Login", "Usuarios");
        }

        //atualizar usuario
        [HttpGet]
        public async Task<IActionResult> Atualizar(string usuarioId)
        {
            _logger.LogInformation("Verificando se o usuáeio existe");
            var usuario = await _usuarioRepositorio.PegarPeloId(usuarioId);

            var atualizarViewModel = new AtualizarViewModel
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                CPF = usuario.CPF,
                Email = usuario.Email,
                Telefone = usuario.Telefone,
                NomeUsuario = usuario.UserName
            };
            _logger.LogInformation("Atualizar usuário");
            return View(atualizarViewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Atualizar(AtualizarViewModel atualizarViewModel)
        {
            if (ModelState.IsValid)
            {
                var usuario = await _usuarioRepositorio.PegarPeloId(atualizarViewModel.Id);

                usuario.Nome = atualizarViewModel.Nome;
                usuario.CPF = atualizarViewModel.CPF;
                usuario.UserName = atualizarViewModel.NomeUsuario;
                usuario.Email = atualizarViewModel.Email;
                usuario.Telefone = atualizarViewModel.Telefone;

                await _usuarioRepositorio.AtualizarUsuario(usuario);
                _logger.LogInformation("Atualizando usuário");

                return RedirectToAction("Index", "Usuarios");

            }
            _logger.LogError("Informações inválidas");

            return View(atualizarViewModel);
        }

    }
}
