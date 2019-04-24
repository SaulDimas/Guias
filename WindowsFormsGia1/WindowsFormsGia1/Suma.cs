using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGia1
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, N, suma = 0;
            listBox1.Items.Clear();
            N = int.Parse(txtN.Text);
            for (x = 1; x <= N; x++)
            {
                suma = suma + x;
                if (checkBox1.Checked == true)
                {
                    listBox1.Items.Add(" Sumando: "  + x + " Suma Parcial: " + suma);
                }
            }
            listBox1.Items.Add("La Suma TOTAL  es: "  + suma);
        }
    }
    }