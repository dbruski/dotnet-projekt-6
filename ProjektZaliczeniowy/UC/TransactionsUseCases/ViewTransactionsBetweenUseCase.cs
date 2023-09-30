using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UC.DataStoreInterfaces;

namespace UC.TransactionsUseCases
{
    public class ViewTransactionsBetweenUseCase : IViewTransactionsBetweenUseCase
    {
        private readonly ITransactionRepo transactionRepo;

        public ViewTransactionsBetweenUseCase(ITransactionRepo transactionRepo)
        {
            this.transactionRepo = transactionRepo;
        }

        public IEnumerable<Transaction> Execute(DateTime start, DateTime end)
        {
            return transactionRepo.GetTransactionsBetween(start, end);
        }
    }
}
