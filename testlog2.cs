using System; 

namespace _221StarterCode
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("Enter Food Total: ");
            int food = Console.ReadLine();

            Console.WriteLine("Enter Alcohol Total: ");
            int alcohol = Console.ReadLine();

            int aTax = alcohol * .09;
            int aFood = food * .18;
            int total = aTax + aFood;

            Console.WriteLine("How much will you pay?");
            int paid = Console.ReadLine();

            if (paid > total) {
                int change = paid - total;
                Console.WriteLine("Your change is: "+change);
            }
            else if (paid < total) {
                Console.WriteLine("Error: Not Enough.");
            }

} 
}
}