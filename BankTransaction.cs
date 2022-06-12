public class BankTransaction
{
    public decimal amount { get; }
    public string note { get; }

    public DateTime time { get; }
    public BankTransaction(decimal amount, string note)
    {
        this.amount = amount;
        this.note = note;
        this.time = DateTime.Now;
    }

}