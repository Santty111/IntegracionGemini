namespace IntegracionGemini.Interfaces
{
    public interface IChatbotService
    {
        public Task<string> ObtenerRespuestaChatbot(string prompt);
        public bool GuardarRespuestaBaseDatoLocal(string prompt, string respuesta);

    }
}
