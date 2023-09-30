using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Service
    {
        public string ServiceId { get; set; }
        [Required(ErrorMessage = "Kategoria jest wymagana")]
        public string CategoryId { get; set; }
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Cena jest wymagana")]
        [Range(0.0, Double.MaxValue, ErrorMessage = "Cena musi być większa bądź równa 0")]
        public double Price { get; set; }
    }
}
