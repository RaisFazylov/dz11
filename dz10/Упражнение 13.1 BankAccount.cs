/* Упражнение 13.1 Из класса банковский счет удалить методы, возвращающие значения
полей номер счета и тип счета, заменить эти методы на свойства только для чтения.
Добавить свойство для чтения и записи типа string для отображения поля держатель
банковского счета. Изменить класс BankTransaction, созданный для хранений финансовых
операций со счетом, - заменить методы доступа к данным на свойства для чтения. */

public class BankAccount
{
    public string AccountNumber { get; private set; }
    public string AccountType { get; private set; }
    public string AccountHolder { get; set; }
    public BankAccount(string accountNumber, string accountType, string accountHolder)
    {
        AccountNumber = accountNumber;
        AccountType = accountType;
        AccountHolder = accountHolder;
    }
}
