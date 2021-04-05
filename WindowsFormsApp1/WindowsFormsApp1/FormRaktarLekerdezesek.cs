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
    public partial class FormRaktarLekerdezesek : Form
    {

        String eleresiAdatok;
        MySqlConnection kapcsolat;
        string termekRaktaron = "keszleten";//elkülönítve a készlet és a kiadott állapot
        string termekSzallitolevelen = "kiadva";

        public void MysqlKapcsolatLetrehozas()//mysql kapcsolat létrehozása
        {
            eleresiAdatok = "datasource = localhost; Database = szf43koszegikaroly; username = root; password =";
            kapcsolat = new MySqlConnection(eleresiAdatok);
            kapcsolat.Open();
        }


        public FormRaktarLekerdezesek()
        {
            InitializeComponent();
        }


        private void keszletToolStripMenuItem_Click(object sender, EventArgs e)//átlép a készlet megtekintés formra
        {
            this.Hide();
            new FormRaktar().ShowDialog();
        }


        private void ÁrukiadásToolStripMenuItem_Click(object sender, EventArgs e)//árukiadás formra lép át
        {
            this.Hide();
            new FormRaktarArukiadas().ShowDialog();
        }


        private void buttonRaktarKilepes_Click(object sender, EventArgs e)//kilép a nyitó belépő formra
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

       

        private void buttonRaktarLekerdezestermekNeve_Click(object sender, EventArgs e)//adatbázisban a terméktörzsben szereplő nevek lekérdezése választáshoz
        {
            buttonRaktarLekerdezesVevo.Visible = false;
            buttonRaktarLekerdezesTermek.Visible = true;//csak az aktuális látható
            buttonRaktarLekerdezesSzallitoSzama.Visible = false;
            buttonRaktarLekerdezesErtekesitesDatuma.Visible = false;

            //törzsben szereplő termékek megjelenítése változtatás értékesítés táblára!!!!! 

            listViewRaktarLekerdezesValasztottTetelek.Clear();//lista kiürítése

            MysqlKapcsolatLetrehozas();

            if (kapcsolat.State != ConnectionState.Open)
            {
                kapcsolat.Open();
            }
            //string sql = "Select distinct raktar.termek_neve from (ertekesites inner join raktar on ertekesites.termek_azonosito = raktar.termek_egyedi_azonosito) inner join termek on termek.cikkszam = raktar.cikkszam ";//terméknevek lekérdezés sql parancs
            string sql = "Select distinct termek_neve from raktar where termek_allapot = '" + termekSzallitolevelen +"' ";
            MySqlCommand cmd = new MySqlCommand(sql, kapcsolat);
            MySqlDataReader Reader = cmd.ExecuteReader();

            listViewRaktarLekerdezesValasztottTetelek.Items.Clear();

            while (Reader.Read())//amíg adatokat kap, addig írja be a listába
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0));
                listViewRaktarLekerdezesValasztottTetelek.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            kapcsolat.Close();
            listViewRaktarLekerdezesValasztottTetelek.GridLines = true;
            listViewRaktarLekerdezesValasztottTetelek.View = View.Details;
            listViewRaktarLekerdezesValasztottTetelek.Columns.Add("Termékek nevei:", 159);//nevezze el az oszlopokat méretmegadással
        }


        private void buttonRaktarLekerdzesVevoNeve_Click(object sender, EventArgs e)//adatbázis törzsben szereplő vevőnevek lekérdezése választáshoz
        {
            buttonRaktarLekerdezesVevo.Visible = true;//csak az aktuális látható
            buttonRaktarLekerdezesTermek.Visible = false;
            buttonRaktarLekerdezesSzallitoSzama.Visible = false;
            buttonRaktarLekerdezesErtekesitesDatuma.Visible = false;
            //törzsben szereplő vevőnevek megjelenítése  értékesítés táblában meglevő nevek!!!!!!
            listViewRaktarLekerdezesValasztottTetelek.Clear();

            MysqlKapcsolatLetrehozas();

            if (kapcsolat.State != ConnectionState.Open)

            {
                kapcsolat.Open();
            }
            string sql = "Select distinct vevo_neve from ertekesites inner join vevok on ertekesites.vevo_azonosito = vevok.vevo_azonosito;";//vevőnevek lekérdezés sql parancs
            MySqlCommand cmd = new MySqlCommand(sql, kapcsolat);
            MySqlDataReader Reader = cmd.ExecuteReader();

            listViewRaktarLekerdezesValasztottTetelek.Items.Clear();

            while (Reader.Read())//amíg adatokat kap, addig írja be a listába
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0));
                listViewRaktarLekerdezesValasztottTetelek.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            kapcsolat.Close();
            listViewRaktarLekerdezesValasztottTetelek.GridLines = true;
            listViewRaktarLekerdezesValasztottTetelek.View = View.Details;
            listViewRaktarLekerdezesValasztottTetelek.Columns.Add("Vevők nevei:", 159);//nevezze el az oszlopokat méretmegadással
            
        }

        private void buttonRaktarLekerdezesSzallitolevelSzam_Click(object sender, EventArgs e) //adatbázisban szereplő szállítólevélsorszámok lekérdezése
        {
            buttonRaktarLekerdezesVevo.Visible = false;
            buttonRaktarLekerdezesTermek.Visible = false;
            buttonRaktarLekerdezesSzallitoSzama.Visible = true;//csak az aktuális látható
            buttonRaktarLekerdezesErtekesitesDatuma.Visible = false;

            listViewRaktarLekerdezesValasztottTetelek.Clear();

            MysqlKapcsolatLetrehozas();

            if (kapcsolat.State != ConnectionState.Open)
            {
                kapcsolat.Open();
            }
            string sql = "Select distinct szallitolevel_sorszam from ertekesites ";//szállítólevél sorszám lekérdezés sql parancs
            MySqlCommand cmd = new MySqlCommand(sql, kapcsolat);
            MySqlDataReader Reader = cmd.ExecuteReader();

            listViewRaktarLekerdezesValasztottTetelek.Items.Clear();

            while (Reader.Read())//amíg adatokat kap, addig írja be a listába
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0));
                listViewRaktarLekerdezesValasztottTetelek.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            kapcsolat.Close();
            listViewRaktarLekerdezesValasztottTetelek.GridLines = true;
            listViewRaktarLekerdezesValasztottTetelek.View = View.Details;
            listViewRaktarLekerdezesValasztottTetelek.Columns.Add("Szállítólevelek sorszámai:", 159);//nevezze el az oszlopokat méretmegadással
            
        }

        private void buttonRaktarLekerdezesDatum_Click(object sender, EventArgs e)//adatbázisban szereplő értékesítési dátumok lekérdezése
        {
            buttonRaktarLekerdezesVevo.Visible = false;
            buttonRaktarLekerdezesTermek.Visible = false;
            buttonRaktarLekerdezesSzallitoSzama.Visible = false;
            buttonRaktarLekerdezesErtekesitesDatuma.Visible = true;//csak az aktuális látható
            

            listViewRaktarLekerdezesValasztottTetelek.Clear();

            MysqlKapcsolatLetrehozas();

            if (kapcsolat.State != ConnectionState.Open)
            {
                kapcsolat.Open();
            }
            string sql = "Select distinct ertekesites_datuma from ertekesites";//értékesítési dátum lekérdezés sql parancs
            MySqlCommand cmd = new MySqlCommand(sql, kapcsolat);
            MySqlDataReader Reader = cmd.ExecuteReader();

            listViewRaktarLekerdezesValasztottTetelek.Items.Clear();

            while (Reader.Read())//amíg adatokat kap, addig írja be a listába
            {
                ListViewItem lv = new ListViewItem(Reader.GetString(0));
                listViewRaktarLekerdezesValasztottTetelek.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            kapcsolat.Close();
            listViewRaktarLekerdezesValasztottTetelek.GridLines = true;
            listViewRaktarLekerdezesValasztottTetelek.View = View.Details;
            listViewRaktarLekerdezesValasztottTetelek.Columns.Add("Kiadási dátumok:", 159);
        }


        private void buttonRaktarLekerdezesRogzitese_Click(object sender, EventArgs e)//választott tétel rögzítése
        {
            try
            {           
              ListViewItem item = listViewRaktarLekerdezesValasztottTetelek.SelectedItems[0];
               if (item != null)
               {
                 textBoxRaktárLekerdezesValasztottTetel.Text = item.SubItems[0].Text;//választott tétel rögzítése megjelenítése külön
                 listViewRaktarLekerdezesValasztottTetelek.Clear();
               }
            }
            catch (Exception)
            {
                MessageBox.Show("Kérem jelölje be a kiválasztott tételt rögzítés előtt! ");
            }
        }


        private void buttonRaktarLekerdezesInditas_Click(object sender, EventArgs e)//Vevő lekérdezés
        {
            try
            {
                MysqlKapcsolatLetrehozas();

                dataGridViewRaktarLekerdezesEredmenytabla.DataSource = null;
                dataGridViewRaktarLekerdezesEredmenytabla.Rows.Clear();
                dataGridViewRaktarLekerdezesEredmenytabla.Refresh();
                dataGridViewRaktarLekerdezesEredmenytabla.Update();

                DataTable dtNyitotabla = new DataTable();

                MySqlCommand listakeszit = new MySqlCommand("SELECT raktar.cikkszam, raktar.termek_neve, raktar.mennyiseg_1 AS mennyiseg_1, raktar.mennyisegi_egyseg_1, raktar.mennyiseg_2 AS mennyiseg_2, raktar.mennyisegi_egyseg_2, ertekesites.ertekesites_datuma, ertekesites.szallitolevel_sorszam FROM (raktar INNER JOIN ertekesites ON raktar.termek_egyedi_azonosito = ertekesites.termek_azonosito) INNER JOIN vevok ON vevok.vevo_azonosito = ertekesites.vevo_azonosito WHERE vevok.vevo_neve = '" + textBoxRaktárLekerdezesValasztottTetel.Text + "'; ", kapcsolat);
                MySqlDataReader megnyit = listakeszit.ExecuteReader();
                dtNyitotabla.Load(megnyit);
                if (dtNyitotabla.Rows.Count > 0)
                {
                    dataGridViewRaktarLekerdezesEredmenytabla.DataSource = dtNyitotabla;

                }
                else
                {
                    MessageBox.Show("Kérem ellenőrizze, hogy a rögzítette-e a kiválasztott vevő nevét! Amennyiben igen, abban az esetben  kiválasztott vevő neve nem szerepel a vásárlók között! ");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vevőlekérdezési hiba!");
            }

            kapcsolat.Close();
        }


    private void buttonRaktarLekerdezesTermek_Click(object sender, EventArgs e)//termék lekérdezés 
        {

           try
            {
            MysqlKapcsolatLetrehozas();

                dataGridViewRaktarLekerdezesEredmenytabla.DataSource = null;
                dataGridViewRaktarLekerdezesEredmenytabla.Rows.Clear();
                dataGridViewRaktarLekerdezesEredmenytabla.Refresh();
                dataGridViewRaktarLekerdezesEredmenytabla.Update();


                DataTable dtNyitotabla = new DataTable();

                MySqlCommand listakeszit = new MySqlCommand("SELECT vevok.vevo_neve, raktar.mennyiseg_1 AS mennyiseg_1, raktar.mennyisegi_egyseg_1, raktar.mennyiseg_2 AS mennyiseg_2, raktar.mennyisegi_egyseg_2, ertekesites.ertekesites_datuma, ertekesites.szallitolevel_sorszam FROM (raktar INNER JOIN ertekesites ON raktar.termek_egyedi_azonosito = ertekesites.termek_azonosito) INNER JOIN vevok ON vevok.vevo_azonosito = ertekesites.vevo_azonosito WHERE raktar.termek_neve = '" + textBoxRaktárLekerdezesValasztottTetel.Text + "'; ", kapcsolat);
                MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
              if (dtNyitotabla.Rows.Count > 0)
              {
                dataGridViewRaktarLekerdezesEredmenytabla.DataSource = dtNyitotabla;

              }
                else
                {
                    MessageBox.Show("Kérem ellenőrizze, hogy a rögzítette-e a kiválasztott termék nevét! Amennyiben rögzítette, abban az esetben  kiválasztott termék nem szerepel az értékesítések között!");
                }

            }
           catch (Exception)
            {

                MessageBox.Show("Terméklekérdezési hiba!");
            }

            kapcsolat.Close();
        }


        private void buttonRaktarLekerdezesSzallitoSzama_Click(object sender, EventArgs e)//szállítólevélszám szerinti lekérdezés
        {

           try
           {

            MysqlKapcsolatLetrehozas();

            dataGridViewRaktarLekerdezesEredmenytabla.DataSource = null;
            dataGridViewRaktarLekerdezesEredmenytabla.Rows.Clear();
            dataGridViewRaktarLekerdezesEredmenytabla.Refresh();
            dataGridViewRaktarLekerdezesEredmenytabla.Update();

            DataTable dtNyitotabla = new DataTable();

            MySqlCommand listakeszit = new MySqlCommand("SELECT vevok.vevo_neve, raktar.cikkszam, raktar.termek_neve, raktar.mennyiseg_1, raktar.mennyisegi_egyseg_1, raktar.mennyiseg_2, raktar.mennyisegi_egyseg_2, ertekesites.ertekesites_datuma FROM (raktar INNER JOIN ertekesites ON raktar.termek_egyedi_azonosito = ertekesites.termek_azonosito) INNER JOIN vevok ON vevok.vevo_azonosito = ertekesites.vevo_azonosito WHERE ertekesites.szallitolevel_sorszam = '" + textBoxRaktárLekerdezesValasztottTetel.Text + "'; ", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
              if (dtNyitotabla.Rows.Count > 0)
              {
                dataGridViewRaktarLekerdezesEredmenytabla.DataSource = dtNyitotabla;

              }
              else
              {
                MessageBox.Show("Kérem ellenőrizze, hogy a rögzítette-e a kiválasztott szállítólevél számát! Amennyiben igen, abban az esetben  kiválasztott szállítólevél számon nem található értékesített termék! Kérem vegye fel a kapcsolatot a könyvelési részleggel! ");
              }

           }
           catch (Exception)
           {

                MessageBox.Show("Szállítólevélszám lekérdezési hiba!");
           }

            kapcsolat.Close();
        }



        private void buttonRaktarLekerdezesErtekesitesDatuma_Click(object sender, EventArgs e)//dátum lekérdezés
        {
           try
           {

            MysqlKapcsolatLetrehozas();

            dataGridViewRaktarLekerdezesEredmenytabla.DataSource = null;
            dataGridViewRaktarLekerdezesEredmenytabla.Rows.Clear();
            dataGridViewRaktarLekerdezesEredmenytabla.Refresh();
            dataGridViewRaktarLekerdezesEredmenytabla.Update();

            DataTable dtNyitotabla = new DataTable();

            MySqlCommand listakeszit = new MySqlCommand("SELECT vevok.vevo_neve, raktar.cikkszam, raktar.termek_neve, raktar.mennyiseg_1, raktar.mennyisegi_egyseg_1, raktar.mennyiseg_2, raktar.mennyisegi_egyseg_2, ertekesites.szallitolevel_sorszam FROM (raktar INNER JOIN ertekesites ON raktar.termek_egyedi_azonosito = ertekesites.termek_azonosito) INNER JOIN vevok ON vevok.vevo_azonosito = ertekesites.vevo_azonosito WHERE ertekesites.ertekesites_datuma = '" + textBoxRaktárLekerdezesValasztottTetel.Text + "'; ", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
                if (dtNyitotabla.Rows.Count > 0)
                {
                   dataGridViewRaktarLekerdezesEredmenytabla.DataSource = dtNyitotabla;
                }
                else
                {
                    MessageBox.Show("Kérem ellenőrizze, hogy a rögzítette-e a kiválasztott értékesítési dátumot! Amennyiben igen, abban az esetben a kiválasztott dátumhoz nem tartozik hozzá értékesítés! Kérem vegye fel a kapcsolatot a könyvelési részleggel! ");
                }
            kapcsolat.Close();
           }
           catch (Exception)
           {
                MessageBox.Show("Dátum lekérdezési hiba!");
           }
        }
    }
}
