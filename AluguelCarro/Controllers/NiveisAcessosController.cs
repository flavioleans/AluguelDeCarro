using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AluguelCarro.Models;
using Microsoft.Extensions.Logging;
using AluguelCarro.AcessoDados.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace AluguelCarro.Controllers
{
    [Authorize]
    public class NiveisAcessosController : Controller
    {
        private readonly INivelAcessoRepositorio _nivelAcessoRepositorio;
        //logging
        private readonly ILogger<NiveisAcessosController> _logger;

        public NiveisAcessosController(INivelAcessoRepositorio nivelAcessoRepositorio, ILogger<NiveisAcessosController> logger)
        {
            _nivelAcessoRepositorio = nivelAcessoRepositorio;
            _logger = logger;
        }

        // GET: NiveisAcessos
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Listando todos os registros");
            return View(await _nivelAcessoRepositorio.PegarTodos().ToListAsync());
        }

        // GET: NiveisAcessos/Create
        public IActionResult Create()
        {
            _logger.LogInformation("Iniciado criação de niveis de acessso");
            return View();
        }

        // POST: NiveisAcessos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descricao,Name")] NiveisAcesso niveisAcesso)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation("Verificando se o nivel de acesso existe");
                bool nivelExiste = await _nivelAcessoRepositorio.NivelAcessoExiste(niveisAcesso.Name);

                if (!nivelExiste)
                {
                    //atribuindo nome maiusculo
                    niveisAcesso.NormalizedName = niveisAcesso.Name.ToUpper();
                    await _nivelAcessoRepositorio.Inserir(niveisAcesso);
                    _logger.LogInformation("Novo nivel de acesso criado");

                    return RedirectToAction("Index", "NiveisAcessos");
                }
            }
            _logger.LogError("Informações invalidas");
            return View(niveisAcesso);
        }

        // GET: NiveisAcessos/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            _logger.LogInformation("Atualizando nivel de acesso");
            if (id == null)
            {
                _logger.LogInformation("Nivel não encontrado");
                return NotFound();
            }

            var niveisAcesso = await _nivelAcessoRepositorio.PegarPeloId(id);
            if (niveisAcesso == null)
            {
                return NotFound();
            }
            return View(niveisAcesso);
        }

        // POST: NiveisAcessos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Descricao,Id,Name,NormalizedName,ConcurrencyStamp")] NiveisAcesso niveisAcesso)
        {
            if (id != niveisAcesso.Id)
            {
                _logger.LogInformation("Nivel não encontrado");
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _nivelAcessoRepositorio.Atualizar(niveisAcesso);
                _logger.LogInformation("Nivel Atualizado");
                return RedirectToAction("Index", "NiveisAcessos");
            }
            _logger.LogInformation("Informacções invalidas");
            return View(niveisAcesso);
        }


        // POST: NiveisAcessos/Delete/5
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            await _nivelAcessoRepositorio.Excluir(id);
            _logger.LogInformation("Nivel excluído");
            return RedirectToAction(nameof(Index));
        }

    }
}
