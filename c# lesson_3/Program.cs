//valyutani muqayise eden proqram


namespace c__lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1USD = 1.70 AZN
            //1EUR = 1.86AZN
            //evvelce azn ile deyer daxil edek 
            Console.WriteLine("AZN daxil edin ; ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal azn))
            {
                Console.WriteLine("AZN dogru daxil edilmeyib!");
                return;
            }
            decimal usdAzn = azn / 1.70m;
            decimal eurAzn = azn / 1.86m;

            Console.WriteLine(azn + " AZN = " + Math.Round(usdAzn, 2) + " USD");
            Console.WriteLine(azn + " AZN = " + Math.Round(eurAzn, 2) + " EUR");



        }
    }
}
