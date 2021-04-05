using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class FormRaktar : Form
    {

        String eleresiAdatok;
        MySqlConnection kapcsolat;

        public void MysqlKapcsolatLetrehozas()
        {
            eleresiAdatok = "datasource = localhost; Database = szf43koszegikaroly; username = root; password =";
            kapcsolat = new MySqlConnection(eleresiAdatok);
            kapcsolat.Open();
        }


        public FormRaktar()
        {
            InitializeComponent();
        }


        private void buttonRaktarKilepes_Click(object sender, EventArgs e)
        {
            Form parbeszedAblak = new Form();
            DialogResult dialog = MessageBox.Show("Biztosan ki akar lépni az ablakból?", "Kilépés", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Dispose();
                new FormNyito().ShowDialog();
            }
            else if (dialog == DialogResult.No)
            {
                parbeszedAblak.Dispose();
            }
        }


        private void készletToolStripMenuItem_Click(object sender, EventArgs e)//készlet menü
        {
            MysqlKapcsolatLetrehozas();
            string termekAllapot = "keszleten";//a nem kiadott áruk lekérdezéséhez, készletben megjelenítéséhez

            DataTable dtNyitotabla = new DataTable();
            MySqlCommand listakeszit = new MySqlCommand("SELECT cikkszam, termek_neve, SUM(mennyiseg_1) AS mennyiseg_1, mennyisegi_egyseg_1, SUM(mennyiseg_2) AS mennyiseg_2, mennyisegi_egyseg_2 FROM raktar WHERE termek_allapot = '" + termekAllapot + "' GROUP BY cikkszam;", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
            if (dtNyitotabla.Rows.Count > 0)
            {
                dataGridViewRaktarOsszKeszlet.DataSource = dtNyitotabla;
            }

            készletToolStripMenuItem.Visible = false;
            dataGridViewRaktarOsszKeszlet.Visible = true;
            kapcsolat.Close();
        }

      

        private void lekérdezésekToolStripMenuItem_Click(object sender, EventArgs e)//átlépés a lekérdezésekhez -- menü
        {
            this.Hide();
            new FormRaktarLekerdezesek().ShowDialog();
        }


        private void ÁrukiadásToolStripMenuItem_Click(object sender, EventArgs e)//átlépés akiadáshoz -- menü
        {
            this.Hide();
            new FormRaktarArukiadas().ShowDialog();
        }
    }
}
