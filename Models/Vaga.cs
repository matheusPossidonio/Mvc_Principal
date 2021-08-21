using System;

namespace Aplicação_mvc_Principal.Models
{
    public record  Vaga
  {
    public int vagaId { get;set; }
    public string nomeVaga { get;set; }
     public string descricaoVaga { get;set; }
  }
}