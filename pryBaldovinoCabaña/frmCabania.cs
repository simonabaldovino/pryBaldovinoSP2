using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBaldovinoCabaña
{
    public partial class frmCabania : Form
    {
        public frmCabania()
        {
            InitializeComponent();
        }



        public struct Reserva
        {        
            public string Tipo;
            public string Personas;
            public string Dias;
        }

        Reserva[] vecReserva = new Reserva[3];

        string [,] matReserva = new string[3, 3];

        int indiceFila = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            matReserva[indiceFila, 0] = cboTipo.Text;
            matReserva[indiceFila, 1] = cboPersonas.Text;
            matReserva[indiceFila, 2] = txtDias.Text;

            indiceFila++;
        }
    }
}
