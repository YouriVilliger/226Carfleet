namespace Carfleet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car _car = new Car("VD 123 567", "Mercedes-Benz", "Vito", "SV30-0169266");
            Truck _truck = new Truck("VD 123 567", "Volvo", "FH16", "VOL45-0157966");
            DisplayCar(_car);
            DisplayTruck(_truck);
        }

        static private void DisplayCar(Car car)
        {
            System.Console.WriteLine(car.ToString());
        }

        static private void DisplayTruck(Truck truck)
        {
            System.Console.WriteLine(truck.ToString());
        }
    }
}