interface IBankAccount
{
    void makeDeposit(decimal amount, string comment);
    void makeWithdrawal(decimal amount, string comment);

    string getTransactionHistory();
}