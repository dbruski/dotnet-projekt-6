using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC.DataStoreInterfaces
{
    public interface ITransactionRepo
    {
        public IEnumerable<Transaction> GetAllTransactions();

        public void AddTransaction(Transaction transaction);

        public IEnumerable<Transaction> GetTodaysTransactions();

        public IEnumerable<Transaction> GetTransactionsBetween(DateTime start, DateTime end);

        public IEnumerable<Transaction> GetTransactionsByDoctorId(string doctorId);

        public IEnumerable<Transaction> GetTransactionsByPatientId(string patientId);
    }
}
