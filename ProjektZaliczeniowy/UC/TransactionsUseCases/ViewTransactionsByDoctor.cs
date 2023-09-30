using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UC.DataStoreInterfaces;

namespace UC.TransactionsUseCases
{
    public class ViewTransactionByDoctor : IViewTransactionByDoctor
    {
        private readonly ITransactionRepo transactionRepo;

        public ViewTransactionByDoctor(ITransactionRepo transactionRepo)
        {
            this.transactionRepo = transactionRepo;
        }

        public IEnumerable<Transaction> Execute(string doctorId)
        {
            return transactionRepo.GetTransactionsByDoctorId(doctorId);
        }
    }
}
