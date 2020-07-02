using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ChinelaLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Tirar Borda e permite mover o launcher
        protected override void OnLoad(EventArgs e)
        {
            if (this.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
            {
                this.MouseDown += new MouseEventHandler(AppFormBase_MouseDown);
                this.MouseMove += new MouseEventHandler(AppFormBase_MouseMove);
                this.MouseUp += new MouseEventHandler(AppFormBase_MouseUp);
            }

            base.OnLoad(e);
        }

        void AppFormBase_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = new Point(e.X, e.Y);
        }
        void AppFormBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
            {
                return;
            }
            Point location = new Point(
                this.Left + e.X - downPoint.X,
                this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }
        void AppFormBase_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = Point.Empty;
        }

        public Point downPoint = Point.Empty;

        //Botão Fechar Launcher
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Icone Discord
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://discord.gg/JA3mqz8");
        }

        //Icone Facebook
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://www.facebook.com/chinelarp/");
        }

        //Icone Site
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"http://www.chinelarp.com.br/");

        }

        //Icone Instagram
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"https://www.instagram.com/chinelarp/");
        
        }

        //Botão Entrar na Cidade
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"fivem://connect/149.56.245.178");
            this.Close();
        }
    }
}
