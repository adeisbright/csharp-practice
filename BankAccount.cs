using System.Text;
public class BankAccount : IBankAccount
{
    public string accountNumber { get; }
    public string accountOwner { get; set; }

    public decimal balance
    {
        get
        {
            decimal bal = 0;
            foreach (var b in allTransaction)
            {
                bal += b.amount;
            }
            return bal;
        }
    }

    private static int seed = 123456789;

    private List<BankTransaction> allTransaction = new List<BankTransaction>();

    public BankAccount(string name, decimal initialDeposit)
    {
        accountOwner = name;
        makeDeposit(initialDeposit, "Initial Deposit");
        accountNumber = BankAccount.seed.ToString();
        BankAccount.seed++;
    }

    public void makeDeposit(decimal amount, string comment)
    {
        try
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount is less than 0");
            }
            var deposit = new BankTransaction(amount, comment);
            allTransaction.Add(deposit);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e);
        }
    }


    public void makeWithdrawal(decimal amount, string comment)
    {
        try
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Amount is less than 0");
            }

            if (balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient Balance");
            }
            var withdrawal = new BankTransaction(-amount, comment);
            allTransaction.Add(withdrawal);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public string getTransactionHistory()
    {
        Console.WriteLine("See the list of all transactions");

        var report = new StringBuilder();
        report.AppendLine("Date\t\tAmount\t\tNote");
        foreach (var transaction in allTransaction)
        {
            report.AppendLine($"{transaction.time.ToShortDateString()}\t{transaction.amount}\t\t{transaction.note}");
        }
        return report.ToString();
    }
}