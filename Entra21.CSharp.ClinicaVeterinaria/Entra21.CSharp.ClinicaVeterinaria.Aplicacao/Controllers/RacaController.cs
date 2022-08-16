using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Servico;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplicacao.Controllers
{
    // Dois pontos mais pra frente é sobre Herença
    public class RacaController : Controller
    {
<<<<<<< HEAD
        private RacaServico _racaServico;
=======
        private readonly RacaServico _racaServico;
>>>>>>> d40bbab2a50f936b9ec775a9b831c826320d4654

        /* Construtor: objetivo - construir o objeto de RacaController,
         com o mínimo necessário para o funcionamento correto */

        public RacaController(ClinicaVeterinariaContexto contexto)
        {
<<<<<<< HEAD
            _racaServico = new RacaServico(contexto);
=======
            _racaServico = new RacaServico(contexto);            
>>>>>>> d40bbab2a50f936b9ec775a9b831c826320d4654
        }

        /// <summary>
        /// Endpoint que permite lista todas as raças
        /// </summary>
        /// <returns>Retorna a página html com as raças</returns>
        [Route("/raca")]
        [HttpGet]
        public IActionResult ObterTodos()
        {
            var racas = _racaServico.ObterTodos();

            // Passar informação do C# para o HTML
            ViewBag.Racas = racas;

            return View("Index");

        }

        [Route("/raca/cadastrar")]
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [Route("/raca/registrar")]
        [HttpGet]
<<<<<<< HEAD

        public IActionResult Registrar(
=======
        public IActionResult Registrar (
>>>>>>> d40bbab2a50f936b9ec775a9b831c826320d4654
            [FromQuery] string nome,
            [FromQuery] string especie)
        {
            _racaServico.Cadastrar(nome, especie);

            return RedirectToAction("Index");
        }
    }
}
