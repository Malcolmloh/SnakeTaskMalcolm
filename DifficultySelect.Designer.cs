namespace Snake
{
    partial class DifficultySelect
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
            this.easymode = new System.Windows.Forms.PictureBox();
            this.mediummode = new System.Windows.Forms.PictureBox();
            this.hardmode = new System.Windows.Forms.PictureBox();
            this.normalBTN = new System.Windows.Forms.Button();
            this.hardBTN = new System.Windows.Forms.Button();
            this.easyBTN = new System.Windows.Forms.Button();
            this.backtomenuBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.easymode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediummode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardmode)).BeginInit();
            this.SuspendLayout();
            // 
            // easymode
            // 
            this.easymode.BackColor = System.Drawing.Color.Transparent;
            this.easymode.Image = global::Snake.Properties.Resources.easymode;
            this.easymode.Location = new System.Drawing.Point(59, 44);
            this.easymode.Name = "easymode";
            this.easymode.Size = new System.Drawing.Size(203, 251);
            this.easymode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.easymode.TabIndex = 0;
            this.easymode.TabStop = false;
            // 
            // mediummode
            // 
            this.mediummode.BackColor = System.Drawing.Color.Transparent;
            this.mediummode.Image = global::Snake.Properties.Resources.normalmode;
            this.mediummode.Location = new System.Drawing.Point(297, 44);
            this.mediummode.Name = "mediummode";
            this.mediummode.Size = new System.Drawing.Size(203, 251);
            this.mediummode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mediummode.TabIndex = 1;
            this.mediummode.TabStop = false;
            // 
            // hardmode
            // 
            this.hardmode.BackColor = System.Drawing.Color.Transparent;
            this.hardmode.Image = global::Snake.Properties.Resources.hardmode;
            this.hardmode.Location = new System.Drawing.Point(533, 44);
            this.hardmode.Name = "hardmode";
            this.hardmode.Size = new System.Drawing.Size(203, 251);
            this.hardmode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hardmode.TabIndex = 2;
            this.hardmode.TabStop = false;
            // 
            // normalBTN
            // 
            this.normalBTN.BackColor = System.Drawing.Color.DimGray;
            this.normalBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.normalBTN.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalBTN.ForeColor = System.Drawing.Color.White;
            this.normalBTN.Location = new System.Drawing.Point(297, 323);
            this.normalBTN.Name = "normalBTN";
            this.normalBTN.Size = new System.Drawing.Size(203, 61);
            this.normalBTN.TabIndex = 4;
            this.normalBTN.Text = "NORMAL";
            this.normalBTN.UseVisualStyleBackColor = false;
            this.normalBTN.Click += new System.EventHandler(this.normalBTN_Click);
            this.normalBTN.MouseHover += new System.EventHandler(this.normalBTN_MouseHover);
            // 
            // hardBTN
            // 
            this.hardBTN.BackColor = System.Drawing.Color.DimGray;
            this.hardBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardBTN.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardBTN.ForeColor = System.Drawing.Color.White;
            this.hardBTN.Location = new System.Drawing.Point(533, 323);
            this.hardBTN.Name = "hardBTN";
            this.hardBTN.Size = new System.Drawing.Size(203, 61);
            this.hardBTN.TabIndex = 5;
            this.hardBTN.Text = "HARD";
            this.hardBTN.UseVisualStyleBackColor = false;
            this.hardBTN.Click += new System.EventHandler(this.hardBTN_Click);
            this.hardBTN.MouseHover += new System.EventHandler(this.hardBTN_MouseHover);
            // 
            // easyBTN
            // 
            this.easyBTN.BackColor = System.Drawing.Color.DimGray;
            this.easyBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyBTN.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyBTN.ForeColor = System.Drawing.Color.White;
            this.easyBTN.Location = new System.Drawing.Point(59, 323);
            this.easyBTN.Name = "easyBTN";
            this.easyBTN.Size = new System.Drawing.Size(203, 61);
            this.easyBTN.TabIndex = 6;
            this.easyBTN.Text = "EASY";
            this.easyBTN.UseVisualStyleBackColor = false;
            this.easyBTN.Click += new System.EventHandler(this.easyBTN_Click);
            this.easyBTN.MouseHover += new System.EventHandler(this.easyBTN_MouseHover);
            // 
            // backtomenuBTN
            // 
            this.backtomenuBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.backtomenuBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backtomenuBTN.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtomenuBTN.ForeColor = System.Drawing.Color.White;
            this.backtomenuBTN.Location = new System.Drawing.Point(323, 402);
            this.backtomenuBTN.Name = "backtomenuBTN";
            this.backtomenuBTN.Size = new System.Drawing.Size(159, 36);
            this.backtomenuBTN.TabIndex = 7;
            this.backtomenuBTN.Text = "BACK";
            this.backtomenuBTN.UseVisualStyleBackColor = false;
            this.backtomenuBTN.Click += new System.EventHandler(this.backtomenuBTN_Click);
            // 
            // DifficultySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.difficultyselectbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backtomenuBTN);
            this.Controls.Add(this.easyBTN);
            this.Controls.Add(this.hardBTN);
            this.Controls.Add(this.normalBTN);
            this.Controls.Add(this.hardmode);
            this.Controls.Add(this.mediummode);
            this.Controls.Add(this.easymode);
            this.DoubleBuffered = true;
            this.Name = "DifficultySelect";
            this.Text = "Difficulty Selection";
            this.Load += new System.EventHandler(this.DifficultySelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.easymode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediummode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardmode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox easymode;
        private System.Windows.Forms.PictureBox mediummode;
        private System.Windows.Forms.PictureBox hardmode;
        private System.Windows.Forms.Button normalBTN;
        private System.Windows.Forms.Button hardBTN;
        private System.Windows.Forms.Button easyBTN;
        private System.Windows.Forms.Button backtomenuBTN;
    }
}