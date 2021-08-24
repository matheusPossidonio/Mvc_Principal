using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aplicação_mvc_Principal.Models;
using Aplicação_mvc_Principal.Servicos;

namespace Aplicação_mvc_Principal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        { 
            //teste do crud de vagas 

            /* Criação de de um objeto teste para testar o PostVagas(), passando um objeto do tipo vaga/tudo ok
            Vaga vaga_teste_post = new Vaga() { vagaId= 0,nomeVaga="medico",descricaoVaga="Profissional que cura infermidades" } ;
            ViewBag.Vagas = await ApiService.PostVagas(vaga_teste_post);
            */

            /*criação de um id e passado para o metodo deletevaga para testar seu funcionamento/tudo ok
            int id = 1;
            ViewBag.Vagas = await ApiService.DeleteVaga(id);
            */

            /*criação de um id e um objeto do tipo vaga passado para o metodo putvaga  para testar seu funcionamento/tudo ok
            Vaga vaga_teste_put = new Vaga() {vagaId=5, nomeVaga="Cientista",descricaoVaga="Pessoa que produz ciencia" } ;
            ViewBag.Vagas = await ApiService.PutVaga(5,vaga_teste_put);
            */
            //ViewBag.Vagas = await ApiService.PostVagas(vaga_teste_put);
            //teste do getVagas
            ViewBag.Vagas = await ApiService.GetVagas();


            //--testes do crud dos candidatos
            //criando  um candidato que ser usado no teste
             Candidato candidato_teste = new Candidato{
                 nomeCandidato = "josevaldo", estadoCivil = "casado", genero = "feminino",
                dataNascimento =  new DateTime(1979, 04, 19), cep = "5840755", endereco = "alto branco",
                numero = "884444486", complemento = " 10", bairro = "alto branco", cidade = "campina grande",
                uf = "pb", telefoneFixo = "33555889", telefoneMovel= " 8844556698", emailCandidato = "teste@gmail.com",
                cpf = "11122233348", rg = "4588779", possuiVeiculo = true, tipoHabilitacao = "A", vagaId = 1};
            
            //no put o candidato deve ter o id
            ViewBag.Candidatos = await ApiService.PutCandidato(10,candidato_teste);
            //no post o objeto candidato nao deve possui o id caso coloque um ele nao adiciona na api 
            //ViewBag.Candidatos = await ApiService.PostCandidato(candidato_teste);
           // ViewBag.Candidatos = await ApiService.DeleteCandidato(3);
            ViewBag.Candidatos = await ApiService.GetCandidatos();

            
           
            //ViewBag.Candidatos = await ApiService.PostCandidato(candidato_teste);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
