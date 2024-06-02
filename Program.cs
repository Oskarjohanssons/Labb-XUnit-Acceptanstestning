namespace Labb_XUnit___Acceptanstestning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("Välj räknesätt:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraktion");
                Console.WriteLine("3. Multiplikation");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Lista tidigare beräkningar");
                Console.WriteLine("6. Avsluta");

                string choice = Console.ReadLine();

                if (choice == "6")
                    break;

                if (choice == "5")
                {
                    var history = calculator.GetPreviousCalculations();
                    foreach (var entry in history)
                    {
                        Console.WriteLine(entry);
                    }
                    continue;
                }

                Console.WriteLine("Mata in första talet:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Mata in andra talet:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                switch (choice)
                {
                    case "1":
                        result = calculator.PerformAddition(num1, num2);
                        break;
                    case "2":
                        result = calculator.PerformSubtraction(num1, num2);
                        break;
                    case "3":
                        result = calculator.PerformMultiplication(num1, num2);
                        break;
                    case "4":
                        result = calculator.PerformDivision(num1, num2);
                        break;
                }

                Console.WriteLine($"Resultatet är: {result}");
            }
        }
    }
}
