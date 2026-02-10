namespace Snake
{
    partial class Info
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backtomenuBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hardmode = new System.Windows.Forms.PictureBox();
            this.mediummode = new System.Windows.Forms.PictureBox();
            this.easymode = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardmode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediummode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easymode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Snake.Properties.Resources.arrowkeyright;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(120, 213);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 45);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Snake.Properties.Resources.arrowkeyleft;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(120, 153);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 45);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Snake.Properties.Resources.arrowkeydown;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(120, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 45);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Snake.Properties.Resources.arrowkeyup;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(120, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 45);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // backtomenuBTN
            // 
            this.backtomenuBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.backtomenuBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backtomenuBTN.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtomenuBTN.ForeColor = System.Drawing.Color.White;
            this.backtomenuBTN.Location = new System.Drawing.Point(245, 350);
            this.backtomenuBTN.Name = "backtomenuBTN";
            this.backtomenuBTN.Size = new System.Drawing.Size(190, 36);
            this.backtomenuBTN.TabIndex = 5;
            this.backtomenuBTN.Text = "MAIN MENU";
            this.backtomenuBTN.UseVisualStyleBackColor = false;
            this.backtomenuBTN.Click += new System.EventHandler(this.backtomenuBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 306);
            this.label1.TabIndex = 6;
            this.label1.Text = "CONTROLS\r\n\r\n\r\nMOVE UP: \r\n\r\n\r\nMOVE DOWN: \r\n\r\n\r\nMOVE LEFT: \r\n\r\n\r\nMOVE RIGHT: \r\n\r\n\r\n" +
    "\r\nCLICK ON \'START\' TO START PLAYING\r\n";
            // 
            // hardmode
            // 
            this.hardmode.BackColor = System.Drawing.Color.Transparent;
            this.hardmode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hardmode.Image = global::Snake.Properties.Resources.hardmode;
            this.hardmode.Location = new System.Drawing.Point(387, 220);
            this.hardmode.Name = "hardmode";
            this.hardmode.Size = new System.Drawing.Size(85, 95);
            this.hardmode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hardmode.TabIndex = 9;
            this.hardmode.TabStop = false;
            // 
            // mediummode
            // 
            this.mediummode.BackColor = System.Drawing.Color.Transparent;
            this.mediummode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mediummode.Image = global::Snake.Properties.Resources.normalmode;
            this.mediummode.Location = new System.Drawing.Point(387, 119);
            this.mediummode.Name = "mediummode";
            this.mediummode.Size = new System.Drawing.Size(85, 95);
            this.mediummode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mediummode.TabIndex = 8;
            this.mediummode.TabStop = false;
            // 
            // easymode
            // 
            this.easymode.BackColor = System.Drawing.Color.Transparent;
            this.easymode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.easymode.Image = global::Snake.Properties.Resources.easymode;
            this.easymode.Location = new System.Drawing.Point(387, 18);
            this.easymode.Name = "easymode";
            this.easymode.Size = new System.Drawing.Size(85, 95);
            this.easymode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.easymode.TabIndex = 7;
            this.easymode.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "EASY MODE - 25pts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "NORMAL MODE - 50pts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "HARD MODE - 100pts";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::Snake.Properties.Resources.infobg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 418);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hardmode);
            this.Controls.Add(this.mediummode);
            this.Controls.Add(this.easymode);
            this.Controls.Add(this.backtomenuBTN);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Info";
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardmode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediummode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easymode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button backtomenuBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox hardmode;
        private System.Windows.Forms.PictureBox mediummode;
        private System.Windows.Forms.PictureBox easymode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}