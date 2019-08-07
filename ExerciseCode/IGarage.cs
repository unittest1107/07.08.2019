using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGarage_03_19
{
    public interface IGarage
    {
        void AddCar(Car car);

        void TakeOutCar(Car car);

        void FixCar(Car car);
    }
}
