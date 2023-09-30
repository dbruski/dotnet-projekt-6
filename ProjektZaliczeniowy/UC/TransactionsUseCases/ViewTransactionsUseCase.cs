using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC.TransactionsUseCases
{
    public class ViewTransactionsUseCase : IViewTransactionsUseCase
    {
        private readonly ITransactionRepo transactionRepo;

        public ViewTransactionsUseCase(ITransactionRepo transactionRepo)
        {
            this.transactionRepo = transactionRepo;
        }

        public IEnumerable<Transaction> Execute()
        {
            return transactionRepo.GetAllTransactions();
        }
    }
}
