using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public string Currency { get; set; }
        public int Id { get; set; }
        public bool IsKing { get; set; }
        public bool IsGood { get; set; }

        public BankAccount()
        {
            Currency = "Zebra";
        }


        public void AddMoney(int id)
        {
            if (IsKing)
            {
                Balance += 100;
            }
            else
            {
                Balance += 10;
            }
        }

        

    }
}
