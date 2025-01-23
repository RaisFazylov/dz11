/* Упражнение 13.2 Добавить индексатор в класс банковский счет для получения доступа к
любому объекту BankTransaction. */ 

using System;
using System.Collections.Generic;

public class BankAccount1
{
    public string AccountNumber { get; private set; }
    public string AccountType { get; private set; }
    public string AccountHolder { get; set; }

    private List<BankTransaction> transactions = new List<BankTransaction>();

    public BankAccount1(string accountNumber, string accountType, string accountHolder)
    {
        AccountNumber = accountNumber;
        AccountType = accountType;
        AccountHolder = accountHolder;
    }
    public BankTransaction this[int index]
    {
        get
        {
            if (index < 0 || index >= transactions.Count)
                throw new IndexOutOfRangeException("Индекс вне диапазона.");
            return transactions[index];
        }
    }
    public void AddTransaction(BankTransaction transaction)
    {
        transactions.Add(transaction);
    }
}
