namespace ToDo_Beta
{
    partial class frmKezdo
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
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.listákKezeléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mBeolvasas = new System.Windows.Forms.ToolStripMenuItem();
            this.mMentes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mKilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBevitel = new System.Windows.Forms.TextBox();
            this.lbToDo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.btnListabol = new System.Windows.Forms.Button();
            this.btnKivesz = new System.Windows.Forms.Button();
            this.btnEltavolit = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.mMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenu
            // 
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listákKezeléseToolStripMenuItem});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(580, 24);
            this.mMenu.TabIndex = 0;
            this.mMenu.Text = "menuStrip1";
            // 
            // listákKezeléseToolStripMenuItem
            // 
            this.listákKezeléseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mBeolvasas,
            this.mMentes,
            this.toolStripMenuItem1,
            this.mKilepes});
            this.listákKezeléseToolStripMenuItem.Name = "listákKezeléseToolStripMenuItem";
            this.listákKezeléseToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.listákKezeléseToolStripMenuItem.Text = "Listák Kezelése";
            // 
            // mBeolvasas
            // 
            this.mBeolvasas.Name = "mBeolvasas";
            this.mBeolvasas.Size = new System.Drawing.Size(180, 22);
            this.mBeolvasas.Text = "Beolvasás";
            // 
            // mMentes
            // 
            this.mMentes.Name = "mMentes";
            this.mMentes.Size = new System.Drawing.Size(180, 22);
            this.mMentes.Text = "Mentés";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mKilepes
            // 
            this.mKilepes.Name = "mKilepes";
            this.mKilepes.Size = new System.Drawing.Size(180, 22);
            this.mKilepes.Text = "Kilépés";
            this.mKilepes.Click += new System.EventHandler(this.mKilepes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnEltavolit);
            this.panel1.Controls.Add(this.btnKivesz);
            this.panel1.Controls.Add(this.btnListabol);
            this.panel1.Controls.Add(this.btnFelvitel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbToDo);
            this.panel1.Controls.Add(this.tbBevitel);
            this.panel1.Location = new System.Drawing.Point(25, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 415);
            this.panel1.TabIndex = 1;
            // 
            // tbBevitel
            // 
            this.tbBevitel.Location = new System.Drawing.Point(18, 13);
            this.tbBevitel.Name = "tbBevitel";
            this.tbBevitel.Size = new System.Drawing.Size(270, 26);
            this.tbBevitel.TabIndex = 2;
            // 
            // lbToDo
            // 
            this.lbToDo.FormattingEnabled = true;
            this.lbToDo.ItemHeight = 20;
            this.lbToDo.Location = new System.Drawing.Point(18, 72);
            this.lbToDo.Name = "lbToDo";
            this.lbToDo.Size = new System.Drawing.Size(270, 284);
            this.lbToDo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tennivalók";
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.BackgroundImage = global::ToDo_Beta.Properties.Resources.check_mark;
            this.btnFelvitel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFelvitel.Location = new System.Drawing.Point(294, 6);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(40, 40);
            this.btnFelvitel.TabIndex = 5;
            this.btnFelvitel.UseVisualStyleBackColor = true;
            // 
            // btnListabol
            // 
            this.btnListabol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListabol.Location = new System.Drawing.Point(294, 72);
            this.btnListabol.Name = "btnListabol";
            this.btnListabol.Size = new System.Drawing.Size(40, 40);
            this.btnListabol.TabIndex = 6;
            this.btnListabol.UseVisualStyleBackColor = true;
            this.btnListabol.Click += new System.EventHandler(this.btnListabol_Click);
            // 
            // btnKivesz
            // 
            this.btnKivesz.BackgroundImage = global::ToDo_Beta.Properties.Resources.minus;
            this.btnKivesz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKivesz.Location = new System.Drawing.Point(294, 127);
            this.btnKivesz.Name = "btnKivesz";
            this.btnKivesz.Size = new System.Drawing.Size(40, 40);
            this.btnKivesz.TabIndex = 6;
            this.btnKivesz.UseVisualStyleBackColor = true;
            // 
            // btnEltavolit
            // 
            this.btnEltavolit.BackgroundImage = global::ToDo_Beta.Properties.Resources.delete;
            this.btnEltavolit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEltavolit.Location = new System.Drawing.Point(294, 316);
            this.btnEltavolit.Name = "btnEltavolit";
            this.btnEltavolit.Size = new System.Drawing.Size(40, 40);
            this.btnEltavolit.TabIndex = 6;
            this.btnEltavolit.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Image = global::ToDo_Beta.Properties.Resources.exit;
            this.btnKilepes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKilepes.Location = new System.Drawing.Point(409, 366);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.btnKilepes.Size = new System.Drawing.Size(149, 70);
            this.btnKilepes.TabIndex = 7;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // frmKezdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 457);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKezdo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo Lista készítés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.frmKezdo_Shown);
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem listákKezeléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mBeolvasas;
        private System.Windows.Forms.ToolStripMenuItem mMentes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mKilepes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEltavolit;
        private System.Windows.Forms.Button btnKivesz;
        private System.Windows.Forms.Button btnListabol;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbToDo;
        private System.Windows.Forms.TextBox tbBevitel;
        private System.Windows.Forms.Button btnKilepes;
    }
}

