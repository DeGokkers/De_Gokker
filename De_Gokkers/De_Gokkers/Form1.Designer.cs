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
            this.Racecourse = new System.Windows.Forms.PictureBox();
            this.btn_PlaceBet = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lst_SelectUser = new System.Windows.Forms.ListBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Bet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_SelectHase = new System.Windows.Forms.ListBox();
            this.lbl_CashLidy = new System.Windows.Forms.Label();
            this.lbl_CashFer = new System.Windows.Forms.Label();
            this.lbl_CashSietse = new System.Windows.Forms.Label();
            this.lbl_Cash = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Countdown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Racecourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Racecourse
            // 
            this.Racecourse.Image = global::De_Gokkers.Properties.Resources.renbaan1;
            this.Racecourse.Location = new System.Drawing.Point(13, 13);
            this.Racecourse.Margin = new System.Windows.Forms.Padding(4);
            this.Racecourse.Name = "Racecourse";
            this.Racecourse.Size = new System.Drawing.Size(1002, 508);
            this.Racecourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Racecourse.TabIndex = 0;
            this.Racecourse.TabStop = false;
            // 
            // btn_PlaceBet
            // 
            this.btn_PlaceBet.Location = new System.Drawing.Point(1025, 62);
            this.btn_PlaceBet.Name = "btn_PlaceBet";
            this.btn_PlaceBet.Size = new System.Drawing.Size(256, 23);
            this.btn_PlaceBet.TabIndex = 1;
            this.btn_PlaceBet.Text = "Plaats weddenschap";
            this.btn_PlaceBet.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1059, 34);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(34, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lst_SelectUser
            // 
            this.lst_SelectUser.FormattingEnabled = true;
            this.lst_SelectUser.ItemHeight = 16;
            this.lst_SelectUser.Location = new System.Drawing.Point(1099, 13);
            this.lst_SelectUser.Name = "lst_SelectUser";
            this.lst_SelectUser.ScrollAlwaysVisible = true;
            this.lst_SelectUser.Size = new System.Drawing.Size(182, 20);
            this.lst_SelectUser.TabIndex = 3;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(1022, 13);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(71, 17);
            this.lbl_User.TabIndex = 4;
            this.lbl_User.Text = "Gebruiker";
            // 
            // lbl_Bet
            // 
            this.lbl_Bet.AutoSize = true;
            this.lbl_Bet.Location = new System.Drawing.Point(1022, 36);
            this.lbl_Bet.Name = "lbl_Bet";
            this.lbl_Bet.Size = new System.Drawing.Size(33, 17);
            this.lbl_Bet.TabIndex = 5;
            this.lbl_Bet.Text = "wed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1096, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "op haas";
            // 
            // lst_SelectHase
            // 
            this.lst_SelectHase.FormattingEnabled = true;
            this.lst_SelectHase.ItemHeight = 16;
            this.lst_SelectHase.Location = new System.Drawing.Point(1161, 36);
            this.lst_SelectHase.Name = "lst_SelectHase";
            this.lst_SelectHase.ScrollAlwaysVisible = true;
            this.lst_SelectHase.Size = new System.Drawing.Size(120, 20);
            this.lst_SelectHase.TabIndex = 8;
            // 
            // lbl_CashLidy
            // 
            this.lbl_CashLidy.AutoSize = true;
            this.lbl_CashLidy.Location = new System.Drawing.Point(1034, 139);
            this.lbl_CashLidy.Name = "lbl_CashLidy";
            this.lbl_CashLidy.Size = new System.Drawing.Size(58, 17);
            this.lbl_CashLidy.TabIndex = 9;
            this.lbl_CashLidy.Text = "Lidy: 50";
            // 
            // lbl_CashFer
            // 
            this.lbl_CashFer.AutoSize = true;
            this.lbl_CashFer.Location = new System.Drawing.Point(1034, 122);
            this.lbl_CashFer.Name = "lbl_CashFer";
            this.lbl_CashFer.Size = new System.Drawing.Size(53, 17);
            this.lbl_CashFer.TabIndex = 10;
            this.lbl_CashFer.Text = "Fer: 50";
            // 
            // lbl_CashSietse
            // 
            this.lbl_CashSietse.AutoSize = true;
            this.lbl_CashSietse.Location = new System.Drawing.Point(1034, 105);
            this.lbl_CashSietse.Name = "lbl_CashSietse";
            this.lbl_CashSietse.Size = new System.Drawing.Size(71, 17);
            this.lbl_CashSietse.TabIndex = 11;
            this.lbl_CashSietse.Text = "Sietse: 50";
            // 
            // lbl_Cash
            // 
            this.lbl_Cash.AutoSize = true;
            this.lbl_Cash.Location = new System.Drawing.Point(1022, 88);
            this.lbl_Cash.Name = "lbl_Cash";
            this.lbl_Cash.Size = new System.Drawing.Size(44, 17);
            this.lbl_Cash.TabIndex = 12;
            this.lbl_Cash.Text = "Cash:";
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(1025, 176);
            this.txt_Status.Multiline = true;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(256, 63);
            this.txt_Status.TabIndex = 13;
            this.txt_Status.Text = "Plaats weddenschappen om te beginnen";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(1022, 156);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(52, 17);
            this.lbl_Status.TabIndex = 14;
            this.lbl_Status.Text = "Status:";
            // 
            // lbl_Countdown
            // 
            this.lbl_Countdown.AutoSize = true;
            this.lbl_Countdown.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Countdown.Location = new System.Drawing.Point(1227, 105);
            this.lbl_Countdown.Name = "lbl_Countdown";
            this.lbl_Countdown.Size = new System.Drawing.Size(47, 49);
            this.lbl_Countdown.TabIndex = 15;
            this.lbl_Countdown.Text = "8";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 528);
            this.Controls.Add(this.lbl_Countdown);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.lbl_Cash);
            this.Controls.Add(this.lbl_CashSietse);
            this.Controls.Add(this.lbl_CashFer);
            this.Controls.Add(this.lbl_CashLidy);
            this.Controls.Add(this.lst_SelectHase);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Bet);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lst_SelectUser);
            this.Controls.Add(this.btn_PlaceBet);
            this.Controls.Add(this.Racecourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            ((System.ComponentModel.ISupportInitialize)(this.Racecourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Racecourse;
        private System.Windows.Forms.Button btn_PlaceBet;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox lst_SelectUser;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Bet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_SelectHase;
        private System.Windows.Forms.Label lbl_CashLidy;
        private System.Windows.Forms.Label lbl_CashFer;
        private System.Windows.Forms.Label lbl_CashSietse;
        private System.Windows.Forms.Label lbl_Cash;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Countdown;
    }
}

