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
    public partial class FormRaktarArukiadas : Form
    {

        String eleresiAdatok;
        MySqlConnection kapcsolat;
        string termekRaktaron = "keszleten";
        string termekSzallitolevelen = "kiadva";
        
        public void MysqlKapcsolatLetrehozas()//mysql kapcsolat létrhozása
        {

            eleresiAdatok = "datasource = localhost; Database = szf43koszegikaroly; username = root; password =";
            kapcsolat = new MySqlConnection(eleresiAdatok);
            kapcsolat.Open();
        }

        public void tablafeltoltesMySqlParanccsalRaktarVevoValasztasTabla()//a vevő törzsben szereplő adatok feltöltése a vevő kiválasztáshoz
        {
            DataTable dtNyitotabla = new DataTable();
            MySqlCommand listakeszit = new MySqlCommand("SELECT * from vevok", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
            if (dtNyitotabla.Rows.Count > 0)
            {
                dataGridViewRaktarArukiadasVevoValasztas.DataSource = dtNyitotabla;
            }

        }

        public void tablafeltoltesMySqlParanccsalRaktarArukiadasTermekValasztasTabla()//a raktáron szereplő elérhető termékek feltöltése
        {

            DataTable dtNyitotabla = new DataTable();
            MySqlCommand listakeszit = new MySqlCommand("SELECT termek_egyedi_azonosito, cikkszam, termek_neve, mennyiseg_1, mennyisegi_egyseg_1, mennyiseg_2, mennyisegi_egyseg_2 from raktar WHERE termek_allapot = '" + termekRaktaron + "'", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
            if (dtNyitotabla.Rows.Count > 0)
            {
                dataGridViewRaktarArukiadasTermekValasztas.DataSource = dtNyitotabla;
            }

        }

        public void tablafeltoltesMySqlParanccsalRaktarArukiadasSzallitolevelSorszam()//a szállítólevél sorszám megjelenítése
        {
            //csak abban az esetben működik, ha már van benne szállítósorszám!!! különben nem tudja kiválasztani az üres adatbázisból!!!!
            DataTable dtNyitotabla = new DataTable();
            MySqlCommand listakeszit = new MySqlCommand("SELECT szallitolevel_sorszam FROM szallitolevel ORDER BY szallitolevel_sorszam DESC;", kapcsolat);// "SELECT MAX(szallitolevel_sorszam) FROM szallitolevel; ", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
            if (dtNyitotabla.Rows.Count > 0)
            {
                dataGridViewRaktarArukiadasSzallitoSorszam.DataSource = dtNyitotabla;
            }

        }

        

        public void tablafeltoltesMySqlParanccsalRaktarArukiadasSzallitolevelTermekLista()//a szállítólevél tábla feltöltése a kiválasztott adatokkal
        {
            DataTable dtNyitotabla = new DataTable();
            MySqlCommand listakeszit = new MySqlCommand("SELECT raktar.termek_egyedi_azonosito, raktar.cikkszam, raktar.termek_neve, raktar.mennyiseg_1, raktar.mennyisegi_egyseg_1, raktar.mennyiseg_2, raktar.mennyisegi_egyseg_2 FROM (raktar INNER JOIN ertekesites ON raktar.termek_egyedi_azonosito = ertekesites.termek_azonosito) INNER JOIN szallitolevel ON ertekesites.szallitolevel_sorszam = szallitolevel.szallitolevel_sorszam WHERE ertekesites.szallitolevel_sorszam = '" + textBoxRaktarArukiadasSzallitoSorszam.Text + "'  ", kapcsolat);
            //MySqlCommand listakeszit = new MySqlCommand("SELECT raktar.termek_egyedi_azonosito, raktar.cikkszam, raktar.termek_neve, raktar.mennyiseg_1, raktar.mennyisegi_egyseg_1, raktar.mennyiseg_2, raktar.mennyisegi_egyseg_2 FROM raktar INNER JOIN ertekesites ON raktar.termek_egyedi_azonosito = ertekesites.termek_azonosito WHERE ertekesites.szallitolevel_sorszam ='" + textBoxRaktarArukiadasSzallitoSorszam.Text + "' ", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
            if (dtNyitotabla.Rows.Count > 0)
            {
                dataGridViewRaktarArukiadasSzallitolevelTermekLista.DataSource = dtNyitotabla;
            }

            dataGridViewRaktarArukiadasSzallitolevelTermekLista.Refresh();
            dataGridViewRaktarArukiadasSzallitolevelTermekLista.Update();
        }


        public FormRaktarArukiadas()
        {
            InitializeComponent();

            MysqlKapcsolatLetrehozas();//kapcsolat felépítése, vevő és raktár tábla feltöltése adatbázis adatokkal
            tablafeltoltesMySqlParanccsalRaktarVevoValasztasTabla();
            tablafeltoltesMySqlParanccsalRaktarArukiadasTermekValasztasTabla();
            tablafeltoltesMySqlParanccsalRaktarArukiadasSzallitolevelTermekLista();
            
        }

        private void készletToolStripMenuItem_Click(object sender, EventArgs e)//raktárkészlet formra ugrik
        {

            if (textBoxRaktarArukiadasTermekNeve.Text != "")
            {
                MessageBox.Show("Kilépés előtt zárja le a szállítólevelet vagy mégsem gombbal töröljön!");
            }
            else if (textBoxRaktarArukiadasValasztottVevo.Text != "")
            {
                MessageBox.Show("Kilépés előtt zárja le a szállítólevelet vagy mégsem gombbal töröljön!");
            }
            else
            {
                this.Hide();
                new FormRaktar().ShowDialog();
            }
           
        }

        private void lekérdezésekToolStripMenuItem_Click(object sender, EventArgs e)//lekérdezések formra ugrik ha lezárt a szállítólevél
        {
            if (textBoxRaktarArukiadasTermekNeve.Text != "")
            {
                MessageBox.Show("Kilépés előtt zárja le a szállítólevelet vagy mégsem gombbal töröljön!");
            }
            else if (textBoxRaktarArukiadasValasztottVevo.Text != "")
            {
                MessageBox.Show("Kilépés előtt zárja le a szállítólevelet vagy mégsem gombbal töröljön!");
            }
            else
            {
                this.Hide();
                new FormRaktarLekerdezesek().ShowDialog();
            }
           
        }

        private void buttonRaktarArukiadasKilepes_Click(object sender, EventArgs e)//nyitó ablakra lép tovább
        {
            Form parbeszedAblak = new Form();
            DialogResult dialog = MessageBox.Show("Biztosan ki akar lépni az ablakból?", "Kilépés", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (textBoxRaktarArukiadasTermekNeve.Text != "")
                {
                    MessageBox.Show("Kilépés előtt zárja le a szállítólevelet vagy mégsem gombbal töröljön!");
                }
                else if (textBoxRaktarArukiadasValasztottVevo.Text != "")
                {
                    MessageBox.Show("Kilépés előtt zárja le a szállítólevelet vagy mégsem gombbal töröljön!");
                }
                else
                {
                    this.Dispose();
                    new FormNyito().ShowDialog();
                }
              
            }
            else if (dialog == DialogResult.No)
            {
                parbeszedAblak.Dispose();
            }
        }

        private void dataGridViewRaktarArukiadasVevoValasztas_CellClick(object sender, DataGridViewCellEventArgs e)//vevőtörzsből lekérdezzzük a választható vevőket már a nyitáskor
        {//vevőválasztás adattábla cella kattintás esménye generálja

            Form parbeszedAblak = new Form();
            DialogResult dialog = MessageBox.Show("Rögzíthető a vevőnév a szállítólevélen?", "Vevő kiválasztás", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewRaktarArukiadasVevoValasztas.Rows[e.RowIndex];
                    textBoxRaktarArukiadasValasztottVevoAzonosito.Text = row.Cells[0].Value.ToString();//textboxba kiirja a vevő azonosítót a program futásához, nem látható
                    textBoxRaktarArukiadasValasztottVevo.Text = row.Cells[1].Value.ToString();//textboxba kiirja a vevő nevét a felhasználónak
                }
            

              string insertQuery = "INSERT INTO szallitolevel VALUES (null);";//vevőkiválasztás esetén szállítólevél sorszámot generál-- auto increment
              

              if (kapcsolat.State != ConnectionState.Open)
              {
                kapcsolat.Open();
              }
              MySqlCommand beszuras = new MySqlCommand(insertQuery, kapcsolat);
                //tablafeltoltesMySqlParanccsalRaktarArukiadasSzallitolevelSorszam();
                try
              {
                if (beszuras.ExecuteNonQuery() == 1)
                {
                   tablafeltoltesMySqlParanccsalRaktarArukiadasSzallitolevelSorszam();

                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = dataGridViewRaktarArukiadasSzallitoSorszam.Rows[e.RowIndex];
                        textBoxRaktarArukiadasSzallitoSorszam.Text = row.Cells[0].Value.ToString();//textboxba kiirjuk a felhasználó számára a szállítósorszámot és ezzel dolgozunk tovább
                        dataGridViewRaktarArukiadasVevoValasztas.Enabled = false;
                        dataGridViewRaktarArukiadasTermekValasztas.Enabled = true;
                        MessageBox.Show("Szállítólevél sorszám rögzítve!");
                    }
                    else
                    {
                        MessageBox.Show("Szállítólevél sorszám rögzítése nem valósult meg! Kapcsolat felépítve.");
                    }

                  
                }
                else
                {
                    MessageBox.Show("Szállítólevél sorszám rögzítése nem valósult meg! Kapcsolat nincs felépítve.");
                }

              }

              catch (Exception ex)
              {
                MessageBox.Show(ex.Message);
              }

            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("Szállítólevél nem került megnyitásra");
                /*textBoxRaktarArukiadasValasztottVevoAzonosito.Clear(); -----------ez akkor kell ha meglévő szállítólevél sorszámot akarok törölni
                textBoxRaktarArukiadasValasztottVevo.Clear();
                if (kapcsolat.State != ConnectionState.Open)
                {
                    kapcsolat.Open();
                }
                string deleteQuery = "DELETE szallitolevel_sorszam from szallitolevel WHERE szallitolevel_sorszam = '" + textBoxRaktarArukiadasSzallitoSorszam.Text + "'";
                if (kapcsolat.State != ConnectionState.Open)
                {
                    kapcsolat.Open();
                }
                MySqlCommand beszuras = new MySqlCommand(deleteQuery, kapcsolat);
                textBoxRaktarArukiadasSzallitoSorszam.Clear();
                parbeszedAblak.Dispose();*/
            }

        }

        //termékválasztó adattábla cellakttintás esetén termékállapot átállítása kiadva-ra, frissítés
        //fel kell tölteni az adatokat az értékesítés táblába, és megjeleníteni a szállítólevél tartalom adattáblában törlési cellakattintás lehetőséggel



        private void dataGridViewRaktarArukiadasTermekValasztas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form parbeszedAblak = new Form();
            DialogResult dialog = MessageBox.Show("Rögzíthető a termék a szállítólevélen?", "Termék kiválasztás", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewRaktarArukiadasTermekValasztas.Rows[e.RowIndex];
                    textBoxRaktarArukiadasTermekEgyediAzonosito.Text = row.Cells[0].Value.ToString();//textboxba kiirja a termék azonosítót a program futásához, nem látható
                    textBoxRaktarArukiadasTermekNeve.Text = row.Cells[2].Value.ToString();//textboxba kiirja a termék nevét a felhasználónak
                }

                string updateQuery = "UPDATE raktar SET termek_allapot = '" + termekSzallitolevelen + "' WHERE termek_egyedi_azonosito ='" + textBoxRaktarArukiadasTermekEgyediAzonosito.Text + "'";

                if (kapcsolat.State != ConnectionState.Open)
                {
                    kapcsolat.Open();
                }
                try
                {
                    MySqlCommand frissites = new MySqlCommand(updateQuery, kapcsolat);
                    if (frissites.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Adatok frissitve");
                    }
                    else
                    {
                        MessageBox.Show("Az adatok frissitése sikertelen");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                dataGridViewRaktarArukiadasTermekValasztas.Refresh();
                dataGridViewRaktarArukiadasTermekValasztas.Update();
                tablafeltoltesMySqlParanccsalRaktarArukiadasTermekValasztasTabla();//frissítsük a termékválasztási lehetőségeket, kivéve belőle a kiadva állapotúakat

                //változtassuk  meg a kiválasztott termék státusát raktáron-ról kiadva-ra, hogy a készleten megjelenítéskor ne szerepeljen



                //töltsük fel az értékesítés táblába a kiválasztott termék adatokat és jelenítsük meg a szállítólevél adattáblában

                var ertekesitesiDatum = DateTime.Now.Date;
                string datumFormatum = "yyyy-MM-dd";//ertekesitesiDatum.ToString(datumFormatum)

                //string insertQuery = "INSERT INTO ertekesites VALUES ('" + Convert.ToInt32(textBoxRaktarArukiadasSzallitoSorszam.Text)  + "','" + Convert.ToInt32(textBoxRaktarArukiadasValasztottVevoAzonosito.Text) + "','" + Convert.ToInt32(textBoxRaktarArukiadasTermekEgyediAzonosito.Text) + "','" + ertekesitesiDatum.ToString(datumFormatum) + "')";
                string insertQuery = "INSERT INTO ertekesites VALUES (null,'" + textBoxRaktarArukiadasSzallitoSorszam.Text + "','" + textBoxRaktarArukiadasValasztottVevoAzonosito.Text + "','" + textBoxRaktarArukiadasTermekEgyediAzonosito.Text + "','" + ertekesitesiDatum.ToString(datumFormatum) + "');";

                if (kapcsolat.State != ConnectionState.Open)
                {
                    kapcsolat.Open();
                }
                try
                {
                    MySqlCommand beszuras = new MySqlCommand(insertQuery, kapcsolat);
                    if (beszuras.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Adatok feltöltve");
                    }
                    else
                    {
                        MessageBox.Show("Az adatok feltöltése sikertelen");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

                //és jelenítsük meg a szállítólevél adattáblában
                tablafeltoltesMySqlParanccsalRaktarArukiadasSzallitolevelTermekLista();


                //ürítsük ki a termékazonosítót a következő termékválasztási lehetőséghez 
                //textBoxRaktarArukiadasTermekNeve.Clear();
                //textBoxRaktarArukiadasTermekEgyediAzonosito.Clear();
                kapcsolat.Close();

            }
            else if (dialog == DialogResult.No)
            {

                MessageBox.Show("Kérem válasszon új terméket vagy lépjen vissza a mégsem gombbal!");

                textBoxRaktarArukiadasTermekNeve.Clear();
                textBoxRaktarArukiadasTermekEgyediAzonosito.Clear();
                textBoxRaktarArukiadasSzallitoSorszam.Clear();
                parbeszedAblak.Dispose();
            }

        }

        
        private void dataGridViewRaktarArukiadasSzallitolevelTermekLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {//szállítólevél lista törlendő elemére kattintva

            //vizsgálja meg, hogy hány sor van a szállítólista táblában
            //ha egy sor van csak benne szállítólevél táblában, akkor törölje ki, ne maradjon benne semmi
            int sorSzamlalo;
            for (sorSzamlalo = 0; sorSzamlalo < dataGridViewRaktarArukiadasSzallitolevelTermekLista.Rows.Count; sorSzamlalo++)
            {
               
            }
            
            if (sorSzamlalo == 2)
                {

                    if (e.RowIndex >= 0)//kiválasztott sor egyedi termékazonosítóját adja át a textboxnak
                    {
                        DataGridViewRow row = this.dataGridViewRaktarArukiadasSzallitolevelTermekLista.Rows[e.RowIndex];
                        textBoxRaktarArukiadasSzallitolevelTermekTorles.Text = row.Cells[0].Value.ToString();//textboxba kiirja a törlendő termék azonosítót a program futásához, nem látható

                    }
                    //törölje ki az értékesítés táblából a visszavett tételt egyedi termékazonosító alapján
                    string deleteQuery = "DELETE from ertekesites WHERE termek_azonosito = '" + textBoxRaktarArukiadasSzallitolevelTermekTorles.Text + "'";
                    if (kapcsolat.State != ConnectionState.Open)
                    {
                        kapcsolat.Open();
                    }
                    try
                    {
                        MySqlCommand beszuras = new MySqlCommand(deleteQuery, kapcsolat);
                        if (beszuras.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Termék adatok szállítóról törölve");
                            tablafeltoltesMySqlParanccsalRaktarArukiadasSzallitolevelTermekLista();
                        }
                        else
                        {
                            MessageBox.Show("A termék adatok törlése sikertelen");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                    //állítsa vissza a termékállapotot a készleten-re, hogy raktárkészlet lekérdezésekor megjelenjen
                    string updateQuery = "UPDATE raktar SET termek_allapot = '" + termekRaktaron + "' WHERE termek_egyedi_azonosito ='" + textBoxRaktarArukiadasSzallitolevelTermekTorles.Text + "'";

                    if (kapcsolat.State != ConnectionState.Open)
                    {
                        kapcsolat.Open();
                    }
                    try
                    {
                        MySqlCommand frissites = new MySqlCommand(updateQuery, kapcsolat);
                        if (frissites.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Raktárkészletbe visszahelyezve");
                        }
                        else
                        {
                            MessageBox.Show("Raktári készletre vétel sikertelen");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                    //ürítse ki a textboxot 
                    textBoxRaktarArukiadasSzallitolevelTermekTorles.Clear();

                    //töltse fel a termékválasztó raktár táblát a friss adatokkal az adatbázisból
                    tablafeltoltesMySqlParanccsalRaktarArukiadasTermekValasztasTabla();
                    dataGridViewRaktarArukiadasSzallitolevelTermekLista.DataSource = null;
                    dataGridViewRaktarArukiadasTermekValasztas.Enabled = false;
                }

                else//akkor hajtsa végre ha a sorszámláló nagyobb,  mint egy, a végén nem üríti ki az adattáblát
                {
                if (e.RowIndex >= 0)//kiválasztott sor egyedi termékazonosítóját adja át a textboxnak
                {
                    DataGridViewRow row = this.dataGridViewRaktarArukiadasSzallitolevelTermekLista.Rows[e.RowIndex];
                    textBoxRaktarArukiadasSzallitolevelTermekTorles.Text = row.Cells[0].Value.ToString();//textboxba kiirja a törlendő termék azonosítót a program futásához, nem látható

                }
                //törölje ki az értékesítés táblából a visszavett tételt egyedi termékazonosító alapján
                string deleteQuery = "DELETE from ertekesites WHERE termek_azonosito = '" + textBoxRaktarArukiadasSzallitolevelTermekTorles.Text + "'";
                if (kapcsolat.State != ConnectionState.Open)
                {
                    kapcsolat.Open();
                }
                try
                {
                    MySqlCommand beszuras = new MySqlCommand(deleteQuery, kapcsolat);
                    if (beszuras.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Termék adatok szállítóról törölve");
                        tablafeltoltesMySqlParanccsalRaktarArukiadasSzallitolevelTermekLista();
                    }
                    else
                    {
                        MessageBox.Show("A termék adatok törlése sikertelen");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


                //állítsa vissza a termékállapotot a készleten-re, hogy raktárkészlet lekérdezésekor megjelenjen
                string updateQuery = "UPDATE raktar SET termek_allapot = '" + termekRaktaron + "' WHERE termek_egyedi_azonosito ='" + textBoxRaktarArukiadasSzallitolevelTermekTorles.Text + "'";

                if (kapcsolat.State != ConnectionState.Open)
                {
                    kapcsolat.Open();
                }
                try
                {
                    MySqlCommand frissites = new MySqlCommand(updateQuery, kapcsolat);
                    if (frissites.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Raktárkészletbe visszahelyezve");
                    }
                    else
                    {
                        MessageBox.Show("Raktári készletre vétel sikertelen");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

                //ürítse ki a textboxot 
                textBoxRaktarArukiadasSzallitolevelTermekTorles.Clear();

                //töltse fel a termékválasztó raktár táblát a friss adatokkal az adatbázisból
                tablafeltoltesMySqlParanccsalRaktarArukiadasTermekValasztasTabla();
            }
            
        }

       
        private void buttonRaktarArukiadasSzallitolevelLezaras_Click(object sender, EventArgs e)
        {
            if (textBoxRaktarArukiadasValasztottVevo.Text == "" || textBoxRaktarArukiadasTermekNeve.Text =="")
            {
                MessageBox.Show("A szállítólevél nem lezárható, kérem válasszon vevőt, terméket/termékeket");
            }
            else
            {
                dataGridViewRaktarArukiadasVevoValasztas.Enabled = true;
                dataGridViewRaktarArukiadasTermekValasztas.Enabled = false;
                dataGridViewRaktarArukiadasSzallitolevelTermekLista.DataSource = null;
                //dataGridViewRaktarArukiadasSzallitoSorszam.DataSource = null;
                textBoxRaktarArukiadasValasztottVevoAzonosito.Clear();
                textBoxRaktarArukiadasValasztottVevo.Clear();
                textBoxRaktarArukiadasTermekEgyediAzonosito.Clear();
                textBoxRaktarArukiadasTermekNeve.Clear();
                textBoxRaktarArukiadasSzallitoSorszam.Clear();
                MessageBox.Show("A szállítólevél rögzítésre került!");
                
            }

        }

        private void buttonRaktarSzallitolevelMegsem_Click(object sender, EventArgs e)
        {

            if (dataGridViewRaktarArukiadasSzallitolevelTermekLista.Rows.Count != 0)//ha a szállítólevél lista tartalmaz még adatokat
            {
                MessageBox.Show("Kérem törölje ki a szállítólevél listáról az összes felvitt adatot!");
            }
            else
            {
                dataGridViewRaktarArukiadasVevoValasztas.Enabled = true;
                dataGridViewRaktarArukiadasTermekValasztas.Enabled = false;
                dataGridViewRaktarArukiadasSzallitolevelTermekLista.DataSource = null;
                //dataGridViewRaktarArukiadasSzallitoSorszam.DataSource = null;
                textBoxRaktarArukiadasValasztottVevoAzonosito.Clear();
                textBoxRaktarArukiadasValasztottVevo.Clear();
                textBoxRaktarArukiadasTermekEgyediAzonosito.Clear();
                textBoxRaktarArukiadasTermekNeve.Clear();
                textBoxRaktarArukiadasSzallitoSorszam.Clear();
            }
        }
    }


}
