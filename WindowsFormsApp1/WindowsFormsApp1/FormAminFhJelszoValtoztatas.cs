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
    public partial class FormAdmin : Form

    {
        String eleresiAdatok;
        MySqlConnection kapcsolat;

        public FormAdmin()
        {
            InitializeComponent();
        }

        public void MysqlKapcsolatLetrehozas()
        {
            
            eleresiAdatok = "datasource = localhost; Database = szf43koszegikaroly; username = root; password =";
            kapcsolat = new MySqlConnection(eleresiAdatok);
            kapcsolat.Open();
        }

        public void tablafeltoltesMySqlParanccsalJelszoTabla()
        {
            DataTable dtNyitotabla = new DataTable();
            MySqlCommand listakeszit = new MySqlCommand("SELECT * from jelszo", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
            if (dtNyitotabla.Rows.Count > 0)
            {
                dataGridViewadminJelszoModositas.DataSource = dtNyitotabla;
            }
        }

        public void cellakKiuritese()
        {
            textBoxFhJelszoHozzaadAgazat.Clear();
            textBoxFhJelszoHozzaadFh.Clear();
            textBoxFhJelszoHozzaadJelszo.Clear();
            textBoxFhJelszoTorolAgazat.Clear();
            textBoxFhJelszoTorolFh.Clear();
            textBoxFhJelszoTorolJelszo.Clear();
            textBoxFhJelszoModositAgazat.Clear();
            textBoxFhJelszoModositFh.Clear();
            textBoxFhJelszoModositJelszo.Clear();
            textBoxAdminModositJelszoAzonosito.Clear();
            textBoxAdminTorolJelszoAzonosito.Clear();
        }
        private void buttonJelszoModositoCellaTorles_Click(object sender, EventArgs e)//cellamezők kiürítése
        {
            cellakKiuritese();
        }


        private void buttonJelszoValtoztatoVegrehajto_Click(object sender, EventArgs e)//módosítás gomb
        {
            if ((textBoxFhJelszoModositAgazat.Text != "termeles" && textBoxFhJelszoModositAgazat.Text != "raktar" && textBoxFhJelszoModositAgazat.Text != "admin"))
            {
                MessageBox.Show("Kérem megfelelő ágazatot válasszon (termeles, raktar, admin)!");
                textBoxFhJelszoModositAgazat.Clear();
            }

            else
            {

                if (textBoxFhJelszoModositAgazat.Text == "" || textBoxFhJelszoModositFh.Text == "" || textBoxFhJelszoModositJelszo.Text == "" || textBoxAdminModositJelszoAzonosito.Text == "")
                {
                    MessageBox.Show("Kérem minden mezőt töltsön ki!");
                }
                else
                {

                    string updateQuery = "UPDATE jelszo SET agazat ='" + textBoxFhJelszoModositAgazat.Text + "', felhasznalonev = '" + textBoxFhJelszoModositFh.Text + "', jelszo = '" + titkositas.SHA5Hash(textBoxFhJelszoModositJelszo.Text) + "' WHERE jelszo_azon = '" + textBoxAdminModositJelszoAzonosito.Text + "'";

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
                    dataGridViewadminJelszoModositas.Refresh();
                    dataGridViewadminJelszoModositas.Update();
                    tablafeltoltesMySqlParanccsalJelszoTabla();//adatbázisból a frissített adatok beolvasása
                    kapcsolat.Close();

                }
            }
        }



        private void buttonAdminFhJelszoKilepes_Click(object sender, EventArgs e)//kilépés a nyitóoldalra
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



        private void termékAdatokVáltoztatásaToolStripMenuItem_Click(object sender, EventArgs e)//átlépés a termékadataok változtatás formra --menüből
        {
            this.Hide();
            new FormadminTermek().ShowDialog();
        }


        private void vevőAdatokVáltoztatásaToolStripMenuItem_Click_1(object sender, EventArgs e)//átlépés a vevőmódosító formra -- menüből
        {
            this.Hide();
            new FormAdminVevo().ShowDialog();
        }

       

        private void felhasználónévÉsJelszóMódosításaToolStripMenuItem_Click(object sender, EventArgs e)//megfelelők megjelenítése
        {
            panelAdminJelszoHozzaadas.Visible = true;
            groupBoxFelhJelszoTorles.Visible = false;
            groupBoxFelhJelszoModositas.Visible = true;
            groupBoxFelhJelszoHozzaadasa.Visible = false;
            dataGridViewadminJelszoModositas.Visible = true;
        }


        private void felhasználónévÉsJelszóTörléseToolStripMenuItem_Click(object sender, EventArgs e)//megfelelők megjelenítése
        {
            panelAdminJelszoHozzaadas.Visible = true;
            groupBoxFelhJelszoHozzaadasa.Visible = false;
            groupBoxFelhJelszoModositas.Visible = false;
            groupBoxFelhJelszoTorles.Visible = true;
            dataGridViewadminJelszoModositas.Visible = true;
        }


        private void felhasználónévÉsJelszóHozzáadásaToolStripMenuItem_Click(object sender, EventArgs e)//megfelelők megjelenítése
        {
            panelAdminJelszoHozzaadas.Visible = true;
            groupBoxFelhJelszoModositas.Visible = false;
            groupBoxFelhJelszoTorles.Visible = false;
            groupBoxFelhJelszoHozzaadasa.Visible = true;
            dataGridViewadminJelszoModositas.Visible = true;
        }
		

        private void FhnevJelszoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdminJelszoHozzaadas.Visible = true;

            MysqlKapcsolatLetrehozas();

            tablafeltoltesMySqlParanccsalJelszoTabla();
        }
		
		

        private void dataGridViewadminJelszoModositas_CellClick(object sender, DataGridViewCellEventArgs e)//cellaklikkre mezőfeltöltések
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewadminJelszoModositas.Rows[e.RowIndex];
                textBoxAdminModositJelszoAzonosito.Text = row.Cells[0].Value.ToString();
                textBoxAdminTorolJelszoAzonosito.Text = row.Cells[0].Value.ToString();
                textBoxFhJelszoModositAgazat.Text = row.Cells[1].Value.ToString();
                textBoxFhJelszoTorolAgazat.Text = row.Cells[1].Value.ToString();
                textBoxFhJelszoModositFh.Text = row.Cells[2].Value.ToString();
                textBoxFhJelszoTorolFh.Text = row.Cells[2].Value.ToString();
                textBoxFhJelszoModositJelszo.Text = row.Cells[3].Value.ToString();
                textBoxFhJelszoTorolJelszo.Text = row.Cells[3].Value.ToString();
            }
        }


        private void buttonAdminFhJelszoTorles_Click(object sender, EventArgs e)//fh jelszótörlésre kattintva
        {
            string deleteQuery = "DELETE FROM jelszo WHERE jelszo_azon ='" + textBoxAdminTorolJelszoAzonosito.Text + "'";
            try
            {
                if (kapcsolat.State != ConnectionState.Open)
                {
                    kapcsolat.Open();
                }
                MySqlCommand command = new MySqlCommand(deleteQuery, kapcsolat);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("A felhasználónév és jelszó törölve!");
                }
                else
                {
                    MessageBox.Show("A felhasználónév és jelszó nem került törlésre!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewadminJelszoModositas.Refresh();
            dataGridViewadminJelszoModositas.Update();
            tablafeltoltesMySqlParanccsalJelszoTabla();
            cellakKiuritese();
            kapcsolat.Close();
        }



        private void buttonAdminFhJelszoHozzaadas_Click(object sender, EventArgs e)//fh jelszó hozzáadásgomb
        {
            if (textBoxFhJelszoHozzaadAgazat.Text != "termeles" && textBoxFhJelszoHozzaadAgazat.Text != "raktar" && textBoxFhJelszoHozzaadAgazat.Text != "admin")
            {
                MessageBox.Show("Kérem megfelelő ágazatot válasszon (termeles, raktar, admin)!");
                textBoxFhJelszoHozzaadAgazat.Clear();
            }

            else
            {

                if (textBoxFhJelszoHozzaadAgazat.Text == "" || textBoxFhJelszoHozzaadFh.Text == "" || textBoxFhJelszoHozzaadJelszo.Text == "")
                {
                    MessageBox.Show("Kérem minden mezőt töltsön ki!");
                }
                else
                {

                    string insertQuery = "INSERT INTO jelszo VALUES('" + "','" + textBoxFhJelszoHozzaadAgazat.Text + "','" + textBoxFhJelszoHozzaadFh.Text + "', '" + titkositas.SHA5Hash(textBoxFhJelszoHozzaadJelszo.Text) + "')";//shift 1 2 3 adat shift 3 2 1, ez a formátum!!!!!!!
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
                    dataGridViewadminJelszoModositas.Refresh();
                    dataGridViewadminJelszoModositas.Update();
                    tablafeltoltesMySqlParanccsalJelszoTabla();
                    cellakKiuritese();
                    kapcsolat.Close();

                }

            }
        }
    }
}
