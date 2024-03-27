using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Bank
    {
        static void Main(string[] args)
        {
            bankk b = new bankk(10000);
            b.deposit(1500);
            Console.WriteLine("the balance after depositing is:"+b.getbalnace());
            b.withdraw(12000);
            b.withdraw(10000);
            Console.WriteLine("the balance after withdrwaing is:" + b.getbalnace());

        }
    }
    public class bankk
    {
    private decimal balance;
    public bankk(decimal initialamount)
    {
        balance = initialamount;
    }
    public void deposit(decimal amount)
    {
        balance += amount;
    }
    public void withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("insufficient balance");
        }
    }
    public decimal getbalnace()
    {
        return balance;
    }
}
    
}
