namespace Snake
{
    partial class nameForm
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.okBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(74, 204);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(192, 28);
            this.nameTB.TabIndex = 0;
            this.nameTB.TabStop = false;
            this.nameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // okBTN
            // 
            this.okBTN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.okBTN.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBTN.Location = new System.Drawing.Point(107, 251);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(124, 27);
            this.okBTN.TabIndex = 1;
            this.okBTN.Text = "Save Score";
            this.okBTN.UseVisualStyleBackColor = false;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // nameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.gameoverbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 303);
            this.Controls.Add(this.okBTN);
            this.Controls.Add(this.nameTB);
            this.Name = "nameForm";
            this.Text = "nameForm";
            this.Load += new System.EventHandler(this.nameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button okBTN;
    }
}