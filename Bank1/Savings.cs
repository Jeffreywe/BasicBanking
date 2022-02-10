using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1 {
    public class Savings : Account {

        public decimal InterestRate { get; set; } = 0.12m;

        public void CalculateAndPayInterest(int months) {
            decimal interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
        }
    }
}
