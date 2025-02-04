using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMosah
{
    public class Vehicle
    {
        public string model;
        public string ID;
        Engine engine;
        public float energy;
        public List<Wheel> wheels;
        public string phoneNumber;
        public string vehiclesOwner;
        public Boolean sold;


        public Vehicle(string model, string ID, Engine engine, float energy, List<Wheel> wheels)
        {
            this.model = model;
            this.ID = ID;
            this.engine = engine;
            this.energy = energy;
            this.wheels = wheels;
            string phoneNumber = "0502777668";
            string vehiclesOwner = "Nagar's Garage";
            Boolean sold = false;

        }
        public Vehicle(string model, string ID, Engine engine, float energy, List<Wheel> wheels, string vehiclesOwner, string phoneNumber, Boolean sold)
        {
            this.model = model;
            this.ID = ID;
            this.engine = engine;
            this.energy = energy;
            this.wheels = wheels;
            this.vehiclesOwner = vehiclesOwner;
            this.phoneNumber = phoneNumber;
            this.sold = sold;
        }
        public string getID()
        {
            return ID;
        }

        public void showID(List<Vehicle> market)
        {
            foreach (Vehicle v in market)
            {
                Console.WriteLine(v.ID);
            }
        }
        // change sold boolean
        public void ChangeOrderStatos(Boolean isSold)
        {
            this.sold = isSold;
        }

        public override string ToString()
        {
            int i = 1;
            string wheelString="";
            foreach (Wheel wheel in wheels)
            {

                wheelString += $"\nWheel number {i}:" + wheel.ToString();
            }
                return $"model: {model}\n" +
                    $"id: {ID}\t" + engine.ToString() +
                    $"energy: {energy}\tvehiclesOwner: {vehiclesOwner}\tphoneNumber: {phoneNumber}\n" +
                    $"sold: {sold} {wheelString}";
            }
        }

    }
