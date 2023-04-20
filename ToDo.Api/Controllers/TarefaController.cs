using Microsoft.AspNetCore.Mvc;
using ToDo.Domain.Interfaces.Service;
using ToDo.Domain.Models;

namespace ToDo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaService _service;
        public TarefaController(ITarefaService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<Tarefa>> Insert(Tarefa tarefa)
        {
            try
            {
                var insertTarefaDb = await _service.Inserir(tarefa);
                return Ok(insertTarefaDb);
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }
    }
}