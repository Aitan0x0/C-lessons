namespace Neqliyyat_sistemi
{


    public abstract class Vehicle
    {

        //konstruktor
        protected Vehicle(string model)
        {
            Model = model;
        }
        public string Model { get; set; } = "Teyin edilmeyib"; // her neqliyyatin model adi var
        public abstract void Move(); //her neqliyyat hereket edir
    }

    /// <summary>
    /// Yanacaqla isleyen neqliyyatlar ucun
    /// </summary>
    interface IFuelable
    {
        void Refuel();
    }

    interface IFlyable
    {
        void Fly();
    }

    public class Car : Vehicle, IFuelable
    {

        public Car(string model) : base(model) { }
        public override void Move()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Model:{Model} . Masin hereket edir , vrm-vrmmm!");
        }

        public void Refuel()
        {
            Console.WriteLine("Masinin yanacagi dolduruldu"); ;
        }
    }

    class Plane : Vehicle, IFuelable, IFlyable
    {
        public Plane(string model) : base(model) { }

        public override void Move()
        {
            Console.WriteLine($"Model:{Model} . Teyyare hereket edir! ");
        }

        public void Refuel()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Teyyarenin yanacagi dolduruldu! ");
        }

        public void Fly()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Teyyare ucur! ");
        }
    }

    class Bicycle : Vehicle
    {
        public Bicycle(string model) : base(model) { }
        public override void Move()
        {
            Console.WriteLine($"Model:{Model} . Velosiped hereket edir!");
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Porshe");
            //car1.Model = "Audi";
            car1.Move();
            car1.Refuel();
            Console.WriteLine();

            Vehicle[] vehicle = { new Plane("plane1"), new Car("car1"), new Bicycle("bicycle1")};
            foreach (var item in vehicle)
            { 
                item.Move();
            }
        }
    }
}
