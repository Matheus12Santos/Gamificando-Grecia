using Jogo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jogo.Services
{
    internal class MedidorService
    {
        private HttpClient httpClient;
        private Medidor medidor;
        private JsonSerializerOptions jsonSerializerOptions; // configurar/formatar o JSON
        Uri uri = new Uri("http://localhost:8080/medidores");

        public MedidorService()
        {
            httpClient = new HttpClient();
            jsonSerializerOptions = new JsonSerializerOptions
            {
                //propriedades dos serializer options
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }




        public async Task<Medidor> GetMedidorByIdAsync(int id)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{uri}/{id}");//quero saber todos os posts;
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    medidor = JsonSerializer.Deserialize<Medidor>(content, jsonSerializerOptions);
                    if (medidor == null)
                    {
                        Console.WriteLine("A deserialização retornou nulo.");
                    }
                }
                else
                {
                    Console.WriteLine($"Falha ao chamar a API. Código de status: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao fazer a chamada da API: {ex.Message}");
            }
            return medidor;
        }

    }
}
