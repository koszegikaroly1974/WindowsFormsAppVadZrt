namespace WindowsFormsApp1
{
    partial class FormTermelesTemelesJelentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTermelesTemelesJelentes));
            this.buttonKilepesTermelesTermelesiJelentes = new System.Windows.Forms.Button();
            this.dataGridViewTermelesTermekKivalaszto = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raktárkészletLekérdezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxTermelesAdatfelvitel = new System.Windows.Forms.GroupBox();
            this.textBoxTermelesSarzs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTermelesME2 = new System.Windows.Forms.TextBox();
            this.textBoxTermelesMennyiseg2 = new System.Windows.Forms.TextBox();
            this.textBoxTermelesME1 = new System.Windows.Forms.TextBox();
            this.textBoxTermelesMennyiseg1 = new System.Windows.Forms.TextBox();
            this.textBoxTermelesNeveRogzit = new System.Windows.Forms.TextBox();
            this.textBoxTermelesCikkszamRogzit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonTermelesRogzites = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermelesTermekKivalaszto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxTermelesAdatfelvitel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKilepesTermelesTermelesiJelentes
            // 
            this.buttonKilepesTermelesTermelesiJelentes.Location = new System.Drawing.Point(749, 6);
            this.buttonKilepesTermelesTermelesiJelentes.Name = "buttonKilepesTermelesTermelesiJelentes";
            this.buttonKilepesTermelesTermelesiJelentes.Size = new System.Drawing.Size(75, 23);
            this.buttonKilepesTermelesTermelesiJelentes.TabIndex = 0;
            this.buttonKilepesTermelesTermelesiJelentes.Text = "Kilépés";
            this.buttonKilepesTermelesTermelesiJelentes.UseVisualStyleBackColor = true;
            this.buttonKilepesTermelesTermelesiJelentes.Click += new System.EventHandler(this.buttonKilepesTermelesTermelesiJelentes_Click);
            // 
            // dataGridViewTermelesTermekKivalaszto
            // 
            this.dataGridViewTermelesTermekKivalaszto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTermelesTermekKivalaszto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTermelesTermekKivalaszto.Location = new System.Drawing.Point(10, 35);
            this.dataGridViewTermelesTermekKivalaszto.Name = "dataGridViewTermelesTermekKivalaszto";
            this.dataGridViewTermelesTermekKivalaszto.ReadOnly = true;
            this.dataGridViewTermelesTermekKivalaszto.Size = new System.Drawing.Size(814, 137);
            this.dataGridViewTermelesTermekKivalaszto.TabIndex = 1;
            this.dataGridViewTermelesTermekKivalaszto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTermelesTermekKivalaszto_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raktárkészletLekérdezésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raktárkészletLekérdezésToolStripMenuItem
            // 
            this.raktárkészletLekérdezésToolStripMenuItem.Name = "raktárkészletLekérdezésToolStripMenuItem";
            this.raktárkészletLekérdezésToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.raktárkészletLekérdezésToolStripMenuItem.Text = "Raktárkészlet lekérdezés";
            this.raktárkészletLekérdezésToolStripMenuItem.Click += new System.EventHandler(this.raktárkészletLekérdezésToolStripMenuItem_Click);
            // 
            // groupBoxTermelesAdatfelvitel
            // 
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.textBoxTermelesSarzs);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.label11);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.label10);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.label8);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.label7);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.label6);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.label5);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.label4);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.label3);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.label2);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.label1);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.textBoxTermelesME2);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.textBoxTermelesMennyiseg2);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.textBoxTermelesME1);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.textBoxTermelesMennyiseg1);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.textBoxTermelesNeveRogzit);
            this.groupBoxTermelesAdatfelvitel.Controls.Add(this.textBoxTermelesCikkszamRogzit);
            this.groupBoxTermelesAdatfelvitel.Location = new System.Drawing.Point(12, 178);
            this.groupBoxTermelesAdatfelvitel.Name = "groupBoxTermelesAdatfelvitel";
            this.groupBoxTermelesAdatfelvitel.Size = new System.Drawing.Size(812, 114);
            this.groupBoxTermelesAdatfelvitel.TabIndex = 3;
            this.groupBoxTermelesAdatfelvitel.TabStop = false;
            this.groupBoxTermelesAdatfelvitel.Text = "Rögzítendő termék mennyisége";
            // 
            // textBoxTermelesSarzs
            // 
            this.textBoxTermelesSarzs.Location = new System.Drawing.Point(706, 44);
            this.textBoxTermelesSarzs.Name = "textBoxTermelesSarzs";
            this.textBoxTermelesSarzs.Size = new System.Drawing.Size(100, 20);
            this.textBoxTermelesSarzs.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(699, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Írja be a mennyiséget";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(703, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Sarzs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Egyedi karton termelés!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Írja be a mennyiséget";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mennyiségi egység 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mennyiség 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mennyiségi egység 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mennyiség 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Termék neve";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cikkszám";
            // 
            // textBoxTermelesME2
            // 
            this.textBoxTermelesME2.Enabled = false;
            this.textBoxTermelesME2.Location = new System.Drawing.Point(585, 44);
            this.textBoxTermelesME2.Name = "textBoxTermelesME2";
            this.textBoxTermelesME2.Size = new System.Drawing.Size(100, 20);
            this.textBoxTermelesME2.TabIndex = 5;
            // 
            // textBoxTermelesMennyiseg2
            // 
            this.textBoxTermelesMennyiseg2.Enabled = false;
            this.textBoxTermelesMennyiseg2.Location = new System.Drawing.Point(465, 44);
            this.textBoxTermelesMennyiseg2.Name = "textBoxTermelesMennyiseg2";
            this.textBoxTermelesMennyiseg2.Size = new System.Drawing.Size(100, 20);
            this.textBoxTermelesMennyiseg2.TabIndex = 4;
            // 
            // textBoxTermelesME1
            // 
            this.textBoxTermelesME1.Enabled = false;
            this.textBoxTermelesME1.Location = new System.Drawing.Point(344, 44);
            this.textBoxTermelesME1.Name = "textBoxTermelesME1";
            this.textBoxTermelesME1.Size = new System.Drawing.Size(100, 20);
            this.textBoxTermelesME1.TabIndex = 3;
            // 
            // textBoxTermelesMennyiseg1
            // 
            this.textBoxTermelesMennyiseg1.Location = new System.Drawing.Point(238, 44);
            this.textBoxTermelesMennyiseg1.Name = "textBoxTermelesMennyiseg1";
            this.textBoxTermelesMennyiseg1.Size = new System.Drawing.Size(100, 20);
            this.textBoxTermelesMennyiseg1.TabIndex = 2;
            // 
            // textBoxTermelesNeveRogzit
            // 
            this.textBoxTermelesNeveRogzit.Enabled = false;
            this.textBoxTermelesNeveRogzit.Location = new System.Drawing.Point(117, 44);
            this.textBoxTermelesNeveRogzit.Name = "textBoxTermelesNeveRogzit";
            this.textBoxTermelesNeveRogzit.Size = new System.Drawing.Size(100, 20);
            this.textBoxTermelesNeveRogzit.TabIndex = 1;
            // 
            // textBoxTermelesCikkszamRogzit
            // 
            this.textBoxTermelesCikkszamRogzit.Enabled = false;
            this.textBoxTermelesCikkszamRogzit.Location = new System.Drawing.Point(7, 45);
            this.textBoxTermelesCikkszamRogzit.Name = "textBoxTermelesCikkszamRogzit";
            this.textBoxTermelesCikkszamRogzit.Size = new System.Drawing.Size(100, 20);
            this.textBoxTermelesCikkszamRogzit.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(306, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Válassza ki a rögzítendő terméket a megfelelő sorra kattintással";
            // 
            // buttonTermelesRogzites
            // 
            this.buttonTermelesRogzites.Location = new System.Drawing.Point(327, 316);
            this.buttonTermelesRogzites.Name = "buttonTermelesRogzites";
            this.buttonTermelesRogzites.Size = new System.Drawing.Size(177, 23);
            this.buttonTermelesRogzites.TabIndex = 5;
            this.buttonTermelesRogzites.Text = "A termelt mennyiség rögzítése";
            this.buttonTermelesRogzites.UseVisualStyleBackColor = true;
            this.buttonTermelesRogzites.Click += new System.EventHandler(this.buttonTermelesRogzites_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxTermelesAdatfelvitel);
            this.panel1.Controls.Add(this.buttonKilepesTermelesTermelesiJelentes);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonTermelesRogzites);
            this.panel1.Controls.Add(this.dataGridViewTermelesTermekKivalaszto);
            this.panel1.Location = new System.Drawing.Point(235, 224);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(836, 355);
            this.panel1.TabIndex = 6;
            // 
            // FormTermelesTemelesJelentes
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
            this.Name = "FormTermelesTemelesJelentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termelés/Termelési jelentés";
            this.Load += new System.EventHandler(this.FormTermelesTemelesJelentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermelesTermekKivalaszto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxTermelesAdatfelvitel.ResumeLayout(false);
            this.groupBoxTermelesAdatfelvitel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKilepesTermelesTermelesiJelentes;
        private System.Windows.Forms.DataGridView dataGridViewTermelesTermekKivalaszto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raktárkészletLekérdezésToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxTermelesAdatfelvitel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTermelesME2;
        private System.Windows.Forms.TextBox textBoxTermelesMennyiseg2;
        private System.Windows.Forms.TextBox textBoxTermelesME1;
        private System.Windows.Forms.TextBox textBoxTermelesMennyiseg1;
        private System.Windows.Forms.TextBox textBoxTermelesNeveRogzit;
        private System.Windows.Forms.TextBox textBoxTermelesCikkszamRogzit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonTermelesRogzites;
        private System.Windows.Forms.TextBox textBoxTermelesSarzs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
    }
}