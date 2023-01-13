using apiCartaoMeuModelo.Data;
using apiCartaoMeuModelo.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace apiCartaoMeuModelo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {

        private SetApplication _context;

        public PessoaController(SetApplication context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddCard([FromBody] Pessoa pessoa)
        {
            _context.Pessoa.Add(pessoa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCardById), new { Id = pessoa.Id }, pessoa);

        }
        [HttpGet]
        public IActionResult GetCardById(int id)
        {
            Pessoa pessoa = _context.Pessoa.FirstOrDefault(pessoa => pessoa.Id == id);
            if (pessoa != null)
            {
                return Ok(pessoa);
            }
            return NotFound();
        }
    }

}
