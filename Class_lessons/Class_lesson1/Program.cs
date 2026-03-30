namespace Class_lesson1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Hero hero1 = new Hero("Leon", "Agent");
            
            Console.WriteLine("Prosesi sonlandirmaq ucun ESC basin");
            Console.WriteLine();
            
            while (true)
            {
            Console.WriteLine("Level artirmaq ucun L'e basin");
                
            Console.WriteLine("Karakterinizin Statusuna baxmaq ucun I'e basin");
                Console.WriteLine();
                ConsoleKey btn = Console.ReadKey(true).Key;
                switch (btn)
                {
                    case ConsoleKey.L:
                        Console.WriteLine();
                        hero1.LevelUp();
                        break;
                    case ConsoleKey.I:
                        Console.WriteLine();
                        hero1.ShowStatus();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    
                }

                



            }





        



        }
    }
}
