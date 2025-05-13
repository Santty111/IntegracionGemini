using IntegracionGemini.Controllers;
using IntegracionGemini.Interfaces;

namespace IntegracionGemini.Repositories
{
    public class OpenAIRepository : IChatbotService
    {
        private readonly ILogger<HomeController> _logger;


        public bool GuardarRespuestaBaseDatoLocal(string prompt, string respuesta)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerRespuestaChatbot(string prompt)
        {
            throw new NotImplementedException();
        }
    }
}
