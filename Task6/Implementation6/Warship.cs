using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation6
{
    public abstract class Warship : IShip
    {
        public abstract string Name { get; set; }

        public abstract string Model { get; set; }

        public abstract int Data { get; set; }

        public abstract double Length { get; set; }

        public abstract int SailStatus { get; set; }

        public string ToSail()
        {
            SailStatus = 1;
            return "Отправляемся в плавание.";
        }

        public string FromSail()
        {
            SailStatus = 2;
            return "Вернулись из плавания.";
        }

        public abstract int NumberOfCrew(); /*кол-во экипажа*/

        public abstract int NumberOfAircraft(); /*кол-во самолетиков хыхыхыххы*/
    }
}
