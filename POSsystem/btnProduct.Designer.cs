namespace Projekat.Kontrola
{
    partial class btnProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.lblNaziv);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblCena);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblKategorija);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(4, 4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(160, 154);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // lblNaziv
            // 
            this.lblNaziv.BackColor = System.Drawing.Color.Transparent;
            this.lblNaziv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNaziv.Location = new System.Drawing.Point(0, 15);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(160, 113);
            this.lblNaziv.TabIndex = 16;
            this.lblNaziv.Text = "Naziv Robe";
            this.lblNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNaziv.Click += new System.EventHandler(this.lblNaziv_Click);
            // 
            // lblCena
            // 
            this.lblCena.BackColor = System.Drawing.Color.Transparent;
            this.lblCena.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.lblCena.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCena.Location = new System.Drawing.Point(0, 128);
            this.lblCena.Name = "lblCena";
            this.lblCena.Padding = new System.Windows.Forms.Padding(0, 0, 5, 3);
            this.lblCena.Size = new System.Drawing.Size(160, 26);
            this.lblCena.TabIndex = 15;
            this.lblCena.Text = "10";
            this.lblCena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKategorija
            // 
            this.lblKategorija.BackColor = System.Drawing.Color.Transparent;
            this.lblKategorija.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKategorija.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKategorija.Location = new System.Drawing.Point(0, 0);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblKategorija.Size = new System.Drawing.Size(160, 15);
            this.lblKategorija.TabIndex = 14;
            this.lblKategorija.Text = "Kategorija";
            // 
            // btnProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "btnProduct";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(168, 162);
            this.Load += new System.EventHandler(this.btnProduct_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        public Label lblNaziv;
        public Label lblCena;
        public Label lblKategorija;
    }
}
