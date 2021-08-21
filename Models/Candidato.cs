
using System;

namespace Aplicação_mvc_Principal.Models
{
  public record Candidato
  {
    public int CandidatoId { get;set; }

    public string NomeCandidato{get; set;}
    public string estado_civil{get; set;}
    public string genero{get; set;}
    public DateTime  data_nascimento{get; set;}
    public string cep { get;set; }
    public string endereco { get;set; }
    public string numero { get;set; }
    public string complemento { get;set; }
    public string bairro { get;set; }
    public string cidade { get;set; }
    public string uf { get;set; }
    public string telefone_fixo { get;set; }
    public string telefone_movel { get;set; }
    public string email{get; set;}
    public string cpf{get; set;}
    public string rg{get; set;}
    public Boolean possui_veiculo{get; set;}
    public String habilitacao{get; set;}
    public int vaga_id{get; set;}
    public Vaga Cargo { get;set; }
  }
}