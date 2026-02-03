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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Snake.Properties.Resources.Ash;
            this.pictureBox1.Location = new System.Drawing.Point(125, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Snake.Properties.Resources.Lily;
            this.pictureBox2.Location = new System.Drawing.Point(432, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 301);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // selectAshBTN
            // 
            this.selectAshBTN.BackColor = System.Drawing.Color.ForestGreen;
            this.selectAshBTN.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAshBTN.ForeColor = System.Drawing.Color.White;
            this.selectAshBTN.Location = new System.Drawing.Point(162, 319);
            this.selectAshBTN.Name = "selectAshBTN";
            this.selectAshBTN.Size = new System.Drawing.Size(163, 49);
            this.selectAshBTN.TabIndex = 2;
            this.selectAshBTN.Text = "ASH";
            this.selectAshBTN.UseVisualStyleBackColor = false;
            this.selectAshBTN.Click += new System.EventHandler(this.selectAshBTN_Click);
            // 
            // selectLilyBTN
            // 
            this.selectLilyBTN.BackColor = System.Drawing.Color.ForestGreen;
            this.selectLilyBTN.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLilyBTN.ForeColor = System.Drawing.Color.White;
            this.selectLilyBTN.Location = new System.Drawing.Point(468, 319);
            this.selectLilyBTN.Name = "selectLilyBTN";
            this.selectLilyBTN.Size = new System.Drawing.Size(163, 49);
            this.selectLilyBTN.TabIndex = 3;
            this.selectLilyBTN.Text = "LILY";
            this.selectLilyBTN.UseVisualStyleBackColor = false;
            this.selectLilyBTN.Click += new System.EventHandler(this.selectLilyBTN_Click);
            // 
            // CharSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.lvl5bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button selectAshBTN;
        private System.Windows.Forms.Button selectLilyBTN;
    }
}