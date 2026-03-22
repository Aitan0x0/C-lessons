//rafaelden ders

namespace Rafael_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            string b = "12";

            Console.WriteLine("eded daxil et: ");
            string cavab = Console.ReadLine();
            int cavabInt = int.Parse(cavab);
            int result = 0;  //cem
            result = cavabInt + a;


            Console.WriteLine("cavab" + result);
        }
    }
}
