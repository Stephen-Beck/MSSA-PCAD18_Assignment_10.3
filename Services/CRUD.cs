using Assignment_10._3.Data;
using Assignment_10._3.Models;

namespace Assignment_10._3.Services
{
    public class CRUD
    {
        public void SaveChanges()
        {
            Records.context.SaveChanges();
        }
        public void AddCar(Car car)
        {
            Records.context.Cars.Add(car);
            SaveChanges();
        }

        public void DeleteCar(string vin)
        {
            Car car = GetCarByVIN(vin);

            if (car != null)
            {
                Records.context.Cars.Remove(car);
                SaveChanges();
            }
        }

        public void UpdateCar(string vin, Car car)
        {
            Car existingCar = GetCarByVIN(vin);
            if (existingCar != null)
            {
                existingCar.Make = car.Make;
                existingCar.Model = car.Model;
                existingCar.Color = car.Color;
                existingCar.Year = car.Year;
                existingCar.Price = car.Price;
                existingCar.Dealership = car.Dealership;
                SaveChanges();
            }
        }

        public List<Car> GetAllCars()
        {
            return Records.context.Cars.ToList();
        }

        public List<Dealership> GetAllDealerships()
        {
            return Records.context.Dealerships.ToList();
        }

        public Car GetCarByVIN(string vin)
        {
            return Records.context.Cars.Find(vin);
        }
    }
}
