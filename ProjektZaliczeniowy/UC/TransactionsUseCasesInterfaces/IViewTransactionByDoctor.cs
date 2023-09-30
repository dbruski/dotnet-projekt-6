using Core;
using System.Collections.Generic;

namespace UC.TransactionsUseCases
{
    public interface IViewTransactionByDoctor
    {
        IEnumerable<Transaction> Execute(string doctorId);
    }
}