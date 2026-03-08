//istifadecinin daxil etdiyi say qeder simvol yazan kod


namespace c__function_methods
{
    internal class Program
    {


        static void PrintSimvols(int count , char simvol)
        {
            for (int i = 0; i <count; i++)
            {
                Console.Write(simvol);
            }



        }
        static void Main(string[] args)
        {


            int charCount = 0;
            char simvol;

            Console.WriteLine("Yazilacaq simvolu ve sayini daxil edin:");
            Console.Write("Simvol:");
            simvol = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Simvol sayi:");
            charCount = int.Parse(Console.ReadLine());

            PrintSimvols(charCount, simvol);



        }
    }
}
