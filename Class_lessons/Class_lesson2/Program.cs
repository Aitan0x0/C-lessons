namespace Class_lesson2


{
    internal class Program
    {
        static void Main(string[] args)
        {

            Telebe telebe1 = new Telebe("Rafael", "Qurbanov");
            telebe1.FizikaBal = 50;
            telebe1.PrintName();
            Console.WriteLine($"telebenin fizika bali : {telebe1.FizikaBal}");
        }
    }
}
