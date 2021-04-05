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
    public partial class FormTermeles : Form
    {
        String eleresiAdatok;
        MySqlConnection kapcsolat;

        public void MysqlKapcsolatLetrehozas()//mysql kapcsolat felépítése
        {
            eleresiAdatok = "datasource = localhost; Database = szf43koszegikaroly; username = root; password =";
            kapcsolat = new MySqlConnection(eleresiAdatok);
            kapcsolat.Open();
        }


        public FormTermeles()
        {
            InitializeComponent();
        }


        private void raktárkészletLekérdezésToolStripMenuItem_Click(object sender, EventArgs e)//készlekérdezés menüpontra kattintva
        {
            MysqlKapcsolatLetrehozas();
            //kiválasztja  keszleten termékállapotú termékeket az adatbázisból mennyiségi összesítésben
            DataTable dtNyitotabla = new DataTable();
            MySqlCommand listakeszit = new MySqlCommand("SELECT cikkszam, termek_neve, SUM(mennyiseg_1), mennyisegi_egyseg_1, SUM(mennyiseg_2), mennyisegi_egyseg_2 FROM raktar WHERE termek_allapot = keszleten GROUP BY cikkszam;", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
            if (dtNyitotabla.Rows.Count > 0)
            {
                dataGridViewTermelesKeszlet.DataSource = dtNyitotabla;           
            }
            dataGridViewTermelesKeszlet.Visible = true;//láthatóvá teszi a készlet táblát
            kapcsolat.Close();
        }


        private void buttonTermelesKilepes_Click(object sender, EventArgs e)//kilépés a bejelentkező ablakba
        {//kilépés jóváhagyása MessageBox igen nem
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


        private void termelésiJelentésToolStripMenuItem_Click(object sender, EventArgs e)//termelési jelentés menüpontra kattintva átlép 
        {
            this.Hide();
            new FormTermelesTemelesJelentes().ShowDialog();
        }


        private void FormTermeles_Load(object sender, EventArgs e)
        {//termelési form betöltődésekor 
            MysqlKapcsolatLetrehozas();
            string termekAllapot = "keszleten";//nem kiadott termékek elkülönítéséhez
            //készletellenőrző tábla jelenik meg
            DataTable dtNyitotabla = new DataTable();
            MySqlCommand listakeszit = new MySqlCommand("SELECT cikkszam, termek_neve, SUM(mennyiseg_1) AS mennyiseg_1, mennyisegi_egyseg_1, SUM(mennyiseg_2) AS mennyiseg_2, mennyisegi_egyseg_2 FROM raktar WHERE termek_allapot = '" + termekAllapot + "'  GROUP BY cikkszam ", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
            if (dtNyitotabla.Rows.Count > 0)
            {
                dataGridViewTermelesKeszlet.DataSource = dtNyitotabla;
            }
            dataGridViewTermelesKeszlet.Visible = true;
            kapcsolat.Close();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
