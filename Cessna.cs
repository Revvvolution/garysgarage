namespace Garage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes Wah wah wah wah wah!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna banks {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine("The bank robbers in the Cessna roll to a stop on the runway of a non-extradition country.");
        }



    }
}