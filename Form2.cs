using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoU1P2
{
    public partial class frmcvjaCompras : Form
    {
        Dictionary<string, double> productos = new Dictionary<string, double>();
        //public List<string> objetos = new List<string>();
        //public List<double> MontoParcial = new List<double>();

        public frmcvjaCompras(String usuario)
        {
            InitializeComponent();
            this.Text = "Bienvenido: " + usuario;
            productos.Add("Audifonos Logitech G335", 1100.99);
            productos.Add("Audifonos Razer Blackshark V2 X", 1299.00);
            productos.Add("Audifonos Logitech G733 Lightspeed", 1039.99);
            productos.Add("Audifonos HyperX Cloud Stinger Core", 759.99);
            productos.Add("Audifonos ASTRO gaming A10", 970.00);
            productos.Add("Audifonos Corsair HS35", 1400.00);
            productos.Add("Laptop HP victus Gaming", 17300.99);
            productos.Add("Laptop Asus TUF GAMING F15", 20200.00);
            productos.Add("Laptop MSI Pulse GL66", 25000.99);
            productos.Add("Laptop Acer Nitro 5", 15459.00);
            productos.Add("Mouse Logitech G203 lightsync", 299.00);
            productos.Add("Mouse HyperX Pulsefire Core", 700.00);
            productos.Add("Mouse Razer Basilisk X HyperSpeed Wireless", 1399.99);
            productos.Add("Mouse Logitech G502 Hero", 999.00);
            productos.Add("Mouse Corsair M65 Pro", 500.00);
            productos.Add("Mouse Logitech G305 Lightspeed Wireless", 799.00);
            productos.Add("Mouse Balam Rush Hiperion Wireless", 550.00);
            productos.Add("Computadora Asus ROG Strix G15", 27500.00);
            productos.Add("Computadora Lenovo Legion T5", 30000.00);
            productos.Add("Computadora Acer Predator Orion 3000", 31299.99);
            productos.Add("Teclado G213 prodigy", 1300.99);
            productos.Add("Teclado HyperX Alloy Core", 750.00);
            productos.Add("Teclado Redragon K630 Dragonborn", 999.99);
            productos.Add("Teclado SteelSeries Apex 7", 1559.00);
        }
     
        private void combcvjaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {


            clbcvjaProductosDisp.Items.Clear();
            string seleccion = combcvjaProductos.SelectedItem.ToString();

            if (seleccion == "Audifonos")
            {
                clbcvjaProductosDisp.Items.Add("Audifonos Logitech G335");
                clbcvjaProductosDisp.Items.Add("Audifonos Razer Blackshark V2 X");
                clbcvjaProductosDisp.Items.Add("Audifonos Logitech G733 Lightspeed");
                clbcvjaProductosDisp.Items.Add("Audifonos HyperX Cloud Stinger Core");
                clbcvjaProductosDisp.Items.Add("Audifonos ASTRO gaming A10");
                clbcvjaProductosDisp.Items.Add("Audifonos Corsair HS35");

            }
            else if (seleccion == "Laptops")
            {
                clbcvjaProductosDisp.Items.Add("Laptop HP victus Gaming");
                clbcvjaProductosDisp.Items.Add("Laptop Asus TUF GAMING F15");
                clbcvjaProductosDisp.Items.Add("Laptop MSI Pulse GL66");
                clbcvjaProductosDisp.Items.Add("Laptop Acer Nitro 5");

            }
            else if (seleccion == "Mouses")
            {
                clbcvjaProductosDisp.Items.Add("Mouse Logitech G203 lightsync");
                clbcvjaProductosDisp.Items.Add("Mouse HyperX Pulsefire Core");
                clbcvjaProductosDisp.Items.Add("Mouse Razer Basilisk X HyperSpeed Wireless");
                clbcvjaProductosDisp.Items.Add("Mouse Logitech G502 Hero");
                clbcvjaProductosDisp.Items.Add("Mouse Corsair M65 Pro");
                clbcvjaProductosDisp.Items.Add("Mouse Logitech G305 Lightspeed Wireless");
                clbcvjaProductosDisp.Items.Add("Mouse Balam Rush Hiperion Wireless");

            }
            else if (seleccion == "PC's Escritorio")
            {
                clbcvjaProductosDisp.Items.Add("Computadora Asus ROG Strix G15");
                clbcvjaProductosDisp.Items.Add("Computadora Lenovo Legion T5");
                clbcvjaProductosDisp.Items.Add("Computadora Acer Predator Orion 3000");

            }
            else if (seleccion == "Teclados")
            {
                clbcvjaProductosDisp.Items.Add("Teclado G213 prodigy");
                clbcvjaProductosDisp.Items.Add("Teclado HyperX Alloy Core");
                clbcvjaProductosDisp.Items.Add("Teclado Redragon K630 Dragonborn");
                clbcvjaProductosDisp.Items.Add("Teclado SteelSeries Apex 7");
            }


        }

        private void clbcvjaProductosDisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // string seleccion = combcvjaProductos.SelectedItem.ToString();
            string seleccion = "null";
            if (seleccion == "Audifonos")
            {
                switch (clbcvjaProductosDisp.SelectedIndex)
                {
                    case 0:
                        if (clbcvjaProductosDisp.GetItemCheckState(0) == CheckState.Checked)
                        {
                            // pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\audiLogiG335.jpg");
                            // pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                    case 1:
                        if (clbcvjaProductosDisp.GetItemCheckState(1) == CheckState.Checked)
                        {
                            //  pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\AudiRazer.jpg");
                            //  pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                    case 2:
                        if (clbcvjaProductosDisp.GetItemCheckState(2) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\AudiLogiG733.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;
                    case 3:
                        if (clbcvjaProductosDisp.GetItemCheckState(3) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\AudiHyperX.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;
                    case 4:
                        if (clbcvjaProductosDisp.GetItemCheckState(4) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\AudiA10.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;
                    case 5:
                        if (clbcvjaProductosDisp.GetItemCheckState(5) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\AudiCorsair.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                }
            }
            else if (seleccion == "Laptops")
            {
                switch (clbcvjaProductosDisp.SelectedIndex)
                {
                    case 0:
                        if (clbcvjaProductosDisp.GetItemCheckState(0) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\LapHP.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                    case 1:
                        if (clbcvjaProductosDisp.GetItemCheckState(1) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\LapAsus.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                    case 2:
                        if (clbcvjaProductosDisp.GetItemCheckState(2) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\LapMSI.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;
                    case 3:
                        if (clbcvjaProductosDisp.GetItemCheckState(3) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\LapAcer.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                }
            }
            else if (seleccion == "Mouses")
            {
                switch (clbcvjaProductosDisp.SelectedIndex)
                {
                    case 0:
                        if (clbcvjaProductosDisp.GetItemCheckState(0) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\MouseLogiG203.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                    case 1:
                        if (clbcvjaProductosDisp.GetItemCheckState(1) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\MouseHyperX.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                    case 2:
                        if (clbcvjaProductosDisp.GetItemCheckState(2) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\MouseRazer.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;
                    case 3:
                        if (clbcvjaProductosDisp.GetItemCheckState(3) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\MouseLogiG502.jpeg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;
                    case 4:
                        if (clbcvjaProductosDisp.GetItemCheckState(4) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\MouseCorsair.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;
                    case 5:
                        if (clbcvjaProductosDisp.GetItemCheckState(5) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\MouseLogiG305.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;
                    case 6:
                        if (clbcvjaProductosDisp.GetItemCheckState(6) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\MouseBalam.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                }
            }
            else if (seleccion == "PC's Escritorio")
            {
                switch (clbcvjaProductosDisp.SelectedIndex)
                {
                    case 0:
                        if (clbcvjaProductosDisp.GetItemCheckState(0) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\CompuAsus.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                    case 1:
                        if (clbcvjaProductosDisp.GetItemCheckState(1) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\CompuLenovo.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                    case 2:
                        if (clbcvjaProductosDisp.GetItemCheckState(2) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\CompuAcer.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;


                }
            }
            else if (seleccion == "Teclados")
            {
                switch (clbcvjaProductosDisp.SelectedIndex)
                {
                    case 0:
                        if (clbcvjaProductosDisp.GetItemCheckState(0) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\TecladoLogi.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                    case 1:
                        if (clbcvjaProductosDisp.GetItemCheckState(1) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\TecladoHyperX.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                    case 2:
                        if (clbcvjaProductosDisp.GetItemCheckState(2) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\TecladoRed.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;
                    case 3:
                        if (clbcvjaProductosDisp.GetItemCheckState(3) == CheckState.Checked)
                        {
                            pbcvja.Image = Image.FromFile(@"F:\Topicos\ProyectoU1P2\Productos\TecladoSteel.jpg");
                            pbcvja.Visible = true;

                        }
                        else
                        {
                            pbcvja.Visible = false;
                        }
                        break;

                }
            }
        }

        private void clbcvjaProductosDisp_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string seleccion = clbcvjaProductosDisp.Text;
            lblcvjaPrecio.Text = "" + productos[seleccion];

        }

        private void btncvjaAgregar_Click(object sender, EventArgs e)
        {
            int ind = combcvjaProductos.SelectedIndex;
            if (ind != -1)
            {
                foreach (object item in clbcvjaProductosDisp.CheckedItems)
                {
                    Program.objetos.Add(item.ToString());
                    Program.MontoParcial.Add(productos[item.ToString()]);
                }
                MessageBox.Show("Se agrego al carro correctamente");
                lblcvjaPrecio.Text = "" + 0;
            }

        }

        private void verCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.f3 == null)
            {
                Program.f3 = new Carrocvja(Program.objetos, Program.MontoParcial);
            }
            Program.f3.Show();

        }

        private void vaciarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.objetos.Clear();
            Program.MontoParcial.Clear();
            if (Program.f3 == null)
            {
                Program.f3 = new Carrocvja(Program.objetos, Program.MontoParcial);
            }
            Program.f3.Hide();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.f4 == null)
            {
                Program.f4 = new Acercade();
            }
            Program.f4.Show();
        }
    }
}
