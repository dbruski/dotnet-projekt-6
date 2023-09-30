using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Doctor
    {
        public string DoctorId { get; set; }
        [Required(ErrorMessage = "Imię jest wymagana")]
        [MinLength(3, ErrorMessage = "Imię powinna mieć conajmniej 3 znaki")]
        [MaxLength(20, ErrorMessage = "Imię nie może przekraczać 30 znaków")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [MinLength(3, ErrorMessage = "Nazwisko powinno mieć conajmniej 3 znaki")]
        public string LastName { get; set; }
    }
}
