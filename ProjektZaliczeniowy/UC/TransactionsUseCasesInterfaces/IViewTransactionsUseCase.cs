using Core;
using System.Collections.Generic;

namespace UC.TransactionsUseCases
{
    public interface IViewTransactionsUseCase
    {
        IEnumerable<Transaction> Execute();
    }
}