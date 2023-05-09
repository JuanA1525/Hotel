using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Clases
{
    internal class Producto
    {
        internal enum e_tipos_producto { Gaseosa , Agua , Vino , Licor , Bata , KitAseo }
        internal e_tipos_producto type;

        public Producto(e_tipos_producto tipo) 
        { 
            type = tipo;
        }

    }
}
