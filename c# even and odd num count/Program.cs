
//tek ve cut ededlerin sayini verilmis araliqda (intervalda) tapan kod

namespace c__even_and_odd_num_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oddCount = 0;
            int evenCount = 0;

            Console.Write("Araligin min deyerini daxil edin: ");
            bool minBool = int.TryParse(Console.ReadLine(), out int minNum);
            while (!minBool)
            {
                Console.WriteLine("Deyer duzgun daxil edilmeyib , yeniden cehd edin");
                minBool = int.TryParse(Console.ReadLine(), out minNum);
            }

            Console.Write("Araligin max deyerini daxil edin: ");
            bool maxBool = int.TryParse(Console.ReadLine(), out int maxNum);

            while (!maxBool || maxNum < minNum)
            {
                if (maxNum < minNum && maxBool)
                {
                    Console.WriteLine("Max deyer min deyereden kicik ola bilmez , yeniden daxil edin");
                    maxBool = int.TryParse(Console.ReadLine(), out maxNum);
                    continue;

                }
                Console.WriteLine("Deyer duzgun daxil edilmeyib , yeniden cehd edin");
                maxBool = int.TryParse(Console.ReadLine(), out maxNum);
            }

            for (int i = minNum +1; i < maxNum; i++)
            {
                if (i % 2 == 0)
                {
                    //cut ededdir 
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine($"({minNum},{maxNum})");

            Console.WriteLine($"Cut ededlerin sayi: {evenCount}");
            Console.WriteLine($"Tek ededlerin sayi: {oddCount}");



        }
    }
}
