namespace Snake
{
    partial class ScoreboardForm
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
            this.scoreListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreListBox
            // 
            this.scoreListBox.BackColor = System.Drawing.Color.Black;
            this.scoreListBox.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreListBox.ForeColor = System.Drawing.Color.White;
            this.scoreListBox.FormattingEnabled = true;
            this.scoreListBox.ItemHeight = 27;
            this.scoreListBox.Location = new System.Drawing.Point(5, 45);
            this.scoreListBox.Name = "scoreListBox";
            this.scoreListBox.Size = new System.Drawing.Size(376, 490);
            this.scoreListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Highscores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backBTN
            // 
            this.backBTN.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.Location = new System.Drawing.Point(286, 7);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 32);
            this.backBTN.TabIndex = 2;
            this.backBTN.Text = "BACK";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // ScoreboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Snake.Properties.Resources.mainmenubg;
            this.ClientSize = new System.Drawing.Size(386, 555);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreListBox);
            this.Name = "ScoreboardForm";
            this.Text = "ScoreboardForm";
            this.Load += new System.EventHandler(this.ScoreboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox scoreListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBTN;
    }
}