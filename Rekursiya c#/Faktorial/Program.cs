//ededin faktorialini hesablayan kod / metod rekursiya

namespace Faktorial
{
    internal class Program
    {

        /// <summary>
        /// Faktoriali tapan kod
        /// </summary>
        /// <param name="num"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        static long Factorial(int num, long result = 1)
        {
            if (num == 0 || num == 1)
            {
                return result;
            }
            result *= num;
            num--;
            return Factorial(num, result);
        }

        static void Main(string[] args)
        {
            int num = int.MinValue;
            Console.Write("Faktoriali tapilacaq ededi daxil edin (musbet eded): ");
            while (num < 0)
            {
                num = int.Parse(Console.ReadLine());
                if (num >= 0)
                    break;
                Console.WriteLine("Yeniden cehd edin: ");

            }
            long result = Factorial(num);

            Console.Write($"{num}! = ");

            for (int i = num; i >=1 ; i--)
            {

                if (i == 1)
                {
                Console.Write(i);
                    break;

                }
                
                Console.Write(i + " * ");
            }

            Console.Write($" = {result}");

        }
    }
}
