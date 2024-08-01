namespace Garage
{
    class Zero : IVehicle, IElectricVehicle  // Electric motorcycle
    {
        public string? MainColor { get; set; } = "black";
        public int MaximumOccupancy { get; set; } = 1;
        public double BatteryKWh { get; set; } = 100;
        public int CurrentChargePercentage { get; set; } = 24;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public void Turn()
        {
            Console.WriteLine($"I lean with it when I turn.");
        }

        public void Stop()
        {
            Console.WriteLine("The vehicle slows to a stop!");
        } 

    }
}
            /* 
                    public override void Drive()
                    {
                        Console.WriteLine($"The {MainColor} Zero goes NNNNYYYYEEEWWW!");
                    }

                    public override void Turn(string direction)
                    {
                        Console.WriteLine($"The Zero turns {direction}!");
                    }

                    public override void Stop()
                    {
                        Console.WriteLine("The Zero drags to a stop after sliding on the pavement!");
                    }

            */