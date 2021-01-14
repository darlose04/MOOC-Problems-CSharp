using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentCard
{
    public class PaymentCard
    {
        private double _balance { get; set; }

        public PaymentCard(double openingBalance)
        {
            _balance = openingBalance;
        }

        public void EatAffordably()
        {
            if (_balance - 2.60 < 0)
            {
                _balance -= 0;
            }
            else
            {
                _balance -= 2.60;
            }
        }

        public void EatHeartily()
        {
            if (_balance - 4.60 < 0)
            {
                _balance -= 0;
            }
            else
            {
                _balance -= 4.60;
            }
        }

        public void AddMoney(double amount)
        {
            if (amount < 0)
            {
                _balance += 0;
            }
            else
            {
                if (_balance + amount > 150.0)
                {
                    _balance = 150.0;
                }
                else
                {
                    _balance += amount;
                }
            }
        }

        public override string ToString()
        {
            return $"The card has a balance of {_balance} euros.";
        }
    }
}
