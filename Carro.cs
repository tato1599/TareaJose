using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoU1P2
{
    public partial class Carrocvja : Form
    {
        public static string user = "Example";
        frmcvjaCompras listas = new frmcvjaCompras(user);

        public Carrocvja(List<String> ListaObjetos, List<double> ListaPrecios)
        {
            InitializeComponent();


            

            lbcvjaProductos.DataSource = ListaObjetos;
            lbcvjaPrecios.DataSource = ListaPrecios;
        }

        private void btncvjaRegresar_Click(object sender, EventArgs e)
        {
            Program.f3.Hide();
            Program.f3 = null;
        }

        private void btncvjaQuitar_Click(object sender, EventArgs e)
        {
            
            int index = lbcvjaProductos.SelectedIndex;
            if (index >= 0)
            {
                Program.objetos.RemoveAt(index);
                Program.MontoParcial.RemoveAt(index);
                lbcvjaProductos.DataSource = null;
                lbcvjaPrecios.DataSource = null;
                lbcvjaProductos.DataSource = Program.objetos;
                lbcvjaPrecios.DataSource = Program.MontoParcial;
            }
            else
            {
                MessageBox.Show("No hay nada seleccionado");
            }


        }
    }
}
