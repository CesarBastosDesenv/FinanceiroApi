using Financeiro.Application.Dto;
using System;

namespace Financeiro.Application.Interfaces;

public interface IAtivoService
{
    Task<ResultViewModel> AddAsync(AtivoCadastro ativo);

    Task<ResultViewModel> UpdateAsync(AtivoCadastro ativo);

    Task<ResultViewModel> GetAllAsync();

    Task<ResultViewModel> BuscaAtivo(Guid Id);
}
