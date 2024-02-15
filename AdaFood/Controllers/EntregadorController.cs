using AdaFood.Filters;
using AdaFood.Repositorio;
using AdaFood.RequestModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdaFood.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EntregadorController : ControllerBase
    {
        private readonly IEntregadorRepository _repository;

        public EntregadorController (IEntregadorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        [HttpPost("adicionar")]
        [AutorizacaoFiltro]
        public IActionResult Post([FromBody] EntregadorRequest entregadorRequest) //, bool UsuarioLogado
        {
            _repository.Add(entregadorRequest);
            return Ok();
        }

        [HttpGet("buscar/{CPF}")]
        public IActionResult Get(string CPF)
        {
            return Ok(_repository.GetByCPF(CPF));
        }

        [HttpGet("TesteErro")]
        public IActionResult Get(bool erro)
        {
            if (erro) {
                throw new Exception ("Erro. Frase no controller");
            };
            return Ok();
        }

    }
}
