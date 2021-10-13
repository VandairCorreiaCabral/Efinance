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
    public class CidadeController : ControllerBase
    {

        int QtdeLineByPage;
        public CidadeController(IConfiguration configuration)
        {
            // quantidade de registro por pagina pra ser usado na paginação recebida por di direto do setting.json
            QtdeLineByPage = Convert.ToInt16(configuration.GetConnectionString("QtdeRegByPage"));
        }

        [HttpGet]
        public async Task<ActionResult<Cidade>> GetAllCidade([FromServices] ICidadeService _CidadeService, [FromServices] ILogger<CidadeController> _logger)
        {
            try
            {

                var result = await _CidadeService.GetAllAsync();

                if (result == null)
                {
                    return (ActionResult)NotFound(result);
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

        public async Task<ActionResult<int>> AddCidade([FromBody] Cidade cit, [FromServices] ICidadeService _CidadeService, [FromServices] ILogger<CidadeController> _logger)
        {
            try
            {

              
                    var result = await _CidadeService.AddAsync(cit);


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

        public async Task<ActionResult<Cidade>> UpdateCidade([FromBody] Cidade cit, [FromServices] ICidadeService _CidadeService, [FromServices] ILogger<CidadeController> _logger)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var result = await _CidadeService.UpdateAsync(cit);

                    return cit;
                }
                else
                {
                    return BadRequest(ModelState);
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "erro ao tentar obter dados.verifique condiçoes quanto ao banco de dados");
                return new StatusCodeResult(500); //condicao inesperada no servidor , nao foi possivel atender a solicitação
            }
        }

        [HttpDelete("{CidadeId:int}")]

        public async Task<ActionResult<bool>> RemoveCidade([FromServices] ICidadeService _CidadeService, [FromServices] ILogger<CidadeController> _logger, int CidadeId)
        {
            try
            {
              

                var result = await _CidadeService.Remove(CidadeId); ;

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

        [HttpGet("{CidadeId:int}")]

        public async Task<ActionResult<Cidade>> GetOneCidade([FromServices] ICidadeService _CidadeService, [FromServices] ILogger<CidadeController> _logger, int CidadeId)
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

                var result = await _CidadeService.GetAsync(CidadeId); ;

                if (result == null)
                {
                    return (ActionResult)NotFound($"Deu merda, não foi possivel encontrar Cidade:{CidadeId}");
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
