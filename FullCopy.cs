using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public  class FullCopy : Fotocopias
    {

        public string tamano { get; set; }

        public double precioFotocopiatotal()
        {
            switch (tamano.ToLower())
            {
                case "a4": precioFotocopia = 0.08; break;
                case "a3": precioFotocopia = 0.15; break;
                default: precioFotocopia = 0.10;break;

            }
            return precioFotocopia;
        }
        public double costoTotalFotocopias()
        {
            return cantDocumento * numeroCopias * precioFotocopiatotal();
        }

    }
}
