namespace Garage
{
    public interface IVehicle
    {
        string? MainColor { get; set; }
        int MaximumOccupancy { get; set; }
        void Drive();
        void Turn();
        void Stop();
    }

    public interface IElectricVehicle
    {
        double BatteryKWh { get; set; }
        int CurrentChargePercentage { get; set; }
        void ChargeBattery();
    }

    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }
        int CurrentTankPercentage { get; set; }

        void RefuelTank();
    }
}
        /* 
            public string? MainColor { get; set; }
            public int MaximumOccupancy { get; set; }

            public virtual void Drive()
            {
                Console.WriteLine("Vrooom!");
            }

            public virtual void Turn(string direction)
            {
                Console.WriteLine($"I turn {direction}");
            }

            public virtual void Stop()
            {
                Console.WriteLine("The vehicle slows to a stop!");
            } 
        */