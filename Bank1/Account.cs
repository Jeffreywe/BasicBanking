using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1 {
    public class Account {
        private static int NextAccountNumber { get; set; } = 1;
        public decimal Balance { get; set; }
        public int AccountNumber { get; set; }
        public string Description { get; set; }

        public bool Deposit(decimal Amount) {
            if(Amount <= 0) {
                throw new Exception("Amount must be positive.");
            }
            Balance += Amount;
            return true;
        }
        public bool Withdraw(decimal Amount) {
            if(Amount <= 0) {
                throw new Exception("Amount must be positive.");
            }
            if(Amount > Balance) {
                throw new Exception("Insufficient funds!");
            }
            Balance -= Amount;
            return true;
        }
        public bool Transfer(decimal Amount, Account ToAccount) {
            try {
                Withdraw(Amount);
            } catch(Exception) {
                throw new Exception("Withdraw failed in Transfer");
            }
            ToAccount.Deposit(Amount);
            return true;
        }

        public void Debug() {
            Console.WriteLine($"{AccountNumber}|{Description}|{Balance:c}");
        }
        
        public Account() {
            AccountNumber = NextAccountNumber;
            NextAccountNumber++;
            Description = "New Account";
            Balance = 0;
        }
    }
}
