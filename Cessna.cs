namespace Garage
{
    public class Cessna : IVehicle, IGasVehicle  // Propellor light aircraft
    {
        public string? MainColor { get; set; } = "vestal-white";
        public int MaximumOccupancy { get; set; } = 4;
        public double FuelCapacity { get; set; } = 56;
        public int CurrentTankPercentage { get; set; } = 2;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes Wah wah wah wah wah!");
        }

        public void Turn()
        {
            Console.WriteLine($"The Cessna banks left to 'DO A BARREL ROLL!'");
        }

        public void Stop()
        {
            Console.WriteLine("The bank robbers in the Cessna roll to a stop on the runway of a non-extradition country.");
        }



    }
}