using b_Hotel.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Interfaces
{
    internal interface I_Recepcion
    {
        void Check_In(Reserva res);
        Dictionary<string, float> Check_Out(Reserva res);
    }
}
