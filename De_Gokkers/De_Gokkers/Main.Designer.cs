namespace De_Gokkers
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PlaceBet = new System.Windows.Forms.Button();
            this.HaseChoosing = new System.Windows.Forms.ComboBox();
            this.Amount = new System.Windows.Forms.ComboBox();
            this.Player1 = new System.Windows.Forms.CheckBox();
            this.Player2 = new System.Windows.Forms.CheckBox();
            this.Player3 = new System.Windows.Forms.CheckBox();
            this.Player1Stats = new System.Windows.Forms.Label();
            this.Player2Stats = new System.Windows.Forms.Label();
            this.Player3Stats = new System.Windows.Forms.Label();
            this.Player4 = new System.Windows.Forms.CheckBox();
            this.Player4Stats = new System.Windows.Forms.Label();
            this.Winner = new System.Windows.Forms.Label();
            this.PlayerTable = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.overHazenRaceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overHazenRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WinnerTable = new System.Windows.Forms.GroupBox();
            this.Run = new System.Windows.Forms.Button();
            this.Hase4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Hase3 = new System.Windows.Forms.PictureBox();
            this.Hase2 = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.GroupBox();
            this.MenuTable = new System.Windows.Forms.GroupBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.PlayerTable.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.WinnerTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hase4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hase3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hase2)).BeginInit();
            this.Background.SuspendLayout();
            this.MenuTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaceBet
            // 
            this.PlaceBet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaceBet.Location = new System.Drawing.Point(469, 83);
            this.PlaceBet.Margin = new System.Windows.Forms.Padding(2);
            this.PlaceBet.Name = "PlaceBet";
            this.PlaceBet.Size = new System.Drawing.Size(72, 31);
            this.PlaceBet.TabIndex = 2;
            this.PlaceBet.TabStop = false;
            this.PlaceBet.Text = "Place bet";
            this.PlaceBet.UseVisualStyleBackColor = true;
            // 
            // HaseChoosing
            // 
            this.HaseChoosing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HaseChoosing.FormattingEnabled = true;
            this.HaseChoosing.Location = new System.Drawing.Point(278, 92);
            this.HaseChoosing.Margin = new System.Windows.Forms.Padding(2);
            this.HaseChoosing.Name = "HaseChoosing";
            this.HaseChoosing.Size = new System.Drawing.Size(185, 21);
            this.HaseChoosing.TabIndex = 6;
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount.FormattingEnabled = true;
            this.Amount.Location = new System.Drawing.Point(89, 92);
            this.Amount.Margin = new System.Windows.Forms.Padding(2);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(185, 21);
            this.Amount.TabIndex = 5;
            // 
            // Player1
            // 
            this.Player1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(18, 23);
            this.Player1.Margin = new System.Windows.Forms.Padding(2);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(45, 17);
            this.Player1.TabIndex = 1;
            this.Player1.Text = "Lidy";
            this.Player1.UseVisualStyleBackColor = true;
            this.Player1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Player1_KeyDown);
            // 
            // Player2
            // 
            this.Player2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(18, 47);
            this.Player2.Margin = new System.Windows.Forms.Padding(2);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(41, 17);
            this.Player2.TabIndex = 2;
            this.Player2.Text = "Fer";
            this.Player2.UseVisualStyleBackColor = true;
            // 
            // Player3
            // 
            this.Player3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Player3.AutoSize = true;
            this.Player3.Location = new System.Drawing.Point(18, 70);
            this.Player3.Margin = new System.Windows.Forms.Padding(2);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(55, 17);
            this.Player3.TabIndex = 3;
            this.Player3.Text = "Sietse";
            this.Player3.UseVisualStyleBackColor = true;
            // 
            // Player1Stats
            // 
            this.Player1Stats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Player1Stats.AutoSize = true;
            this.Player1Stats.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Stats.Location = new System.Drawing.Point(29, 21);
            this.Player1Stats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player1Stats.Name = "Player1Stats";
            this.Player1Stats.Size = new System.Drawing.Size(117, 26);
            this.Player1Stats.TabIndex = 5;
            this.Player1Stats.Text = "Lidy:  € 0,00";
            this.Player1Stats.Click += new System.EventHandler(this.Player1Stats_Click);
            // 
            // Player2Stats
            // 
            this.Player2Stats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Player2Stats.AutoSize = true;
            this.Player2Stats.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Stats.Location = new System.Drawing.Point(36, 44);
            this.Player2Stats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player2Stats.Name = "Player2Stats";
            this.Player2Stats.Size = new System.Drawing.Size(110, 26);
            this.Player2Stats.TabIndex = 5;
            this.Player2Stats.Text = "Fer:  € 0,00";
            this.Player2Stats.Click += new System.EventHandler(this.Player2Stats_Click);
            // 
            // Player3Stats
            // 
            this.Player3Stats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Player3Stats.AutoSize = true;
            this.Player3Stats.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3Stats.Location = new System.Drawing.Point(12, 65);
            this.Player3Stats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player3Stats.Name = "Player3Stats";
            this.Player3Stats.Size = new System.Drawing.Size(134, 26);
            this.Player3Stats.TabIndex = 5;
            this.Player3Stats.Text = "Sietse:  € 0,00";
            this.Player3Stats.Click += new System.EventHandler(this.Player3Stats_Click);
            // 
            // Player4
            // 
            this.Player4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Player4.AutoSize = true;
            this.Player4.Location = new System.Drawing.Point(18, 94);
            this.Player4.Margin = new System.Windows.Forms.Padding(2);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(54, 17);
            this.Player4.TabIndex = 4;
            this.Player4.Text = "Name";
            this.Player4.UseVisualStyleBackColor = true;
            // 
            // Player4Stats
            // 
            this.Player4Stats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Player4Stats.AutoSize = true;
            this.Player4Stats.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4Stats.Location = new System.Drawing.Point(45, 87);
            this.Player4Stats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player4Stats.Name = "Player4Stats";
            this.Player4Stats.Size = new System.Drawing.Size(101, 26);
            this.Player4Stats.TabIndex = 5;
            this.Player4Stats.Text = "ID:  € 0,00";
            // 
            // Winner
            // 
            this.Winner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Winner.AutoSize = true;
            this.Winner.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner.ForeColor = System.Drawing.Color.Green;
            this.Winner.Location = new System.Drawing.Point(6, 18);
            this.Winner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(161, 23);
            this.Winner.TabIndex = 6;
            this.Winner.Text = "ID: won this round!";
            // 
            // PlayerTable
            // 
            this.PlayerTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerTable.Controls.Add(this.Player3Stats);
            this.PlayerTable.Controls.Add(this.Player4Stats);
            this.PlayerTable.Controls.Add(this.Player1Stats);
            this.PlayerTable.Controls.Add(this.Player2Stats);
            this.PlayerTable.Location = new System.Drawing.Point(0, 2);
            this.PlayerTable.Margin = new System.Windows.Forms.Padding(2);
            this.PlayerTable.Name = "PlayerTable";
            this.PlayerTable.Padding = new System.Windows.Forms.Padding(2);
            this.PlayerTable.Size = new System.Drawing.Size(191, 120);
            this.PlayerTable.TabIndex = 7;
            this.PlayerTable.TabStop = false;
            this.PlayerTable.Text = "Players:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1002, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem1
            // 
            this.bestandToolStripMenuItem1.Name = "bestandToolStripMenuItem1";
            this.bestandToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bestandToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem1.Text = "&Bestand";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overHazenRaceToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // overHazenRaceToolStripMenuItem1
            // 
            this.overHazenRaceToolStripMenuItem1.Name = "overHazenRaceToolStripMenuItem1";
            this.overHazenRaceToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.overHazenRaceToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.overHazenRaceToolStripMenuItem1.Text = "&Over HazenRace";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "&Bestand";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overHazenRaceToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // overHazenRaceToolStripMenuItem
            // 
            this.overHazenRaceToolStripMenuItem.Name = "overHazenRaceToolStripMenuItem";
            this.overHazenRaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.overHazenRaceToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.overHazenRaceToolStripMenuItem.Text = "&Over HazenRace ";
            // 
            // WinnerTable
            // 
            this.WinnerTable.Controls.Add(this.Winner);
            this.WinnerTable.Location = new System.Drawing.Point(190, 2);
            this.WinnerTable.Margin = new System.Windows.Forms.Padding(2);
            this.WinnerTable.Name = "WinnerTable";
            this.WinnerTable.Padding = new System.Windows.Forms.Padding(2);
            this.WinnerTable.Size = new System.Drawing.Size(272, 128);
            this.WinnerTable.TabIndex = 9;
            this.WinnerTable.TabStop = false;
            this.WinnerTable.Text = "Winner:";
            // 
            // Run
            // 
            this.Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Run.BackColor = System.Drawing.Color.Transparent;
            this.Run.Image = ((System.Drawing.Image)(resources.GetObject("Run.Image")));
            this.Run.Location = new System.Drawing.Point(469, 8);
            this.Run.Margin = new System.Windows.Forms.Padding(2);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(72, 73);
            this.Run.TabIndex = 2;
            this.Run.TabStop = false;
            this.Run.UseVisualStyleBackColor = false;
            // 
            // Hase4
            // 
            this.Hase4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Hase4.BackColor = System.Drawing.Color.Transparent;
            this.Hase4.Image = global::De_Gokkers.Properties.Resources.Hase_4;
            this.Hase4.Location = new System.Drawing.Point(927, 342);
            this.Hase4.Margin = new System.Windows.Forms.Padding(2);
            this.Hase4.Name = "Hase4";
            this.Hase4.Size = new System.Drawing.Size(71, 71);
            this.Hase4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Hase4.TabIndex = 1;
            this.Hase4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::De_Gokkers.Properties.Resources.Hase_1;
            this.pictureBox1.Location = new System.Drawing.Point(927, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Hase3
            // 
            this.Hase3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Hase3.BackColor = System.Drawing.Color.Transparent;
            this.Hase3.Image = global::De_Gokkers.Properties.Resources.Hase_3;
            this.Hase3.Location = new System.Drawing.Point(927, 257);
            this.Hase3.Margin = new System.Windows.Forms.Padding(2);
            this.Hase3.Name = "Hase3";
            this.Hase3.Size = new System.Drawing.Size(71, 71);
            this.Hase3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Hase3.TabIndex = 1;
            this.Hase3.TabStop = false;
            // 
            // Hase2
            // 
            this.Hase2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Hase2.BackColor = System.Drawing.Color.Transparent;
            this.Hase2.Image = global::De_Gokkers.Properties.Resources.Hase_2;
            this.Hase2.Location = new System.Drawing.Point(927, 172);
            this.Hase2.Margin = new System.Windows.Forms.Padding(2);
            this.Hase2.Name = "Hase2";
            this.Hase2.Size = new System.Drawing.Size(71, 71);
            this.Hase2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Hase2.TabIndex = 1;
            this.Hase2.TabStop = false;
            // 
            // Background
            // 
            this.Background.Controls.Add(this.PlayerTable);
            this.Background.Controls.Add(this.MenuTable);
            this.Background.Controls.Add(this.WinnerTable);
            this.Background.Location = new System.Drawing.Point(0, 495);
            this.Background.Margin = new System.Windows.Forms.Padding(2);
            this.Background.Name = "Background";
            this.Background.Padding = new System.Windows.Forms.Padding(2);
            this.Background.Size = new System.Drawing.Size(1002, 122);
            this.Background.TabIndex = 10;
            this.Background.TabStop = false;
            // 
            // MenuTable
            // 
            this.MenuTable.Controls.Add(this.Player4);
            this.MenuTable.Controls.Add(this.Player1);
            this.MenuTable.Controls.Add(this.Player3);
            this.MenuTable.Controls.Add(this.HaseChoosing);
            this.MenuTable.Controls.Add(this.PlaceBet);
            this.MenuTable.Controls.Add(this.Player2);
            this.MenuTable.Controls.Add(this.Run);
            this.MenuTable.Controls.Add(this.Amount);
            this.MenuTable.Location = new System.Drawing.Point(458, 2);
            this.MenuTable.Margin = new System.Windows.Forms.Padding(2);
            this.MenuTable.Name = "MenuTable";
            this.MenuTable.Padding = new System.Windows.Forms.Padding(2);
            this.MenuTable.Size = new System.Drawing.Size(544, 138);
            this.MenuTable.TabIndex = 10;
            this.MenuTable.TabStop = false;
            this.MenuTable.Text = "Menu:";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(766, 11);
            this.lbl_User.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(53, 13);
            this.lbl_User.TabIndex = 4;
            this.lbl_User.Text = "Gebruiker";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::De_Gokkers.Properties.Resources.Renbaan;
            this.ClientSize = new System.Drawing.Size(1002, 617);
            this.Controls.Add(this.Hase4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hase3);
            this.Controls.Add(this.Hase2);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.lbl_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HazenRace";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PlayerTable.ResumeLayout(false);
            this.PlayerTable.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.WinnerTable.ResumeLayout(false);
            this.WinnerTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hase4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hase3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hase2)).EndInit();
            this.Background.ResumeLayout(false);
            this.MenuTable.ResumeLayout(false);
            this.MenuTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Hase2;
        private System.Windows.Forms.PictureBox Hase3;
        private System.Windows.Forms.PictureBox Hase4;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button PlaceBet;
        private System.Windows.Forms.ComboBox HaseChoosing;
        private System.Windows.Forms.ComboBox Amount;
        private System.Windows.Forms.CheckBox Player2;
        private System.Windows.Forms.CheckBox Player3;
        private System.Windows.Forms.Label Player1Stats;
        private System.Windows.Forms.Label Player2Stats;
        private System.Windows.Forms.Label Player3Stats;
        private System.Windows.Forms.CheckBox Player4;
        private System.Windows.Forms.Label Player4Stats;
        private System.Windows.Forms.Label Winner;
        private System.Windows.Forms.GroupBox PlayerTable;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overHazenRaceToolStripMenuItem;
        private System.Windows.Forms.GroupBox WinnerTable;
        private System.Windows.Forms.CheckBox Player1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Background;
        private System.Windows.Forms.GroupBox MenuTable;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem overHazenRaceToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_User;
    }
}
