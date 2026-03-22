// n'ci yerde duran Fibonacci ededinin tapilmasi
// Fibonacci ededleri -> ozunden evvel gelen ilk iki ededin cemine beraber olan ededleridir.
// 0 , 1'den baslqayaraq gedirik.
// N 0'dan baslayir


namespace Fibonacci_ededleri
{

   

    internal class Program
    { static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n-2);
        


    }
        static void Main(string[] args)
        {
            Console.Write("Fibonacci ededinin sirasini daxil edin (n = 0 ' dan baslqayir) : n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int fibonacciNum = Fibonacci(n);
            Console.WriteLine($"{n}ci yere kimi fibonacci ededleri: ");
            for (int i = 0; i <= n; i++)
            {
                Console.Write(  $" {i} -> " + Fibonacci(i) + "   ");
            }
      

        }
    }
}
