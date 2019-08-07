using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGarage_03_19
{
    public class Garage : IGarage
    {
        private List<Car> cars;
        private List<string> carTypes;

        public Garage(List<string> list)
        {
            cars = new List<Car>();
            carTypes = list;
        }

        public void AddCar(Car car)
        {
            if (car == null)
                throw new CarNullException();
            if (!carTypes.Contains(car.Brand))
                throw new WrongGarageException();
            if (cars.Contains(car))
                throw new CarAlreadyInGarageException();
            if (car.TotalLoss)
                throw new WeDoNotFixTotalLossException();
            if (!car.NeedsRepair)
                throw new RepairMismatchException();
            cars.Add(car);
        }

        public void TakeOutCar(Car car)
        {
            if (car == null)
                throw new CarNullException();
            if (!cars.Contains(car))
                throw new CarNotInGarageException();
            if (car.NeedsRepair)
                throw new CarNotReadyException();
            cars.Remove(car);
        }

        public void FixCar(Car car)
        {
            if (car == null)
                throw new CarNullException();
            if (!cars.Contains(car))
                throw new CarNotInGarageException();
            if (!car.NeedsRepair)
                throw new RepairMismatchException();

            car.NeedsRepair = false;
        }
    }
}
