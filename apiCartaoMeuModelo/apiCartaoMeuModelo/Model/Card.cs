using System;
using System.ComponentModel.DataAnnotations;

namespace apiCartaoMeuModelo.Model
{
    public class Card
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Number { get; set; }

        public DateTime DataExpiracao { get; set; }

        public bool Bloqueado { get; set; }


    }
}
