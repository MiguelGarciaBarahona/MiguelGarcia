using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiguelGarcia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {

            string producto;
            int cantidad, cantidad2;
            double precio, precio2, subtotal2, subtotal, fac, impuesto, total;

            producto = (this.productotextBox.Text);

            cantidad = int.Parse(this.cantidadtextBox.Text);
            precio = double.Parse(this.PreciotextBox.Text);
            cantidad2 = int.Parse(this.cantidad2textBox.Text);
            precio2 = double.Parse(this.precio2textBox.Text);

            subtotal = cantidad * precio;
            subtotal2 = cantidad2 * precio2;
            fac = subtotal + subtotal2;

            impuesto = fac * 0.15;
            total = fac - impuesto;


            this.SubtotaltextBox.Text = fac.ToString();
            this.ImpuestotextBox.Text = impuesto.ToString();
            this.totaltextBox.Text = total.ToString();





        }
    }
}
