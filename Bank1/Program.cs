using System;

namespace Bank1 {
    class Program {
        static void Main(string[] args) {

            Savings sav1 = new Savings();
            sav1.Deposit(100);
            sav1.CalculateAndPayInterest(1);
            sav1.Debug();

            Account acct1 = new Account();
            acct1.Deposit(500);
            acct1.Withdraw(200);
            acct1.Debug();

            Account acct2 = new Account();
            acct2.Description = "My 2nd Account";
            acct2.Deposit(1000);
            acct2.Withdraw(350);
            acct2.Debug();

            acct2.Transfer(100, acct1);
            acct1.Debug();
            acct2.Debug();
        }
    }
}
