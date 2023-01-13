using CartoesAPI.Data;
using CartoesAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartoesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : Controller
    {
        private SetApplication _context;

        public CardController(SetApplication context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Card> GetCards()
        {
            return _context.Cards;
        }
        [HttpPost]
        public IActionResult AddCard([FromBody] Card card)
        {
            _context.Cards.Add(card);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCardById), new { Id =  card.Id}, card);
        }

        [HttpGet("{id}")]
        public IActionResult GetCardById(int id)
        {
            Card card = _context.Cards.FirstOrDefault(card => card.Id == id);
            if(card != null)
            {
                return Ok(card);
            }
            return NotFound();
        }

    }
}
