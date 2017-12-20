namespace AdamAsmaca
{
    partial class Welcome
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnOyna = new System.Windows.Forms.Button();
            this.lblHg = new System.Windows.Forms.Label();
            this.btnOynaPC = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(375, 37);
            this.panelHeader.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(305, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 37);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnClose.Location = new System.Drawing.Point(340, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 37);
            this.btnClose.TabIndex = 5;
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
            this.lblHeader.Size = new System.Drawing.Size(295, 23);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Adam Asmaca Oyunu - CÜYBS";
            // 
            // btnOyna
            // 
            this.btnOyna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOyna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOyna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOyna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOyna.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnOyna.ForeColor = System.Drawing.Color.White;
            this.btnOyna.Location = new System.Drawing.Point(74, 99);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(226, 57);
            this.btnOyna.TabIndex = 2;
            this.btnOyna.Text = "Oyuna Başla";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // lblHg
            // 
            this.lblHg.AutoSize = true;
            this.lblHg.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHg.ForeColor = System.Drawing.Color.White;
            this.lblHg.Location = new System.Drawing.Point(105, 59);
            this.lblHg.Name = "lblHg";
            this.lblHg.Size = new System.Drawing.Size(157, 21);
            this.lblHg.TabIndex = 3;
            this.lblHg.Text = "Hoşgeldin, [isim] (:";
            // 
            // btnOynaPC
            // 
            this.btnOynaPC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOynaPC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnOynaPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnOynaPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOynaPC.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnOynaPC.ForeColor = System.Drawing.Color.White;
            this.btnOynaPC.Location = new System.Drawing.Point(104, 177);
            this.btnOynaPC.Name = "btnOynaPC";
            this.btnOynaPC.Size = new System.Drawing.Size(167, 41);
            this.btnOynaPC.TabIndex = 2;
            this.btnOynaPC.Text = "Bilgisayar Modu";
            this.btnOynaPC.UseVisualStyleBackColor = true;
            this.btnOynaPC.Click += new System.EventHandler(this.btnOynaPC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(375, 241);
            this.Controls.Add(this.lblHg);
            this.Controls.Add(this.btnOynaPC);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adam Asmaca Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHg;
        private System.Windows.Forms.Button btnOynaPC;

    }
}

