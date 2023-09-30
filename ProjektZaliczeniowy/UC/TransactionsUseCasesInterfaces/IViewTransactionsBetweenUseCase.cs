using Core;
using System;
using System.Collections.Generic;

namespace UC.TransactionsUseCases
{
    public interface IViewTransactionsBetweenUseCase
    {
        IEnumerable<Transaction> Execute(DateTime start, DateTime end);
    }
}