using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Clases
{
    public class Huesped : Usuario
    {
        public Huesped(string nom, e_tipoID tipoid, short documento, short tel, string usu, string contra) : base(nom, tipoid, documento, tel, usu, contra)
        {}
    }
}
