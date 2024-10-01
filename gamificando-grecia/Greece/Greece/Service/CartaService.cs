using Greece.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Greece.Service
{
    internal class CartaService
    {
        private HttpClient httpClient;
        private JsonSerializerOptions jsonSerializerOptions; 
        Uri uri = new Uri("https://jsonplaceholder.typicode.com/cartas");
        private ObservableCollection<Carta>? cartas;

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
        public async Task<Carta> SaveCartaAsync(Carta item)//Task do tipo Post,para retornar as infos da classe post,precisa verifcar o que a api retorna no postman//
        {
            try
            {

                string json = JsonSerializer.Serialize<Carta>(item, jsonSerializerOptions);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uri, content);
                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(response.Content);
                }

            }
            catch (Exception e)
            {

                Debug.WriteLine(e.Message);


            }
            return cartas; 
        }

    }
}
