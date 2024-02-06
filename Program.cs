
using Cars_and_used_cars;

Console.WriteLine("Welcome to the GC Car Dealership");

List<Car> CarList = new List<Car>()
{ 
    // used cars
    new UsedCar("Ford", "Bronco", 2018, 30000m, 20000),
    new UsedCar("Chevy", "Camaro", 2020, 50000m, 5000),
    new UsedCar("GM\t", "Yukon", 2020, 50000m, 2000),

    // new cars
    new Car("Toyota", "Sienna", 2024, 30000m),
    new Car("Jeep", "4xe", 2024, 80000m),
    new Car("Ford", "Raptor", 2024, 60000m)
};

Car.ListCars(CarList);