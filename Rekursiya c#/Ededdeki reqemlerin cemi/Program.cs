//ededin reqemleri cemi rekursiya ile

namespace Ededdeki_reqemlerin_cemi
{
    internal class Program
    {
     
        /// <summary>
        /// Calculates the sum of the digits of a non-negative integer.
        /// </summary>
        /// <param name="num">The non-negative integer whose digits are to be summed.</param>
        /// <param name="result">An optional accumulator for the running total of the digit sum.  This parameter is intended for internal or
        /// recursive use and should typically be omitted when calling the method directly.</param>
        /// <returns>The sum of the digits of <paramref name="num"/>.</returns>
        static int DigitSum(int num , int result = 0)
        {
            result += num % 10;
            if (num / 10 == 0)
                return result;
            num = num / 10;
            return DigitSum(num , result);

        }
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ededdeki reqemlerin cemi: {DigitSum(num)}");
        }
    }
}
