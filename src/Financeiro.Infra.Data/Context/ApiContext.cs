using System;
using Financeiro.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Infra.Data.Context;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions<ApiContext> options) : base(options)
    {
        
    }

    public DbSet<Ativo> Ativos { get; set;}

}
