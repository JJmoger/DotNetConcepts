using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    /*
     * Abstraction: Focus on essential attributes and behaviors while hiding unnecessary implementation.
     * The complex implementation details of a system are hide behind a simplified interface or API.
     * abstraction is commonly achieved through several mechanisms:
     * Abstract classes and Interfaces
     * 
     * Abstraction is the process of hiding the complex implementation details and showing only the necessary features of an object.
     * This can be achieved using abstract classes and interfaces.
     */

    internal class Abstraction
    {
        public void AbstractionExample()
        {
            var indianOil = new IODispenser();

            indianOil.DispenserName = "Indian Oil Pump 1";
            Console.WriteLine($"Fuel Amount {indianOil.FuelAmount}");
            indianOil.Refuel(100.99m);
            indianOil.WithdrawnFuel(0.99m);
            Console.WriteLine($"Fuel Amount {indianOil.FuelAmount}");
            indianOil.CalculatePurchase();
            Console.WriteLine($"Amount {indianOil.CalculatePurchase()}");

            FuelDispenser bp = new BPDispenser();
            Console.WriteLine($"Fuel Amount {bp.FuelAmount}");
            bp.Refuel(120.99m);
            bp.WithdrawnFuel(10.99m);
            Console.WriteLine($"Fuel Amount {bp.FuelAmount}");
            bp.CalculatePurchase();
            Console.WriteLine($"Amount {bp.CalculatePurchase()}");
        }

        public void AbstractionExample2()
        {
            ITrafficSignal pedestrian = new Pedestrian();
            ITrafficSignal vehcle = new Vehicle();

            pedestrian.BeReady();
            vehcle.BeReady();

            pedestrian.Start();
            vehcle.Start();

            pedestrian.Stop();
            vehcle.Stop();

        }
    }

    public abstract class FuelDispenser
    {
        public string DispenserName { get; set; }
        public decimal FuelAmount { get; protected set; }

        public abstract void WithdrawnFuel(decimal amount);
        public abstract void Refuel(decimal refuelAmount);

        public abstract decimal CalculatePurchase();
    }

    public class IODispenser : FuelDispenser
    {
        public override void WithdrawnFuel(decimal fuelAmount)
        {
            FuelAmount -= fuelAmount;
        }

        public override void Refuel(decimal refuelAmount)
        {
            FuelAmount += refuelAmount;
        }

        public override decimal CalculatePurchase()
        {
            decimal purchaseValue = FuelAmount * 100;
            return purchaseValue;
        }
    }

    public class BPDispenser : FuelDispenser
    {
        public override void WithdrawnFuel(decimal fuelAmount)
        {
            FuelAmount -= fuelAmount;
        }

        public override void Refuel(decimal refuelAmount)
        {
            FuelAmount += refuelAmount;
        }

        public override decimal CalculatePurchase()
        {
            decimal purchaseValue = FuelAmount * 102;
            return purchaseValue;
        }
    }

    interface ITrafficSignal
    {
        void Start();
        void Stop();
        void BeReady();
    }

    interface ITrafficSignal2
    {
        void Start();
        void Stop();
        void BeReady();
    }

    public class Vehicle : ITrafficSignal,  ITrafficSignal2
    {
        public void BeReady()
        {
            Console.WriteLine("Orange signal: Be ready to drive");
        }

        public void Start()
        {
            Console.WriteLine("Green signal: Start driving");
        }

        public void Stop()
        {
            Console.WriteLine("Red signal: Stop driving");
        }
    }

    public class Pedestrian : Vehicle, ITrafficSignal
    {
        public new void  BeReady()
        {
            Console.WriteLine("Orange signal: Be aware");
        }

        public new void Start()
        {
            Console.WriteLine("Green signal: Stop crossing");
        }

        public new void Stop()
        {
            Console.WriteLine("Red signal: Start crossing");
        }
    }
}
