using System;

namespace Financeiro.Domain.Models;

public class Ativo
{
  public Guid Id { get; set; }

  public required string NomeAtivo { get; set; } 

  public required string NomeCompleto { get; set; }  

   
}
