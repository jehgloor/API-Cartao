using System.ComponentModel.DataAnnotations;
using System;

namespace apiCartaoMeuModelo.Model
{
    public class Pessoa
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }

       
    }
}
