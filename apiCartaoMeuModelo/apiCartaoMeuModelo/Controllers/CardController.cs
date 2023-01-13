using apiCartaoMeuModelo.Data;
using apiCartaoMeuModelo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiCartaoMeuModelo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        
        private SetApplication _context;

        public CardController(SetApplication context)
        {
            _context = context;
        }

         [HttpPost]
        public IActionResult AddCard([FromBody] Card card)
         {

            _context.Cards.Add(card);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCardById), new {Id = card.Id}, card );

         }
        [HttpGet("{id}")]
        public IActionResult GetCardById(int id)
        {
            Card card = _context.Cards.FirstOrDefault(card => card.Id == id);
            if (card != null)
            {
                return Ok(card);
            }
            return NotFound();
        }

        [HttpGet]

        public IEnumerable<Card> GetAlll ()
        {
           
            return _context.Cards.ToList();
        }

        [HttpDelete("{id}")]
        public void DeleteCardById(int id)
        {
            Card card = _context.Cards.FirstOrDefault(card => card.Id == id);
            if (card != null)
            {
                _context.Cards.Remove(card);
                _context.SaveChanges();
            }

        }


    }
}
