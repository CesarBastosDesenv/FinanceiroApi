using Financeiro.Application.Dto;
using Financeiro.Application.Interfaces;
using Financeiro.Domain.Models;
using Financeiro.Infra.Data.Interfaces;
using System;

namespace Financeiro.Application.Services;

public class AtivoService : IAtivoService
{
    private IAtivoRepository _ativoRepository;

    public AtivoService(IAtivoRepository ativoRepository)
    {
        _ativoRepository = ativoRepository;
       
    }
    public async Task<ResultViewModel> AddAsync(AtivoCadastro args)
    {
        var ativo = new Ativo()
        {
            NomeAtivo = args.NomeAtivo,
            NomeCompleto = args.NomeCompleto
        };
        _ativoRepository.AdicionarAtivo(ativo);
        var result = new ResultViewModel(await _ativoRepository.SaveChangesAsync());
       
        if (!(bool)result.Data)
            result.AddNotification("", "Erro ao cadastrar");

        return result;  
    }

    public Task<ResultViewModel> BuscaAtivo(Guid Id)
    {
        throw new NotImplementedException();
    }

    public async Task<ResultViewModel> GetAllAsync()
    {
        var retorno = await _ativoRepository.BuscaAtivos();
        var retornoModel = retorno.Select(x => new AtivoView(){
            Id = x.Id,
            NomeAtivo = x.NomeAtivo,
            NomeCompleto = x.NomeCompleto
            });
        return new ResultViewModel(retornoModel);
    }

    public Task<ResultViewModel> UpdateAsync(AtivoCadastro ativo)
    {
        throw new NotImplementedException();
    }
}
