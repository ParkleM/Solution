using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation6
{
    public class AircraftCarrier : Warship
    {
        public override string Name { get; set; }
        public override string Model { get; set; }
        public override string Data { get; set; }
        public override double Length { get; set; }
        public override int SailStatus { get ; set; }
        public int Crew { get; set; }

        public int Aircraft { get; set; }

        public override int NumberOfCrew()
        {
            return (int)(Length*1.5);
        }

        public string GetCrew()
        {
            return $"Количество экипажа: " + Crew;
        }

        public override int NumberOfAircraft()
        {
            return(int)(Length/75);
        }

    }
}
