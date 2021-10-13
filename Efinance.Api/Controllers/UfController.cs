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
    public class UfController : Controller
    {

        int QtdeLineByPage; // para o caso de precisar paginar consulta nao usado no exemplo
        public UfController(IConfiguration configuration)
        {
            // quantidade de registro por pagina pra ser usado na paginação recebida por di direto do setting.json
            QtdeLineByPage = Convert.ToInt16(configuration.GetConnectionString("QtdeRegByPage")); 
        }

        [HttpGet]
        public async Task<ActionResult<Uf>> GetAllUf([FromServices] IEstadoService _EstadoService, [FromServices] ILogger<UfController> _logger)
        {
            try
            {

                var result = await _EstadoService.GetAllAsync();

                if (result == null)
                {
                    return (ActionResult)NotFound(result);
                }

                return (ActionResult)Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "erro no servidor. verifique condiçoes quanto ao banco de dados");
                return new StatusCodeResult(500); //condicao inesperada no servidor , nao foi possivel atender a solicitação
            }
        }


       [HttpPost]
     
        public async Task<ActionResult<int>> AddUf([FromBody] Uf uf,[FromServices] IEstadoService _EstadoService, [FromServices] ILogger<UfController> _logger)
        {
            try
            {

            
                var result = await _EstadoService.AddAsync(uf);

                if (result != -1)
                {
                    return (ActionResult)Ok(result);
                }
                return (ActionResult)NotFound(result); 


            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "erro no servidor. verifique condiçoes quanto ao banco de dados");
                return new StatusCodeResult(500); //condicao inesperada no servidor , nao foi possivel atender a solicitação
            }
        }
        [HttpPut]

        public async Task<ActionResult<bool>> UpdateUf([FromBody] Uf uf, [FromServices] IEstadoService _EstadoService, [FromServices] ILogger<UfController> _logger)
        {
            try
            {

              
                var result = await _EstadoService.UpdateAsync(uf);

                if (result)
                {
                    return (ActionResult)Ok(result);
                }
                return  (ActionResult)NotFound(result); 
                


            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "erro de servidor. verifique condiçoes quanto ao banco de dados");
                return new StatusCodeResult(500); //condicao inesperada no servidor , nao foi possivel atender a solicitação
            }
        }

        [HttpDelete("{UfId:int}")]

        public async Task< ActionResult <bool>> RemoveUf([FromServices] IEstadoService _EstadoService, [FromServices] ILogger<UfController> _logger,int UfId)
        {
            try
            {

              

                var result = await _EstadoService.Remove(UfId); ;

                if (result)
                {
                    return (ActionResult)Ok(result);
                }
                             
                return (ActionResult)NotFound(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "erro de servidor. verifique condiçoes quanto ao banco de dados");
                return new StatusCodeResult(500); //condicao inesperada no servidor , nao foi possivel atender a solicitação
            }
        }

        [HttpGet("{UfId:int}")]

        public async Task<ActionResult<Uf>> GetOneUf([FromServices] IEstadoService _EstadoService, [FromServices] ILogger<UfController> _logger, int UfId)
        {
            try
            {

             

                var result = await  _EstadoService.GetAsync(UfId);

             

                if (result == null)
                {
                    return (ActionResult)NotFound($"Impossivel encontrar UF:{UfId}");
                }

                return (ActionResult)Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "erro de servidor.verifique condiçoes quanto ao banco de dados");
                return new StatusCodeResult(500); //condicao inesperada no servidor , nao foi possivel atender a solicitação
            }
        }


    }
}
