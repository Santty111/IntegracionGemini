using System.Diagnostics;
using IntegracionGemini.Interfaces;
using IntegracionGemini.Models;
using IntegracionGemini.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IntegracionGemini.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IChatbotService _chatbotService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _chatbotService = new GeminiRepository();

        }

        public async Task<IActionResult> Index()
        {
            var response = await _chatbotService.ObtenerRespuestaChatbot("Resumen de 100 palabras de Titanic"); 
            ViewBag.respuesta = response;
            return View();
        }
    }
}
