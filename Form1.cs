using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            FullCopy fullCopy = new FullCopy()
            {
                nombreCliente = txtCliente.Text,
                descripcionDocumento = txtDescripcion.Text,
                cantDocumento = int.Parse(txtCantidad.Text),
                numeroCopias = int.Parse(txtNroCopias.Text),
                tamano = cboTamano.Text,
            };

            txtPrecioCopia.Text = fullCopy.precioFotocopiatotal().ToString();
            txtCostoTotal.Text= fullCopy.costoTotalFotocopias().ToString();







        }
    }
}
