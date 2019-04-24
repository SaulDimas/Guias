using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGia2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MessageBoxButtons tipoDeBoton = MessageBoxButtons.OK;
        private void tipoDeBoton_CheckedChange(object sender, EventArgs e)
        {
            if (sender == radioButton1)
                tipoDeBoton = MessageBoxButtons.OK;
            else if (sender == radioButton2)
                tipoDeBoton = MessageBoxButtons.OKCancel;
            else if (sender == radioButton3)
                tipoDeBoton = MessageBoxButtons.YesNo;
            else if (sender == radioButton4)
                tipoDeBoton = MessageBoxButtons.YesNoCancel;
            else if (sender == radioButton5)
                tipoDeBoton = MessageBoxButtons.RetryCancel;
            else
                tipoDeBoton = MessageBoxButtons.AbortRetryIgnore;
        }
        private MessageBoxIcon tipoDeIcono = MessageBoxIcon.Error;
        private void tipoDeIcono_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton7) //display error icon
                tipoDeIcono = MessageBoxIcon.Information;
            else if (sender == radioButton8)
                tipoDeIcono = MessageBoxIcon.Exclamation;
            else if (sender == radioButton9)
                tipoDeIcono = MessageBoxIcon.Question;
            else //only one 
                tipoDeIcono = MessageBoxIcon.Error;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mensaje a desplegar",
                "Titulo de la ventana", tipoDeBoton, tipoDeIcono);
            switch (result)
            {
                case DialogResult.OK: label2.Text = "Selecciono ok.";
                    break;
                case DialogResult.Cancel: label2.Text = "Selecciono Canselar.";
                    break;
                case DialogResult.Yes: label2.Text = "Selecciono Yes.";
                    break;
                case DialogResult.No: label2.Text = "Selecciono NO.";
                    break;
                case DialogResult.Ignore: label2.Text = "Selecciono Ignore.";
                    break;
                case DialogResult.Abort: label2.Text = "Selecciono Abort.";
                    break;
                case DialogResult.Retry: label2.Text = "Selecciono Retry.";
                    break;
            }
        }
    }
}
