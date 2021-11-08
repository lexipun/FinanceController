using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceController.Funcionality.Models
{
    class Finance
    {
        public decimal Money { get; set; }
        public string Currency { get; set; } = "GRN";
        public DateTime LastChange { get; private set; }

        public Finance()
        {
            LastChange = DateTime.Now;
        }

        public Finance(decimal count)
        {
            Money = count;
            LastChange = DateTime.Now;
        }

        public Finance(Finance finance)
        {
            Money = finance.Money;
            Currency = finance.Currency;
            LastChange = DateTime.Now;
        }

        public static Finance operator+(Finance left, Finance right)
        {
            if(left.Currency.CompareTo(right) != 0)
            {
                throw new Exception("this functionality is in developping(Different currency)");
            }

            return new Finance()
            {
                Money = left.Money + right.Money,
                Currency = left.Currency,
                LastChange = DateTime.Now,
        };
        }

        public static Finance operator -(Finance left, Finance right)
        {
            if (left.Currency.CompareTo(right) != 0)
            {
                throw new Exception("this functionality is in developping(Different currency)");
            }

            return new Finance()
            {
                Money = left.Money - right.Money,
                Currency = left.Currency,
                LastChange = DateTime.Now,
        };
        }

        public static Finance operator *(Finance left, Finance right)
        {
            if (left.Currency.CompareTo(right) != 0)
            {
                throw new Exception("this functionality is in developping(Different currency)");
            }

            return new Finance()
            {
                Money = left.Money * right.Money,
                Currency = left.Currency,
                LastChange = DateTime.Now,
            };
        }

        public static Finance operator /(Finance left, Finance right)
        {
            if (left.Currency.CompareTo(right) != 0)
            {
                throw new Exception("this functionality is in developping(Different currency)");
            }

            return new Finance()
            {
                Money = left.Money / right.Money,
                Currency = left.Currency,
                LastChange = DateTime.Now,
            };
        }

        public override string ToString()
        {
            return string.Concat(Money, Currency);
        }
    }
}
