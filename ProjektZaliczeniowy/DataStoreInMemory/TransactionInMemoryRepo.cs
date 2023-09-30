using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace DataStoreInMemory
{
    public class TransactionInMemoryRepo : ITransactionRepo
    {
        private List<Transaction> transactions;
        private readonly IPatientRepo patientRepo;

        public TransactionInMemoryRepo(IPatientRepo patientRepo)
        {
            transactions = new List<Transaction>();
            this.patientRepo = patientRepo;
        }
        public IEnumerable<Transaction> GetAllTransactions()
        {
            static int Compare(Transaction t1, Transaction t2)
            {
                return t2.Timestamp.CompareTo(t1.Timestamp);
            }
            List<Transaction> sortedTransactions = transactions;
            sortedTransactions.Sort(new Comparison<Transaction>(Compare));
            return sortedTransactions;
        }

        public void AddTransaction(Transaction transaction)
        {
            Guid guid = Guid.NewGuid();
            transaction.TransactionId = guid.ToString();
            transaction.Timestamp = DateTime.Now;

            transactions.Add(transaction);
        }

        public IEnumerable<Transaction> GetTodaysTransactions()
        {
            DateTime today = GetStartOfDay(DateTime.Now);

            IEnumerable<Transaction> result = from t in transactions
                         where t.Timestamp >= today
                         select t;
            return result;

        }

        public IEnumerable<Transaction> GetTransactionsBetween(DateTime start, DateTime end)
        {
            DateTime startDay = GetStartOfDay(start);
            DateTime endDay = GetEndOfDay(end);

            IEnumerable<Transaction> result = from t in transactions
                         where t.Timestamp >= startDay && t.Timestamp <= endDay
                         select t;
            return result;
        }

        public IEnumerable<Transaction> GetTransactionsByDoctorId(string doctorId)
        {
            IEnumerable<Transaction> result = from t in transactions
                                              where patientRepo.GetPatientById(t.PatientId).DoctorId == doctorId
                                              select t;
            return result;
        }

        public IEnumerable<Transaction> GetTransactionsByPatientId(string patientId)
        {
            IEnumerable<Transaction> result = from t in transactions
                                              where t.PatientId == patientId
                                              select t;
            return result;
        }

        private DateTime GetStartOfDay(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
        }

        private DateTime GetEndOfDay(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 23, 59, 59, 999);
        }
    }
}
