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
    public partial class GameOver : Form
    {
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }

        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }


        public GameOver()
        {
            InitializeComponent();
        }


        public static string startTime = "";
        public static string finishTime = "";

        void kazandin()
        {
            this.Height = 285;
            btnYeni.Location = new Point(2, 249);
            panel1.BackColor = Color.SeaGreen;

            Image img = Image.FromFile("images/bravo.png");
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            lblBaslik.Text = "TEBRİKLER BİLDİNİZ!!!";
            lblBaslik.ForeColor = Color.Green;
            lblBiseyler.Text = "engin kelime bilginle bizi mest ettin!";
            lblBaslik.Location = new Point((this.Width / 2) - lblBaslik.Width / 2, 200);
            lblBiseyler.Location = new Point((this.Width / 2) - lblBiseyler.Width / 2, 225);

            lblSaat.Visible = false;
            lblRIP.Visible = false;
            lblFedakar.Visible = false;
        }

        void kaybettin()
        {
            this.Height = 350;
            panel1.BackColor = Color.Brown;

            Image img = Image.FromFile("images/wasted.png");
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            lblBaslik.Text = "maalesef bilemediniz...";
            lblBaslik.ForeColor = Color.Red;
            lblBiseyler.Text = "olmadı, artık bir dahaki sefere";
            lblBaslik.Location = new Point((this.Width / 2) - lblBaslik.Width / 2, 180);
            lblBiseyler.Location = new Point((this.Width / 2) - lblBiseyler.Width / 2, 225);

            lblSaat.Text = "(" + startTime + " - " + finishTime + ")";
            lblRIP.Location = new Point((this.Width / 2) - lblRIP.Width / 2, 250);
            lblFedakar.Location = new Point((this.Width / 2) - lblFedakar.Width / 2, 265);
            lblSaat.Location = new Point((this.Width / 2) - lblSaat.Width / 2, 280);
        }

        void pcFinish()
        {
            this.Height = 310;
            btnYeni.Location = new Point(2, 274);
            panel1.BackColor = Color.FromArgb(64, 64, 64);

            Image img = Image.FromFile("images/ai.png");
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            lblBaslik.Text = "OYUN BİTTİ";
            lblBaslik.ForeColor = Color.WhiteSmoke;
            lblBiseyler.Text = "bilgisayar, "+Game.kelimeSayisi + " adet benzer kelimeden \nbu kelimeyi " + Game.yanlisSayisi + " yanlışla bildi.";
            lblBaslik.Location = new Point((this.Width / 2) - lblBaslik.Width / 2, 200);
            lblBiseyler.Location = new Point((this.Width / 2) - lblBiseyler.Width / 2, 225);

            lblSaat.Visible = false;
            lblRIP.Visible = false;
            lblFedakar.Visible = false;
        }

        private void OyunSonu_Load(object sender, EventArgs e)
        {
            if (Game.galibiyet && Welcome.whois == "user")
                kazandin();
            else if (Game.galibiyet && Welcome.whois == "pc")
                pcFinish();
            else
                kaybettin();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
