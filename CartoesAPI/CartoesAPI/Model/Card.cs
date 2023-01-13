using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CartoesAPI.Model
{
    public class Card
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Number card need be 16 characters")]
        [StringLength(16)]
        public string Number { get; set; }
        [Required(ErrorMessage ="Expirate date is required")]
        public DateTime ExpiredDate { get; set; }
        [Required]
        public string Cvv { get; set; }

    }
}
