using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Aplicação_mvc_Principal.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System;

namespace Aplicação_mvc_Principal.Servicos
{
    public class ApiService
    {
        public static async Task<List<Vaga>> GetVagas()
        {
            HttpClient http = new HttpClient();
            var responseGet = await http.GetAsync("https://localhost:8080/Vagas");
            if (responseGet.IsSuccessStatusCode)
            {
                var resultado = responseGet.Content.ReadAsStringAsync().Result;
                var vagas = JsonConvert.DeserializeObject<List<Vaga>>(resultado);
                return vagas;
            }
            return new List<Vaga>();
        }
       
        public static async Task<List<Vaga>> PostVagas(Vaga vaga)
        {
            HttpClient http = new HttpClient();
            var jsonContent = JsonConvert.SerializeObject(vaga);
            var jsonString = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
            var responsePost = await http.PostAsync("https://localhost:8080/Vagas", jsonString);
            if (responsePost.IsSuccessStatusCode)
            {
            }
            return new List<Vaga>();
        }

        public static async Task<List<Vaga>> DeleteVaga(int id)
        {

            HttpClient http = new HttpClient();
            string caminho = $"https://localhost:8080/vagas/{id}";
            var responseDelete = await http.DeleteAsync(caminho);
            return new List<Vaga>();
        }

        public static async Task<List<Vaga>> PutVaga(int id, Vaga novaVaga)
        {
            HttpClient http = new HttpClient();
            string caminho = $"https://localhost:8080/vagas/{id}";
            var jsonContent = JsonConvert.SerializeObject(novaVaga);
            var jsonString = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
            var responsePut = await http.PutAsync(caminho, jsonString);
            return new List<Vaga>();
        }

 //--------------------------------AREA CANDIDATOS-----------------------------------------------------------------------------------------------------
        public static async Task<List<Candidato>> GetCandidatos()
        {
            HttpClient http = new HttpClient();
            var response = await http.GetAsync($"{Program.ApiHost}/Candidatos");
            if (response.IsSuccessStatusCode)
            {
                var resultado = response.Content.ReadAsStringAsync().Result;
                var candidatos = JsonConvert.DeserializeObject<List<Candidato>>(resultado);
                return candidatos;
            }
            return new List<Candidato>();
        }

        public static async Task<List<Candidato>> PostCandidato(Candidato candidato)
        {
            HttpClient http = new HttpClient();
            var jsonContent = JsonConvert.SerializeObject(candidato);
            var jsonString = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
            var responsePost = await http.PostAsync("https://localhost:8080/Candidatos", jsonString);
            if (responsePost.IsSuccessStatusCode)
            {
            }
            return new List<Candidato>();
        }

        public static async Task<List<Candidato>> DeleteCandidato(int id)
        {
            HttpClient http = new HttpClient();
            string caminho = $"https://localhost:8080/Candidatos/{id}";
            var responseDelete = await http.DeleteAsync(caminho);
            return new List<Candidato>();
        }
         public static async Task<List<Candidato>> PutCandidato(int id, Candidato novoCadidato)
        {
            HttpClient http = new HttpClient();
            string caminho = $"https://localhost:8080/Candidatos/{id}";
            var jsonContent = JsonConvert.SerializeObject(novoCadidato);
            var jsonString = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");
            var responsePut = await http.PutAsync(caminho, jsonString);
            return new List<Candidato>();
        }

    }
}