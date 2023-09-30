using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Category
    {
        public string CategoryId { get; set; }
        [Required(ErrorMessage = "Nazwa jest wymagana"), MinLength(3, ErrorMessage = "Nazwa powinna mieć conajmniej 3 znaki"), MaxLength(30, ErrorMessage = "Nazwa nie może przekraczać 30 znaków")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Opis jest wymagany")]
        public string Description { get; set; }
    }
}
