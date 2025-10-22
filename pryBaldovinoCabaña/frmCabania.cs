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

        // constantes para los cálculos
        private const float TIPOA = 20;
        public const float TIPOB = 34;
        const float COCINA = 1;
        const float HELADERA = 1.5f;
        const float TELEVISOR = 2;
        const float PORPERSONA = 1;


        public frmCabania()
        {
            InitializeComponent();
        }

        void CargarDatos()
        {
            matReserva[0, 0] = "Tipo A"; matReserva[0, 1] = "45"; matReserva[0, 2] = "12";
            matReserva[1, 0] = "Tipo B"; matReserva[1, 1] = "78"; matReserva[1, 2] = "23";
            matReserva[2, 0] = "Tipo A"; matReserva[2, 1] = "12"; matReserva[2, 2] = "5";
            matReserva[3, 0] = "Tipo B"; matReserva[3, 1] = "93"; matReserva[3, 2] = "31";
            matReserva[4, 0] = "Tipo A"; matReserva[4, 1] = "26"; matReserva[4, 2] = "18";
            matReserva[5, 0] = "Tipo B"; matReserva[5, 1] = "51"; matReserva[5, 2] = "9";
            matReserva[6, 0] = "Tipo A"; matReserva[6, 1] = "88"; matReserva[6, 2] = "29";
            matReserva[7, 0] = "Tipo B"; matReserva[7, 1] = "60"; matReserva[7, 2] = "4";
            matReserva[8, 0] = "Tipo A"; matReserva[8, 1] = "33"; matReserva[8, 2] = "16";
            matReserva[9, 0] = "Tipo B"; matReserva[9, 1] = "7"; matReserva[9, 2] = "25";
            matReserva[10, 0] = "Tipo A"; matReserva[10, 1] = "98"; matReserva[10, 2] = "11";
            matReserva[11, 0] = "Tipo B"; matReserva[11, 1] = "15"; matReserva[11, 2] = "22";
            matReserva[12, 0] = "Tipo A"; matReserva[12, 1] = "55"; matReserva[12, 2] = "3";
            matReserva[13, 0] = "Tipo B"; matReserva[13, 1] = "82"; matReserva[13, 2] = "30";
            matReserva[14, 0] = "Tipo A"; matReserva[14, 1] = "39"; matReserva[14, 2] = "14";
            matReserva[15, 0] = "Tipo B"; matReserva[15, 1] = "67"; matReserva[15, 2] = "27";
            matReserva[16, 0] = "Tipo A"; matReserva[16, 1] = "4"; matReserva[16, 2] = "6";
            matReserva[17, 0] = "Tipo B"; matReserva[17, 1] = "91"; matReserva[17, 2] = "19";
            matReserva[18, 0] = "Tipo A"; matReserva[18, 1] = "73"; matReserva[18, 2] = "17";
            matReserva[19, 0] = "Tipo B"; matReserva[19, 1] = "20"; matReserva[19, 2] = "26";
            matReserva[20, 0] = "Tipo A"; matReserva[20, 1] = "63"; matReserva[20, 2] = "10";
            matReserva[21, 0] = "Tipo B"; matReserva[21, 1] = "37"; matReserva[21, 2] = "2";
            matReserva[22, 0] = "Tipo A"; matReserva[22, 1] = "49"; matReserva[22, 2] = "28";
            matReserva[23, 0] = "Tipo B"; matReserva[23, 1] = "77"; matReserva[23, 2] = "13";
            matReserva[24, 0] = "Tipo A"; matReserva[24, 1] = "22"; matReserva[24, 2] = "21";
            matReserva[25, 0] = "Tipo B"; matReserva[25, 1] = "84"; matReserva[25, 2] = "8";
            matReserva[26, 0] = "Tipo A"; matReserva[26, 1] = "1"; matReserva[26, 2] = "24";
            matReserva[27, 0] = "Tipo B"; matReserva[27, 1] = "96"; matReserva[27, 2] = "15";
            matReserva[28, 0] = "Tipo A"; matReserva[28, 1] = "58"; matReserva[28, 2] = "7";
            matReserva[29, 0] = "Tipo B"; matReserva[29, 1] = "10"; matReserva[29, 2] = "32";
            matReserva[30, 0] = "Tipo A"; matReserva[30, 1] = "81"; matReserva[30, 2] = "20";
            matReserva[31, 0] = "Tipo B"; matReserva[31, 1] = "44"; matReserva[31, 2] = "1";
            matReserva[32, 0] = "Tipo A"; matReserva[32, 1] = "70"; matReserva[32, 2] = "33";
            matReserva[33, 0] = "Tipo B"; matReserva[33, 1] = "25"; matReserva[33, 2] = "17";
            matReserva[34, 0] = "Tipo A"; matReserva[34, 1] = "95"; matReserva[34, 2] = "10";
            matReserva[35, 0] = "Tipo B"; matReserva[35, 1] = "13"; matReserva[35, 2] = "26";
            matReserva[36, 0] = "Tipo A"; matReserva[36, 1] = "50"; matReserva[36, 2] = "5";
            matReserva[37, 0] = "Tipo B"; matReserva[37, 1] = "76"; matReserva[37, 2] = "29";
            matReserva[38, 0] = "Tipo A"; matReserva[38, 1] = "3"; matReserva[38, 2] = "12";
            matReserva[39, 0] = "Tipo B"; matReserva[39, 1] = "89"; matReserva[39, 2] = "31";
            matReserva[40, 0] = "Tipo A"; matReserva[40, 1] = "65"; matReserva[40, 2] = "18";
            matReserva[41, 0] = "Tipo B"; matReserva[41, 1] = "28"; matReserva[41, 2] = "9";
            matReserva[42, 0] = "Tipo A"; matReserva[42, 1] = "42"; matReserva[42, 2] = "25";
            matReserva[43, 0] = "Tipo B"; matReserva[43, 1] = "17"; matReserva[43, 2] = "4";
            matReserva[44, 0] = "Tipo A"; matReserva[44, 1] = "94"; matReserva[44, 2] = "16";
            matReserva[45, 0] = "Tipo B"; matReserva[45, 1] = "6"; matReserva[45, 2] = "23";
            matReserva[46, 0] = "Tipo A"; matReserva[46, 1] = "79"; matReserva[46, 2] = "11";
            matReserva[47, 0] = "Tipo B"; matReserva[47, 1] = "35"; matReserva[47, 2] = "22";
            matReserva[48, 0] = "Tipo A"; matReserva[48, 1] = "52"; matReserva[48, 2] = "3";
            matReserva[49, 0] = "Tipo B"; matReserva[49, 1] = "90"; matReserva[49, 2] = "30";
            matReserva[50, 0] = "Tipo A"; matReserva[50, 1] = "21"; matReserva[50, 2] = "14";
            matReserva[51, 0] = "Tipo B"; matReserva[51, 1] = "68"; matReserva[51, 2] = "27";
            matReserva[52, 0] = "Tipo A"; matReserva[52, 1] = "47"; matReserva[52, 2] = "6";
            matReserva[53, 0] = "Tipo B"; matReserva[53, 1] = "11"; matReserva[53, 2] = "19";
            matReserva[54, 0] = "Tipo A"; matReserva[54, 1] = "83"; matReserva[54, 2] = "17";
            matReserva[55, 0] = "Tipo B"; matReserva[55, 1] = "30"; matReserva[55, 2] = "26";
            matReserva[56, 0] = "Tipo A"; matReserva[56, 1] = "62"; matReserva[56, 2] = "10";
            matReserva[57, 0] = "Tipo B"; matReserva[57, 1] = "5"; matReserva[57, 2] = "2";
            matReserva[58, 0] = "Tipo A"; matReserva[58, 1] = "34"; matReserva[58, 2] = "28";
            matReserva[59, 0] = "Tipo B"; matReserva[59, 1] = "92"; matReserva[59, 2] = "13";
            matReserva[60, 0] = "Tipo A"; matReserva[60, 1] = "16"; matReserva[60, 2] = "21";
            matReserva[61, 0] = "Tipo B"; matReserva[61, 1] = "75"; matReserva[61, 2] = "8";
            matReserva[62, 0] = "Tipo A"; matReserva[62, 1] = "40"; matReserva[62, 2] = "24";
            matReserva[63, 0] = "Tipo B"; matReserva[63, 1] = "23"; matReserva[63, 2] = "15";
            matReserva[64, 0] = "Tipo A"; matReserva[64, 1] = "86"; matReserva[64, 2] = "7";
            matReserva[65, 0] = "Tipo B"; matReserva[65, 1] = "59"; matReserva[65, 2] = "32";
            matReserva[66, 0] = "Tipo A"; matReserva[66, 1] = "19"; matReserva[66, 2] = "20";
            matReserva[67, 0] = "Tipo B"; matReserva[67, 1] = "4"; matReserva[67, 2] = "1";
            matReserva[68, 0] = "Tipo A"; matReserva[68, 1] = "72"; matReserva[68, 2] = "33";
            matReserva[69, 0] = "Tipo B"; matReserva[69, 1] = "97"; matReserva[69, 2] = "17";
            matReserva[70, 0] = "Tipo A"; matReserva[70, 1] = "29"; matReserva[70, 2] = "10";
            matReserva[71, 0] = "Tipo B"; matReserva[71, 1] = "41"; matReserva[71, 2] = "26";
            matReserva[72, 0] = "Tipo A"; matReserva[72, 1] = "56"; matReserva[72, 2] = "5";
            matReserva[73, 0] = "Tipo B"; matReserva[73, 1] = "85"; matReserva[73, 2] = "29";
            matReserva[74, 0] = "Tipo A"; matReserva[74, 1] = "14"; matReserva[74, 2] = "12";
            matReserva[75, 0] = "Tipo B"; matReserva[75, 1] = "32"; matReserva[75, 2] = "31";
            matReserva[76, 0] = "Tipo A"; matReserva[76, 1] = "69"; matReserva[76, 2] = "18";
            matReserva[77, 0] = "Tipo B"; matReserva[77, 1] = "54"; matReserva[77, 2] = "9";
            matReserva[78, 0] = "Tipo A"; matReserva[78, 1] = "2"; matReserva[78, 2] = "25";
            matReserva[79, 0] = "Tipo B"; matReserva[79, 1] = "71"; matReserva[79, 2] = "4";
            matReserva[80, 0] = "Tipo A"; matReserva[80, 1] = "9"; matReserva[80, 2] = "16";
            matReserva[81, 0] = "Tipo B"; matReserva[81, 1] = "48"; matReserva[81, 2] = "23";
            matReserva[82, 0] = "Tipo A"; matReserva[82, 1] = "57"; matReserva[82, 2] = "11";
            matReserva[83, 0] = "Tipo B"; matReserva[83, 1] = "24"; matReserva[83, 2] = "22";
            matReserva[84, 0] = "Tipo A"; matReserva[84, 1] = "80"; matReserva[84, 2] = "3";
            matReserva[85, 0] = "Tipo B"; matReserva[85, 1] = "18"; matReserva[85, 2] = "30";
            matReserva[86, 0] = "Tipo A"; matReserva[86, 1] = "43"; matReserva[86, 2] = "14";
            matReserva[87, 0] = "Tipo B"; matReserva[87, 1] = "64"; matReserva[87, 2] = "27";
            matReserva[88, 0] = "Tipo A"; matReserva[88, 1] = "27"; matReserva[88, 2] = "6";
            matReserva[89, 0] = "Tipo B"; matReserva[89, 1] = "99"; matReserva[89, 2] = "19";
            matReserva[90, 0] = "Tipo A"; matReserva[90, 1] = "74"; matReserva[90, 2] = "17";
            matReserva[91, 0] = "Tipo B"; matReserva[91, 1] = "53"; matReserva[91, 2] = "26";
            matReserva[92, 0] = "Tipo A"; matReserva[92, 1] = "38"; matReserva[92, 2] = "10";
            matReserva[93, 0] = "Tipo B"; matReserva[93, 1] = "100"; matReserva[93, 2] = "2";
            matReserva[94, 0] = "Tipo A"; matReserva[94, 1] = "95"; matReserva[94, 2] = "28";
            matReserva[95, 0] = "Tipo B"; matReserva[95, 1] = "61"; matReserva[95, 2] = "13";
            matReserva[96, 0] = "Tipo A"; matReserva[96, 1] = "31"; matReserva[96, 2] = "21";
            matReserva[97, 0] = "Tipo B"; matReserva[97, 1] = "46"; matReserva[97, 2] = "8";
            matReserva[98, 0] = "Tipo A"; matReserva[98, 1] = "87"; matReserva[98, 2] = "24";
            matReserva[99, 0] = "Tipo B"; matReserva[99, 1] = "1"; matReserva[99, 2] = "15";
            matReserva[100, 0] = "Tipo A"; matReserva[100, 1] = "13"; matReserva[100, 2] = "7";
            matReserva[101, 0] = "Tipo B"; matReserva[101, 1] = "9"; matReserva[101, 2] = "32";
        }


        public struct Reserva
        {
            public string Tipo;
            public string Personas;
            public string Dias;
        }

        Reserva[] vecReserva = new Reserva[3];

        string[,] matReserva = new string[200, 3];

        int indiceFila = 0;



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float PrecioBase;
            float Opcionales;
            float Recargo;
            int Dias;
            float Total;
            // obtener la cantidad de dìas ingresados
            Dias = int.Parse(txtDias.Text);
            // controlar el tipo de cabaña para determinar el precio base
            if (cboTipo.SelectedIndex == 0)
            {
                PrecioBase = TIPOA;
            }
            else
            {
                PrecioBase = TIPOB;
            }

            // sumar al precio base el importe extra por persona (US$ 1)
            PrecioBase = PrecioBase + (PORPERSONA * int.Parse(cboPersonas.Text));
            // controlar los adicionales por las opciones
            Opcionales = 0;
            if (chkCocina.Checked == true)
            {
                Opcionales = Opcionales + COCINA;
            }
            if (chkHeladera.Checked == true)
            {
                Opcionales = Opcionales + HELADERA;
            }
            if (chkTelevisor.Checked == true)
            {
                Opcionales = Opcionales + TELEVISOR;
            }
            // determinar el total por la cantidad de dìas
            Total = (PrecioBase + Opcionales) * Dias;

            // controlar la forma de pago
            if (optTarjeta.Checked == true)
            {
                if (cboTarjetas.SelectedIndex == 0)
                {
                    Recargo = Total * 10 / 100;
                }
                else
                {
                    Recargo = Total * 20 / 100;
                }
                Total = Total + Recargo;
            }
            // mostrar el resultado
            MessageBox.Show("Total = $ " + Total.ToString(), "Importe de la reserva",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            // inicialzar los controles de la interfaz

            cboTipo.SelectedIndex = 0;
            txtDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            // en los radiobuttons se asigna sólo el que debe quedar en true
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefonos.Text = "";
        

            matReserva[indiceFila, 0] = cboTipo.Text;
            matReserva[indiceFila, 1] = cboPersonas.Text;
            matReserva[indiceFila, 2] = txtDias.Text;

            indiceFila++;
        }


        private void frmCabania_Load(object sender, EventArgs e)
        {

            // cargar los items en el primer control combobox
            cboTipo.Items.Clear();
            cboTipo.Items.Add("Tipo A");
            cboTipo.Items.Add("Tipo B");
            // esta acción provoca el disparo del evento "SelectedIndexChanged"
            cboTipo.SelectedIndex = 0;
            // se inicializa la cantidad de días en 1
            txtDias.Text = "1";
            // inicialzar los demás controles de la interfaz
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            // en los radiobuttons se asigna sólo el que debe quedar en true
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefonos.Text = "";
            // cargar los items del combo de tarjetas
            cboTarjetas.Items.Clear();
            cboTarjetas.Items.Add("Card Red");
            cboTarjetas.Items.Add("Card Green");
            cboTarjetas.Items.Add("Card Blue");
            // deshabiliar el botón "Aceptar"
            btnAceptar.Enabled = false;


            CargarDatos();
            for (int indiceRecorridoFila = 0; indiceRecorridoFila < matReserva.GetLength(0); indiceRecorridoFila++)
            {
                dgvDatos.Rows.Add(matReserva[indiceRecorridoFila, 0],
                    matReserva[indiceRecorridoFila, 1],
                    matReserva[indiceRecorridoFila, 2]);
            }

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cuando ocurra el evento se debe actualizar el
            // contenido del combo de personas
            int I = 0;
            // limpiar los items de personas
            cboPersonas.Items.Clear();
            // si es tipo de cabaña A ->> cargar los items del 1 al 4
            if (cboTipo.SelectedIndex == 0) // o cmbTipo.SelectedItem == "Tipo A"
            {
                for (I = 1; I <= 4; I++)
                {
                    cboPersonas.Items.Add(I);
                }
            }
            else
            { // si es tipo de cabaña B ->> cargar los items del 1 al 8
                for (I = 1; I <= 8; I++)
                {
                    cboPersonas.Items.Add(I);
                }
            }
            // establecer como preseleccionado el item 0 del combo
            cboPersonas.SelectedIndex = 0;
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            // se deshabilita el combo y no se muestra nada
            cboTarjetas.Enabled = false;
            cboTarjetas.SelectedIndex = -1;
        }
        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            // se habilita el combo y se muestra el primer item
            cboTarjetas.Enabled = true;
            cboTarjetas.SelectedIndex = 0;
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el botón "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
            txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el botón "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
            txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtTelefonos_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el botón "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
            txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }
    }
}
