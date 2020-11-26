using System;

namespace Car
{
    class Program
    {
        class Car
        {
            string name;
            string model;
            string registrationnumber;
            string color;
            int odometer;
            int fueltank;

            public Car(string _name, string _model, string _registrationnumber, string _color)
            {
                name = _name;
                model = _model;
                registrationnumber = _registrationnumber;
                color = _color;
                odometer = 0;
                fueltank = 60;
                Console.WriteLine($"the car {name} has been created.");
            }

            public string Name
            {
                get { return name; }
            }

            public string Model
            {
               get { return model; }
            }

            public string  Registrationnumber
            {
                get { return registrationnumber; }
                set
                {
                    if(value.Length == 6)
                    {
                        Registrationnumber = value;

                    }else
                    {
                        registrationnumber = " Fast and speedrun";
                    }
                }
            }
            public string Color
            {
                get { return color; }
            }

            public int Odometer
            {
                get { return odometer; }
            }

            public int FuelTank
            {
                get { return fueltank; }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car newCar = new Car("Audi s6", "sedan", "AMG801", "Green");
            Console.WriteLine(newCar.Name);
            Console.WriteLine(newCar.Model);
            Console.WriteLine(newCar.Registrationnumber);
            Console.WriteLine(newCar.Color);
            Console.WriteLine(newCar.Odometer);
            Console.WriteLine(newCar.FuelTank);

        }
    }
}
