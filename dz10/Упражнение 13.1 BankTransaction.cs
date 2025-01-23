using System;

public class BankTransaction
{
    public decimal Amount { get; private set; }
    public DateTime TransactionDate { get; private set; }
    public BankTransaction(decimal amount, DateTime transactionDate)
    {
        Amount = amount;
        TransactionDate = transactionDate;
    }
}
