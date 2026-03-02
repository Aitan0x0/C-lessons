//ededi orta tapma
namespace C___lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ilk ededi daxil edin:");
            if(!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Eded dogru deyil yeniden cehd edin");
                return; 
            }


            Console.WriteLine("Ikinci ededi daxil edin:");
            //double a = Convert.To( Console.ReadLine());

            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Eded dogru deyil yeniden cehd edin");
                return;
            }

            double result =  (a + b) / 2;

            Console.WriteLine("ededi orta " + result);

        }
    }
}
