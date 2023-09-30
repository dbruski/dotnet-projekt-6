using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UC.DataStoreInterfaces;

namespace UC.TransactionsUseCases
{
    public class ViewTransactionByPatient : IViewTransactionByPatient
    {
        private readonly ITransactionRepo transactionRepo;

        public ViewTransactionByPatient(ITransactionRepo transactionRepo)
        {
            this.transactionRepo = transactionRepo;
        }

        public IEnumerable<Transaction> Execute(string patientId)
        {
            return transactionRepo.GetTransactionsByPatientId(patientId);
        }
    }
}
