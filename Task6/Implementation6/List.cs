using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation6
{
    public class List
    {
        private List<AircraftCarrier> ShipList { get; set; }

        List()
        {
            ShipList = new List<AircraftCarrier>();
        }

        public void Add(AircraftCarrier a)
        {
            ShipList.Add(a);
        }

        public void Remove(AircraftCarrier a)
        {
            ShipList.Remove(a);
        }

        public void ToSail(int index)
        {
            ShipList[index].ToSail();
        }

        public void FromSail(int index)
        {
            ShipList[index].FromSail();
        }

        public bool ContainsShip(AircraftCarrier a)
        {
            return ShipList.Contains(a) ? true : false;
        }
    }
}
