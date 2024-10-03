using Greece.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Greece.Services
{
    internal class CartaService
    {
        private HttpClient httpClient;
        private ObservableCollection<Carta> cartas;
        private Carta carta;
        private JsonSerializerOptions jsonSerializerOptions; // configurar/formatar o JSON
        Uri uri = new Uri("https://localhost8080/cartas");
    
        public CartaService()
        {
            httpClient = new HttpClient();
            jsonSerializerOptions = new JsonSerializerOptions
            {
                //propriedades dos serializer options
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }

        public async Task<ObservableCollection<Carta>> GetCartasAsync() // TASK: usado no await
        {

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(uri);//quero saber todos os posts;
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();// tranforma o conteudo em string;
                    cartas = JsonSerializer.Deserialize<ObservableCollection<Carta>>(content, jsonSerializerOptions);
                }
            }
            catch
            {

            }
            return cartas;
        }



        public async Task<Carta> GetCartaByIdAsync(int id) // TASK: usado no await
        {

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{uri}/{id}");//quero saber todos os posts;
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();// tranforma o conteudo em string;
                    carta = JsonSerializer.Deserialize<Carta>(content, jsonSerializerOptions);
                }
            }
            catch
            {

            }
            return carta;
        }


    }
}
