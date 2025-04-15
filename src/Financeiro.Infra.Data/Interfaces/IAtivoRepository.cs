using System;
using Financeiro.Domain.Models;

namespace Financeiro.Infra.Data.Interfaces;

public interface IAtivoRepository
{
    Task<IEnumerable<Ativo>> BuscaAtivos();
    Task<Ativo> BuscaId(Guid Id);
    void AdicionarAtivo(Ativo ativo);
    void AtualizarAtivo(Ativo ativo);
    void DeletarAtivo(Ativo ativo);

    Task<bool> SaveChangesAsync();
}
