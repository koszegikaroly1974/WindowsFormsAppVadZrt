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
    public partial class FormNyito : Form
    {

        //globális változók létrehozása a kapcsolat felépítéséhez
        String eleresiAdatok;
        MySqlConnection kapcsolat;

        public FormNyito()
        {
            InitializeComponent();
        }

        public void MysqlKapcsolatLetrehozas()//adatbáziskapcsolat felépítése
        {

            eleresiAdatok = "datasource = localhost; Database = szf43koszegikaroly; username = root; password =";
            kapcsolat = new MySqlConnection(eleresiAdatok);
            kapcsolat.Open();
           
        }

        private void FormNyito_Load(object sender, EventArgs e)//nyitó form betöltés eseményei
        {

            /*
            Screen scr = Screen.PrimaryScreen;
            this.Left = (scr.Bounds.Width – this.Bounds.Width) / 2;
            this.Top = (scr.WorkingArea.Height – this.Height) / 2;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Bounds.Width;
            this.Top = Screen.PrimaryScreen.Bounds.Height - this.Bounds.Height;
            SetDesktopLocation(Left, Top);*/
            this.StartPosition = FormStartPosition.CenterScreen;

            try//kapcsolat felépítési kísérlet
            {

                MysqlKapcsolatLetrehozas();
            }
            catch (Exception)//hiba esetén azaz nem sikerült a kapcsolat felépítése
            {

                MessageBox.Show("Nincs kapcsolat a MySql szerverrel! " +
                     " Indítsa el a MySql kapcsolatot a program indítása előtt!");
                Dispose();
            }
            finally//mindenképppen hajtsa végre, akkor is ha nincs kapcsolat
            {
                if (kapcsolat.State == ConnectionState.Open)
                {
                    label1BelepesJelzo.Text = "Kapcsolódva";//kapcsolatjelző cimkék megjelenése
                    label1BelepesJelzo.BackColor = Color.LimeGreen;
                    label1BelepesJelzo.ForeColor = Color.Yellow;
                }

                else
                {
                    label1BelepesJelzo.Text = "Nincs kapcsolat";//kapcsolatjelző cimkék megjelenése
                    label1BelepesJelzo.BackColor = Color.Red;
                    label1BelepesJelzo.ForeColor = Color.Yellow;
                    
                }
            }

        }

        private void buttonKilépés_Click(object sender, EventArgs e)
        {
            //kilépés megerősítése MessageBox segítségével
           Form parbeszedAblak = new Form();
           DialogResult dialog = MessageBox.Show("Biztosan be akarja zárni a programot?", "Kilépés" , MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
               Application.Exit();//kilépés a programból, erőforrások felszabadítása
            }
            else if(dialog == DialogResult.No)
            {
                parbeszedAblak.Dispose();
            }
        }


        private void buttonBelépés_Click(object sender, EventArgs e)//belépés gomb lenyomásakor
        {
			
			     MysqlKapcsolatLetrehozas();
            //belépés beviteli mezők vizsgálata
               
                 if (comboBoxreszlegNeve.Text =="" || textBoxfelhasznaloNev.Text == "" || textBoxjelszo.Text == "")//minden mező kitöltésre kerüljön
                 {
                     MessageBox.Show("Kérem töltse ki az összes mezőt!");//ha valamelyik mező üres
                     comboBoxreszlegNeve.Focus();//kerüljön a fókusz az első mezőre

                 }
                 else if (comboBoxreszlegNeve.Text != "termelés" && comboBoxreszlegNeve.Text != "raktár" && comboBoxreszlegNeve.Text != "admin")//csak a három ágazat szerepeljen
                 {
                    MessageBox.Show("Kérem a felsoroltakból válasszon !");//ha valamelyik mező üres
                    comboBoxreszlegNeve.Focus();//kerüljön a fókusz az első mezőre

                 }


                 else
                 {
                    string reszlegNeve = Convert.ToString(comboBoxreszlegNeve.Text);//első beviteli mező, ágazat
                    string jelszoEllenorzes = titkositas.SHA5Hash(textBoxjelszo.Text);//beviteli adatból generáljon egy titkosított jelszót
                   if (kapcsolat.State == ConnectionState.Open)
                    {

                        if (reszlegNeve == "termelés")//ágazat beviteli mező vizsgálata
                        {
                           MysqlKapcsolatLetrehozas();
                        //jelszóbevitel helyességének ellenőrzése a jelszó táblából
                         
                         string sqlLekerdezes = "SELECT jelszo from jelszo WHERE felhasznalonev = '" + textBoxfelhasznaloNev.Text.Trim() + "' AND jelszo = '" + jelszoEllenorzes + "'AND agazat = '" + "termelés"+ "'";//kérdezze le az adatbázisból a jelszót, ahol a fhnev és az ágazat egyezik
                         MySqlDataAdapter mysqlAdatAtalakito = new MySqlDataAdapter(sqlLekerdezes, eleresiAdatok);
                         DataTable adatTabla = new DataTable();//adattábla nevű adattábla létrehozása
                         mysqlAdatAtalakito.Fill(adatTabla);//adattáblába feltölti a lehetséges találatokat
                        
                         if (adatTabla.Rows.Count == 1)
                         {

                             this.Hide();
                             kapcsolat.Close();
                             new FormTermeles().ShowDialog();//ha megfelelő a termeléshez tartozó jelszó, akkor lépjen a termelés lapra
                         }

                         else
                         {
                             MessageBox.Show("Nem megfelelő felhasználónév illetve jelszó!");
                             comboBoxreszlegNeve.Focus();//lépjen a részleg első mezőre
                             textBoxfelhasznaloNev.Clear();//ürítse ki az összes mezőt
                             textBoxjelszo.Clear();
                         }
                         kapcsolat.Close();
                        }

                        else if (reszlegNeve == "raktár")//ágazat beviteli mező vizsgálata
                        {
                            MysqlKapcsolatLetrehozas();

                            //jelszóbevitel helyességének ellenőrzése a jelszó táblából
                            string sqlLekerdezes = "SELECT * from jelszo WHERE felhasznalonev = '" + textBoxfelhasznaloNev.Text.Trim() + "' AND jelszo = '" + jelszoEllenorzes + "'AND agazat = '" + "raktár" + "'";
                            MySqlDataAdapter mysqlAdatAtalakito = new MySqlDataAdapter(sqlLekerdezes, eleresiAdatok);
                            DataTable adatTabla = new DataTable();
                            mysqlAdatAtalakito.Fill(adatTabla);
                            if (adatTabla.Rows.Count == 1)
                            {
                                this.Hide();
                                kapcsolat.Close();
                                new FormRaktar().ShowDialog();//ha megfelelő a raktárhoz tartozó jelszó,akkor lépjen a raktár lapra
                            }

                            else
                            {
                                MessageBox.Show("Nem megfelelő felhasználónév illetve jelszó!");
                                comboBoxreszlegNeve.Focus();
                                textBoxfelhasznaloNev.Clear();
                                textBoxjelszo.Clear();													
                            }
                           kapcsolat.Close();

                        }

                        else if (reszlegNeve == "admin")//ágazat beviteli mező vizsgálata
                        {
                            MysqlKapcsolatLetrehozas();

                        //jelszóbevitel helyességének ellenőrzése a jelszó táblából
                            string sqlLekerdezes = "SELECT * from jelszo WHERE felhasznalonev = '" + textBoxfelhasznaloNev.Text.Trim() + "' AND jelszo = '" + jelszoEllenorzes + "'AND agazat = '" + "admin" + "'";
                            MySqlDataAdapter mysqlAdatAtalakito = new MySqlDataAdapter(sqlLekerdezes, eleresiAdatok);
                            DataTable adatTabla = new DataTable();
                            mysqlAdatAtalakito.Fill(adatTabla);
                            if (adatTabla.Rows.Count == 1)
                            {
                                this.Hide();
                                kapcsolat.Close();
                                new FormAdmin().ShowDialog();//ha megfelelő az adminhoz tartozó jelszó, akkor lépjen az admin lapra
                            }

                            else
                            {
                                MessageBox.Show("Nem megfelelő felhasználónév illetve jelszó!");
                                comboBoxreszlegNeve.Focus();
                                textBoxfelhasznaloNev.Clear();
                                textBoxjelszo.Clear();                           
                            }
							
                            kapcsolat.Close();

                        }
                   }
                 }
            
        }


        private void buttonVissza_Click(object sender, EventArgs e)//mégsem gomb megnyomása esetén mezők kiürítése
        {
            comboBoxreszlegNeve.Text = "";
            textBoxfelhasznaloNev.Clear();
            textBoxjelszo.Clear();

        }


        private void buttonSzerverKapcsolatLetrehozas_Click(object sender, EventArgs e)//mysql kapcsolódás rendben van , de adatbázis nem megfelelő
        {
            if (kapcsolat.State != ConnectionState.Open)
            {
                MysqlKapcsolatLetrehozas();
                buttonSzerverKapcsolatLetrehozas.Visible = false;
                buttonSzerverKapcsolatBontas.Visible = false;
                label1BelepesJelzo.Text = "Kapcsolódva";
                label1BelepesJelzo.BackColor = Color.LimeGreen;
                label1BelepesJelzo.ForeColor = Color.Yellow;
            }
        }

        private void buttonSzerverKapcsolatBontas_Click(object sender, EventArgs e)
        {
                kapcsolat.Close();
                buttonSzerverKapcsolatLetrehozas.Visible = false;
                buttonSzerverKapcsolatBontas.Visible = false;
                label1BelepesJelzo.Text = "Nincs kapcsolat";
                label1BelepesJelzo.BackColor = Color.Red;
                label1BelepesJelzo.ForeColor = Color.Yellow;
        }
    }
}