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
        public override int Data { get; set; }
        public override double Length { get; set; }
        public override int SailStatus { get; set; }
        public int Crew { get; set; }
        public int Aircraft { get; set; }

        AircraftCarrier(string name, string model, int data, double length)
        {
            Name = name;
            Model = model;
            Data = data;
            Length = length;
            Crew = 0;
            Aircraft = 0;
        }

        public override int NumberOfCrew()
        {
            return (int)(Length * 1.5);
        }

        public string GetCrew()
        {
            Crew = NumberOfCrew();
            return $"Количество экипажа на корабле: {Crew}";
        }

        public override int NumberOfAircraft()
        {
            return (int)(Length / 75);
        }

        public string GetAircraft()
        {
            Aircraft = NumberOfAircraft();
            return $"Количество самолетов на корабле: {Aircraft}";
        }

        public string GetInfo()
        {
            string text = "Информация о корабле:" +
                            "\r\nНазвание: " + Name +
                            "\r\nМодель: " + Model +
                            "\r\nТип: Авианосец" +
                            "\r\nГод выпуска: " + Data +
                            "\r\nДлина: " + Length +
                            "\r\n" +
                            "\r\nИнформация о плавании: ";
            switch (SailStatus)
            {
                case 0:
                    text += "\r\nКорабль не был в плавании. ";
                    break;
                case 1:
                    text += "\r\nКорабль в плавании." +
                            "\r\n" + NumberOfCrew() +
                            "\r\n" + NumberOfAircraft();

                    break;
                case 2:
                    text += "\r\nКорабль вернулся из плавания." +
                            "\r\n" + NumberOfCrew() +
                            "\r\n" + NumberOfAircraft();
                    break;
            }
            return text;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
