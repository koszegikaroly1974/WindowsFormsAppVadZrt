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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class FormadminTermek : Form
    {
        String eleresiAdatok;
        MySqlConnection kapcsolat;
        //regex egyeztetéshez létrehozott változók
        Regex cikkszamEgyezes = new Regex("^SVK[0-9]{6}$");
        Regex termekNevEgyezes = new Regex("^[a-zA-ZÁáÉéÍíÓóÚúÜüŰű]*$");

        public FormadminTermek()
        {
            InitializeComponent();
        }

        public void MysqlKapcsolatLetrehozas()//mysql kapcsolat létrehozása
        {

            eleresiAdatok = "datasource = localhost; Database = szf43koszegikaroly; username = root; password =";
            kapcsolat = new MySqlConnection(eleresiAdatok);
            kapcsolat.Open();
        }

        public void tablafeltoltesMySqlParanccsalTermekTabla()//terméktábla törzs feltöltése
        {
            DataTable dtNyitotabla = new DataTable();
            MySqlCommand listakeszit = new MySqlCommand("SELECT cikkszam, termek_neve, mennyisegi_egyseg_1, mennyisegi_egyseg_2 from termek", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
            if (dtNyitotabla.Rows.Count > 0)
            {
                dataGridViewadminTermekValtoztatas.DataSource = dtNyitotabla;

            }
        }

        /*public void termeknevHozzaadasElemzes()
        {
            textBoxTermekHozzaadasNeve.Text.Trim();
            string[] szavak1 = textBoxTermekHozzaadasNeve.Text.Split(' ');
            int szavak1Hossz = 0;
           
                foreach (var db1 in szavak1)
                {
                  szavak1Hossz++;
                    if (!termekNevEgyezes.IsMatch(db1))
                    {
                        MessageBox.Show("Nem megfelelő terméknév beviteli formátum! A terméknév mezőben csak  szóközzel ellátott megnevezés engedélyezett! Írásjel, szám , egyéb karakter használata nem lehetséges! ");
                        textBoxTermekHozzaadasNeve.Focus();
                        szavak1Hossz = 0;
                        //textBoxTermekHozzaadasNeve.Clear(); 
                    }

                }
           
        }*/

        /*public void termeknevModositasElemzes()
        {
            textBoxTermekModositNeve.Text.Trim();
            string[] szavak2 = textBoxTermekModositNeve.Text.Split(' ');
            foreach (var db2 in szavak2)
            {
                if (!termekNevEgyezes.IsMatch(db2))
                {
                    MessageBox.Show("Nem megfelelő terméknév beviteli formátum! A terméknév mezőben csak  szóközzel ellátott megnevezés engedélyezett! Írásjel, szám , egyéb karakter használata nem lehetséges! ");
                    textBoxTermekHozzaadasNeve.Focus();
                    //textBoxTermekHozzaadasNeve.Clear(); 
                }
            }
        }*/

        private void Form5_Load(object sender, EventArgs e)//form betöltési eseménye
        {
            MysqlKapcsolatLetrehozas();

            tablafeltoltesMySqlParanccsalTermekTabla();

            panelAdminTermekValtoztatas.Visible = true;//egyes elemek láthatóvá tétele

            dataGridViewadminTermekValtoztatas.Visible = true;

            groupBoxAdminTermekHozzaadas.Visible = true; ;

            groupBoxadminTermekModositas.Visible = true;

            groupBoxadminTermekTorles.Visible = true;

            buttontermekModositoMezokTorlese.Visible = true;

            buttonAdminTermekModosito.Visible = true;

            buttonAdminTermekKilepes.Visible = true;
        }




        private void buttontermekModositoMezokTorlese_Click(object sender, EventArgs e)//termékmódosító mezők kiürítése gomb
        {
            textBoxtermekHozzaadasCikkszam.Clear();
            textBoxTermekHozzaadasNeve.Clear();
            textBoxTermekHozzaadasME1.Clear();
            textBoxTermekHozzaadasME2.Clear();
            textBoxtermekTorlesCikkszam.Clear();
            textBoxTermekTorlesNeve.Clear();
            textBoxTermekTorlesME1.Clear();
            textBoxTermekTorlesME2.Clear();
            textBoxtermekModositCikkszam.Clear();
            textBoxTermekModositNeve.Clear();
            textBoxTermekModositasME1.Clear();
            textBoxTermekModositasME2.Clear();
        }

       

        private void buttonAdminTermekKilepes_Click(object sender, EventArgs e)//adminformból kilépés  a nyitó belépő oldalra
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


        private void felhasználónévÉsJelszóVáltoztatásaToolStripMenuItem_Click(object sender, EventArgs e)//Fh és jelszó menüre kattintva
        {
            this.Hide();
            new FormAdmin().ShowDialog();//alap belépő admin formra lépés
        }

        

        private void vevőAdatokVáltoztatásaToolStripMenuItem_Click_1(object sender, EventArgs e)//vevőadatok menüre kattintva
        {
            this.Hide();
            new FormAdminVevo().ShowDialog();//vevő formra lépés
        }


        private void dataGridViewadminTermekValtoztatas_CellClick(object sender, DataGridViewCellEventArgs e)
        {//termék adattáblára kattintva feltölti a módosító és törlő mezőket a cella értékeivel
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewadminTermekValtoztatas.Rows[e.RowIndex];
                textBoxtermekTorlesCikkszam.Text = row.Cells[0].Value.ToString();
                textBoxTermekTorlesNeve.Text = row.Cells[1].Value.ToString();
                textBoxTermekTorlesME1.Text = row.Cells[2].Value.ToString();
                textBoxTermekTorlesME2.Text = row.Cells[3].Value.ToString();
                textBoxtermekModositCikkszam.Text = row.Cells[0].Value.ToString();
                textBoxTermekModositNeve.Text = row.Cells[1].Value.ToString();
                textBoxTermekModositasME1.Text = row.Cells[2].Value.ToString();
                textBoxTermekModositasME2.Text = row.Cells[3].Value.ToString();
            }
        }


        private void buttonAdminTermekModosito_Click(object sender, EventArgs e)//módosító gombra kattintva a mezőkben lévő értékekkel frissíti a termék törzs adttáblát
        {
            if (textBoxtermekModositCikkszam.Text == "" || textBoxTermekModositNeve.Text == "" || textBoxTermekModositasME1.Text == "" || textBoxTermekModositasME2.Text == "")
            {
                MessageBox.Show("Kérem töltse ki az összes mezőt!");
            }

            else
            {
                //textBoxTermekModositasME1 csak kg vagy db lehet
                //textBoxTermekModositasME2 csak karton 
                //textBoxtermekModositCikkszam SVK020202 csak ez szerepelhet benne SVK és 6db szám  ^SVK.[0-9]{6}$
                //textBoxTermekModositNeve csak ékezetes betűk szerepelhetnek benne és szóköz ^[a-zA-ZÁáÉéÍíÓóÚúÖöÜüŐőŰű ]$

                textBoxTermekModositNeve.Text.Trim();
                string[] szavak1 = textBoxTermekModositNeve.Text.Split(' ');
                bool hibasSzoveg1 = false;
                foreach (var db1 in szavak1)
                {
                    if (hibasSzoveg1)
                    {
                        hibasSzoveg1 = true;
                    }
                }

                if (hibasSzoveg1)
                {
                    MessageBox.Show("Nem megfelelő terméknév beviteli formátum! A terméknév mezőben csak  szóközzel ellátott megnevezés engedélyezett! Írásjel, szám , egyéb karakter használata nem lehetséges! ");
                    textBoxTermekModositNeve.Focus();
                    //textBoxTermekHozzaadasNeve.Clear();
                }

                else
                {
                    if (!cikkszamEgyezes.IsMatch(textBoxtermekModositCikkszam.Text))
                    {
                        MessageBox.Show("Nem megfelelő cikkszámbeviteli formátum! A cikkszám mezőben csak  a következő formátum megengedett: SVK után szóköz nélkül 6db azonosító számjegy (például SVK010101)!  ");
                        textBoxtermekModositCikkszam.Focus();
                        //textBoxtermekModositCikkszam.Clear();
                    }
                    else if (textBoxTermekModositasME1.Text != "kg" && textBoxTermekModositasME1.Text != "db")
                    {
                        MessageBox.Show("A mennyiségi egység 1 mezőben csak  kg vagy db szerepelhet! ");
                        textBoxTermekModositasME1.Focus();
                        //textBoxTermekModositasME1.Clear();
                    }
                    else if (textBoxTermekModositasME2.Text != "karton")
                    {
                        MessageBox.Show("A mennyiségi egység 2 mezőben csak  karton szerepelhet! ");
                        textBoxTermekModositasME2.Focus();
                        //textBoxTermekModositasME2.Clear();
                    }

                    else
                    {

                        string updateQuery = "UPDATE termek SET cikkszam ='" + textBoxtermekModositCikkszam.Text + "', termek_neve = '" + textBoxTermekModositNeve.Text + "', mennyisegi_egyseg_1 = '" + textBoxTermekModositasME1.Text + "', mennyisegi_egyseg_2 = '" + "karton" + "' WHERE cikkszam = '" + textBoxtermekModositCikkszam.Text + "'";

                        if (kapcsolat.State != ConnectionState.Open)
                        {
                            kapcsolat.Open();
                        }

                        try
                        {
                            MySqlCommand frissites = new MySqlCommand(updateQuery, kapcsolat);
                            if (frissites.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Adatok frissítve");
                                //cellatörlések
                                textBoxTermekTorlesNeve.Clear();
                                textBoxtermekTorlesCikkszam.Clear();
                                textBoxTermekTorlesME1.Clear();
                                textBoxTermekTorlesME2.Clear();
                                textBoxtermekModositCikkszam.Clear();
                                textBoxTermekModositNeve.Clear();
                                textBoxTermekModositasME1.Clear();
                                textBoxTermekModositasME2.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Adatok frissítése eredménytelen");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        dataGridViewadminTermekValtoztatas.Refresh();//frisssítés
                        dataGridViewadminTermekValtoztatas.Update();
                        tablafeltoltesMySqlParanccsalTermekTabla();//feltölti a táblát a frissített adatokkal
                        kapcsolat.Close();
                    }
                }

            }
        
        }


        private void buttonAdminTermekTorles_Click(object sender, EventArgs e) // terméktörlő gombra kattintva
        {//törli a kiválasztott cikkszámú terméket, itt a törzsben a cikkszám egy terméket jelöl alapadatokkal!!
            string deleteQuery = "DELETE FROM termek WHERE cikkszam ='" + textBoxtermekTorlesCikkszam.Text + "'";
            try
            {
                if (kapcsolat.State != ConnectionState.Open)
                {
                    kapcsolat.Open();
                }
                MySqlCommand command = new MySqlCommand(deleteQuery, kapcsolat);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("A termék törölve");
                    //cellák kiürítése
                    textBoxTermekTorlesNeve.Clear();
                    textBoxtermekTorlesCikkszam.Clear();
                    textBoxTermekTorlesME1.Clear();
                    textBoxTermekTorlesME2.Clear();
                    textBoxtermekModositCikkszam.Clear();
                    textBoxTermekModositNeve.Clear();
                    textBoxTermekModositasME1.Clear();
                    textBoxTermekModositasME2.Clear();
                }
                else
                {
                    MessageBox.Show("A termék nem került törlésre!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridViewadminTermekValtoztatas.Refresh();//frissítés
            dataGridViewadminTermekValtoztatas.Update();
            tablafeltoltesMySqlParanccsalTermekTabla();//adattábla feltöltése a friss adatokkal az adatbázisból
            kapcsolat.Close();
        }



        private void buttonAdminTermekHozzaadas_Click(object sender, EventArgs e)//új termék hozzáadása a törzshöz
        {//csak akkor adja hozzá, ha minden mező ki van töltve
            if (textBoxtermekHozzaadasCikkszam.Text == "" || textBoxTermekHozzaadasNeve.Text == "" || textBoxTermekHozzaadasME1.Text == "" || textBoxTermekHozzaadasME2.Text == "")
            {
                MessageBox.Show("Kérem töltse ki az összes mezőt!");
            }

            else
            {//adja hozzá az adott mezőben levő termékadatokat, amit újonnan megadtunk ha a következő kritériumoknak megfelel
             //textBoxTermekHozzaadasME1 csak kg vagy db lehet
             //textBoxTermekHozzaadasME2 csak karton  lehet
             //textBoxtermekHozzaadasCikkszam SVK020202 csak ez szerepelhet benne SVK és 6db szám ^SVK.[0-9]{6}$
             //textBoxTermekHozzaadasNeve csak ékezetes betűk szerepelhetnek benne és szóköz ^[a-zA-ZÁáÉéÍíÓóÚúÖöÜüŐőŰű ]$


                if (!cikkszamEgyezes.IsMatch(textBoxtermekHozzaadasCikkszam.Text))
                {
                    MessageBox.Show("Nem megfelelő cikkszámbeviteli formátum! A cikkszám mezőben csak  a következő formátum megengedett: SVK után szóköz nélkül 6db azonosító számjegy (például SVK010101)!  ");
                    textBoxtermekHozzaadasCikkszam.Focus();
                    //textBoxtermekHozzaadasCikkszam.Clear();
                }

                else 
                {
                    textBoxTermekHozzaadasNeve.Text.Trim();
                    string[] szavak2 = textBoxTermekHozzaadasNeve.Text.Split(' ');
                    bool hibasSzoveg2 = false;


                    foreach (var db2 in szavak2)
                    {
                        if (!termekNevEgyezes.IsMatch(db2))
                        {
                            hibasSzoveg2 = true;
                        }
                    }

                    if (hibasSzoveg2)
                    {
                        MessageBox.Show("Nem megfelelő terméknév beviteli formátum! A terméknév mezőben csak  szóközzel ellátott megnevezés engedélyezett! Írásjel, szám , egyéb karakter használata nem lehetséges! ");
                        textBoxTermekHozzaadasNeve.Focus();
                        //textBoxTermekHozzaadasNeve.Clear(); 
                    }
                    else if (textBoxTermekHozzaadasME1.Text != "kg" && textBoxTermekHozzaadasME1.Text != "db")
                    {
                        MessageBox.Show("A mennyiségi egység 1 mezőben csak  kg vagy db szerepelhet! ");
                        textBoxTermekHozzaadasME1.Focus();
                        //textBoxTermekHozzaadasME1.Clear();
                    }
                    else if (textBoxTermekHozzaadasME2.Text != "karton")
                    {
                        MessageBox.Show("A mennyiségi egység 2 mezőben csak  karton szerepelhet! ");
                        textBoxTermekHozzaadasME2.Focus();
                        //textBoxTermekHozzaadasME2.Clear();
                    }

                    else
                    {
                        string insertQuery = "INSERT INTO termek VALUES('" + textBoxtermekHozzaadasCikkszam.Text + "','" + textBoxTermekHozzaadasNeve.Text + "','" + textBoxTermekHozzaadasME1.Text + "', '" + textBoxTermekHozzaadasME2.Text + "')";//shift 1 2 3 adat shift 3 2 1, ez a formátum!!!!!!!
                        if (kapcsolat.State != ConnectionState.Open)
                        {
                            kapcsolat.Open();
                        }
                        MySqlCommand beszuras = new MySqlCommand(insertQuery, kapcsolat);
                        try
                        {
                            if (beszuras.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Adatok rögzítve!");
                                //ide írni a cellatörléseket
                                textBoxtermekHozzaadasCikkszam.Clear();
                                textBoxTermekHozzaadasNeve.Clear();
                                textBoxTermekHozzaadasME1.Clear();
                                textBoxTermekHozzaadasME2.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Adatok rögzítése nem valósult meg!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        dataGridViewadminTermekValtoztatas.Refresh();//frissítés
                        dataGridViewadminTermekValtoztatas.Update();
                        tablafeltoltesMySqlParanccsalTermekTabla();//frissített aadtbázis adatok feltöltése a táblába

                        kapcsolat.Close();
                    }

                }

            }
        }
    }
}
    

