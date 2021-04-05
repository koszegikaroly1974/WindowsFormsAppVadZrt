namespace WindowsFormsApp1
{
    partial class FormRaktarLekerdezesek
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRaktarLekerdezesek));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keszletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ÁrukiadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRaktarKilepes = new System.Windows.Forms.Button();
            this.dataGridViewRaktarLekerdezesEredmenytabla = new System.Windows.Forms.DataGridView();
            this.buttonRaktarKivalasztasVevoNeve = new System.Windows.Forms.Button();
            this.buttonRaktarKivalasztasTermekNeve = new System.Windows.Forms.Button();
            this.buttonRaktarKivalasztasSzallitolevelSzam = new System.Windows.Forms.Button();
            this.buttonRaktarKivalasztasDatum = new System.Windows.Forms.Button();
            this.listViewRaktarLekerdezesValasztottTetelek = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRaktarLekerdezesVevo = new System.Windows.Forms.Button();
            this.textBoxRaktárLekerdezesValasztottTetel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRaktarLekerdezesRogzitese = new System.Windows.Forms.Button();
            this.buttonRaktarLekerdezesTermek = new System.Windows.Forms.Button();
            this.buttonRaktarLekerdezesSzallitoSzama = new System.Windows.Forms.Button();
            this.buttonRaktarLekerdezesErtekesitesDatuma = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaktarLekerdezesEredmenytabla)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keszletToolStripMenuItem,
            this.ÁrukiadásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // keszletToolStripMenuItem
            // 
            this.keszletToolStripMenuItem.Name = "keszletToolStripMenuItem";
            this.keszletToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.keszletToolStripMenuItem.Text = "Készlet";
            this.keszletToolStripMenuItem.Click += new System.EventHandler(this.keszletToolStripMenuItem_Click);
            // 
            // ÁrukiadásToolStripMenuItem
            // 
            this.ÁrukiadásToolStripMenuItem.Name = "ÁrukiadásToolStripMenuItem";
            this.ÁrukiadásToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ÁrukiadásToolStripMenuItem.Text = "Árukiadás";
            this.ÁrukiadásToolStripMenuItem.Click += new System.EventHandler(this.ÁrukiadásToolStripMenuItem_Click);
            // 
            // buttonRaktarKilepes
            // 
            this.buttonRaktarKilepes.Location = new System.Drawing.Point(853, 12);
            this.buttonRaktarKilepes.Name = "buttonRaktarKilepes";
            this.buttonRaktarKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonRaktarKilepes.TabIndex = 1;
            this.buttonRaktarKilepes.Text = "Kilépés";
            this.buttonRaktarKilepes.UseVisualStyleBackColor = true;
            this.buttonRaktarKilepes.Click += new System.EventHandler(this.buttonRaktarKilepes_Click);
            // 
            // dataGridViewRaktarLekerdezesEredmenytabla
            // 
            this.dataGridViewRaktarLekerdezesEredmenytabla.AllowUserToAddRows = false;
            this.dataGridViewRaktarLekerdezesEredmenytabla.AllowUserToDeleteRows = false;
            this.dataGridViewRaktarLekerdezesEredmenytabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaktarLekerdezesEredmenytabla.Location = new System.Drawing.Point(9, 33);
            this.dataGridViewRaktarLekerdezesEredmenytabla.Name = "dataGridViewRaktarLekerdezesEredmenytabla";
            this.dataGridViewRaktarLekerdezesEredmenytabla.ReadOnly = true;
            this.dataGridViewRaktarLekerdezesEredmenytabla.Size = new System.Drawing.Size(523, 239);
            this.dataGridViewRaktarLekerdezesEredmenytabla.TabIndex = 2;
            // 
            // buttonRaktarKivalasztasVevoNeve
            // 
            this.buttonRaktarKivalasztasVevoNeve.Location = new System.Drawing.Point(549, 52);
            this.buttonRaktarKivalasztasVevoNeve.Name = "buttonRaktarKivalasztasVevoNeve";
            this.buttonRaktarKivalasztasVevoNeve.Size = new System.Drawing.Size(98, 35);
            this.buttonRaktarKivalasztasVevoNeve.TabIndex = 3;
            this.buttonRaktarKivalasztasVevoNeve.Text = "Vevő szerinti választás";
            this.buttonRaktarKivalasztasVevoNeve.UseVisualStyleBackColor = true;
            this.buttonRaktarKivalasztasVevoNeve.Click += new System.EventHandler(this.buttonRaktarLekerdzesVevoNeve_Click);
            // 
            // buttonRaktarKivalasztasTermekNeve
            // 
            this.buttonRaktarKivalasztasTermekNeve.Location = new System.Drawing.Point(549, 107);
            this.buttonRaktarKivalasztasTermekNeve.Name = "buttonRaktarKivalasztasTermekNeve";
            this.buttonRaktarKivalasztasTermekNeve.Size = new System.Drawing.Size(98, 34);
            this.buttonRaktarKivalasztasTermekNeve.TabIndex = 4;
            this.buttonRaktarKivalasztasTermekNeve.Text = "Termék szerinti választás";
            this.buttonRaktarKivalasztasTermekNeve.UseVisualStyleBackColor = true;
            this.buttonRaktarKivalasztasTermekNeve.Click += new System.EventHandler(this.buttonRaktarLekerdezestermekNeve_Click);
            // 
            // buttonRaktarKivalasztasSzallitolevelSzam
            // 
            this.buttonRaktarKivalasztasSzallitolevelSzam.Location = new System.Drawing.Point(549, 147);
            this.buttonRaktarKivalasztasSzallitolevelSzam.Name = "buttonRaktarKivalasztasSzallitolevelSzam";
            this.buttonRaktarKivalasztasSzallitolevelSzam.Size = new System.Drawing.Size(98, 57);
            this.buttonRaktarKivalasztasSzallitolevelSzam.TabIndex = 5;
            this.buttonRaktarKivalasztasSzallitolevelSzam.Text = "Szállítólevél szám szerinti választás";
            this.buttonRaktarKivalasztasSzallitolevelSzam.UseVisualStyleBackColor = true;
            this.buttonRaktarKivalasztasSzallitolevelSzam.Click += new System.EventHandler(this.buttonRaktarLekerdezesSzallitolevelSzam_Click);
            // 
            // buttonRaktarKivalasztasDatum
            // 
            this.buttonRaktarKivalasztasDatum.Location = new System.Drawing.Point(549, 224);
            this.buttonRaktarKivalasztasDatum.Name = "buttonRaktarKivalasztasDatum";
            this.buttonRaktarKivalasztasDatum.Size = new System.Drawing.Size(98, 48);
            this.buttonRaktarKivalasztasDatum.TabIndex = 6;
            this.buttonRaktarKivalasztasDatum.Text = "Értékesítés dátuma szerinti választás";
            this.buttonRaktarKivalasztasDatum.UseVisualStyleBackColor = true;
            this.buttonRaktarKivalasztasDatum.Click += new System.EventHandler(this.buttonRaktarLekerdezesDatum_Click);
            // 
            // listViewRaktarLekerdezesValasztottTetelek
            // 
            this.listViewRaktarLekerdezesValasztottTetelek.GridLines = true;
            this.listViewRaktarLekerdezesValasztottTetelek.HideSelection = false;
            this.listViewRaktarLekerdezesValasztottTetelek.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewRaktarLekerdezesValasztottTetelek.Location = new System.Drawing.Point(695, 33);
            this.listViewRaktarLekerdezesValasztottTetelek.Name = "listViewRaktarLekerdezesValasztottTetelek";
            this.listViewRaktarLekerdezesValasztottTetelek.Size = new System.Drawing.Size(152, 287);
            this.listViewRaktarLekerdezesValasztottTetelek.TabIndex = 7;
            this.listViewRaktarLekerdezesValasztottTetelek.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "A lekérdezés eredménye";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rendezési elvek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Választható tételek";
            // 
            // buttonRaktarLekerdezesVevo
            // 
            this.buttonRaktarLekerdezesVevo.Location = new System.Drawing.Point(9, 297);
            this.buttonRaktarLekerdezesVevo.Name = "buttonRaktarLekerdezesVevo";
            this.buttonRaktarLekerdezesVevo.Size = new System.Drawing.Size(197, 23);
            this.buttonRaktarLekerdezesVevo.TabIndex = 12;
            this.buttonRaktarLekerdezesVevo.Text = "Vevő szerinti lekérdezés";
            this.buttonRaktarLekerdezesVevo.UseVisualStyleBackColor = true;
            this.buttonRaktarLekerdezesVevo.Visible = false;
            this.buttonRaktarLekerdezesVevo.Click += new System.EventHandler(this.buttonRaktarLekerdezesInditas_Click);
            // 
            // textBoxRaktárLekerdezesValasztottTetel
            // 
            this.textBoxRaktárLekerdezesValasztottTetel.Enabled = false;
            this.textBoxRaktárLekerdezesValasztottTetel.Location = new System.Drawing.Point(695, 355);
            this.textBoxRaktárLekerdezesValasztottTetel.Name = "textBoxRaktárLekerdezesValasztottTetel";
            this.textBoxRaktárLekerdezesValasztottTetel.Size = new System.Drawing.Size(152, 20);
            this.textBoxRaktárLekerdezesValasztottTetel.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(692, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Választott  tétel";
            // 
            // buttonRaktarLekerdezesRogzitese
            // 
            this.buttonRaktarLekerdezesRogzitese.Location = new System.Drawing.Point(516, 355);
            this.buttonRaktarLekerdezesRogzitese.Name = "buttonRaktarLekerdezesRogzitese";
            this.buttonRaktarLekerdezesRogzitese.Size = new System.Drawing.Size(173, 44);
            this.buttonRaktarLekerdezesRogzitese.TabIndex = 15;
            this.buttonRaktarLekerdezesRogzitese.Text = "Választott tétel rögzítése";
            this.buttonRaktarLekerdezesRogzitese.UseVisualStyleBackColor = true;
            this.buttonRaktarLekerdezesRogzitese.Click += new System.EventHandler(this.buttonRaktarLekerdezesRogzitese_Click);
            // 
            // buttonRaktarLekerdezesTermek
            // 
            this.buttonRaktarLekerdezesTermek.Location = new System.Drawing.Point(9, 326);
            this.buttonRaktarLekerdezesTermek.Name = "buttonRaktarLekerdezesTermek";
            this.buttonRaktarLekerdezesTermek.Size = new System.Drawing.Size(194, 23);
            this.buttonRaktarLekerdezesTermek.TabIndex = 16;
            this.buttonRaktarLekerdezesTermek.Text = "Termék szerinti lekérdezés";
            this.buttonRaktarLekerdezesTermek.UseVisualStyleBackColor = true;
            this.buttonRaktarLekerdezesTermek.Visible = false;
            this.buttonRaktarLekerdezesTermek.Click += new System.EventHandler(this.buttonRaktarLekerdezesTermek_Click);
            // 
            // buttonRaktarLekerdezesSzallitoSzama
            // 
            this.buttonRaktarLekerdezesSzallitoSzama.Location = new System.Drawing.Point(9, 355);
            this.buttonRaktarLekerdezesSzallitoSzama.Name = "buttonRaktarLekerdezesSzallitoSzama";
            this.buttonRaktarLekerdezesSzallitoSzama.Size = new System.Drawing.Size(194, 23);
            this.buttonRaktarLekerdezesSzallitoSzama.TabIndex = 17;
            this.buttonRaktarLekerdezesSzallitoSzama.Text = "Szállítólevél szám szerinti lekérdezés";
            this.buttonRaktarLekerdezesSzallitoSzama.UseVisualStyleBackColor = true;
            this.buttonRaktarLekerdezesSzallitoSzama.Visible = false;
            this.buttonRaktarLekerdezesSzallitoSzama.Click += new System.EventHandler(this.buttonRaktarLekerdezesSzallitoSzama_Click);
            // 
            // buttonRaktarLekerdezesErtekesitesDatuma
            // 
            this.buttonRaktarLekerdezesErtekesitesDatuma.Location = new System.Drawing.Point(9, 384);
            this.buttonRaktarLekerdezesErtekesitesDatuma.Name = "buttonRaktarLekerdezesErtekesitesDatuma";
            this.buttonRaktarLekerdezesErtekesitesDatuma.Size = new System.Drawing.Size(194, 23);
            this.buttonRaktarLekerdezesErtekesitesDatuma.TabIndex = 18;
            this.buttonRaktarLekerdezesErtekesitesDatuma.Text = "Értékesítési dátum szerinti lekérdezés";
            this.buttonRaktarLekerdezesErtekesitesDatuma.UseVisualStyleBackColor = true;
            this.buttonRaktarLekerdezesErtekesitesDatuma.Visible = false;
            this.buttonRaktarLekerdezesErtekesitesDatuma.Click += new System.EventHandler(this.buttonRaktarLekerdezesErtekesitesDatuma_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRaktarLekerdezesErtekesitesDatuma);
            this.panel1.Controls.Add(this.buttonRaktarKilepes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonRaktarLekerdezesRogzitese);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewRaktarLekerdezesEredmenytabla);
            this.panel1.Controls.Add(this.buttonRaktarLekerdezesTermek);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonRaktarKivalasztasVevoNeve);
            this.panel1.Controls.Add(this.buttonRaktarKivalasztasTermekNeve);
            this.panel1.Controls.Add(this.buttonRaktarKivalasztasSzallitolevelSzam);
            this.panel1.Controls.Add(this.buttonRaktarKivalasztasDatum);
            this.panel1.Controls.Add(this.listViewRaktarLekerdezesValasztottTetelek);
            this.panel1.Controls.Add(this.buttonRaktarLekerdezesSzallitoSzama);
            this.panel1.Controls.Add(this.textBoxRaktárLekerdezesValasztottTetel);
            this.panel1.Controls.Add(this.buttonRaktarLekerdezesVevo);
            this.panel1.Location = new System.Drawing.Point(178, 153);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(955, 416);
            this.panel1.TabIndex = 19;
            // 
            // FormRaktarLekerdezesek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRaktarLekerdezesek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRaktarLekerdezesek";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaktarLekerdezesEredmenytabla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem keszletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ÁrukiadásToolStripMenuItem;
        private System.Windows.Forms.Button buttonRaktarKilepes;
        private System.Windows.Forms.DataGridView dataGridViewRaktarLekerdezesEredmenytabla;
        private System.Windows.Forms.Button buttonRaktarKivalasztasVevoNeve;
        private System.Windows.Forms.Button buttonRaktarKivalasztasTermekNeve;
        private System.Windows.Forms.Button buttonRaktarKivalasztasSzallitolevelSzam;
        private System.Windows.Forms.Button buttonRaktarKivalasztasDatum;
        private System.Windows.Forms.ListView listViewRaktarLekerdezesValasztottTetelek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRaktarLekerdezesVevo;
        private System.Windows.Forms.TextBox textBoxRaktárLekerdezesValasztottTetel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRaktarLekerdezesRogzitese;
        private System.Windows.Forms.Button buttonRaktarLekerdezesTermek;
        private System.Windows.Forms.Button buttonRaktarLekerdezesSzallitoSzama;
        private System.Windows.Forms.Button buttonRaktarLekerdezesErtekesitesDatuma;
        private System.Windows.Forms.Panel panel1;
    }
}