
using ConsoleApp.Modelo;
using Newtonsoft.Json;
using System.Text.Json;

namespace ConsoleApp.Utilidade
{
    public static class JsonExtensions
    {
        public static List<Fluxo> Convert(string pasta, string nomeArquivo)
        {
            var caminhoArquivo = Path.Combine("..", "ConsoleApp", pasta, nomeArquivo);
            var jsonString = File.ReadAllText(caminhoArquivo);
            return JsonConvert.DeserializeObject<List<Fluxo>>(jsonString);
        }
    }
}
