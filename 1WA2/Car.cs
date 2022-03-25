using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1WA2
{
    internal class Car
    {
        //properties
        //Lesen Sie sich den Code durch und schreiben Sie sinnvolle Comments
        public String CarDesc { get; set; }
        public int FuelCap { get; set; }
        private double fuel;
        public double Fuel {
            get
            {
                return this.fuel;
            }
            set
            {
                this.fuel = value;
                
                if (value >= this.FuelCap)
                {
                    this.fuel = this.FuelCap;
                }
                if (value < 0)
                {
                    this.fuel = 0;
                }

            }
        }
        public double FuelConsume { get; set; }
        public double MaxRange { 
            get
            {
                return this.fuel * 100 / this.FuelConsume;
            }
        }

        public int DrivenKm { get; set; }


        //constructor
        public Car(String carDesc, int fuelCap, double fuel, double fuelConsume)
        {
            this.CarDesc = carDesc;
            this.FuelCap = fuelCap;
            this.fuel = fuel;
            this.FuelConsume = fuelConsume;
        }
        //ToString Method
        public override string ToString()
        {
            //hier werden alle Properties als string ausgeben
            return "Model: " + CarDesc + 
                ", Fuel Capacity: " + FuelCap +
                ", Fuel Consumption: " + FuelConsume +
                ", Fuel: " + fuel +
                ", DrivenKm: " + DrivenKm;
        }

        public void Drive(int distance)
        {
            if (distance < 0)
            {
                return;
            }
            double usedFuel = this.FuelConsume * distance / 100;
            if (usedFuel > this.fuel)
            {
                return;
            }
            this.Fuel -= usedFuel;
            this.DrivenKm += distance;
        }

    }
}
