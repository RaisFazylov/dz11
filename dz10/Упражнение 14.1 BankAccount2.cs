/* Упражнение 14.1 Использование предопределенного условного атрибута для условного
выполнения кода (указывает компиляторам, что при отсутствии символа условной
компиляции, вызов метода или атрибут следует игнорировать). В классе банковский счет
добавить метод DumpToScreen, который отображает детали банковского счета. Для
выполнения этого метода использовать условный атрибут, зависящий от символа условной
компиляции DEBUG_ACCOUNT. Протестировать метод DumpToScreen. */

using System;
public class BankAccount2
{
    public string AccountNumber { get; private set; }
    public string AccountType { get; private set; }
    public string AccountHolder { get; set; }
    public BankAccount2(string accountNumber, string accountType, string accountHolder)
    {
        AccountNumber = accountNumber;
        AccountType = accountType;
        AccountHolder = accountHolder;
    }
    [System.Diagnostics.Conditional("DEBUG_ACCOUNT")]
    public void DumpToScreen()
    {
        Console.WriteLine("Детали банковского счета:");
        Console.WriteLine($"Номер счёта: {AccountNumber}");
        Console.WriteLine($"Тип счёта: {AccountType}");
        Console.WriteLine($"Держатель счёта: {AccountHolder}");
    }
}
