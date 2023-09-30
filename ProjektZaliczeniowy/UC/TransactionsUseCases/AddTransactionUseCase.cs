using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC.TransactionsUseCases
{
    public class AddTransactionUseCase : IAddTransactionUseCase
    {
        private readonly ITransactionRepo transactionRepo;

        public AddTransactionUseCase(ITransactionRepo transactionRepo)
        {
            this.transactionRepo = transactionRepo;
        }

        public void Execute(Transaction transaction)
        {
            transactionRepo.AddTransaction(transaction);
        }
    }
}
