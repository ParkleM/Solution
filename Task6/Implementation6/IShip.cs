using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation6
{
    public interface IShip
    {
        string Name { get; set; }

        string ToSail();

        string FromSail();

    }
}
