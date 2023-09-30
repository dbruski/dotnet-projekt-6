using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Patient : IValidatableObject
    {
        public string PatientId { get; set; }
        [Required(ErrorMessage = "Imię jest wymagana")]
        [MinLength(3, ErrorMessage = "Imię powinna mieć conajmniej 3 znaki")]
        [MaxLength(20, ErrorMessage = "Imię nie może przekraczać 30 znaków")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [MinLength(3, ErrorMessage = "Nazwisko powinno mieć conajmniej 3 znaki")]
        public string LastName { get; set; }
        [DataType(DataType.Date), Required(ErrorMessage = "Nazwisko jest wymagane")]
        public DateTime Birthday { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [RegularExpression(@"[0-9]{9}", ErrorMessage = "Proszę podać poprawny numer telefonu w formacie (xxxxxxxxx)")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Numer PESEL jest wymagany")]
        [RegularExpression(@"[0-9]{11}", ErrorMessage = "Proszę podać poprawny numer pesel")]

        public string Pesel { get; set; }
        [Required(ErrorMessage = "Lekarz musi zostać wybrany")]
        public string DoctorId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            string yearFromBirthday = Birthday.Year.ToString().Substring(2, 2);
            string monthFromBirthday = Birthday.Month < 10 ? $"0{Birthday.Month}" : Birthday.Month.ToString();
            string dayFromBirthday = Birthday.Day < 10 ? $"0{Birthday.Day}" : Birthday.Day.ToString();

            string yearFromPesel = Pesel.Substring(0, 2);
            string monthFromPesel = Pesel.Substring(2, 2);
            string dayFromPesel = Pesel.Substring(4, 2);

            if (yearFromBirthday != yearFromPesel || monthFromBirthday != monthFromPesel || dayFromBirthday != dayFromPesel)
            {
                yield return new ValidationResult("Data urodzenia nie pokrywa się z peselem");
            }

            if (DateTime.Compare(Birthday, DateTime.Now) > 0) {
                yield return new ValidationResult("Data urodzenia nie może być późniejsza niż dziś");
            }
        }
    }
}
