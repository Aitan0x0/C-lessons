//ucbucaqlar veren kod , for'larla

namespace c__Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //birinci ucbucaq
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("1");
                }
                Console.WriteLine();

            }

            Console.WriteLine();

            //ikinci ucbucaq
            for (int i = 10; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("2");
                }
                Console.WriteLine();

            }

            Console.WriteLine();

            //ucuncu ucbucaq

            for (int i = 0; i <= 10; i++)
            {
                
                //ard arda gedirler
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0 ; k < i; k++)
                {
                    Console.Write("3");

                }
                Console.WriteLine();

            }

            Console.WriteLine();

            //dorduncu ucbucaq
            
            for(int i=10; i>0; i--)
            {
                for(int j=1; j<=10-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k<=i;k++)
                {
                    Console.Write("5");
                }
                Console.WriteLine();

            }
        }
    }
}
