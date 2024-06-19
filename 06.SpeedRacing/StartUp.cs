using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
2
AudiA4 23 0.3
BMW-M2 45 0.42
Drive BMW-M2 56
Drive AudiA4 5
Drive AudiA4 13
End

3
AudiA4 18 0.34
BMW-M2 33 0.41
Ferrari-488Spider 50 0.47
Drive Ferrari-488Spider 97
Drive Ferrari-488Spider 35
Drive AudiA4 85
Drive AudiA4 50
End

 */
namespace _06.SpeedRacing
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int rows = int.Parse(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = line[0];
                double fuelAmount = double.Parse(line[1]);
                double fuelConsumptionFor1km = double.Parse(line[2]);

                if (!cars.Any(c => c.Model == model))
                {
                    Car car = new(model, fuelAmount, fuelConsumptionFor1km);
                    cars.Add(car);
                }

            }

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray(); 

                string command = arguments[0];
                string carModel = arguments[1];
                double amountOfKm = double.Parse(arguments[2]);

                var findCar = cars.Where(c => c.Model.Contains(carModel)).FirstOrDefault();
                if (findCar != null)
                {
                    findCar.Move(findCar, amountOfKm);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
