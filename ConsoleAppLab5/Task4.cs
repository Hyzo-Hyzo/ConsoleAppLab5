using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab5
{
    public class CreditCard
    {
        private string cardNumber;
        private int cvcCode;
        private double balance;

        public CreditCard(string cardNumber, int cvcCode, double balance)
        {
            this.CardNumber = cardNumber;
            this.CvcCode = cvcCode;
            this.Balance = balance;
        }

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public int CvcCode
        {
            get { return cvcCode; }
            set { cvcCode = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public static CreditCard operator +(CreditCard card, double amount)
        {
            return new CreditCard(card.CardNumber, card.CvcCode, card.Balance + amount);
        }

        public static CreditCard operator -(CreditCard card, double amount)
        {
            return new CreditCard(card.CardNumber, card.CvcCode, card.Balance - amount);
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            if (ReferenceEquals(card1, null) && ReferenceEquals(card2, null))
            {
                return true;
            }

            if (ReferenceEquals(card1, null) || ReferenceEquals(card2, null))
            {
                return false;
            }

            return card1.CvcCode == card2.CvcCode;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !(card1 == card2);
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            if (ReferenceEquals(card1, null) || ReferenceEquals(card2, null))
            {
                return false;
            }

            return card1.Balance > card2.Balance;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            if (ReferenceEquals(card1, null) || ReferenceEquals(card2, null))
            {
                return false;
            }

            return card1.Balance < card2.Balance;
        }

        public override bool Equals(object obj)
        {
            CreditCard otherCard = obj as CreditCard;

            if (otherCard == null)
            {
                return false;
            }

            return this.CvcCode == otherCard.CvcCode;
        }

        public override int GetHashCode()
        {
            return this.CvcCode.GetHashCode();
        }
    }
}
