using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            float balance = 1000;
            // default constructor is parameterless
            //Account account = new Account(); // instance of Account class i.e object
            Account account = new Account("Kirti Singh", false); // parameterized constructor
            //a constructor forces you initialize the required states
            account.SetName("Kirti");
            Console.WriteLine("The name1 is " + account.GetName());
            //account.Name = "Wu";
            account.Name = "";
            //account.IsActive = true;
            //account.Is_Active = true;
            Console.WriteLine("Is the account active?" + account.IsActive);
            Console.WriteLine("The name2 is " + account.Name);
            // Fully qualified type name, which includes a namespace"dot"
            Console.WriteLine(account);
            Console.WriteLine("Enter the amount to be withdrawn: ");
            float withdrawalAmt = float.Parse(Console.ReadLine());
            balance = account.Withdraw(withdrawalAmt, balance);
            Console.WriteLine("The account balance is: {0}", balance);
        }
    }
}

