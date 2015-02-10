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
            this.Renbaan = new System.Windows.Forms.PictureBox();
            this.Race = new System.Windows.Forms.Button();
            this.Bet = new System.Windows.Forms.Button();
            this.ChooseDog = new System.Windows.Forms.ComboBox();
            this.BetAmount = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Renbaan)).BeginInit();
            this.SuspendLayout();
            // 
            // Renbaan
            // 
            this.Renbaan.Location = new System.Drawing.Point(12, 12);
            this.Renbaan.Name = "Renbaan";
            this.Renbaan.Size = new System.Drawing.Size(523, 332);
            this.Renbaan.TabIndex = 2;
            this.Renbaan.TabStop = false;
            // 
            // Race
            // 
            this.Race.Location = new System.Drawing.Point(459, 387);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(75, 23);
            this.Race.TabIndex = 3;
            this.Race.Text = "Race";
            this.Race.UseVisualStyleBackColor = true;
            // 
            // Bet
            // 
            this.Bet.Location = new System.Drawing.Point(459, 416);
            this.Bet.Name = "Bet";
            this.Bet.Size = new System.Drawing.Size(75, 23);
            this.Bet.TabIndex = 4;
            this.Bet.Text = "Place bet";
            this.Bet.UseVisualStyleBackColor = true;
            // 
            // ChooseDog
            // 
            this.ChooseDog.FormattingEnabled = true;
            this.ChooseDog.Location = new System.Drawing.Point(332, 418);
            this.ChooseDog.Name = "ChooseDog";
            this.ChooseDog.Size = new System.Drawing.Size(121, 21);
            this.ChooseDog.TabIndex = 5;
            // 
            // BetAmount
            // 
            this.BetAmount.FormattingEnabled = true;
            this.BetAmount.Location = new System.Drawing.Point(332, 388);
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(121, 21);
            this.BetAmount.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(246, 373);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(246, 396);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(246, 419);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "checkBox1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 447);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BetAmount);
            this.Controls.Add(this.ChooseDog);
            this.Controls.Add(this.Bet);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.Renbaan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gevarlijke Hondenrace";
            ((System.ComponentModel.ISupportInitialize)(this.Renbaan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Renbaan;
        private System.Windows.Forms.Button Race;
        private System.Windows.Forms.Button Bet;
        private System.Windows.Forms.ComboBox ChooseDog;
        private System.Windows.Forms.ComboBox BetAmount;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

