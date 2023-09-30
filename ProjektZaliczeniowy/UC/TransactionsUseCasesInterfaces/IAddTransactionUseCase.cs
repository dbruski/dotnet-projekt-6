using Core;

namespace UC.TransactionsUseCases
{
    public interface IAddTransactionUseCase
    {
        void Execute(Transaction transaction);
    }
}