using System.Globalization;

namespace _090424_fonctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture;
            bool endOps = false;

            // Set to english format ('.' instead of ',')
            culture = CultureInfo.CreateSpecificCulture("en-US");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            while (!endOps)
            {
                float x, y;
                string inputOps;
                string[] operation =
                    ["add", "substract", "multiply", "divide", "modulo"];

                inputOps = ChooseOperation();
                if (inputOps == "done")
                {
                    Console.WriteLine("\nEnding program succesfully");
                    break;
                }
                else if (!operation.Contains(inputOps))
                {
                    Console.WriteLine("Invalid input. Choose a valid option\n");
                    continue;
                }

                Console.Write("first operand: ");
                x = FloatInput();
                Console.Write("second operand: ");
                y = FloatInput();

                Calculator(inputOps, x, y);

                Console.WriteLine();
            }
        }

        static float AddFloats(float x, float y) => x + y;
        static float SubFloats(float x, float y) => x - y;
        static float MulFloats(float x, float y) => x * y;
        static float DivFloats(float x, float y) => x / y;
        static float ModFloats(float x, float y) => x % y;

        static float FloatInput() =>
                  Convert.ToSingle(Console.ReadLine());

        static string ChooseOperation()
        {
            string input;

            Console.Write("Choose an operation: ");
            Console.WriteLine("add, substract, multiply, divide, modulo");
            Console.WriteLine("Enter \"done\" to end the program\n");
            Console.Write("which operation you choose: ");

            input = Console.ReadLine() ?? "error";

            return input;
        }

        static void Calculator(string input, float x, float y)
        {
            float res;

            switch (input)
            {
                case "add":
                    res = AddFloats(x, y);
                    Console.WriteLine($"{x} + {y} = {res}");
                    break;
                case "substract":
                    res = SubFloats(x, y);
                    Console.WriteLine($"{x} - {y} = {res}");

                    break;
                case "multiply":
                    res = MulFloats(x, y);
                    Console.WriteLine($"{x} x {y} = {res}");
                    break;
                case "divide":
                    res = DivFloats(x, y);
                    Console.WriteLine($"{x} / {y} = {res}");
                    break;
                case "modulo":
                    res = ModFloats(x, y);
                    Console.WriteLine($"{x} % {y} = {res}");
                    break;
            }

        }

    }
}
