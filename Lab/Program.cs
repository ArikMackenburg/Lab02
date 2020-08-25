using System;
using System.Security.Cryptography.X509Certificates;

namespace Lab
{

    public class Program
    {
        public static decimal Balance = 50;
      
        static void Main(string[] args)
        {

            WithrawRequest();
            DepositRequest();
           
        }

        static public decimal ViewBalance(decimal balance)
        {
            return balance;
        }

        static public decimal Withdraw(decimal balance,decimal withdrawAmount)
        {   
            
            
            if (NotNegative(withdrawAmount) && balance > withdrawAmount)
            {
                balance = balance - withdrawAmount;
                Console.WriteLine($"Withdraw Amount: ${withdrawAmount} ");
                Console.WriteLine($"Remaing Balance: ${balance}");
                Balance = balance;
                return balance;
            }
            if (NotNegative(withdrawAmount) && balance < withdrawAmount)
            {
                Console.WriteLine($"Could only withraw ${balance}");
                Console.WriteLine("Remaining Balance: $0");
                balance = 0;
                Balance = balance;
                return balance;
            }
            else
            {
                Console.WriteLine("Couldn't process request.");
                Balance = balance;
                return balance;
            }
            
        }

        static public decimal Deposit(decimal balance, decimal depositAmount)
        {


            if (NotNegative(depositAmount))
            {
                balance = balance + depositAmount;
                Console.WriteLine($"Deposit Amount: ${depositAmount} ");
                Console.WriteLine($"New Balance: ${balance}");
                return balance;
            }
            else
            {
                Console.WriteLine("Couldn't process request.");
                return balance;
            }

        }

        static public decimal WithrawRequest()
        {
            Console.WriteLine("Select an amount to withdraw");
            Console.WriteLine($"Current Balance: ${Balance}");
            string input = Console.ReadLine();
            decimal withdraw = Convert.ToDecimal(input);
            return Withdraw(Balance,withdraw);
        }

        static public decimal DepositRequest()
        {
            Console.WriteLine("Select an amount to deposit");
            string input = Console.ReadLine();
            decimal deposit = Convert.ToDecimal(input);
            return Deposit(Balance, deposit);
        }
        static public bool NotNegative(decimal value)
        {
            if ( value > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
