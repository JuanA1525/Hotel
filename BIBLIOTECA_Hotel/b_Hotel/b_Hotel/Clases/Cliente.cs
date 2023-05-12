using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_Hotel.Clases
{
    internal class Cliente : Usuario
    {
        private string codigoCliente;
        private float descuento;

        public Cliente(string nom, e_tipoID tipoid, short documento, short tel, string usu, string contra, string codigo, e_Nacionalidad nacion, float descto) : base(nom, tipoid, documento, tel, usu, contra, nacion)
        {
            CodigoCliente = codigo;
            Descuento = descto;
        }

        public string CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public float Descuento { get => descuento; set => descuento = value; }
    }
}
