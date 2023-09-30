using Core;
using System.Collections.Generic;

namespace UC.TransactionsUseCases
{
    public interface IViewTodaysTransactionsUseCase
    {
        IEnumerable<Transaction> Execute();
    }
}