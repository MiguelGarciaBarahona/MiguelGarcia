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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double capital = 200000;
            double interes = 0.015;
            double mes = 0;
            double generado = 0;
            double total = generado;

            for (mes = 1; mes <= 12; mes++)
            {

                generado = capital * interes * mes;

                total = generado;

                if (mes == 1)
                {
                    meseslistBox.Items.Add("Enero" + "      " + " L     " + total);
                }
                else if (mes == 2)
                {
                    meseslistBox.Items.Add("Febrero" + "   " + " L    " + generado);
                }
                else if (mes == 3)
                {
                    meseslistBox.Items.Add("Marzo" + "      " + "L     " + generado);
                }
                else if (mes == 4)
                {
                    meseslistBox.Items.Add("Abril" + "      " + "   L     " + generado);
                }
                else if (mes == 5)
                {
                    meseslistBox.Items.Add("Mayo" + "      " + "  L     " + generado);
                }
                else if (mes == 6)
                {
                    meseslistBox.Items.Add("Junio" + "      " + "  L     " + generado);
                }
                else if (mes == 7)
                {
                    meseslistBox.Items.Add("Julio" + "      " + "   L     " + generado);
                }
                else if (mes == 8)
                {
                    meseslistBox.Items.Add("Agosto" + "      " + "  L     " + generado);
                }
                else if (mes == 9)
                {
                    meseslistBox.Items.Add("Septiembre" + "   " + "L     " + generado);
                }
                else if (mes == 10)
                {
                    meseslistBox.Items.Add("Octubre" + "      " + " L     " + generado);
                }
                else if (mes == 11)
                {
                    meseslistBox.Items.Add("Noviembre" + "     " + "L     " + generado);
                }
                else if (mes == 12)
                {
                    meseslistBox.Items.Add("Diciembre" + "      " + "L     " + generado);
                }

















            }

















        }











    }
}
