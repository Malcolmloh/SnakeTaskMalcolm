namespace Snake
{
    partial class CharSelect
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.selectAshBTN = new System.Windows.Forms.Button();
            this.selectLilyBTN = new System.Windows.Forms.Button();
            this.backtomenuBTN = new System.Windows.Forms.Button();
            this.titleLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Snake.Properties.Resources.Ash;
            this.pictureBox1.Location = new System.Drawing.Point(161, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Snake.Properties.Resources.Lily;
            this.pictureBox2.Location = new System.Drawing.Point(592, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 301);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // selectAshBTN
            // 
            this.selectAshBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.selectAshBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectAshBTN.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAshBTN.ForeColor = System.Drawing.Color.White;
            this.selectAshBTN.Location = new System.Drawing.Point(205, 454);
            this.selectAshBTN.Name = "selectAshBTN";
            this.selectAshBTN.Size = new System.Drawing.Size(163, 49);
            this.selectAshBTN.TabIndex = 2;
            this.selectAshBTN.Text = "ASH";
            this.selectAshBTN.UseVisualStyleBackColor = false;
            this.selectAshBTN.Click += new System.EventHandler(this.selectAshBTN_Click);
            // 
            // selectLilyBTN
            // 
            this.selectLilyBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.selectLilyBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectLilyBTN.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLilyBTN.ForeColor = System.Drawing.Color.White;
            this.selectLilyBTN.Location = new System.Drawing.Point(627, 454);
            this.selectLilyBTN.Name = "selectLilyBTN";
            this.selectLilyBTN.Size = new System.Drawing.Size(163, 49);
            this.selectLilyBTN.TabIndex = 3;
            this.selectLilyBTN.Text = "LILY";
            this.selectLilyBTN.UseVisualStyleBackColor = false;
            this.selectLilyBTN.Click += new System.EventHandler(this.selectLilyBTN_Click);
            // 
            // backtomenuBTN
            // 
            this.backtomenuBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.backtomenuBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backtomenuBTN.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtomenuBTN.ForeColor = System.Drawing.Color.White;
            this.backtomenuBTN.Location = new System.Drawing.Point(403, 535);
            this.backtomenuBTN.Name = "backtomenuBTN";
            this.backtomenuBTN.Size = new System.Drawing.Size(190, 36);
            this.backtomenuBTN.TabIndex = 6;
            this.backtomenuBTN.Text = "BACK";
            this.backtomenuBTN.UseVisualStyleBackColor = false;
            this.backtomenuBTN.Click += new System.EventHandler(this.backtomenuBTN_Click);
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.BackColor = System.Drawing.Color.Transparent;
            this.titleLBL.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLBL.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.LightGreen;
            this.titleLBL.Location = new System.Drawing.Point(81, 41);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(797, 74);
            this.titleLBL.TabIndex = 7;
            this.titleLBL.Text = "CHOOSE YOUR CHARACTER";
            this.titleLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.lvl5bg;
            this.ClientSize = new System.Drawing.Size(980, 596);
            this.Controls.Add(this.titleLBL);
            this.Controls.Add(this.backtomenuBTN);
            this.Controls.Add(this.selectLilyBTN);
            this.Controls.Add(this.selectAshBTN);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CharSelect";
            this.Text = "CharSelect";
            this.Load += new System.EventHandler(this.CharSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button selectAshBTN;
        private System.Windows.Forms.Button selectLilyBTN;
        private System.Windows.Forms.Button backtomenuBTN;
        private System.Windows.Forms.Label titleLBL;
    }
}