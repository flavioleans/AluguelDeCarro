using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarro.Controllers
{
    public class ErrosController : Controller
    {
        [HttpGet("Erros/{codigoErro}")]
        public IActionResult Index(int codigoErro)
        {
            return View(codigoErro);
        }
    }
}
