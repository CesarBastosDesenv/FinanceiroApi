using Financeiro.Domain.Models;
using Financeiro.Infra.Data.Context;
using Financeiro.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace Financeiro.Infra.Data.Repositories;

public class AtivoRepository : IAtivoRepository
{
     private readonly ApiContext _context;

         public AtivoRepository(ApiContext context)
        {
            _context = context;
        }

    public void AdicionarAtivo(Ativo ativo)
    {
         _context.Add(ativo);
    }

    public void AtualizarAtivo(Ativo ativo)
    {
        _context.Update(ativo);
    }

    public async Task<IEnumerable<Ativo>> BuscaAtivos()
    {
        return await _context.Ativos.ToListAsync();
    }

    public async Task<Ativo> BuscaId(Guid Id)
    {
        return await _context.Ativos.
                       Where(x => x.Id == Id).FirstOrDefaultAsync();
    }

    public void DeletarAtivo(Ativo ativo)
    {
        _context.Remove(ativo);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

   
}
