using DAO.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace e_construmarket.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ILogger<ProdutoController> _logger;
        private readonly IProdutoDAO _produtoDAO;

        public ProdutoController(IProdutoDAO produtoDAO, ILogger<ProdutoController> logger)
        {
            _logger = logger;
            _produtoDAO = produtoDAO;
        }

        [HttpGet]
        public ObjectResult Get()
        {
            try
            {
                return Ok(_produtoDAO.GetAll());
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message} | {ex.StackTrace}");
                return StatusCode(500, new { Message = $"Não foi possível concluir a requisição. Erro: {ex.Message}" });
            }
        }
    }
}
