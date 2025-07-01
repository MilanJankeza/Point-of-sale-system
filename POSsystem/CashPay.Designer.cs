namespace POSsystem
{
    partial class CashPay
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.OrderIDLB = new System.Windows.Forms.Label();
            this.TimeLB = new System.Windows.Forms.Label();
            this.DateLB = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.DataTableList = new System.Windows.Forms.DataGridView();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.DiscountRB = new System.Windows.Forms.RadioButton();
            this.PayBT = new Guna.UI2.WinForms.Guna2Button();
            this.GivenTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ReturnLB = new System.Windows.Forms.Label();
            this.SumLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableList)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.OrderIDLB);
            this.guna2Panel1.Controls.Add(this.TimeLB);
            this.guna2Panel1.Controls.Add(this.DateLB);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(279, 32);
            this.guna2Panel1.TabIndex = 0;
            // 
            // OrderIDLB
            // 
            this.OrderIDLB.AutoSize = true;
            this.OrderIDLB.Location = new System.Drawing.Point(234, 9);
            this.OrderIDLB.Name = "OrderIDLB";
            this.OrderIDLB.Size = new System.Drawing.Size(0, 16);
            this.OrderIDLB.TabIndex = 2;
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Location = new System.Drawing.Point(120, 9);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(41, 16);
            this.TimeLB.TabIndex = 1;
            this.TimeLB.Text = "Time:";
            // 
            // DateLB
            // 
            this.DateLB.AutoSize = true;
            this.DateLB.Location = new System.Drawing.Point(12, 9);
            this.DateLB.Name = "DateLB";
            this.DateLB.Size = new System.Drawing.Size(39, 16);
            this.DateLB.TabIndex = 0;
            this.DateLB.Text = "Date:";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.DataTableList);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 32);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(279, 475);
            this.guna2Panel2.TabIndex = 1;
            // 
            // DataTableList
            // 
            this.DataTableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTableList.Location = new System.Drawing.Point(0, 0);
            this.DataTableList.Name = "DataTableList";
            this.DataTableList.RowHeadersWidth = 51;
            this.DataTableList.RowTemplate.Height = 24;
            this.DataTableList.Size = new System.Drawing.Size(279, 475);
            this.DataTableList.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.DiscountRB);
            this.guna2Panel3.Controls.Add(this.PayBT);
            this.guna2Panel3.Controls.Add(this.GivenTB);
            this.guna2Panel3.Controls.Add(this.ReturnLB);
            this.guna2Panel3.Controls.Add(this.SumLB);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 273);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(279, 234);
            this.guna2Panel3.TabIndex = 2;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // DiscountRB
            // 
            this.DiscountRB.AutoSize = true;
            this.DiscountRB.Enabled = false;
            this.DiscountRB.Location = new System.Drawing.Point(81, 20);
            this.DiscountRB.Name = "DiscountRB";
            this.DiscountRB.Size = new System.Drawing.Size(80, 20);
            this.DiscountRB.TabIndex = 7;
            this.DiscountRB.Text = "Discount";
            this.DiscountRB.UseVisualStyleBackColor = true;
            // 
            // PayBT
            // 
            this.PayBT.AutoRoundedCorners = true;
            this.PayBT.BorderRadius = 21;
            this.PayBT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PayBT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PayBT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PayBT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PayBT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PayBT.ForeColor = System.Drawing.Color.White;
            this.PayBT.Location = new System.Drawing.Point(38, 178);
            this.PayBT.Name = "PayBT";
            this.PayBT.Size = new System.Drawing.Size(180, 45);
            this.PayBT.TabIndex = 6;
            this.PayBT.Text = "Pay";
            this.PayBT.Click += new System.EventHandler(this.PayBT_Click);
            // 
            // GivenTB
            // 
            this.GivenTB.AutoRoundedCorners = true;
            this.GivenTB.BorderRadius = 18;
            this.GivenTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GivenTB.DefaultText = "";
            this.GivenTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GivenTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GivenTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GivenTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GivenTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GivenTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GivenTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GivenTB.Location = new System.Drawing.Point(89, 91);
            this.GivenTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GivenTB.Name = "GivenTB";
            this.GivenTB.PasswordChar = '\0';
            this.GivenTB.PlaceholderText = "";
            this.GivenTB.SelectedText = "";
            this.GivenTB.Size = new System.Drawing.Size(79, 38);
            this.GivenTB.TabIndex = 5;
            this.GivenTB.TextChanged += new System.EventHandler(this.GivenTB_TextChanged);
            // 
            // ReturnLB
            // 
            this.ReturnLB.AutoSize = true;
            this.ReturnLB.Location = new System.Drawing.Point(107, 141);
            this.ReturnLB.Name = "ReturnLB";
            this.ReturnLB.Size = new System.Drawing.Size(14, 16);
            this.ReturnLB.TabIndex = 4;
            this.ReturnLB.Text = "0";
            // 
            // SumLB
            // 
            this.SumLB.AutoSize = true;
            this.SumLB.Location = new System.Drawing.Point(107, 62);
            this.SumLB.Name = "SumLB";
            this.SumLB.Size = new System.Drawing.Size(14, 16);
            this.SumLB.TabIndex = 3;
            this.SumLB.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vratiti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dato:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukupno:";
            // 
            // CashPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 507);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashPay";
            this.Text = "CashPay";
            this.Load += new System.EventHandler(this.CashPay_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableList)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.DataGridView DataTableList;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Label DateLB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button PayBT;
        private Guna.UI2.WinForms.Guna2TextBox GivenTB;
        private System.Windows.Forms.Label ReturnLB;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton DiscountRB;
        public System.Windows.Forms.Label OrderIDLB;
        public System.Windows.Forms.Label SumLB;
    }
}