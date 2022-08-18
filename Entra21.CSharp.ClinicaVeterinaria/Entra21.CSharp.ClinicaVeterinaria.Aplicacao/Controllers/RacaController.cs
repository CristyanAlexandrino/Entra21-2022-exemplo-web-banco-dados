using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Enums;
using Entra21.CSharp.ClinicaVeterinaria.Servico;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplicacao.Controllers
{
    // Dois pontos mais pra frente é sobre Herença
    public class RacaController : Controller
    {
        private readonly RacaServico _racaServico;
        private readonly List<string> _especies;
        /* Construtor: objetivo - construir o objeto de RacaController,
         com o mínimo necessário para o funcionamento correto */

        public RacaController(ClinicaVeterinariaContexto contexto)
        {
            _racaServico = new RacaServico(contexto);
        }

        /// <summary>
        /// Endpoint que permite lista todas as raças
        /// </summary>
        /// <returns>Retorna a página html com as raças</returns>
        [Route("/raca")]
        [HttpGet]
        public IActionResult ObterTodos()
        {
            var raca = _racaServico.ObterTodos();

            // Passar informação do C# para o HTML
            ViewBag.Racas = raca;

            return View("Index");

        }

        [Route("/raca/cadastrar")]
        [HttpGet]
        public IActionResult Cadastrar()
        {
            var especies = ObterEspecies();
            ViewBag.Especies = especies;
            return View();
        }

        [Route("/raca/cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar(

            [FromForm] string nome,
            [FromForm] string especie)
        {
            _racaServico.Cadastrar(nome, especie);

            return RedirectToAction("Index");
        }
        [Route("/racas/apagar")]
        [HttpGet]

        public IActionResult Apagar([FromQuery] int id)
        {
            _racaServico.Apagar(id);

            return RedirectToAction("Index");
        }
        [Route("/racas/editar")]
        [HttpGet]

        public IActionResult Editar([FromQuery] int id)
        {
            var raca = _racaServico.ObterPorId(id);
            var especies = ObterEspecies();

            ViewBag.Raca = raca;
            ViewBag.Especies = especies;

            return View("Editar");

        }
        [HttpPost]
        [Route("/raca/alterar")]

        public IActionResult Editar(
            [FromForm] int id,
            [FromForm] string nome,
            [FromForm] string especie)
        {
            _racaServico.Editar(id, nome, especie);

            return RedirectToAction("Index");
        }

        private List<string> ObterEspecies()
        {
            return Enum.GetNames<Especie>().OrderBy(x => x).ToList();
        }
    }
}
