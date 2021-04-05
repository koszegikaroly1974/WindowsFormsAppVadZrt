namespace WindowsFormsApp1
{
    partial class FormRaktarArukiadas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRaktarArukiadas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.készletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekérdezésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRaktarArukiadasKilepes = new System.Windows.Forms.Button();
            this.dataGridViewRaktarArukiadasVevoValasztas = new System.Windows.Forms.DataGridView();
            this.dataGridViewRaktarArukiadasTermekValasztas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRaktarArukiadasValasztottVevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRaktarArukiadasSzallitiLezaras = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRaktarArukiadasTermekEgyediAzonosito = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRaktarArukiadasValasztottVevoAzonosito = new System.Windows.Forms.TextBox();
            this.dataGridViewRaktarArukiadasSzallitoSorszam = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxRaktarArukiadasSzallitoSorszam = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRaktarArukiadasTermekNeve = new System.Windows.Forms.TextBox();
            this.dataGridViewRaktarArukiadasSzallitolevelTermekLista = new System.Windows.Forms.DataGridView();
            this.textBoxRaktarArukiadasSzallitolevelTermekTorles = new System.Windows.Forms.TextBox();
            this.buttonRaktarArukiadasMegsem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRaktarArukiadasSzallitolevelLezaras = new System.Windows.Forms.Button();
            this.buttonRaktarSzallitolevelMegsem = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaktarArukiadasVevoValasztas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaktarArukiadasTermekValasztas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaktarArukiadasSzallitoSorszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaktarArukiadasSzallitolevelTermekLista)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.készletToolStripMenuItem,
            this.lekérdezésekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // készletToolStripMenuItem
            // 
            this.készletToolStripMenuItem.Name = "készletToolStripMenuItem";
            this.készletToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.készletToolStripMenuItem.Text = "Készlet";
            this.készletToolStripMenuItem.Click += new System.EventHandler(this.készletToolStripMenuItem_Click);
            // 
            // lekérdezésekToolStripMenuItem
            // 
            this.lekérdezésekToolStripMenuItem.Name = "lekérdezésekToolStripMenuItem";
            this.lekérdezésekToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.lekérdezésekToolStripMenuItem.Text = "Lekérdezések";
            this.lekérdezésekToolStripMenuItem.Click += new System.EventHandler(this.lekérdezésekToolStripMenuItem_Click);
            // 
            // buttonRaktarArukiadasKilepes
            // 
            this.buttonRaktarArukiadasKilepes.Location = new System.Drawing.Point(749, 11);
            this.buttonRaktarArukiadasKilepes.Name = "buttonRaktarArukiadasKilepes";
            this.buttonRaktarArukiadasKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonRaktarArukiadasKilepes.TabIndex = 1;
            this.buttonRaktarArukiadasKilepes.Text = "Kilépés";
            this.buttonRaktarArukiadasKilepes.UseVisualStyleBackColor = true;
            this.buttonRaktarArukiadasKilepes.Click += new System.EventHandler(this.buttonRaktarArukiadasKilepes_Click);
            // 
            // dataGridViewRaktarArukiadasVevoValasztas
            // 
            this.dataGridViewRaktarArukiadasVevoValasztas.AllowUserToAddRows = false;
            this.dataGridViewRaktarArukiadasVevoValasztas.AllowUserToDeleteRows = false;
            this.dataGridViewRaktarArukiadasVevoValasztas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRaktarArukiadasVevoValasztas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaktarArukiadasVevoValasztas.Location = new System.Drawing.Point(24, 25);
            this.dataGridViewRaktarArukiadasVevoValasztas.Name = "dataGridViewRaktarArukiadasVevoValasztas";
            this.dataGridViewRaktarArukiadasVevoValasztas.ReadOnly = true;
            this.dataGridViewRaktarArukiadasVevoValasztas.Size = new System.Drawing.Size(520, 61);
            this.dataGridViewRaktarArukiadasVevoValasztas.TabIndex = 2;
            this.dataGridViewRaktarArukiadasVevoValasztas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRaktarArukiadasVevoValasztas_CellClick);
            // 
            // dataGridViewRaktarArukiadasTermekValasztas
            // 
            this.dataGridViewRaktarArukiadasTermekValasztas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaktarArukiadasTermekValasztas.Enabled = false;
            this.dataGridViewRaktarArukiadasTermekValasztas.Location = new System.Drawing.Point(24, 105);
            this.dataGridViewRaktarArukiadasTermekValasztas.Name = "dataGridViewRaktarArukiadasTermekValasztas";
            this.dataGridViewRaktarArukiadasTermekValasztas.ReadOnly = true;
            this.dataGridViewRaktarArukiadasTermekValasztas.Size = new System.Drawing.Size(520, 150);
            this.dataGridViewRaktarArukiadasTermekValasztas.TabIndex = 3;
            this.dataGridViewRaktarArukiadasTermekValasztas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRaktarArukiadasTermekValasztas_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kattintson a vevő kiválasztásához a megfelelő névre";
            // 
            // textBoxRaktarArukiadasValasztottVevo
            // 
            this.textBoxRaktarArukiadasValasztottVevo.Enabled = false;
            this.textBoxRaktarArukiadasValasztottVevo.Location = new System.Drawing.Point(553, 32);
            this.textBoxRaktarArukiadasValasztottVevo.Name = "textBoxRaktarArukiadasValasztottVevo";
            this.textBoxRaktarArukiadasValasztottVevo.Size = new System.Drawing.Size(189, 20);
            this.textBoxRaktarArukiadasValasztottVevo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "A vevő neve:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kattintson a termék kiválasztásához a megfelelő termékre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Szállítólevélen kiadandó áruk listája";
            // 
            // buttonRaktarArukiadasSzallitiLezaras
            // 
            this.buttonRaktarArukiadasSzallitiLezaras.Location = new System.Drawing.Point(660, 775);
            this.buttonRaktarArukiadasSzallitiLezaras.Name = "buttonRaktarArukiadasSzallitiLezaras";
            this.buttonRaktarArukiadasSzallitiLezaras.Size = new System.Drawing.Size(155, 23);
            this.buttonRaktarArukiadasSzallitiLezaras.TabIndex = 11;
            this.buttonRaktarArukiadasSzallitiLezaras.Text = "Szállítólevél lezárása";
            this.buttonRaktarArukiadasSzallitiLezaras.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "A szállítólevélen szereplő  termék törléséhez kattintson az adott termék azonosít" +
    "ójára";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "A választott termék egyedi azonosítója:";
            // 
            // textBoxRaktarArukiadasTermekEgyediAzonosito
            // 
            this.textBoxRaktarArukiadasTermekEgyediAzonosito.Enabled = false;
            this.textBoxRaktarArukiadasTermekEgyediAzonosito.Location = new System.Drawing.Point(553, 171);
            this.textBoxRaktarArukiadasTermekEgyediAzonosito.Name = "textBoxRaktarArukiadasTermekEgyediAzonosito";
            this.textBoxRaktarArukiadasTermekEgyediAzonosito.Size = new System.Drawing.Size(71, 20);
            this.textBoxRaktarArukiadasTermekEgyediAzonosito.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Vevő azonosító";
            // 
            // textBoxRaktarArukiadasValasztottVevoAzonosito
            // 
            this.textBoxRaktarArukiadasValasztottVevoAzonosito.Enabled = false;
            this.textBoxRaktarArukiadasValasztottVevoAzonosito.Location = new System.Drawing.Point(553, 71);
            this.textBoxRaktarArukiadasValasztottVevoAzonosito.Name = "textBoxRaktarArukiadasValasztottVevoAzonosito";
            this.textBoxRaktarArukiadasValasztottVevoAzonosito.Size = new System.Drawing.Size(71, 20);
            this.textBoxRaktarArukiadasValasztottVevoAzonosito.TabIndex = 16;
            // 
            // dataGridViewRaktarArukiadasSzallitoSorszam
            // 
            this.dataGridViewRaktarArukiadasSzallitoSorszam.AllowUserToAddRows = false;
            this.dataGridViewRaktarArukiadasSzallitoSorszam.AllowUserToDeleteRows = false;
            this.dataGridViewRaktarArukiadasSzallitoSorszam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRaktarArukiadasSzallitoSorszam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaktarArukiadasSzallitoSorszam.Location = new System.Drawing.Point(6, 317);
            this.dataGridViewRaktarArukiadasSzallitoSorszam.Name = "dataGridViewRaktarArukiadasSzallitoSorszam";
            this.dataGridViewRaktarArukiadasSzallitoSorszam.Size = new System.Drawing.Size(49, 40);
            this.dataGridViewRaktarArukiadasSzallitoSorszam.TabIndex = 19;
            this.dataGridViewRaktarArukiadasSzallitoSorszam.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Szállítólevél sorszáma";
            // 
            // textBoxRaktarArukiadasSzallitoSorszam
            // 
            this.textBoxRaktarArukiadasSzallitoSorszam.Enabled = false;
            this.textBoxRaktarArukiadasSzallitoSorszam.Location = new System.Drawing.Point(6, 275);
            this.textBoxRaktarArukiadasSzallitoSorszam.Name = "textBoxRaktarArukiadasSzallitoSorszam";
            this.textBoxRaktarArukiadasSzallitoSorszam.Size = new System.Drawing.Size(65, 20);
            this.textBoxRaktarArukiadasSzallitoSorszam.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "A választott termék neve:";
            // 
            // textBoxRaktarArukiadasTermekNeve
            // 
            this.textBoxRaktarArukiadasTermekNeve.Enabled = false;
            this.textBoxRaktarArukiadasTermekNeve.Location = new System.Drawing.Point(553, 132);
            this.textBoxRaktarArukiadasTermekNeve.Name = "textBoxRaktarArukiadasTermekNeve";
            this.textBoxRaktarArukiadasTermekNeve.Size = new System.Drawing.Size(189, 20);
            this.textBoxRaktarArukiadasTermekNeve.TabIndex = 23;
            // 
            // dataGridViewRaktarArukiadasSzallitolevelTermekLista
            // 
            this.dataGridViewRaktarArukiadasSzallitolevelTermekLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaktarArukiadasSzallitolevelTermekLista.Location = new System.Drawing.Point(77, 291);
            this.dataGridViewRaktarArukiadasSzallitolevelTermekLista.Name = "dataGridViewRaktarArukiadasSzallitolevelTermekLista";
            this.dataGridViewRaktarArukiadasSzallitolevelTermekLista.ReadOnly = true;
            this.dataGridViewRaktarArukiadasSzallitolevelTermekLista.Size = new System.Drawing.Size(349, 150);
            this.dataGridViewRaktarArukiadasSzallitolevelTermekLista.TabIndex = 24;
            this.dataGridViewRaktarArukiadasSzallitolevelTermekLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRaktarArukiadasSzallitolevelTermekLista_CellClick);
            // 
            // textBoxRaktarArukiadasSzallitolevelTermekTorles
            // 
            this.textBoxRaktarArukiadasSzallitolevelTermekTorles.Enabled = false;
            this.textBoxRaktarArukiadasSzallitolevelTermekTorles.Location = new System.Drawing.Point(432, 317);
            this.textBoxRaktarArukiadasSzallitolevelTermekTorles.Name = "textBoxRaktarArukiadasSzallitolevelTermekTorles";
            this.textBoxRaktarArukiadasSzallitolevelTermekTorles.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaktarArukiadasSzallitolevelTermekTorles.TabIndex = 25;
            // 
            // buttonRaktarArukiadasMegsem
            // 
            this.buttonRaktarArukiadasMegsem.Location = new System.Drawing.Point(461, 775);
            this.buttonRaktarArukiadasMegsem.Name = "buttonRaktarArukiadasMegsem";
            this.buttonRaktarArukiadasMegsem.Size = new System.Drawing.Size(144, 23);
            this.buttonRaktarArukiadasMegsem.TabIndex = 26;
            this.buttonRaktarArukiadasMegsem.Text = "Mégsem";
            this.buttonRaktarArukiadasMegsem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRaktarArukiadasSzallitolevelLezaras);
            this.panel1.Controls.Add(this.buttonRaktarSzallitolevelMegsem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewRaktarArukiadasVevoValasztas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxRaktarArukiadasSzallitolevelTermekTorles);
            this.panel1.Controls.Add(this.buttonRaktarArukiadasKilepes);
            this.panel1.Controls.Add(this.textBoxRaktarArukiadasValasztottVevo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridViewRaktarArukiadasSzallitoSorszam);
            this.panel1.Controls.Add(this.textBoxRaktarArukiadasSzallitoSorszam);
            this.panel1.Controls.Add(this.dataGridViewRaktarArukiadasSzallitolevelTermekLista);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxRaktarArukiadasTermekNeve);
            this.panel1.Controls.Add(this.textBoxRaktarArukiadasValasztottVevoAzonosito);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxRaktarArukiadasTermekEgyediAzonosito);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridViewRaktarArukiadasTermekValasztas);
            this.panel1.Location = new System.Drawing.Point(268, 117);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(840, 458);
            this.panel1.TabIndex = 27;
            // 
            // buttonRaktarArukiadasSzallitolevelLezaras
            // 
            this.buttonRaktarArukiadasSzallitolevelLezaras.Location = new System.Drawing.Point(671, 418);
            this.buttonRaktarArukiadasSzallitolevelLezaras.Name = "buttonRaktarArukiadasSzallitolevelLezaras";
            this.buttonRaktarArukiadasSzallitolevelLezaras.Size = new System.Drawing.Size(153, 23);
            this.buttonRaktarArukiadasSzallitolevelLezaras.TabIndex = 27;
            this.buttonRaktarArukiadasSzallitolevelLezaras.Text = "Szállítólevél lezárása";
            this.buttonRaktarArukiadasSzallitolevelLezaras.UseVisualStyleBackColor = true;
            this.buttonRaktarArukiadasSzallitolevelLezaras.Click += new System.EventHandler(this.buttonRaktarArukiadasSzallitolevelLezaras_Click);
            // 
            // buttonRaktarSzallitolevelMegsem
            // 
            this.buttonRaktarSzallitolevelMegsem.Location = new System.Drawing.Point(504, 418);
            this.buttonRaktarSzallitolevelMegsem.Name = "buttonRaktarSzallitolevelMegsem";
            this.buttonRaktarSzallitolevelMegsem.Size = new System.Drawing.Size(75, 23);
            this.buttonRaktarSzallitolevelMegsem.TabIndex = 26;
            this.buttonRaktarSzallitolevelMegsem.Text = "Mégsem";
            this.buttonRaktarSzallitolevelMegsem.UseVisualStyleBackColor = true;
            this.buttonRaktarSzallitolevelMegsem.Click += new System.EventHandler(this.buttonRaktarSzallitolevelMegsem_Click);
            // 
            // FormRaktarArukiadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRaktarArukiadasMegsem);
            this.Controls.Add(this.buttonRaktarArukiadasSzallitiLezaras);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRaktarArukiadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRaktarArukiadas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaktarArukiadasVevoValasztas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaktarArukiadasTermekValasztas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaktarArukiadasSzallitoSorszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaktarArukiadasSzallitolevelTermekLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem készletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekérdezésekToolStripMenuItem;
        private System.Windows.Forms.Button buttonRaktarArukiadasKilepes;
        private System.Windows.Forms.DataGridView dataGridViewRaktarArukiadasVevoValasztas;
        private System.Windows.Forms.DataGridView dataGridViewRaktarArukiadasTermekValasztas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRaktarArukiadasValasztottVevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRaktarArukiadasSzallitiLezaras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRaktarArukiadasTermekEgyediAzonosito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRaktarArukiadasValasztottVevoAzonosito;
        private System.Windows.Forms.DataGridView dataGridViewRaktarArukiadasSzallitoSorszam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxRaktarArukiadasSzallitoSorszam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRaktarArukiadasTermekNeve;
        private System.Windows.Forms.DataGridView dataGridViewRaktarArukiadasSzallitolevelTermekLista;
        private System.Windows.Forms.TextBox textBoxRaktarArukiadasSzallitolevelTermekTorles;
        private System.Windows.Forms.Button buttonRaktarArukiadasMegsem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRaktarArukiadasSzallitolevelLezaras;
        private System.Windows.Forms.Button buttonRaktarSzallitolevelMegsem;
    }
}