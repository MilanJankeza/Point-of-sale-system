using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat.Kontrola
{
    public partial class btnProduct : UserControl
    {
        public int brojac = 1;
        public int pesak = 1;
        static btnProduct _btnpro;
        public static btnProduct Instance
        {
            get
            {
                if (_btnpro == null)
                {
                    _btnpro = new btnProduct();
                }
                return _btnpro;
            }
        }
        public Label Pritisni
        {
            get { return lblNaziv; }
            set { lblNaziv = value; }
        }
        private int itemNum;

        public string ItemID { get; set; }
        public string ItemCategory
        {
            get { return lblKategorija.Text; }
            set { lblKategorija.Text = value; }
        }
        public string ItemIme
        {
            get { return lblNaziv.Text; }
            set { lblNaziv.Text = value; }
        }
        public int ItemNum { get => itemNum; set { itemNum = value; lblCena.Text = itemNum.ToString(""); } }

        public static Action<object, object> OnSelect { get; internal set; }

        public void Control_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        public btnProduct()
        {
            InitializeComponent();
        }
        private void btnProduct_Load(object sender, EventArgs e)
        {

        }
        public void Addstvari(string name, int cost, int broj, string ukupno)
        {
            Form1.instance.Pera.Controls.Add(new CartItem()
            {
                ItemIme = name,
                ItemCena = cost,
                ItemBroj = broj,
                ItemUkupno = ukupno,
            });
        }
        public void MenjajBroj(int broj)
        {
            Form1.instance.Pera.Controls.Add(new CartItem()
            {
                ItemBroj = broj,
            });
        }

        private void lblNaziv_Click(object sender, EventArgs e)
        {
           
            bool postoji = false;
            int postojeciindex= -1;

            for (int i = 0; i < Form1.instance.zoran.Rows.Count; i++)
            {
                if (Form1.instance.zoran.Rows[i].Cells[0].Value != null && (Form1.instance.zoran.Rows[i].Cells[0].Value).ToString() == lblNaziv.Text)
                {
                    postoji = true;
                    postojeciindex = i;
                    break;
                    
                }

            }
            if (!postoji)
            {
                brojac += 0;
                pesak += 0;

                Form1.instance.zoran.Rows.Add(new object[] { lblNaziv.Text, brojac, lblCena.Text, 1 }); // Initialize count to 1
                Form1.instance.lblukupnacena.Text = (Convert.ToInt32(Form1.instance.lblukupnacena.Text) + Convert.ToInt32(lblCena.Text)).ToString();
            }
            else
            {
                Form1.instance.zoran.Rows[postojeciindex].Cells[1].Value = (Convert.ToInt32(Form1.instance.zoran.Rows[postojeciindex].Cells[1].Value) + 1).ToString();
                Form1.instance.zoran.Rows[postojeciindex].Cells[2].Value = (Convert.ToInt32(Form1.instance.zoran.Rows[postojeciindex].Cells[2].Value) + Convert.ToInt32(lblCena.Text)).ToString();
                Form1.instance.lblukupnacena.Text = (Convert.ToInt32(Form1.instance.lblukupnacena.Text) + Convert.ToInt32(lblCena.Text)).ToString();
            }

        }
    }
}
