using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGarage_03_19
{
    public class Car
    {
        public string Brand { get; private set; }
        public bool TotalLoss { get; private set; }
        public bool NeedsRepair { get; set; }

        public Car(string brand, bool totalLoss, bool needsRepair)
        {
            Brand = brand;
            TotalLoss = totalLoss;
            NeedsRepair = needsRepair;

            if (TotalLoss == true && NeedsRepair == false)
            {
                throw new RepairMismatchException();
            }
        }
    }
}
