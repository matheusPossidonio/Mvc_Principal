
using System;
using System.Text.Json.Serialization;

namespace Aplicação_mvc_Principal.Models
{
  public class Candidato
  {
    public int candidatoId { get;set; }
    public string nomeCandidato{get; set;}
    public string estadoCivil{get; set;}
    public string genero{get; set;}
    public DateTime  dataNascimento{get; set;}
    public string cep { get;set; }
    public string endereco { get;set; }
    public string numero { get;set; }
    public string complemento { get;set; }
    public string bairro { get;set; }
    public string cidade { get;set; }
    public string uf { get;set; }
    public string telefoneFixo { get;set; }
    public string telefoneMovel { get;set; }
    public string emailCandidato{get; set;}
    public string cpf{get; set;}
    public string rg{get; set;}
    public Boolean possuiVeiculo{get; set;}
    public String tipoHabilitacao{get; set;}
    public int vagaId{get; set;}
    [JsonIgnore]
    public Vaga Cargo { get;set; }
  }
}