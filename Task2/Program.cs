class BankAccount
{
    private string accountNumber;
    private decimal balance;

    //Question-2
    public BankAccount(string accountNumber)
    {
        this.accountNumber = accountNumber;
        this.balance = 0;
    }

    //Question-3
    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    //Question-4
    public void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficent Amount to withdraw!");
        }
    }

    //Question-5
    public decimal GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount myAccount = new BankAccount("9385723943289");
        myAccount.Deposit(69420);
        myAccount.Withdraw(420);

        Console.WriteLine("Total Balance: " + myAccount.GetBalance());
    }
}