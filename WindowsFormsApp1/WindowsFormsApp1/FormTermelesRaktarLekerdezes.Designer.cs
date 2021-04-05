namespace WindowsFormsApp1
{
    partial class FormTermeles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTermeles));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.termelésiJelentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raktárkészletLekérdezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTermelesKeszlet = new System.Windows.Forms.DataGridView();
            this.buttonTermelesKilepes = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermelesKeszlet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termelésiJelentésToolStripMenuItem,
            this.raktárkészletLekérdezésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // termelésiJelentésToolStripMenuItem
            // 
            this.termelésiJelentésToolStripMenuItem.Name = "termelésiJelentésToolStripMenuItem";
            this.termelésiJelentésToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.termelésiJelentésToolStripMenuItem.Text = "Termelési jelentés";
            this.termelésiJelentésToolStripMenuItem.Click += new System.EventHandler(this.termelésiJelentésToolStripMenuItem_Click);
            // 
            // raktárkészletLekérdezésToolStripMenuItem
            // 
            this.raktárkészletLekérdezésToolStripMenuItem.Name = "raktárkészletLekérdezésToolStripMenuItem";
            this.raktárkészletLekérdezésToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.raktárkészletLekérdezésToolStripMenuItem.Text = "Raktárkészlet lekérdezés";
            this.raktárkészletLekérdezésToolStripMenuItem.Visible = false;
            this.raktárkészletLekérdezésToolStripMenuItem.Click += new System.EventHandler(this.raktárkészletLekérdezésToolStripMenuItem_Click);
            // 
            // dataGridViewTermelesKeszlet
            // 
            this.dataGridViewTermelesKeszlet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTermelesKeszlet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTermelesKeszlet.Location = new System.Drawing.Point(172, 221);
            this.dataGridViewTermelesKeszlet.Name = "dataGridViewTermelesKeszlet";
            this.dataGridViewTermelesKeszlet.ReadOnly = true;
            this.dataGridViewTermelesKeszlet.Size = new System.Drawing.Size(884, 315);
            this.dataGridViewTermelesKeszlet.TabIndex = 1;
            this.dataGridViewTermelesKeszlet.Visible = false;
            // 
            // buttonTermelesKilepes
            // 
            this.buttonTermelesKilepes.Location = new System.Drawing.Point(1093, 221);
            this.buttonTermelesKilepes.Name = "buttonTermelesKilepes";
            this.buttonTermelesKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonTermelesKilepes.TabIndex = 2;
            this.buttonTermelesKilepes.Text = "Kilépés";
            this.buttonTermelesKilepes.UseVisualStyleBackColor = true;
            this.buttonTermelesKilepes.Click += new System.EventHandler(this.buttonTermelesKilepes_Click);
            // 
            // FormTermeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.ControlBox = false;
            this.Controls.Add(this.buttonTermelesKilepes);
            this.Controls.Add(this.dataGridViewTermelesKeszlet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTermeles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termelés/Raktárkészlet lekérdezés";
            this.Load += new System.EventHandler(this.FormTermeles_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermelesKeszlet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termelésiJelentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raktárkészletLekérdezésToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewTermelesKeszlet;
        private System.Windows.Forms.Button buttonTermelesKilepes;
    }
}