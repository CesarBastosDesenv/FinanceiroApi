using System;

namespace Financeiro.Application.Dto;

public class AtivoView
{
  public Guid Id { get; set; }

  public required string NomeAtivo { get; set; } 

  public required string NomeCompleto { get; set; }  
}
