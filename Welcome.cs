using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHg.Text = "Hoşgeldin, " + Environment.UserName+ " (:";
            lblHg.Location = new Point((this.Width/2)-lblHg.Width/2,60  );
            
            
        }

        public static string whois = "";
        private void btnOyna_Click(object sender, EventArgs e)
        {
            whois = "user";
            this.Hide();
            Game playAA = new Game();
            playAA.ShowDialog();
        }

        private void btnOynaPC_Click(object sender, EventArgs e)
        {
            whois = "pc";
            this.Hide();
            Game playAA = new Game();
            playAA.ShowDialog();
        }

        

        
    }
}
