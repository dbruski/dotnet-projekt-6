using Core;
using System.Collections.Generic;

namespace UC.TransactionsUseCases
{
    public interface IViewTransactionByPatient
    {
        IEnumerable<Transaction> Execute(string patientId);
    }
}