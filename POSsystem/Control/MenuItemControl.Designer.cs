namespace POSsystem.Control
{
    partial class MenuItemControl
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
            this.CategoryLB = new System.Windows.Forms.Label();
            this.PriceLB = new System.Windows.Forms.Label();
            this.NameLB = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryLB
            // 
            this.CategoryLB.BackColor = System.Drawing.Color.Transparent;
            this.CategoryLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoryLB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.CategoryLB.Location = new System.Drawing.Point(0, 0);
            this.CategoryLB.Name = "CategoryLB";
            this.CategoryLB.Size = new System.Drawing.Size(168, 22);
            this.CategoryLB.TabIndex = 0;
            this.CategoryLB.Text = "Category";
            // 
            // PriceLB
            // 
            this.PriceLB.BackColor = System.Drawing.Color.Transparent;
            this.PriceLB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PriceLB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.PriceLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.PriceLB.Location = new System.Drawing.Point(0, 145);
            this.PriceLB.Name = "PriceLB";
            this.PriceLB.Size = new System.Drawing.Size(168, 22);
            this.PriceLB.TabIndex = 1;
            this.PriceLB.Text = "0";
            this.PriceLB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NameLB
            // 
            this.NameLB.BackColor = System.Drawing.Color.Transparent;
            this.NameLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.NameLB.ForeColor = System.Drawing.Color.White;
            this.NameLB.Location = new System.Drawing.Point(0, 22);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(168, 123);
            this.NameLB.TabIndex = 2;
            this.NameLB.Text = "Name";
            this.NameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameLB.Click += new System.EventHandler(this.NameLB_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 14;
            this.guna2CustomGradientPanel1.Controls.Add(this.NameLB);
            this.guna2CustomGradientPanel1.Controls.Add(this.PriceLB);
            this.guna2CustomGradientPanel1.Controls.Add(this.CategoryLB);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(168, 167);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // MenuItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MenuItemControl";
            this.Size = new System.Drawing.Size(168, 167);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label CategoryLB;
        private System.Windows.Forms.Label PriceLB;
        public System.Windows.Forms.Label NameLB;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}
