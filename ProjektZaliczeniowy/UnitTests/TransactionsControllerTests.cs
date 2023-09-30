using Core;
using DataStoreInMemory;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;
using Xunit;

namespace UnitTests
{
    public class TransactionsControllerTests
    {
        private readonly ITransactionRepo transactionRepo;
        private IPatientRepo patientRepo;

        public TransactionsControllerTests()
        {
            transactionRepo = new TransactionInMemoryRepo(patientRepo);
        }

        [Fact]
        public void TestAddThreeTransactions_AndGetAllTransactions()
        {
            transactionRepo.AddTransaction(new Transaction() { TransactionId = "1", PatientId = "1", ServiceId = "2", Timestamp = new DateTime(2022, 1, 5, 8, 30, 52) });
            transactionRepo.AddTransaction(new Transaction() { TransactionId = "2", PatientId = "1", ServiceId = "2", Timestamp = new DateTime(2022, 1, 5, 12, 30, 52) });
            transactionRepo.AddTransaction(new Transaction() { TransactionId = "3", PatientId = "1", ServiceId = "1", Timestamp = new DateTime(2022, 1, 6, 15, 30, 52) });

            var result = transactionRepo.GetAllTransactions() as List<Transaction>;

            Assert.Equal(3, result.Count);
        }
    }
}
