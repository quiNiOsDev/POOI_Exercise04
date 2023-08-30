using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public  class Fotocopias
    {
        public string nombreCliente { get; set; }
        public string descripcionDocumento { get; set;}
        public int cantDocumento { get; set; }
        public int numeroCopias { get; set; }
        

        public double precioFotocopia { get; set; }

        public Fotocopias()
        {
            cantDocumento = 0;
            numeroCopias = 0;
            precioFotocopia = 0.10;

        }



        

    }
}
