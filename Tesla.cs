namespace Garage
{
    public class Tesla : IVehicle, IElectricVehicle // Electric car
    {
        public string? MainColor { get; set; } = "pearl-white";
        public int MaximumOccupancy { get; set; } = 5;
        public double BatteryKWh { get; set; } = 100;
        public int CurrentChargePercentage { get; set; } = 65;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla goes Brrrrrr!");
        }

        public void Turn()
        {
            Console.WriteLine($"The Tesla turns right into oncoming traffic. By right, I mean 'directly'.  #AutoPilot");
        }

        public void Stop()
        {
            Console.WriteLine("The Tesla stops after driving over a wrecked Zero motorcycle.");
        }



    }
}