namespace Garage
{
    public class Ram : IVehicle, IGasVehicle  // Gas powered truck
    {
        public string? MainColor { get; set; } = "red";
        public int MaximumOccupancy { get; set; } = 4;
        public double FuelCapacity { get; set; } = 23;
        public int CurrentTankPercentage { get; set; } = 17;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram goes Rumble rumble rumble!");
        }

        public void Turn()
        {
            Console.WriteLine($"The Ram turns and runs into the Zero motorcycle!");
        }

        public void Stop()
        {
            Console.WriteLine("The Ram suddenly stops then speeds away to avoid prison.  #SixBeerLunch");
        }


    }
}