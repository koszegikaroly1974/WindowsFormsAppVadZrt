namespace WindowsFormsApp1
{
    partial class FormRaktar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRaktar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.készletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ÁrukiadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekérdezésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRaktarKilepes = new System.Windows.Forms.Button();
            this.dataGridViewRaktarOsszKeszlet = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaktarOsszKeszlet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.készletToolStripMenuItem,
            this.ÁrukiadásToolStripMenuItem,
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
            // ÁrukiadásToolStripMenuItem
            // 
            this.ÁrukiadásToolStripMenuItem.Name = "ÁrukiadásToolStripMenuItem";
            this.ÁrukiadásToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ÁrukiadásToolStripMenuItem.Text = "Árukiadás";
            this.ÁrukiadásToolStripMenuItem.Click += new System.EventHandler(this.ÁrukiadásToolStripMenuItem_Click);
            // 
            // lekérdezésekToolStripMenuItem
            // 
            this.lekérdezésekToolStripMenuItem.Name = "lekérdezésekToolStripMenuItem";
            this.lekérdezésekToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.lekérdezésekToolStripMenuItem.Text = "Lekérdezések";
            this.lekérdezésekToolStripMenuItem.Click += new System.EventHandler(this.lekérdezésekToolStripMenuItem_Click);
            // 
            // buttonRaktarKilepes
            // 
            this.buttonRaktarKilepes.Location = new System.Drawing.Point(1221, 52);
            this.buttonRaktarKilepes.Name = "buttonRaktarKilepes";
            this.buttonRaktarKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonRaktarKilepes.TabIndex = 1;
            this.buttonRaktarKilepes.Text = "Kilépés";
            this.buttonRaktarKilepes.UseVisualStyleBackColor = true;
            this.buttonRaktarKilepes.Click += new System.EventHandler(this.buttonRaktarKilepes_Click);
            // 
            // dataGridViewRaktarOsszKeszlet
            // 
            this.dataGridViewRaktarOsszKeszlet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRaktarOsszKeszlet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaktarOsszKeszlet.Location = new System.Drawing.Point(177, 173);
            this.dataGridViewRaktarOsszKeszlet.Name = "dataGridViewRaktarOsszKeszlet";
            this.dataGridViewRaktarOsszKeszlet.ReadOnly = true;
            this.dataGridViewRaktarOsszKeszlet.Size = new System.Drawing.Size(993, 373);
            this.dataGridViewRaktarOsszKeszlet.TabIndex = 2;
            this.dataGridViewRaktarOsszKeszlet.Visible = false;
            // 
            // FormRaktar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 746);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewRaktarOsszKeszlet);
            this.Controls.Add(this.buttonRaktarKilepes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRaktar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raktár";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaktarOsszKeszlet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem készletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ÁrukiadásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekérdezésekToolStripMenuItem;
        private System.Windows.Forms.Button buttonRaktarKilepes;
        private System.Windows.Forms.DataGridView dataGridViewRaktarOsszKeszlet;
    }
}