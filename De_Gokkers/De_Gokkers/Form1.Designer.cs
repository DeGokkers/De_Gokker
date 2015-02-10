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
            ((System.ComponentModel.ISupportInitialize)(this.Racecourse)).BeginInit();
            this.SuspendLayout();
            // 
            // Racecourse
            // 
            this.Racecourse.Image = global::De_Gokkers.Properties.Resources.renbaan1;
            this.Racecourse.Location = new System.Drawing.Point(12, 12);
            this.Racecourse.Name = "Racecourse";
            this.Racecourse.Size = new System.Drawing.Size(1003, 496);
            this.Racecourse.TabIndex = 0;
            this.Racecourse.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 482);
            this.Controls.Add(this.Racecourse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hazenrace";
            ((System.ComponentModel.ISupportInitialize)(this.Racecourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Racecourse;
    }
}

