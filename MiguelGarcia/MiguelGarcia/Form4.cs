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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num = 0, num2 = 0;


            for (int i = 1; i <= 100; i++)
            {
                num = i % 3;
                num2 = i % 5;

                if (num == 0 && num2 == 0)
                {
                    listBox1.Items.Add("Miguel Garcia");

                }
                else if (num == 0)
                {
                    listBox1.Items.Add("Miguel");

                }
                else if (num2 == 0)
                {
                    listBox1.Items.Add("Garcia");
                }
                else
                {
                    listBox1.Items.Add(i);
                }











            }










        }







    }
}
