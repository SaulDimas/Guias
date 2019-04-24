using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsGia1
{
    public partial class Usodll : Form
    {
        private int tiempo;
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MONITORPOWER = 0xF170;
        private object timer1;

        [DllImport("user32.dll")]
        private extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("winmm")]
        private extern static void SendMessage(IntPtr lpstrCommand, string lpstrReturnString, int uReturnLength, long hwndCallback);
        public Usodll()
        {
            InitializeComponent();
        }

        private void Usodll_Load(object sender, EventArgs e)
        {
        }
            private void ApagarMonotor()
        {
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
        }
        private void EncenderMonotor()
        {
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, -1);
        }
        private void button1_Click (object sender, EventArgs e)
        {
            ApagarMonotor();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tiempo = 5;
            ApagarMonotor();
            //timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempo != 0)
            {
                tiempo--;
            }
            else
            {
                //timer1.Stop();
                EncenderMonotor();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            mciSendString("Set CDAudio door open", "", 127, 0);
        }

        private void mciSendString(string v1, string v2, int v3, int v4)
        {
            throw new NotImplementedException();
        }
    }

    }
    
 

