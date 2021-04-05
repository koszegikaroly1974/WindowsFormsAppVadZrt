namespace WindowsFormsApp1
{
    partial class FormNyito
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
            this.buttonKilépés = new System.Windows.Forms.Button();
            this.buttonVissza = new System.Windows.Forms.Button();
            this.buttonBelépés = new System.Windows.Forms.Button();
            this.labelProgramNeve = new System.Windows.Forms.Label();
            this.comboBoxreszlegNeve = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelReszleg = new System.Windows.Forms.Label();
            this.textBoxjelszo = new System.Windows.Forms.TextBox();
            this.textBoxfelhasznaloNev = new System.Windows.Forms.TextBox();
            this.labeljelszo = new System.Windows.Forms.Label();
            this.labelfelhasznaloNev = new System.Windows.Forms.Label();
            this.label1BelepesJelzo = new System.Windows.Forms.Label();
            this.buttonSzerverKapcsolatLetrehozas = new System.Windows.Forms.Button();
            this.buttonSzerverKapcsolatBontas = new System.Windows.Forms.Button();
            this.panelNyito = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panelNyito.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKilépés
            // 
            this.buttonKilépés.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKilépés.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonKilépés.Location = new System.Drawing.Point(388, 18);
            this.buttonKilépés.Name = "buttonKilépés";
            this.buttonKilépés.Size = new System.Drawing.Size(97, 23);
            this.buttonKilépés.TabIndex = 1;
            this.buttonKilépés.Text = "Kilépés";
            this.buttonKilépés.UseVisualStyleBackColor = true;
            this.buttonKilépés.Click += new System.EventHandler(this.buttonKilépés_Click);
            // 
            // buttonVissza
            // 
            this.buttonVissza.Location = new System.Drawing.Point(27, 244);
            this.buttonVissza.Name = "buttonVissza";
            this.buttonVissza.Size = new System.Drawing.Size(75, 23);
            this.buttonVissza.TabIndex = 0;
            this.buttonVissza.Text = "Mégsem";
            this.buttonVissza.UseVisualStyleBackColor = true;
            this.buttonVissza.Click += new System.EventHandler(this.buttonVissza_Click);
            // 
            // buttonBelépés
            // 
            this.buttonBelépés.Location = new System.Drawing.Point(194, 244);
            this.buttonBelépés.Name = "buttonBelépés";
            this.buttonBelépés.Size = new System.Drawing.Size(75, 23);
            this.buttonBelépés.TabIndex = 1;
            this.buttonBelépés.Text = "Belépés";
            this.buttonBelépés.UseVisualStyleBackColor = true;
            this.buttonBelépés.Click += new System.EventHandler(this.buttonBelépés_Click);
            // 
            // labelProgramNeve
            // 
            this.labelProgramNeve.AutoSize = true;
            this.labelProgramNeve.Location = new System.Drawing.Point(86, 29);
            this.labelProgramNeve.Name = "labelProgramNeve";
            this.labelProgramNeve.Size = new System.Drawing.Size(113, 13);
            this.labelProgramNeve.TabIndex = 3;
            this.labelProgramNeve.Text = "Készletkezelő program";
            // 
            // comboBoxreszlegNeve
            // 
            this.comboBoxreszlegNeve.FormattingEnabled = true;
            this.comboBoxreszlegNeve.Items.AddRange(new object[] {
            "termelés",
            "raktár",
            "admin"});
            this.comboBoxreszlegNeve.Location = new System.Drawing.Point(136, 90);
            this.comboBoxreszlegNeve.Name = "comboBoxreszlegNeve";
            this.comboBoxreszlegNeve.Size = new System.Drawing.Size(133, 21);
            this.comboBoxreszlegNeve.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelReszleg);
            this.groupBox1.Controls.Add(this.textBoxjelszo);
            this.groupBox1.Controls.Add(this.textBoxfelhasznaloNev);
            this.groupBox1.Controls.Add(this.labeljelszo);
            this.groupBox1.Controls.Add(this.labelfelhasznaloNev);
            this.groupBox1.Controls.Add(this.buttonVissza);
            this.groupBox1.Controls.Add(this.buttonBelépés);
            this.groupBox1.Controls.Add(this.labelProgramNeve);
            this.groupBox1.Controls.Add(this.comboBoxreszlegNeve);
            this.groupBox1.Location = new System.Drawing.Point(22, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 301);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vad Zrt";
            // 
            // labelReszleg
            // 
            this.labelReszleg.AutoSize = true;
            this.labelReszleg.Location = new System.Drawing.Point(34, 93);
            this.labelReszleg.Name = "labelReszleg";
            this.labelReszleg.Size = new System.Drawing.Size(90, 13);
            this.labelReszleg.TabIndex = 8;
            this.labelReszleg.Text = "Kérem válasszon:";
            // 
            // textBoxjelszo
            // 
            this.textBoxjelszo.Location = new System.Drawing.Point(136, 167);
            this.textBoxjelszo.Name = "textBoxjelszo";
            this.textBoxjelszo.PasswordChar = '*';
            this.textBoxjelszo.Size = new System.Drawing.Size(100, 20);
            this.textBoxjelszo.TabIndex = 7;
            // 
            // textBoxfelhasznaloNev
            // 
            this.textBoxfelhasznaloNev.Location = new System.Drawing.Point(136, 127);
            this.textBoxfelhasznaloNev.Name = "textBoxfelhasznaloNev";
            this.textBoxfelhasznaloNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxfelhasznaloNev.TabIndex = 6;
            // 
            // labeljelszo
            // 
            this.labeljelszo.AutoSize = true;
            this.labeljelszo.Location = new System.Drawing.Point(36, 170);
            this.labeljelszo.Name = "labeljelszo";
            this.labeljelszo.Size = new System.Drawing.Size(39, 13);
            this.labeljelszo.TabIndex = 5;
            this.labeljelszo.Text = "Jelszó:";
            // 
            // labelfelhasznaloNev
            // 
            this.labelfelhasznaloNev.AutoSize = true;
            this.labelfelhasznaloNev.Location = new System.Drawing.Point(34, 130);
            this.labelfelhasznaloNev.Name = "labelfelhasznaloNev";
            this.labelfelhasznaloNev.Size = new System.Drawing.Size(84, 13);
            this.labelfelhasznaloNev.TabIndex = 4;
            this.labelfelhasznaloNev.Text = "Felhasználónév:";
            // 
            // label1BelepesJelzo
            // 
            this.label1BelepesJelzo.AutoSize = true;
            this.label1BelepesJelzo.BackColor = System.Drawing.Color.Navy;
            this.label1BelepesJelzo.ForeColor = System.Drawing.Color.Lime;
            this.label1BelepesJelzo.Location = new System.Drawing.Point(365, 251);
            this.label1BelepesJelzo.Name = "label1BelepesJelzo";
            this.label1BelepesJelzo.Padding = new System.Windows.Forms.Padding(5);
            this.label1BelepesJelzo.Size = new System.Drawing.Size(10, 23);
            this.label1BelepesJelzo.TabIndex = 5;
            this.label1BelepesJelzo.Visible = false;
            // 
            // buttonSzerverKapcsolatLetrehozas
            // 
            this.buttonSzerverKapcsolatLetrehozas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSzerverKapcsolatLetrehozas.Location = new System.Drawing.Point(351, 287);
            this.buttonSzerverKapcsolatLetrehozas.Name = "buttonSzerverKapcsolatLetrehozas";
            this.buttonSzerverKapcsolatLetrehozas.Size = new System.Drawing.Size(151, 37);
            this.buttonSzerverKapcsolatLetrehozas.TabIndex = 6;
            this.buttonSzerverKapcsolatLetrehozas.Text = "Kapcsolódás a szerverhez ";
            this.buttonSzerverKapcsolatLetrehozas.UseVisualStyleBackColor = true;
            this.buttonSzerverKapcsolatLetrehozas.Visible = false;
            this.buttonSzerverKapcsolatLetrehozas.Click += new System.EventHandler(this.buttonSzerverKapcsolatLetrehozas_Click);
            // 
            // buttonSzerverKapcsolatBontas
            // 
            this.buttonSzerverKapcsolatBontas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSzerverKapcsolatBontas.Location = new System.Drawing.Point(351, 330);
            this.buttonSzerverKapcsolatBontas.Name = "buttonSzerverKapcsolatBontas";
            this.buttonSzerverKapcsolatBontas.Size = new System.Drawing.Size(151, 34);
            this.buttonSzerverKapcsolatBontas.TabIndex = 7;
            this.buttonSzerverKapcsolatBontas.Text = "Szerverkapcsolat bontása";
            this.buttonSzerverKapcsolatBontas.UseVisualStyleBackColor = true;
            this.buttonSzerverKapcsolatBontas.Visible = false;
            this.buttonSzerverKapcsolatBontas.Click += new System.EventHandler(this.buttonSzerverKapcsolatBontas_Click);
            // 
            // panelNyito
            // 
            this.panelNyito.AutoSize = true;
            this.panelNyito.Controls.Add(this.groupBox1);
            this.panelNyito.Controls.Add(this.buttonKilépés);
            this.panelNyito.Controls.Add(this.buttonSzerverKapcsolatBontas);
            this.panelNyito.Controls.Add(this.label1BelepesJelzo);
            this.panelNyito.Controls.Add(this.buttonSzerverKapcsolatLetrehozas);
            this.panelNyito.Location = new System.Drawing.Point(132, 173);
            this.panelNyito.Name = "panelNyito";
            this.panelNyito.Size = new System.Drawing.Size(529, 381);
            this.panelNyito.TabIndex = 8;
            // 
            // FormNyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bükklevél;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 746);
            this.ControlBox = false;
            this.Controls.Add(this.panelNyito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormNyito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nyitó oldal";
            this.Load += new System.EventHandler(this.FormNyito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelNyito.ResumeLayout(false);
            this.panelNyito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKilépés;
        private System.Windows.Forms.Button buttonVissza;
        private System.Windows.Forms.Button buttonBelépés;
        private System.Windows.Forms.Label labelProgramNeve;
        private System.Windows.Forms.ComboBox comboBoxreszlegNeve;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxjelszo;
        private System.Windows.Forms.TextBox textBoxfelhasznaloNev;
        private System.Windows.Forms.Label labeljelszo;
        private System.Windows.Forms.Label labelfelhasznaloNev;
        private System.Windows.Forms.Label labelReszleg;
        private System.Windows.Forms.Label label1BelepesJelzo;
        private System.Windows.Forms.Button buttonSzerverKapcsolatLetrehozas;
        private System.Windows.Forms.Button buttonSzerverKapcsolatBontas;
        private System.Windows.Forms.Panel panelNyito;
    }
}

