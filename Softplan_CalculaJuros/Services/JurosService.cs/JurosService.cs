using RestSharp;
using System;

namespace Softplan_CalculaJuros.Services.JurosService.cs
{
    public class JurosService : IJurosService
    {
        public double CalculaJuros(double valorInicial, int tempo)
        {
            if (tempo < 0)
            {
                throw new Exception("Tempo não pode ser negativo.");
            }

            var juros = GetJuros();
            var jurosCompostos = valorInicial * Math.Pow((1+juros), tempo);

            return Math.Truncate(100 * jurosCompostos) / 100;
        }

        private static double GetJuros()
        {
            var url = "https://localhost:1080/ConsultaJuros/taxaJuros";
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            var response = client.Execute<double>(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Erro ao consultar Juros - StatusCode: " + response.StatusCode);
            }

            return response.Data;
        }

        public string GetUrl()
        {
            var url = "https://github.com/Tbrandaos/Softplan_CalculaJuros";
            return url;
        }
    }
}
