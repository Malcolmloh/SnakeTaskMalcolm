namespace Snake
{
    partial class MenuForm
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
            this.startBTN = new System.Windows.Forms.Button();
            this.scoreboardBTN = new System.Windows.Forms.Button();
            this.quitBTN = new System.Windows.Forms.Button();
            this.infoBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.startBTN.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.ForeColor = System.Drawing.Color.White;
            this.startBTN.Location = new System.Drawing.Point(313, 250);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(190, 36);
            this.startBTN.TabIndex = 0;
            this.startBTN.Text = "START";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // scoreboardBTN
            // 
            this.scoreboardBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.scoreboardBTN.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardBTN.ForeColor = System.Drawing.Color.White;
            this.scoreboardBTN.Location = new System.Drawing.Point(313, 292);
            this.scoreboardBTN.Name = "scoreboardBTN";
            this.scoreboardBTN.Size = new System.Drawing.Size(192, 36);
            this.scoreboardBTN.TabIndex = 1;
            this.scoreboardBTN.Text = "SCOREBOARD";
            this.scoreboardBTN.UseVisualStyleBackColor = false;
            this.scoreboardBTN.Click += new System.EventHandler(this.optionsBTN_Click);
            // 
            // quitBTN
            // 
            this.quitBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.quitBTN.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBTN.ForeColor = System.Drawing.Color.White;
            this.quitBTN.Location = new System.Drawing.Point(313, 376);
            this.quitBTN.Name = "quitBTN";
            this.quitBTN.Size = new System.Drawing.Size(190, 36);
            this.quitBTN.TabIndex = 2;
            this.quitBTN.Text = "QUIT";
            this.quitBTN.UseVisualStyleBackColor = false;
            this.quitBTN.Click += new System.EventHandler(this.quitBTN_Click);
            // 
            // infoBTN
            // 
            this.infoBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.infoBTN.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBTN.ForeColor = System.Drawing.Color.White;
            this.infoBTN.Location = new System.Drawing.Point(313, 334);
            this.infoBTN.Name = "infoBTN";
            this.infoBTN.Size = new System.Drawing.Size(190, 36);
            this.infoBTN.TabIndex = 3;
            this.infoBTN.Text = "INFO";
            this.infoBTN.UseVisualStyleBackColor = false;
            this.infoBTN.Click += new System.EventHandler(this.infoBTN_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.mainmenubg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoBTN);
            this.Controls.Add(this.quitBTN);
            this.Controls.Add(this.scoreboardBTN);
            this.Controls.Add(this.startBTN);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.VisibleChanged += new System.EventHandler(this.MenuForm_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button scoreboardBTN;
        private System.Windows.Forms.Button quitBTN;
        private System.Windows.Forms.Button infoBTN;
    }
}