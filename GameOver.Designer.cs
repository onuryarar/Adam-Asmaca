namespace AdamAsmaca
{
    partial class GameOver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblRIP = new System.Windows.Forms.Label();
            this.lblBiseyler = new System.Windows.Forms.Label();
            this.lblFedakar = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(3, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeni.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnYeni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btnYeni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnYeni.Location = new System.Drawing.Point(2, 315);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(298, 35);
            this.btnYeni.TabIndex = 1;
            this.btnYeni.Text = "Yeniden Oyna";
            this.btnYeni.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Controls.Add(this.lblSaat);
            this.panel1.Controls.Add(this.lblRIP);
            this.panel1.Controls.Add(this.lblBiseyler);
            this.panel1.Controls.Add(this.lblFedakar);
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 320);
            this.panel1.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(296, 37);
            this.panelHeader.TabIndex = 5;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(261, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(102, 23);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Oyun Bitti!";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblSaat.ForeColor = System.Drawing.Color.Wheat;
            this.lblSaat.Location = new System.Drawing.Point(66, 284);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(168, 20);
            this.lblSaat.TabIndex = 9;
            this.lblSaat.Text = "(07.12.2017-07.12.2017)";
            // 
            // lblRIP
            // 
            this.lblRIP.AutoSize = true;
            this.lblRIP.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblRIP.ForeColor = System.Drawing.Color.Wheat;
            this.lblRIP.Location = new System.Drawing.Point(128, 246);
            this.lblRIP.Name = "lblRIP";
            this.lblRIP.Size = new System.Drawing.Size(44, 20);
            this.lblRIP.TabIndex = 10;
            this.lblRIP.Text = "R.I.P.";
            // 
            // lblBiseyler
            // 
            this.lblBiseyler.AutoSize = true;
            this.lblBiseyler.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblBiseyler.ForeColor = System.Drawing.Color.Khaki;
            this.lblBiseyler.Location = new System.Drawing.Point(-6, 219);
            this.lblBiseyler.Name = "lblBiseyler";
            this.lblBiseyler.Size = new System.Drawing.Size(338, 21);
            this.lblBiseyler.TabIndex = 3;
            this.lblBiseyler.Text = "[bişeylererbişeylerbişeylerbişeylerbişeyler]";
            this.lblBiseyler.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFedakar
            // 
            this.lblFedakar.AutoSize = true;
            this.lblFedakar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblFedakar.ForeColor = System.Drawing.Color.Wheat;
            this.lblFedakar.Location = new System.Drawing.Point(70, 265);
            this.lblFedakar.Name = "lblFedakar";
            this.lblFedakar.Size = new System.Drawing.Size(161, 20);
            this.lblFedakar.TabIndex = 11;
            this.lblFedakar.Text = "FEDAKAR ÇÖPADAM";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(113, 203);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(125, 36);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "[BAŞLIK]";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sonuc";
            this.Load += new System.EventHandler(this.OyunSonu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBiseyler;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblRIP;
        private System.Windows.Forms.Label lblFedakar;
        private System.Windows.Forms.Button btnClose;
    }
}