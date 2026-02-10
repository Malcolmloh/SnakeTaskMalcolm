namespace Snake
{
    partial class confirmexit
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
            this.quitBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHighLevel = new System.Windows.Forms.TextBox();
            this.lblPlayTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quitBTN
            // 
            this.quitBTN.BackColor = System.Drawing.Color.SeaGreen;
            this.quitBTN.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBTN.ForeColor = System.Drawing.Color.White;
            this.quitBTN.Location = new System.Drawing.Point(38, 218);
            this.quitBTN.Name = "quitBTN";
            this.quitBTN.Size = new System.Drawing.Size(190, 36);
            this.quitBTN.TabIndex = 3;
            this.quitBTN.Text = "CONFIRM EXIT?";
            this.quitBTN.UseVisualStyleBackColor = false;
            this.quitBTN.Click += new System.EventHandler(this.quitBTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(284, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "BACK TO MENU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHighLevel
            // 
            this.lblHighLevel.BackColor = System.Drawing.Color.MintCream;
            this.lblHighLevel.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighLevel.Location = new System.Drawing.Point(74, 54);
            this.lblHighLevel.Name = "lblHighLevel";
            this.lblHighLevel.ReadOnly = true;
            this.lblHighLevel.Size = new System.Drawing.Size(371, 29);
            this.lblHighLevel.TabIndex = 5;
            this.lblHighLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.BackColor = System.Drawing.Color.MintCream;
            this.lblPlayTime.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayTime.Location = new System.Drawing.Point(74, 115);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.ReadOnly = true;
            this.lblPlayTime.Size = new System.Drawing.Size(371, 29);
            this.lblPlayTime.TabIndex = 6;
            this.lblPlayTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmexit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.infobg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 312);
            this.Controls.Add(this.lblPlayTime);
            this.Controls.Add(this.lblHighLevel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quitBTN);
            this.Name = "confirmexit";
            this.Text = "confirmexit";
            this.Load += new System.EventHandler(this.confirmexit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quitBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lblHighLevel;
        private System.Windows.Forms.TextBox lblPlayTime;
    }
}