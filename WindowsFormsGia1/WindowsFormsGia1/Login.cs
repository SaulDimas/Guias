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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, password;
            usuario = txtLogin.Text.TrimEnd();
            password = txtPassword.Text.TrimEnd();
            if ((usuario == "UTEC")&&(password == "programacion1"))
            {
                MessageBox.Show("Bienvenidos al Sistema");

            }
            else
            {
                MessageBox.Show("Verifique usuario y Password");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
