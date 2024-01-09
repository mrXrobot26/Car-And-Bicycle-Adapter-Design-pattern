namespace Car_And_Bicycle_Adapter_Design_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVhicale car = new car();
            useVhicale(car);
            IVhicale bike = new BicycleAdapter(new Bicycle());
            useVhicale(bike);
        }

        static void useVhicale(IVhicale vhicale )
        {
            vhicale.accelerate();
            vhicale.soundHorn();
            vhicale.stop();
            Console.WriteLine("-------------------------------------------");
        }
    }
}
