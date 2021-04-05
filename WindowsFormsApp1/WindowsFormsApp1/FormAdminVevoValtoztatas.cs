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
    public partial class FormAdminVevo : Form
    {

        String eleresiAdatok;
        MySqlConnection kapcsolat;
        //regex egyeztetéshez létrehozott változók
        Regex adoszamEgyezes = new Regex("^[0-9]{8}$");
        Regex vevoNeveEgyezes = new Regex("^[a-zA-ZÁáÉéÍíÓóÚúÖöÜüŐőŰű]*$");
        Regex lakcimEgyezes = new Regex("^[0-9a-zA-ZÁáÉéÍíÓóÚúÖöÜüŐőŰű]*$");

        public FormAdminVevo()
        {
            InitializeComponent();
        }

        public void MysqlKapcsolatLetrehozas()
        {
            eleresiAdatok = "datasource = localhost; Database = szf43koszegikaroly; username = root; password =";
            kapcsolat = new MySqlConnection(eleresiAdatok);
            kapcsolat.Open();
        }

        public void tablafeltoltesMySqlParanccsalVevokTabla()//vevőadatok a törzsből lekérés -- vevő adattábla
        {
            DataTable dtNyitotabla = new DataTable();
            MySqlCommand listakeszit = new MySqlCommand("SELECT * from vevok", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
            if (dtNyitotabla.Rows.Count > 0)
            {
                dataGridViewAdminVevoModositas.DataSource = dtNyitotabla;
            }
        }


        private void FormAdminVevo_Load(object sender, EventArgs e)//betöltési esemény
        {
            MysqlKapcsolatLetrehozas();

            tablafeltoltesMySqlParanccsalVevokTabla();

            panelAdminVevoVáltoztatas.Visible = true;

            dataGridViewAdminVevoModositas.Visible = true;

            groupBoxAdminVevoHozzaadas.Visible = true; ;

            groupBoxAdminVevoModositas.Visible = true;

            groupBoxAdminVevoTorles.Visible = true;

            buttonVevoModositoMezokTorlése.Visible = true;

            buttonVevoValtoztatoVegrehajto.Visible = true;

            buttonAdminVevoKilepes.Visible = true;
        }



        private void buttonAdminVevoKilepes_Click(object sender, EventArgs e)//kilépés anyitó belépő oldalra
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


        private void buttonVevoValtoztatoVegrehajto_Click(object sender, EventArgs e)//módosító gomb!!!
        {
            if (textBoxAdminNevModositas.Text == "" || textBoxAdminLakcimModositas.Text == "" || textBoxAdminAdoszamModositas.Text == "")
            {
                MessageBox.Show("Kérem töltse ki az összes mezőt!");//mezőkitöltés vizsgálata
            }

            //adja hozzá az adott mezőben levő termékadatokat, amit újonnan megadtunk ha a következő kritériumoknak megfelel
            //textBoxAdminNevModositas.Text csak ékezetes betűk szerepelhetnek benne és szóköz ^[a-zA-ZÁáÉéÍíÓóÚúÖöÜüŐőŰű ]$
            //textBoxAdminLakcimModositas.Text irányitószám 1234számjegy, ékezetes betűk, számok, szóköz
            //textBoxAdminAdoszamModositas.Text 8db szám csak ^[0-9]{8}$

            else
            {
              
                    textBoxAdminNevModositas.Text.Trim();
                    string[] szavak1 = textBoxAdminNevModositas.Text.Split(' ');
                    bool hibasSzoveg1 = false;
                   
                    foreach (var db1 in szavak1)
                    {

                        if (!vevoNeveEgyezes.IsMatch(db1))
                        {
                        hibasSzoveg1 = true;
                        }

                    }

                if (hibasSzoveg1)
                {
                    MessageBox.Show("Nem megfelelő vevőnév beviteli formátum! A vevőnév mezőben csak  szóközzel ellátott megnevezés engedélyezett! Írásjel, szám , egyéb karakter használata nem lehetséges! ");
                    textBoxAdminNevModositas.Focus();
                    //textBoxAdminNevModositas.Clear(); 
                }

                else
                {
                    //ide kell lakcím egyezés levédése!!!
                    textBoxAdminLakcimModositas.Text.Trim();
                    string[] szavak2 = textBoxAdminLakcimModositas.Text.Split(' ');
                    bool hibasSzoveg2 = false;

                    foreach (var db2 in szavak2)
                    {
                        
                        if (!lakcimEgyezes.IsMatch(db2))
                        {
                            hibasSzoveg2 = true;
                        }
                    }

                    if (hibasSzoveg2)
                    {
                        MessageBox.Show("Nem megfelelő lakcím beviteli formátum! A lakcím mezőben  következő formátum engedélyezett: Irányítószám település közterület házszám! ");
                        textBoxAdminLakcimModositas.Focus();
                        //textBoxAdminLakcimModositas.Clear(); 
                    }

                    else if (!adoszamEgyezes.IsMatch(textBoxAdminAdoszamModositas.Text))
                    {

                        MessageBox.Show("Nem megfelelő adószám beviteli formátum! A cikkszám mezőben csak  a következő formátum megengedett: 8db azonosító számjegy (adószám)!  ");
                        textBoxAdminAdoszamModositas.Focus();
                        //textBoxAdminAdoszamModositas.Clear();
                    }
                    else
                    {
                        string updateQuery = "UPDATE vevok SET vevo_neve ='" + textBoxAdminNevModositas.Text + "', vevo_cime = '" + textBoxAdminLakcimModositas.Text + "', vevo_adoszam = '" + textBoxAdminAdoszamModositas.Text + "' WHERE vevo_azonosito = '" + textBoxAdminVevoAzonositoModosito.Text + "'";

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
                                textBoxAdminVevoAzonositoModosito.Clear();
                                textBoxAdminNevModositas.Clear();
                                textBoxAdminLakcimModositas.Clear();
                                textBoxAdminAdoszamModositas.Clear();
                                textBoxAdminVevoAzonositoTorles.Clear();
                                textBoxAdminNevTorles.Clear();
                                textBoxAdminLakcimTorles.Clear();
                                textBoxAdminAdoszamTorles.Clear();
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
                        dataGridViewAdminVevoModositas.Refresh();
                        dataGridViewAdminVevoModositas.Update();
                        tablafeltoltesMySqlParanccsalVevokTabla();//frissített adatok letöltése az adatbázisból
                        kapcsolat.Close();
                    }

                }
            }
        }


        private void buttonVevoModositoMezokTorlése_Click(object sender, EventArgs e)//mezők kiürítése másik választáshoz
        {
            textBoxAdminNevHozzaadas.Clear();
            textBoxAdminLakcimHozzaadas.Clear();
            textBoxAdminAdoszamHozzaadas.Clear();
            textBoxAdminNevTorles.Clear();
            textBoxAdminAdoszamTorles.Clear();
            textBoxAdminLakcimTorles.Clear();
            textBoxAdminNevModositas.Clear();
            textBoxAdminAdoszamModositas.Clear();
            textBoxAdminLakcimModositas.Clear();
            textBoxAdminVevoAzonositoModosito.Clear();
            textBoxAdminVevoAzonositoTorles.Clear();
        }

       

        private void felhasználónévÉsJelszóVáltoztatásaToolStripMenuItem_Click(object sender, EventArgs e)
        {//fh és jelszóváltoztatás menüsorra kattintva megjelenik a felhasználónév és jelszómódosító form
            this.Hide();
            new FormAdmin().ShowDialog();
        }


        private void termékAdatokVáltoztatásaToolStripMenuItem_Click(object sender, EventArgs e)
        {//termék adatváltoztatás menüsorra kattintva megjelenik a termék módosító form
            this.Hide();
            new FormadminTermek().ShowDialog();
        }

        private void dataGridViewAdminVevoModositas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cellakattintásra a textboxokban megjelennek a kattintott cella sorai
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewAdminVevoModositas.Rows[e.RowIndex];

                textBoxAdminVevoAzonositoModosito.Text = row.Cells[0].Value.ToString();
                textBoxAdminVevoAzonositoTorles.Text = row.Cells[0].Value.ToString();
                textBoxAdminNevModositas.Text = row.Cells[1].Value.ToString();
                textBoxAdminNevTorles.Text = row.Cells[1].Value.ToString();
                textBoxAdminLakcimModositas.Text = row.Cells[2].Value.ToString();
                textBoxAdminLakcimTorles.Text = row.Cells[2].Value.ToString();
                textBoxAdminAdoszamModositas.Text = row.Cells[3].Value.ToString();
                textBoxAdminAdoszamTorles.Text = row.Cells[3].Value.ToString();

            }
        }

        private void buttonAdminVevoHozzaadas_Click(object sender, EventArgs e)
        {
          if (textBoxAdminNevHozzaadas.Text == "" || textBoxAdminLakcimHozzaadas.Text == "" || textBoxAdminAdoszamHozzaadas.Text == "")
          {
                MessageBox.Show("Kérem töltse ki az összes mezőt!");//minden mező kitöltés vizsgálata
          }
          else
            {//adja hozzá az adott mezőben levő termékadatokat, amit újonnan megadtunk ha a következő kritériumoknak megfelel
             //textBoxAdminNevHozzaadas.Text csak ékezetes betűk szerepelhetnek benne és szóköz ^[a-zA-ZÁáÉéÍíÓóÚúÖöÜüŐőŰű ]$
             //textBoxAdminLakcimHozzaadas.Text irányitószám 1234számjegy, ékezetes betűk, számok, szóköz
             //textBoxAdminAdoszamHozzaadas.Text 8db szám csak ^[0-9]{8}$

                textBoxAdminNevHozzaadas.Text.Trim();
                string[] szavak1 = textBoxAdminNevHozzaadas.Text.Split(' ');
                bool hibasSzoveg1 = false;

                foreach (var db1 in szavak1)
                {

                    if (!vevoNeveEgyezes.IsMatch(db1))
                    {
                        hibasSzoveg1 = true;
                    }
                }

                if (hibasSzoveg1)
                {
                    MessageBox.Show("Nem megfelelő vevőnév beviteli formátum! A vevőnév mezőben csak  szóközzel ellátott megnevezés engedélyezett! Írásjel, szám , egyéb karakter használata nem lehetséges! ");
                    textBoxAdminNevHozzaadas.Focus();
                    //textBoxAdminNevHozzaadas.Clear();
                }

                else
                {
                    textBoxAdminLakcimHozzaadas.Text.Trim();
                    string[] szavak2 = textBoxAdminLakcimHozzaadas.Text.Split(' ');
                    bool hibasSzoveg2 = false;

                    foreach (var db2 in szavak2)
                    {

                        if (!lakcimEgyezes.IsMatch(db2))
                        {
                            hibasSzoveg2 = true;
                        }
                    }

                    if (hibasSzoveg2)
                    {
                        MessageBox.Show("Nem megfelelő lakcím beviteli formátum! A lakcím mezőben  következő formátum engedélyezett: Irányítószám település közterület házszám! ");
                        textBoxAdminLakcimHozzaadas.Focus();
                        //textBoxAdminLakcimHozzaadas.Clear(); 
                    }

                    else if (!adoszamEgyezes.IsMatch(textBoxAdminAdoszamHozzaadas.Text))
                    {
                        MessageBox.Show("Nem megfelelő adószám beviteli formátum! A cikkszám mezőben csak  a következő formátum megengedett: 8db azonosító számjegy (adószám)!  ");
                        textBoxAdminAdoszamHozzaadas.Focus();
                        //textBoxAdminAdoszamHozzaadas.Clear();

                    }

                    else
                    {

                        string insertQuery = "INSERT INTO vevok VALUES(null,'" + textBoxAdminNevHozzaadas.Text + "','" + textBoxAdminLakcimHozzaadas.Text + "', '" + textBoxAdminAdoszamHozzaadas.Text + "')";//shift 1 2 3 adat shift 3 2 1, ez a formátum!!!!!!!
                        if (kapcsolat.State != ConnectionState.Open)//kapcsolat megnyitása, ha le van zárva
                        {
                            kapcsolat.Open();
                        }
                        MySqlCommand beszuras = new MySqlCommand(insertQuery, kapcsolat);
                        try
                        {
                            if (beszuras.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Adatok rögzítve!");
                                textBoxAdminNevHozzaadas.Clear();
                                textBoxAdminLakcimHozzaadas.Clear();
                                textBoxAdminAdoszamHozzaadas.Clear();
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
                        dataGridViewAdminVevoModositas.Refresh();
                        dataGridViewAdminVevoModositas.Update();
                        tablafeltoltesMySqlParanccsalVevokTabla();
                        kapcsolat.Close();
                    }
                }

          }
        }
		
		
        private void buttonAdminVevoTorles_Click(object sender, EventArgs e)//vevő törlése
        {
            string deleteQuery = "DELETE FROM vevok WHERE vevo_azonosito ='" + textBoxAdminVevoAzonositoTorles.Text + "'";
            try
            {
                if (kapcsolat.State != ConnectionState.Open)
                {
                    kapcsolat.Open();
                }
                MySqlCommand command = new MySqlCommand(deleteQuery, kapcsolat);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("A partner törölve");
                    textBoxAdminVevoAzonositoModosito.Clear();
                    textBoxAdminNevModositas.Clear();
                    textBoxAdminLakcimModositas.Clear();
                    textBoxAdminAdoszamModositas.Clear();
                    textBoxAdminVevoAzonositoTorles.Clear();
                    textBoxAdminNevTorles.Clear();
                    textBoxAdminLakcimTorles.Clear();
                    textBoxAdminAdoszamTorles.Clear();
                }
                else
                {
                    MessageBox.Show("A partner nem került törlésre!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewAdminVevoModositas.Refresh();
            dataGridViewAdminVevoModositas.Update();
            tablafeltoltesMySqlParanccsalVevokTabla();
            kapcsolat.Close();
        }
    }
}
