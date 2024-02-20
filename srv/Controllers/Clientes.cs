using Microsoft.AspNetCore.Mvc;
using RinhaBachend2024q1.Model;

namespace RinhaBachend2024q1.Controllers;


[Route("/clientes")]
public class Clientes : ControllerBase
{
    private readonly ILogger<Clientes> _logger;

    public Clientes(ILogger<Clientes> logger)
    {
        _logger = logger;
    }


    [HttpGet("{id}/extrato")]
    public async Task<IActionResult> Extrato()
    {
        return Ok("Get do extrato feito");
    }

    [HttpPost("{id}/transacoes")]
    public async Task<IActionResult> FazerTransacao(int id, [FromBody] TransacaoModel transacao)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _logger.LogInformation("Propriedades e valores da transação: {TransacaoModel}", transacao);
        return Ok($"Transação para id {id} recebida");

    }

}