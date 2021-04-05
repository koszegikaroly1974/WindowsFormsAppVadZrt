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
    public partial class FormTermelesTemelesJelentes : Form
    {
        String eleresiAdatok;
        MySqlConnection kapcsolat;

        public FormTermelesTemelesJelentes()
        {
            InitializeComponent();
        }

        public void MysqlKapcsolatLetrehozas()//mysql kapcsolat létrehozása
        {
            eleresiAdatok = "datasource = localhost; Database = szf43koszegikaroly; username = root; password =";
            kapcsolat = new MySqlConnection(eleresiAdatok);
            kapcsolat.Open();
        }


        private void buttonKilepesTermelesTermelesiJelentes_Click(object sender, EventArgs e)//kilépés a nyitóoldalra, belépéshez
        {// kilépés megerősítése messageBox segítségével
            Form parbeszedAblak = new Form();
            DialogResult dialog = MessageBox.Show("Biztosan ki akar lépni az ablakból?", "Kilépés", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Dispose();
                new FormNyito().ShowDialog();//vissza a nyitóoldalra
            }
            else if (dialog == DialogResult.No)
            {
                parbeszedAblak.Dispose();
            }
        }


        private void dataGridViewTermelesTermekKivalaszto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cellakattintás a terméktáblában a termelés kiválasztásához, adott beviteli mezőkben megjelennek a kattintott cellasor adatai
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewTermelesTermekKivalaszto.Rows[e.RowIndex];
                textBoxTermelesCikkszamRogzit.Text = row.Cells[0].Value.ToString();
                textBoxTermelesNeveRogzit.Text = row.Cells[1].Value.ToString();
                textBoxTermelesME1.Text = row.Cells[2].Value.ToString();
                textBoxTermelesME2.Text = row.Cells[3].Value.ToString();
                textBoxTermelesMennyiseg2.Text = "1";
            }            
        }


        private void raktárkészletLekérdezésToolStripMenuItem_Click(object sender, EventArgs e)//raktárkészletlekérezés menüre kattintva
        {
            this.Hide();
            kapcsolat.Close();
            new FormTermeles().ShowDialog();
        }


        private void FormTermelesTemelesJelentes_Load(object sender, EventArgs e)//betöltéskor
        {
            MysqlKapcsolatLetrehozas();
            //termék törzsadatok lekérdezése, adattáblába feltöltése, ebből lehet választani a termelés megírásához, törzsben levő adatok
            DataTable dtNyitotabla = new DataTable();
            MySqlCommand listakeszit = new MySqlCommand("SELECT cikkszam, termek_neve, mennyisegi_egyseg_1, mennyisegi_egyseg_2 from termek", kapcsolat);
            MySqlDataReader megnyit = listakeszit.ExecuteReader();
            dtNyitotabla.Load(megnyit);
            if (dtNyitotabla.Rows.Count > 0)
            {
                dataGridViewTermelesTermekKivalaszto.DataSource = dtNyitotabla;
            }
        }



        private void buttonTermelesRogzites_Click(object sender, EventArgs e)//termelés felvitele a raktárkészletbe
        {//üres mezők ellenőrzése
            if (textBoxTermelesCikkszamRogzit.Text == "" || textBoxTermelesNeveRogzit.Text == "" || textBoxTermelesMennyiseg1.Text == "" || textBoxTermelesME1.Text == "" || textBoxTermelesMennyiseg2.Text == "" || textBoxTermelesME2.Text == "")
            {
                MessageBox.Show("Kérem töltse ki az összes mezőt!");
            }

            else
            {
                //új termelési adat felvitele
                //adatbázis feltöltéséhez változók felvétele => yyyy-mm-dd sztem ez a mysql formátum
                var gyartasiDatum = DateTime.Now.Date;
                var lejaratiDatum = DateTime.Now.Date.AddYears(3);
                string datumFormatum = "yyyy-MM-dd";//gyartasiDatum.ToString(datumFormatum), lejaratiDatum.ToString(datumFormatum)
                string termekAllapotRaktaron = "keszleten";

                /* Mintakód  DateTime AktIdo = DateTime.Now;  listBox1.Items.Add("Tegnap: "+DateTime.Now.Date.AddDays(-1).ToString());
                string format = "yyyy.MM.dd HH:mm";
                Console.WriteLine(AktIdo.ToString(format));*/

                //vizsgáljuk meg a beviteli mezőket, számokat kell megadni betűk nem lehetnek ezt kell kivédeni mielőtt lefut e végrehajtó kód
                if (double.TryParse(textBoxTermelesMennyiseg1.Text, out double result1) && int.TryParse(textBoxTermelesSarzs.Text, out int result2))
                {
                    if ((result1<=0 || result1>35) || (result2<=0 || result2>35))
                    {
                        MessageBox.Show("A beírt számok értékei nem megfelelőek az adatrögzítéshez! A szám nem lehet negatív és túl nagy értékű(max 35kg)");
                        textBoxTermelesSarzs.Clear();//kiüríti az írható mezőket a helyes adatfelvételhez
                        textBoxTermelesMennyiseg1.Clear();
                    }
                    else
                    {
                    
                    //felviszi a mezőkben megadott értékeket a raktár táblába
                    string insertQuery = "INSERT INTO raktar VALUES(null,'" + textBoxTermelesCikkszamRogzit.Text + "','" + textBoxTermelesNeveRogzit.Text + "','" + textBoxTermelesMennyiseg1.Text + "', '" + textBoxTermelesME1.Text + "','" + textBoxTermelesMennyiseg2.Text + "','" + textBoxTermelesME2.Text + "','" + textBoxTermelesSarzs.Text + "','" + gyartasiDatum.ToString(datumFormatum) + "', '" + lejaratiDatum.ToString(datumFormatum) + "', '" + termekAllapotRaktaron + "')";//shift 1 2 3 adat shift 3 2 1, ez a formátum!!!!!!!
                    if (kapcsolat.State != ConnectionState.Open)//kapcsolatellenőrzés
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

                    textBoxTermelesSarzs.Clear();//kiüríti az írható mezőket az új felvételhez
                    textBoxTermelesMennyiseg1.Clear();
                    //textBoxTermelesMennyiseg2.Clear();


                    kapcsolat.Close();
                    }
                }
                else
                {
                    MessageBox.Show("A beírt adatok nem számok, nem megfelelőek az adatrögzítéshez!");
                    textBoxTermelesSarzs.Clear();//kiüríti az írható mezőket a helyes adatfelvételhez
                    textBoxTermelesMennyiseg1.Clear();
                }
            }
        }
    }
}
