using Efinance.Models.Dto;
using Efinance.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Efinance.Api.Controllers
{
    [Route("Efinance/V1/[controller]/[action]")]
    [Produces("application/json")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        int QtdeLineByPage;
        public ClienteController(IConfiguration configuration)
        {
            // quantidade de registro por pagina pra ser usado na paginação recebida por di direto do setting.json
            QtdeLineByPage = Convert.ToInt16(configuration.GetConnectionString("QtdeRegByPage"));
        }
        [HttpGet]
        public async Task<ActionResult<Cliente>> GetAllCliente([FromServices] IClienteService _ClienteService, [FromServices] ILogger<ClienteController> _logger)
        {
            try
            {

                var result = await _ClienteService.GetAllAsync();

                if (result == null)
                {
                    return (ActionResult)NotFound();
                }

                return (ActionResult)Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "erro ao tentar obter dados.verifique condiçoes quanto ao banco de dados");
                return new StatusCodeResult(500); //condicao inesperada no servidor , nao foi possivel atender a solicitação
            }
        }


        [HttpPost]

        public async Task<ActionResult<int>> AddCliente([FromBody] Cliente cliente, [FromServices] IClienteService _ClienteService, [FromServices] ILogger<ClienteController> _logger)
        {
            try
            {


                var result = await _ClienteService.AddAsync(cliente);

                if (result != -1)
                {

                    return (ActionResult)Ok(result);

                }
                return (ActionResult)NotFound(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "erro ao tentar obter dados.verifique condiçoes quanto ao banco de dados");
                return new StatusCodeResult(500); //condicao inesperada no servidor , nao foi possivel atender a solicitação
            }
        }
        [HttpPut]

        public async Task<ActionResult<bool>> UpdateCliente([FromBody] Cliente cliente, [FromServices] IClienteService _ClienteService, [FromServices] ILogger<ClienteController> _logger)
        {
            try
            {

            
                    var result = await _ClienteService.UpdateAsync(cliente);

                if (result)
                {

                    return (ActionResult)Ok(result);

                }
                return (ActionResult)NotFound(result);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "erro ao tentar obter dados.verifique condiçoes quanto ao banco de dados");
                return new StatusCodeResult(500); //condicao inesperada no servidor , nao foi possivel atender a solicitação
            }
        }

        [HttpDelete("{ClienteId:int}")]

        public async Task<ActionResult<bool>> RemoveCliente([FromServices] IClienteService _ClienteService, [FromServices] ILogger<ClienteController> _logger, int ClienteId)
        {
            try
            {

              

                var result = await _ClienteService.Remove(ClienteId); ;

                if (result)
                {

                    return (ActionResult)Ok(result);

                }
                return (ActionResult)NotFound(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "erro ao tentar obter dados.verifique condiçoes quanto ao banco de dados");
                return new StatusCodeResult(500); //condicao inesperada no servidor , nao foi possivel atender a solicitação
            }
        }

        [HttpGet("{ClienteId:int}")]

        public async Task<ActionResult<Cliente>> GetOneCliente([FromServices] IClienteService _ClienteService, [FromServices] ILogger<ClienteController> _logger, int ClienteId)
        {
            try
            {

                //if (ModelState.IsValid)
                //{
                //     _EstadoService.Remove(UfId);

                //    return uf;
                //}
                //else
                //{
                //    return BadRequest(ModelState);
                //}

                var result = await _ClienteService.GetAsync(ClienteId); ;

                if (result == null)
                {
                    return (ActionResult)NotFound($"Deu merda, não foi possivel encontrar Cliente:{ClienteId}");
                }

                return (ActionResult)Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "erro ao tentar obter dados.verifique condiçoes quanto ao banco de dados");
                return new StatusCodeResult(500); //condicao inesperada no servidor , nao foi possivel atender a solicitação
            }
        }

    }
}
