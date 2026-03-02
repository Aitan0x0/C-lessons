//sade kalkulyator

namespace c__lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Birinci ededi daxil edin: ");

            bool num1_bool = double.TryParse(Console.ReadLine(), out double num1);

            while (!num1_bool)
            {
                Console.WriteLine("Eded dogru deyil , yeniden daxil edin :");
                num1_bool = double.TryParse(Console.ReadLine(), out num1);

            }

            Console.Write("Ikinci ededi daxil edin: ");

            bool num2_bool = double.TryParse(Console.ReadLine(), out double num2);

            while (!num2_bool)
            {
                Console.WriteLine("Eded dogru deyil , yeniden daxil edin :");
                num2_bool = double.TryParse(Console.ReadLine(), out num2);

            }

            while (true)
            {
                Console.WriteLine("+ - * / emellerinden birini secin: ");
                ConsoleKeyInfo selBut = Console.ReadKey(true);
                char selectChar = selBut.KeyChar;
                double result;

                switch (selectChar)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine(num1 + " + " + num2 + " = " + result);
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine(num1 + " - " + num2 + " = " + result);
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Ededi 0a bolmek olmaz! Basqa emeliyyat secin");
                            continue;
                        }
                        result = num1 / num2;

                        Console.WriteLine(num1 + " / " + num2 + " = " + result);
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine(num1 + " * " + num2 + " = " + result);
                        break;
                    default:
                        Console.WriteLine("Bele emeliyyat yoxdur , yeniden cehd edin");
                        continue;

                }
                break;
            }



        }
    }
}
