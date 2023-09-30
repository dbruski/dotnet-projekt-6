using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Transaction
    {
        public string TransactionId { get; set; }
        [Required(ErrorMessage = "Usługa musi zostać wybrana")]
        public string ServiceId { get; set; }
        [Required(ErrorMessage = "Pacjent musi zostać wybrany")]
        public string PatientId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
