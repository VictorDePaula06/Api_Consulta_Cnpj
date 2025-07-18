using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiConsultaCnpj.Models;
using ApiConsultaCnpj.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiConsultaCnpj.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class CnpjController : ControllerBase
    {
        private readonly CnpjService _cnpjService;

        public CnpjController(CnpjService cnpjService)
        {
            _cnpjService = cnpjService;
        }

        [HttpGet("{cnpj}")]
        public async Task<IActionResult> Get(string cnpj)
        {
            var resultado = await _cnpjService.ConsultarCnpjAsync(cnpj);

            if (resultado == null)
                return NotFound("CNPJ não encontrado");

            var inscricaoEstadual = resultado.Estabelecimento?.InscricaoEstaduais?
            .Select(inscricao => new
            {
                numero = inscricao.Numero,
                ativo = inscricao.Ativo,
                estado = inscricao.Estado
            });

            return Ok(new
            {
                razaoSocial = resultado.RazaoSocial,
                cnpj = resultado.Estabelecimento?.Cnpj,
                status = resultado.Estabelecimento?.Status,
                InscricaoEstadual = inscricaoEstadual
            });
        }
    }
}