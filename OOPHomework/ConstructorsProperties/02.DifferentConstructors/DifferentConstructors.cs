﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DifferentConstructors
{
    class DifferentConstructors
    {
        static void Main(string[] args)
        {
            GSM phone = new GSM("lala", "sumsAng");
            Console.WriteLine(phone.ToString());
            phone = new GSM("lala", "sumsAng", "batman");
            Console.WriteLine(phone.ToString());
            phone = new GSM("lol", "krusha", "suparMan", 9999, new Battery("tuhla", 2, 1));
            Console.WriteLine(phone.ToString());
            phone = new GSM("lol", "krusha", "suparMan", 9999, new Display(5.5, 3));
            Console.WriteLine(phone.ToString());
        }
    }

    class GSM
    {
        public Battery battery { get; set; }
        public Display display { get; set; }

        public string model { get; set; }
        public string manufacturer { get; set; }
        public string owner { get; set; }
        public double? price { get; set; }

        public GSM(string model, string manuf)
        {
            this.model = model;
            this.manufacturer = manuf;
            this.owner = null;
            this.price = null;
        }

        public GSM(string model, string manuf, string owner)
        {
            this.model = model;
            this.manufacturer = manuf;
            this.owner = owner;
            this.price = null;
        }

        public GSM(string model, string manuf, string owner, double price)
        {
            this.model = model;
            this.manufacturer = manuf;
            this.owner = owner;
            this.price = price;
        }

        public GSM(string model, string manuf, string owner, double price, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manuf;
            this.owner = owner;
            this.price = price;
            this.battery = battery;
            this.display = display;
        }

        public GSM(string model, string manuf, string owner, double price, Battery battery)
        {
            this.model = model;
            this.manufacturer = manuf;
            this.owner = owner;
            this.price = price;
            this.battery = battery;
        }

        public GSM(string model, string manuf, string owner, double price, Display display)
        {
            this.model = model;
            this.manufacturer = manuf;
            this.owner = owner;
            this.price = price;
            this.display = display;
        }

        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Model: {0}\n", model);
            sb.AppendFormat("Manufacturer: {0}\n", manufacturer);
            sb.AppendFormat("Owner: {0}\n", owner);
            sb.AppendFormat("Price: {0}\n", price);

            if (battery != null)
            {
                sb.Append(battery.ToString());
            }
            if (display != null)
            {
                sb.Append(display.ToString());
            }
            return sb.ToString();
        }

    }

    class Battery
    {
        public string model { get; set; }
        public int hoursIdle { get; set; }
        public int hoursTalk { get; set; }

        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Battery model: {0}\n", model);
            sb.AppendFormat("Battery hours idle: {0}\n", hoursIdle);
            sb.AppendFormat("Battery hours talk: {0}\n", hoursTalk);
            return sb.ToString();
        }
    }

    class Display
    {
        public double sizeInches { get; set; }
        public int numberOfColors { get; set; }

        public Display(double sizeInches, int numberOfColors)
        {
            this.sizeInches = sizeInches;
            this.numberOfColors = numberOfColors;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Display size in inches: {0}\n", sizeInches);
            sb.AppendFormat("Display number of colors: {0}\n", numberOfColors);
            return sb.ToString();
        }
    }
}
