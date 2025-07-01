using Projekat.Kontrola;
using Projekat.Repository;
using System.Data;
using System.Data.SqlClient;


namespace Projekat
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        private readonly ISqlRepository _sqlRepository;
        public static Form1 instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1(new SqlRepository());
                }
                return _obj;
            }
        }
        public DataGridView zoran
        {
            get { return dataview1; }
            set { dataview1 = (Guna.UI2.WinForms.Guna2DataGridView)value; }
        }
        public FlowLayoutPanel Pera
        {
            get { return paneldodaj; }
            set { paneldodaj = value; }
        }
        public void Addstvari(string name, int cost, int broj, string ukupno)
        {
            paneldodaj.Controls.Add(new CartItem()
            {
                ItemIme = name,
                ItemCena = cost,
                ItemBroj = broj,
                ItemUkupno = ukupno,
            });
        }
        public Form1(ISqlRepository sqlRepository)
        {
            InitializeComponent();
            _sqlRepository = sqlRepository;


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            _sqlRepository.test();

        }

        public void AddItem(string name, int cost, string category)
        {
            panelstvari.Controls.Add(new btnProduct()
            {
                ItemIme = name,
                ItemNum = cost,
                ItemCategory = category,


            });

        }


        public void btnProductLabelclick(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            AddItem("Espreso", 150, "Kafa");
            AddItem("Crna", 130, "Kafa");
            AddItem("Capucino", 170, "Kafa");
            AddItem("Topla Cokolada", 180, "Kafa");
            AddItem("Tocen Jelen", 170, "Pivo");
            AddItem("Tocen Lav", 160, "Pivo");
            AddItem("Jelen 0.5", 200, "Pivo");
            AddItem("Tuborg 0.5", 190, "Pivo");
            AddItem("Caj od Sumskog voca", 129, "Cajevi");
            AddItem("Caj od Nane", 130, "Cajevi");
            AddItem("Ice Tea Pomorandza", 150, "Cajevi");
            AddItem("Ice tea Sumsko voce", 150, "Cajevi");
            AddItem("Knjaz Milos", 110, "Voda");
            AddItem("Rosa", 100, "Voda");
            AddItem("Jazak", 130, "Voda");
            AddItem("Kola", 180, "Sokovi");
            AddItem("Sprite", 170, "Sokovi");
            AddItem("Sweps", 190, "Sokovi");
            AddItem("Jabuka", 200, "Rakija");
            AddItem("Sljiva", 200, "Rakija");
            AddItem("Kajsija", 200, "Rakija");
            AddItem("Belo", 300, "Vino");
            AddItem("Crno", 300, "Vino");
            AddItem("Rose", 350, "Vino");
            AddItem("Plazma", 200, "Frape");
            AddItem("Banana", 210, "Frape");
            AddItem("Oreo", 240, "Frape");
            AddItem("Vanila", 200, "Frape");
            AddItem("Cokolada", 220, "Frape");
            Addstvari("Prvi", 120, 1, "Ukupno");
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            foreach (var item in panelstvari.Controls)
            {
                var wdg = (btnProduct)item;
                wdg.Visible = wdg.lblNaziv.Text.ToLower().Contains(txtSearch.Text.Trim());

            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {

            foreach (var item in panelstvari.Controls)
            {
                var wdg = (btnProduct)item;
                wdg.Visible = wdg.lblNaziv.Text.ToLower().Contains(txtSearch.Text.Trim());

            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            foreach (var item in panelstvari.Controls)
            {
                var wdg = (btnProduct)item;
                wdg.Visible = wdg.ItemCategory.ToString().Contains("Kafa");

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            foreach (var item in panelstvari.Controls)
            {
                var wdg = (btnProduct)item;
                wdg.Visible = wdg.lblKategorija.Text.ToLower().Contains(txtSearch.Text.Trim());

            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            foreach (var item in panelstvari.Controls)
            {
                var wdg = (btnProduct)item;
                wdg.Visible = wdg.ItemCategory.ToString().Contains("Pivo");

            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            foreach (var item in panelstvari.Controls)
            {
                var wdg = (btnProduct)item;
                wdg.Visible = wdg.ItemCategory.ToString().Contains("Sokovi");

            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            foreach (var item in panelstvari.Controls)
            {
                var wdg = (btnProduct)item;
                wdg.Visible = wdg.ItemCategory.ToString() == "Frape";


            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            foreach (var item in panelstvari.Controls)
            {
                var wdg = (btnProduct)item;
                wdg.Visible = wdg.ItemCategory.ToString() == "Rakija";


            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            foreach (var item in panelstvari.Controls)
            {
                var wdg = (btnProduct)item;
                wdg.Visible = wdg.ItemCategory.ToString() == "Voda";


            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            foreach (var item in panelstvari.Controls)
            {
                var wdg = (btnProduct)item;
                wdg.Visible = wdg.ItemCategory.ToString() == "Cajevi";


            }
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            foreach (var item in panelstvari.Controls)
            {
                var wdg = (btnProduct)item;
                wdg.Visible = wdg.ItemCategory.ToString() == "Vino";


            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || txtSearch.Text.Trim().Length == 0)
            {
                foreach (var item in panelstvari.Controls)
                {
                    var wdg = (btnProduct)item;
                    wdg.Visible = wdg.lblNaziv.Text.ToLower().Contains(txtSearch.Text.Trim());

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Form2 form= new Form2();
            form.Show();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {

        }

        private void panelstvari_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in panelstvari.Controls)
            {
                var wdg = (btnProduct)item;
                wdg.Visible = wdg.lblNaziv.Text.ToLower().Contains(txtSearch.Text.Trim());

            }
        }

        private void dataview1_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {

        }

        public void dataview1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {



        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

            int a = dataview1.CurrentCell.RowIndex;
            int b = Convert.ToInt32(dataview1.CurrentRow.Cells[2].Value.ToString());
            lblukupnacena.Text = (Convert.ToInt32(lblukupnacena.Text) - b).ToString();
            dataview1.Rows.RemoveAt(a);



        }

        private void lblukupnacena_Click(object sender, EventArgs e)
        {

        }
    }
}