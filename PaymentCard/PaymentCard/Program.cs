using System;

namespace PaymentCard
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(10);
            Console.WriteLine(card);

            card.AddMoney(15);
            Console.WriteLine(card);

            card.EatAffordably();
            Console.WriteLine(card);

            card.EatHeartily();
            Console.WriteLine(card);

            card.AddMoney(200);
            Console.WriteLine(card);

            card.AddMoney(-50);
            Console.WriteLine(card);
        }
    }
}
