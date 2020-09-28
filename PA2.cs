using System; 

namespace _221StarterCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Convert Currencies. 2. Restaurant POS. 3. Exit.");
            string choice = Console.ReadLine();

        if (choice == "1") {
            Console.WriteLine("Which currency will you convert from? (UCEIJMB");
            string curr = Console.ReadLine();

                if (curr == "C") {
                    Console.WriteLine("Which currency will you convert to? (UEIJMB)");
                    string next = Console.ReadLine();

                    if (next == "U"){
                    int amount = 1;
                    }

                     else if (next == "E"){
                    int amount = .757;
                    }

                     else if (next == "I"){
                    int amount = 52.53;
                    }

                     else if (next == "J"){
                    int amount = 80.92;
                    }

                     else if (next == "M"){
                    int amount = 13.1544;
                    }

                     else if (next == "B"){
                    int amount = .6178;
                    }
                    
                }

                else if (curr == "E") {
                    Console.WriteLine("Which currency will you convert to? (UCIJMB)");
                    string next = Console.ReadLine();

                    if (next == "U"){
                    int amount = 1;
                    }

                     else if (next == "C"){
                    int amount = .9813;
                    }

                     else if (next == "I"){
                    int amount = 52.53;
                    }

                     else if (next == "J"){
                    int amount = 80.92;
                    }

                     else if (next == "M"){
                    int amount = 13.1544;
                    }

                     else if (next == "B"){
                    int amount = .6178;
                    }
                }

                else if (curr == "I") {
                    Console.WriteLine("Which currency will you convert to? (UCEJMB)");
                    string next = Console.ReadLine();

                    if (next == "U"){
                    int amount = 1;
                    }

                     else if (next == "E"){
                    int amount = .757;
                    }

                     else if (next == "C"){
                    int amount = .9813;
                    }

                     else if (next == "J"){
                    int amount = 80.92;
                    }

                     else if (next == "M"){
                    int amount = 13.1544;
                    }

                     else if (next == "B"){
                    int amount = .6178;
                    }
                }

                else if (curr == "J") {
                    Console.WriteLine("Which currency will you convert to? (UCEIMB)");
                    string next = Console.ReadLine();

                    if (next == "U"){
                    int amount = 1;
                    }

                     else if (next == "E"){
                    int amount = .757;
                    }

                     else if (next == "I"){
                    int amount = 52.53;
                    }

                     else if (next == "C"){
                    int amount = .9813;
                    }

                     else if (next == "M"){
                    int amount = 13.1544;
                    }

                     else if (next == "B"){
                    int amount = .6178;
                    }
                }

                else if (curr == "M") {
                    Console.WriteLine("Which currency will you convert to? (UCEIJB)");
                    string next = Console.ReadLine();

                    if (next == "U"){
                    int amount = 1;
                    }

                     else if (next == "E"){
                    int amount = .757;
                    }

                     else if (next == "I"){
                    int amount = 52.53;
                    }

                     else if (next == "J"){
                    int amount = 80.92;
                    }

                     else if (next == "C"){
                    int amount = .9813;
                    }

                     else if (next == "B"){
                    int amount = .6178;
                    }
                }

                else if (curr == "B") {
                    Console.WriteLine("Which currency will you convert to? (UCEIJM)");
                    string next = Console.ReadLine();

                    if (next == "U"){
                    int amount = 1;
                    }

                     else if (next == "E"){
                    int amount = .757;
                    }

                     else if (next == "I"){
                    int amount = 52.53;
                    }

                     else if (next == "J"){
                    int amount = 80.92;
                    }

                     else if (next == "M"){
                    int amount = 13.1544;
                    }

                     else if (next == "C"){
                    int amount = .9813;
                    }
                }
                else if (curr == "U") {
                    Console.WriteLine("Which currency will you convert to? (CEIJMB)");
                    string next = Console.ReadLine();

                    if (next == "C"){
                    int amount = .9813;
                    }

                     else if (next == "E"){
                    int amount = .757;
                    }

                     else if (next == "I"){
                    int amount = 52.53;
                    }

                     else if (next == "J"){
                    int amount = 80.92;
                    }

                     else if (next == "M"){
                    int amount = 13.1544;
                    }

                     else if (next == "B"){
                    int amount = .6178;
                    }
                }
        
        Console.WriteLine("New Amount is: "+amount);
        }

        else if (choice == "2") {
            Console.WriteLine("Enter Food Total: ");
            int food = Console.ReadLine;

            Console.WriteLine("Enter Alcohol Total: ");
            int alcohol = Console.ReadLine;

            int aTax = alcohol * .09;
            int aFood = food * .18;
            int total = aTax + aFood;

            Console.WriteLine("How much will you pay?");
            int paid = Console.ReadLine;

            if (paid > total) {
                int change = paid - total;
                Console.WriteLine("Your change is: "+change);
            }
            else if (paid < total) {
                Console.WriteLine("Error: Not Enough.");
            }

        }
        else if (choice == "3") {
            Console.WriteLine("Goodbye.");
        }

        else {
            Console.WriteLine("Error: Please Enter a Correct Choice.");
        }
        }
    }
}