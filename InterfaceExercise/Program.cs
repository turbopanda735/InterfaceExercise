using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main()
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */

            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car = new Car()
            {
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                FuelType = "Electric",
                IsDriveable = true,
                CompanyName = "Ford",
                Logo = "blue oval with FORD written in a stylized font"
            };
            var truck = new Truck()
            {
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                FuelType = "Diesel",
                IsDriveable = true,
                CompanyName = "Big Truck",
                Logo = "i made this one up"
            };
            var suv = new SUV()
            {
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                FuelType = "Gasoline",
                IsDriveable = true,
                CompanyName = "Subaru",
                Logo = "blue oval with eight stars arranged"
            };

            var companyLot = new List<ICompany>();
            companyLot.Add(car);
            companyLot.Add(truck);
            companyLot.Add(suv);

            var vehicleLot = new List<IVehicle>();
            vehicleLot.Add(car);
            vehicleLot.Add(truck);
            vehicleLot.Add(suv);

            foreach (var vehicle in companyLot)
            {
                Console.WriteLine(vehicle.CompanyName);
                Console.WriteLine(vehicle.Logo);
            }
            foreach (var vehicle in vehicleLot)
            {
                Console.WriteLine(vehicle.NumberOfWheels);
                Console.WriteLine(vehicle.NumberOfDoors);
                Console.WriteLine(vehicle.FuelType);
                Console.WriteLine(vehicle.IsDriveable);
            }

        }
    }
}
