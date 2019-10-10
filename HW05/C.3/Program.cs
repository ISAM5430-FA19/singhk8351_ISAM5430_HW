using System;

namespace C
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Money money = new Money(1.5,25);
            Money money1 = new Money(1.5);
            money.DecrementMoney();
            money1.IncrementMoney();
            Console.WriteLine(money.GetMoneyValue());
            Console.WriteLine(money1.GetMoneyValue());
            Console.WriteLine(money);
            Console.WriteLine(money1);
        }
    }
}
