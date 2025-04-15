using System;
using Financeiro.Application.Dto;
using Financeiro.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Financeiro.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AtivoController : ControllerBase
{
     private ILogger<AtivoController> _logger;
     private IAtivoService _ativoService;

     public AtivoController(ILogger<AtivoController> logger, IAtivoService ativoService)
    {
        _logger = logger;
        _ativoService = ativoService;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        try
        {
            var result = await _ativoService.GetAllAsync();
            return Ok(result);
        }
        catch (Exception ex)
        {
            var er = new ResultViewModel();
            er.AddNotification("Erro", ex.Message);
            return BadRequest(er);
        }
    } 

    [HttpPost]
    public async Task<ActionResult> Add(AtivoCadastro args)
    {
        try
        {
            if (!ModelState.IsValid) return Ok(new ResultViewModel(args, ModelState));
            var result = await _ativoService.AddAsync(args);
            return Ok(result);
        }
        catch (Exception ex)
        {
            var er = new ResultViewModel();
            er.AddNotification("Erro", ex.Message);
            return BadRequest(er);
        }
    }
}
