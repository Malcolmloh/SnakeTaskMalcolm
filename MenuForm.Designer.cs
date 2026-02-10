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
            this.titleLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menudeco1 = new System.Windows.Forms.PictureBox();
            this.menudeco2 = new System.Windows.Forms.PictureBox();
            this.muteBTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.menudeco1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menudeco2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muteBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.startBTN.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.scoreboardBTN.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.quitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.infoBTN.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.BackColor = System.Drawing.Color.Transparent;
            this.titleLBL.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLBL.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.SeaGreen;
            this.titleLBL.Location = new System.Drawing.Point(142, 43);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(528, 74);
            this.titleLBL.TabIndex = 4;
            this.titleLBL.Text = "CATCH THEM ALL";
            this.titleLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLBL.Click += new System.EventHandler(this.titleLBL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(241, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ash and Lily\'s Adventure";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menudeco1
            // 
            this.menudeco1.BackColor = System.Drawing.Color.Transparent;
            this.menudeco1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menudeco1.Image = global::Snake.Properties.Resources.legendpokemon1;
            this.menudeco1.Location = new System.Drawing.Point(0, 26);
            this.menudeco1.Name = "menudeco1";
            this.menudeco1.Size = new System.Drawing.Size(222, 195);
            this.menudeco1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menudeco1.TabIndex = 6;
            this.menudeco1.TabStop = false;
            // 
            // menudeco2
            // 
            this.menudeco2.BackColor = System.Drawing.Color.Transparent;
            this.menudeco2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menudeco2.Image = global::Snake.Properties.Resources.legendpokemon2;
            this.menudeco2.Location = new System.Drawing.Point(531, 217);
            this.menudeco2.Name = "menudeco2";
            this.menudeco2.Size = new System.Drawing.Size(222, 195);
            this.menudeco2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menudeco2.TabIndex = 7;
            this.menudeco2.TabStop = false;
            // 
            // muteBTN
            // 
            this.muteBTN.BackColor = System.Drawing.Color.Transparent;
            this.muteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteBTN.Image = global::Snake.Properties.Resources.mutebutton4;
            this.muteBTN.Location = new System.Drawing.Point(0, 351);
            this.muteBTN.Name = "muteBTN";
            this.muteBTN.Size = new System.Drawing.Size(135, 99);
            this.muteBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.muteBTN.TabIndex = 8;
            this.muteBTN.TabStop = false;
            this.muteBTN.Click += new System.EventHandler(this.muteBTN_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.startmenubganimated1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.muteBTN);
            this.Controls.Add(this.menudeco2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLBL);
            this.Controls.Add(this.infoBTN);
            this.Controls.Add(this.quitBTN);
            this.Controls.Add(this.scoreboardBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.menudeco1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.VisibleChanged += new System.EventHandler(this.MenuForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.menudeco1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menudeco2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muteBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button scoreboardBTN;
        private System.Windows.Forms.Button quitBTN;
        private System.Windows.Forms.Button infoBTN;
        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menudeco1;
        private System.Windows.Forms.PictureBox menudeco2;
        private System.Windows.Forms.PictureBox muteBTN;
    }
}