namespace FifaManager
{
    partial class FifaManagerMdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FifaManagerMdi));
            this.MatchManagementMnu = new System.Windows.Forms.MenuStrip();
            this.FifaManagerMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.JoueursMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionMatchsMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassementMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.MatchManagmentMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChampionnatMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.EquipesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MatchManagementMnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MatchManagementMnu
            // 
            this.MatchManagementMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FifaManagerMnu,
            this.MatchManagmentMnu});
            this.MatchManagementMnu.Location = new System.Drawing.Point(0, 0);
            this.MatchManagementMnu.Name = "MatchManagementMnu";
            this.MatchManagementMnu.Size = new System.Drawing.Size(800, 24);
            this.MatchManagementMnu.TabIndex = 3;
            this.MatchManagementMnu.Text = "MatchManagementMnu";
            // 
            // FifaManagerMnu
            // 
            this.FifaManagerMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JoueursMnu,
            this.GestionMatchsMnu,
            this.ClassementMnu});
            this.FifaManagerMnu.Name = "FifaManagerMnu";
            this.FifaManagerMnu.Size = new System.Drawing.Size(64, 20);
            this.FifaManagerMnu.Text = "BackEnd";
            // 
            // JoueursMnu
            // 
            this.JoueursMnu.Name = "JoueursMnu";
            this.JoueursMnu.Size = new System.Drawing.Size(156, 22);
            this.JoueursMnu.Text = "Joueurs";
            this.JoueursMnu.Click += new System.EventHandler(this.JoueursMnu_Click);
            // 
            // GestionMatchsMnu
            // 
            this.GestionMatchsMnu.Name = "GestionMatchsMnu";
            this.GestionMatchsMnu.Size = new System.Drawing.Size(156, 22);
            this.GestionMatchsMnu.Text = "Gestion Matchs";
            this.GestionMatchsMnu.Click += new System.EventHandler(this.GestionMatchsMnu_Click);
            // 
            // ClassementMnu
            // 
            this.ClassementMnu.Name = "ClassementMnu";
            this.ClassementMnu.Size = new System.Drawing.Size(156, 22);
            this.ClassementMnu.Text = "Classement";
            this.ClassementMnu.Click += new System.EventHandler(this.ClassementMnu_Click);
            // 
            // MatchManagmentMnu
            // 
            this.MatchManagmentMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChampionnatMnu,
            this.EquipesMenu});
            this.MatchManagmentMnu.Name = "MatchManagmentMnu";
            this.MatchManagmentMnu.Size = new System.Drawing.Size(118, 20);
            this.MatchManagmentMnu.Text = "MatchManagment";
            // 
            // ChampionnatMnu
            // 
            this.ChampionnatMnu.Name = "ChampionnatMnu";
            this.ChampionnatMnu.Size = new System.Drawing.Size(147, 22);
            this.ChampionnatMnu.Text = "Championnat";
            this.ChampionnatMnu.Click += new System.EventHandler(this.ChampionnatMnu_Click);
            // 
            // EquipesMenu
            // 
            this.EquipesMenu.Name = "EquipesMenu";
            this.EquipesMenu.Size = new System.Drawing.Size(147, 22);
            this.EquipesMenu.Text = "Equipes";
            this.EquipesMenu.Click += new System.EventHandler(this.EquipesMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FifaManagerMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MatchManagementMnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MatchManagementMnu;
            this.Name = "FifaManagerMdi";
            this.Text = "FifaManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MatchManagementMnu.ResumeLayout(false);
            this.MatchManagementMnu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MatchManagementMnu;
        private System.Windows.Forms.ToolStripMenuItem FifaManagerMnu;
        private System.Windows.Forms.ToolStripMenuItem ClassementMnu;
        private System.Windows.Forms.ToolStripMenuItem JoueursMnu;
        private System.Windows.Forms.ToolStripMenuItem GestionMatchsMnu;
        private System.Windows.Forms.ToolStripMenuItem MatchManagmentMnu;
        private System.Windows.Forms.ToolStripMenuItem ChampionnatMnu;
        private System.Windows.Forms.ToolStripMenuItem EquipesMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

