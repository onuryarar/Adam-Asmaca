using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace AdamAsmaca
{
    public partial class Game : Form
    {
        class PCMODE
        {
            public static Hashtable kelimeList(string kType, int kSize)
            {
                Hashtable kList = new Hashtable();
                StreamReader oku = new StreamReader("kelimeler.txt", Encoding.Default);

                while (!oku.EndOfStream)
                {
                    string satir = oku.ReadLine();
                    string[] satirSplit = satir.Split(',');

                    if (satirSplit[2] == kType && satirSplit[1].Length == kSize)
                        kList.Add(satirSplit[0], satirSplit[1]);
                }
                Game.kelimeSayisi = kList.Count;
                return kList;
            }

            public static Hashtable harfList(Hashtable kList)
            {
                //MessageBox.Show("harflist > Harfno: " + harfNo);
                Hashtable hList = new Hashtable();      //key: baş harf, value: baş harf adeti
                int i = 1;
                string harf = "";

                foreach (DictionaryEntry kelimeler in kList)    //kelimeleri gezim harflist'in içinde olmayanları ekliyor, olanların adetini güncelliyor 
                {
                    //MessageBox.Show("harflist > klist döngüsü [in]");
                    harf = kelimeler.Value.ToString().Substring(harfNo, 1);
                    if (!hList.ContainsKey(harf))
                    {
                        i = 1;
                        hList.Add(harf, i);
                    }
                    else if (hList.ContainsKey(harf))
                    {
                        i = (int)hList[harf];       //harfin o anki adeti değişkenin içine
                        i++;
                        hList[harf] = i;
                    }
                }
                return hList;
            }

            public static string encokHarf(Hashtable hList)
            {
                int buyukSayi = 0;
                string Harf = "";
                foreach (DictionaryEntry harfler in hList)
                {
                    if ((int)harfler.Value > buyukSayi)
                    {
                        buyukSayi = (int)harfler.Value;
                        Harf = harfler.Key.ToString();
                    }
                }
                return Harf;       //adeti fazla olan kelimeyi döndürür
            }

            public static void buttonControl(string encokHarf, Control.ControlCollection buttonControls)        //gönderilen harfin klavye üstünde tıklanması işlemi
            {
                foreach (Control ctrl in buttonControls)      //buton tıklaması
                {
                    if (ctrl is Button)
                    {
                        Button b = (Button)ctrl;
                        if (b.Text == encokHarf)
                        {
                            b.Enabled = false;
                            b.ForeColor = Color.FromArgb(50, 50, 50);
                            b.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
                        }
                    }
                }
            }


            public static int kalanHak = 0;
            static bool adamiAs = true;
            public static int labelControl(string encokHarf, Control.ControlCollection labelControls)
            {
                int sayac = 0;
                adamiAs = true;
                foreach (Control ctrl in labelControls)
                {
                    if (ctrl is Label)
                    {
                        Label l = (Label)ctrl;
                        if (l.Tag.ToString() == encokHarf)
                        {
                            if (sayac == harfNo)
                            {
                                l.Text = encokHarf;
                                adamiAs = false;
                            }

                        }
                        sayac++;
                    }
                }
                if (adamiAs)
                {
                    kalanHak++;
                }

                return kalanHak;
            }

            public static int harfNo = 0;
            public static int harfSira(Hashtable kList, Hashtable hList, string encokHarf)
            {
                //MessageBox.Show("harfsira > harfno: "+harfNo);
                //MessageBox.Show("seçilen harf: "+encokHarf);
                Hashtable clonekList = new Hashtable(kList);
                Hashtable clonehList = new Hashtable(hList);
                kList.Clear();
                hList.Clear();
                //MessageBox.Show((kList.Count+"..."+hList.Count));
                if (adamiAs)        //harfin yanlış bilinmesi
                {
                    //MessageBox.Show("Yanlış bildi.");
                    foreach (DictionaryEntry kelimeler in clonekList)
                    {
                        if (kelimeler.Value.ToString().Substring(harfNo, 1) != encokHarf)
                            kList.Add(kelimeler.Key, kelimeler.Value);
                    }
                    foreach (DictionaryEntry harfler in clonehList)
                    {
                        if (harfler.Key.ToString() != encokHarf)
                            hList.Add(harfler.Key, harfler.Value);
                    }
                }
                else              //harfin doğru bilinmesi
                {
                    //MessageBox.Show("Doru bildi.");
                    foreach (DictionaryEntry kelimeler in clonekList)
                    {
                        if (kelimeler.Value.ToString().Substring(harfNo, 1) == encokHarf)
                        {
                            kList.Add(kelimeler.Key, kelimeler.Value);
                        }
                    }
                    hList.Clear();
                    harfNo++;
                }
                //MessageBox.Show((kList.Count + "......" + hList.Count));
                return harfNo;
            }


        }


//HEADER
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



//METHODS & PROPERTIES

        int kelimeSize = 0;
        string kelime = "";
        string kelimeType = "";
        public static int kalanHak = 0;
        public static bool galibiyet = false;
        public static string startTime = "";
        public static string finishTime = "";
        public static int yanlisSayisi = 0;
        public static int kelimeSayisi = 0;

        void darAgaciGelsin(int yanlisSayisi)
        {
            Bitmap bmp = new Bitmap(220, 220);
            Graphics g = Graphics.FromImage(bmp);

            Pen p6 = new Pen(Brushes.White, 6);
            g.DrawLine(p6, 0, bmp.Height - 10, 70, bmp.Height - 10);         //ayağı
            g.DrawLine(p6, 35, 0, 35, bmp.Height - 10);                  //direği
            g.DrawLine(p6, 35, 60, 95, 0);                               //desteği
            g.DrawLine(p6, 35, 2, 180, 2);                               //üst direği

            Pen p3 = new Pen(Brushes.White, 3);
            g.DrawLine(p3, 130, 2, 130, 50);                            //ipi

            if (yanlisSayisi > 0)
                g.DrawEllipse(p3, 110, 50, 40, 40);                         //kafası
            if (yanlisSayisi > 1)
                g.DrawLine(p3, 130, 90, 130, 150);                         //bedeni
            if (yanlisSayisi > 2)
                g.DrawLine(p3, 110, 120, 130, 100);                         //sol kol
            if (yanlisSayisi > 3)
                g.DrawLine(p3, 130, 100, 150, 120);                         //sağ kol
            if (yanlisSayisi > 4)
                g.DrawLine(p3, 110, 170, 130, 150);                         //sol bacak
            if (yanlisSayisi > 5)
            {
                g.DrawLine(p3, 130, 150, 150, 170);                         //sağ bacak

                Pen p2 = new Pen(Brushes.White, 2);
                g.DrawLine(p2, 120, 60, 125, 65);                  //sol göz çizgi1
                g.DrawLine(p2, 125, 60, 120, 65);                  //sol göz çizgi2

                g.DrawLine(p2, 135, 60, 140, 65);               //sağ göz çizgi1
                g.DrawLine(p2, 140, 60, 135, 65);               //sağ göz çizgi2

                g.DrawLine(p2, 120, 80, 140, 80);               //ağız
            }
            pictureBox1.Image = bmp;
            
        }

        void klavyeGelsin()
        {
            
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
            int y = 0, x = 0, art = 0, r = 0;
            for (int i = 0; i < harfler.Length; i++)
            {
                Button btnHarf = new Button();
                btnHarf.Text = harfler[i].ToString();
                btnHarf.Size = new Size(30, 30);
                if (i == 10)
                {
                    x = 0;
                    y++;
                    art = 10;
                }
                else if (i == 19)
                {
                    x = 0;
                    y++;
                    art = 0;
                }
                btnHarf.Location = new Point(x * 31 + art+6, y * 31+20);
                btnHarf.FlatStyle = FlatStyle.Flat;
                btnHarf.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, r, 30);
                btnHarf.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, r, 30);
                //btnHarf.BackColor = Color.FromArgb(200, r, 30);
                //btnHarf.FlatAppearance.BorderColor = Color.FromArgb(200, r, 30);
                r += 5;
                btnHarf.ForeColor = Color.White;
                btnHarf.Cursor = Cursors.Hand;

                if (Welcome.whois == "user")
                {
                    btnHarf.Click += btnHarf_Click;
                    gbKlavye.Controls.Add(txtTahmin);
                    gbKlavye.Controls.Add(btnTahmin);
                }
                else if (Welcome.whois == "pc")
                {
                    gbKlavye.Controls.Remove(txtTahmin);
                    btnHarf.Location = new Point(x * 31 + art + 6, y * 31 + 18);
                    btnTahmin.Size = new Size(250, 23);
                    btnTahmin.Location = new Point(35,113);
                    btnTahmin.Text = "...:::   BΛŞLΛT   :::...";
                    gbKlavye.Controls.Add(btnTahmin);
                }

                gbKlavye.Controls.Add(btnHarf);

                x++;
            }
        }

        int rastgeleSatir()
        {
            StreamReader okuBakiyim = new StreamReader("kelimeler.txt", Encoding.Default);
            int satirSayisi = 0;
            while (okuBakiyim.Read() > 0)
            {
                okuBakiyim.ReadLine();
                satirSayisi++;
            }

            Random r = new Random();
            return r.Next(1, satirSayisi);
        }

        void harflerGelsin(string kelime, string kelimeTuru)
        {
            int harfSayisi = kelime.Length;
            gbKelime.Text = harfSayisi + " harften oluşan bir " + kelimeTuru + ": ";

            for (int i = 0; i < harfSayisi; i++)
            {
                Label lblHarf = new Label();
                lblHarf.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                lblHarf.Text = "_";
                lblHarf.Tag = kelime[i];
                lblHarf.Size = new Size(25, 25);
                int ortaNokta = (gbKelime.Width / harfSayisi) + lblHarf.Width;
                lblHarf.Location = new Point(i * lblHarf.Width + ortaNokta - 1, 30);
                gbKelime.Controls.Add(lblHarf);
            }
        }

        void kelimeyiGonder()
        {
            int randomSayi = rastgeleSatir();

            StreamReader okuBakiyim = new StreamReader("kelimeler.txt", Encoding.Default);

            while (!okuBakiyim.EndOfStream)
            {
                string satir = okuBakiyim.ReadLine();
                string[] satirSplit = satir.Split(',');

                if (satirSplit[0].ToString() == randomSayi.ToString())
                {
                    kelimeSize = satirSplit[1].Length;      //kelimenin harf sayısını değişkene at
                    kelime = satirSplit[1];    //kelimeyi değişkene at 
                    kelimeType = satirSplit[2];      //kelimenin türünü değişkene at
                }
            }
        }

        void OyunBitti(bool sonuc,object sender,EventArgs e)
        {
            //oyun bittikten sonra kelimenin tüm harflerini açar
            foreach (Control ctrl in gbKelime.Controls)
            {
                if (ctrl is Label)
                {
                    Label lbl = (Label)ctrl;
                    for (int i = 0; i < kelime.Length; i++)
                    {
                        if (lbl.Tag.ToString() == kelime[i].ToString())
                        {
                            lbl.Text = kelime[i].ToString();
                        }
                    }
                }
            }

            GameOver.finishTime = DateTime.Now.ToLongTimeString();
            GameOver gameover = new GameOver();
            galibiyet = sonuc;
            kalanHak = 0;

            yanlisSayisi = PCMODE.kalanHak;
            PCMODE.kalanHak = 0;
            if (gameover.ShowDialog() == DialogResult.OK)
            {
                Play_Load(sender, e);
                btnTahmin.Enabled = true;
                PCMODE.harfNo = 0;
            }

        }



//FORM COMPANENTS
        public Game()
        {
            InitializeComponent();
        }

//PLAY'S
        private void Play_Load(object sender, EventArgs e)
        {//yükle tüm kontrolleri
            gbKelime.Controls.Clear();
            gbKlavye.Controls.Clear();
            
            kelimeyiGonder();
            klavyeGelsin();
            darAgaciGelsin(0);
            harflerGelsin(kelime, kelimeType);
            txtTahmin.Text = "";

            GameOver.startTime = DateTime.Now.ToLongTimeString();

        }
       
        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTahmin_Click(sender, e);
            }
        }


//BUTTON'S CLICK
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        public void btnHarf_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            b.Enabled = false;            
            b.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            
            bool adamiAs = true;
            foreach (Control item in gbKelime.Controls)
            {
                if (item is Label)
                {
                    Label lbl = (Label)item;
                    if (lbl.Tag.ToString() == b.Text)
                    {
                        lbl.Text = b.Text;
                        adamiAs = false;
                    }
                }
            }
            

            if (adamiAs)
                darAgaciGelsin(++kalanHak);

            if (kalanHak>5)
            {
                OyunBitti(false, sender, e);
                
            }


            bool labelControl = true;
            foreach(Control ctrl in gbKelime.Controls)
            {
                if(ctrl is Label)
                {
                    if(ctrl.Text == "_")
                    {
                        labelControl = false;
                        break;
                    }
                }
            }
                
            if (labelControl)
            {
                OyunBitti(true, sender, e);
            }
            
        }

        private void txtTahmin_TextChanged(object sender, EventArgs e)
        {
            txtTahmin.Text = txtTahmin.Text.ToUpper();
            txtTahmin.SelectionStart = txtTahmin.Text.Length;
        }

        string encokHarf = "";
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            //tahmin doğruluğu veya yanlışlığını kontrol et, yanlışsa mbox ile doğru ise başka form ile gönder
            //adam asıldığında başka formda WASTED yazısını gönder

            if (Welcome.whois == "user")
            {
                if (txtTahmin.Text == kelime)
                {
                    OyunBitti(true, sender, e);
                }
                else
                    MessageBox.Show("Bi kaç harf daha açmayı dene (:", "Yanlış tahmin, maalesef...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Welcome.whois == "pc")
            {

                btnTahmin.Enabled = false;
                Hashtable kList = new Hashtable();                          //sorudaki kelimeye benzer türde kelimeler
                foreach (DictionaryEntry item in PCMODE.kelimeList(kelimeType, kelimeSize))
                {
                    kList.Add(item.Key, item.Value);
                    //MessageBox.Show(item.Key + " " + item.Value);
                }

                Hashtable hList = new Hashtable();                          //harf listesi
                int sayac = 0;

                for (int i = 0; i < kelimeSize * 2; i++)
                {
                    if (sayac == kelimeSize)
                        break;
                    foreach (DictionaryEntry item in PCMODE.harfList(kList))
                    {
                        if (!hList.Contains(item.Key))
                        {
                            hList.Add(item.Key, item.Value);
                            //MessageBox.Show(item.Key + " " + item.Value);
                        }

                    }
                    encokHarf = PCMODE.encokHarf(hList);     //en çok harf

                    System.Threading.Thread.Sleep(500);        //bekle ulen

                    PCMODE.buttonControl(encokHarf, gbKlavye.Controls);     // bu harfi butona click ediyoruz
                    darAgaciGelsin(PCMODE.labelControl(encokHarf, gbKelime.Controls));     //bu harf labelde var mı kontrolü

                    
                    int a = PCMODE.harfSira(kList, hList, encokHarf);

                    if (a == kelimeSize)
                        break;

                }

                //MessageBox.Show(kelime);
                OyunBitti(true, sender, e);
            }
            
        }
        
    }
}
