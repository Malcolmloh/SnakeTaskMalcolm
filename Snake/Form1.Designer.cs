namespace Snake
{
    partial class Form1
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.levelLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLBL = new System.Windows.Forms.Label();
            this.pauseBTN = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.modeLBL = new System.Windows.Forms.Label();
            this.timerLBL = new System.Windows.Forms.Label();
            this.upBTN = new System.Windows.Forms.Button();
            this.leftBTN = new System.Windows.Forms.Button();
            this.downBTN = new System.Windows.Forms.Button();
            this.rightBTN = new System.Windows.Forms.Button();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.levelLBL);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.scoreLBL);
            this.controlPanel.Controls.Add(this.pauseBTN);
            this.controlPanel.Controls.Add(this.startBTN);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.modeLBL);
            this.controlPanel.Controls.Add(this.timerLBL);
            this.controlPanel.Controls.Add(this.upBTN);
            this.controlPanel.Controls.Add(this.leftBTN);
            this.controlPanel.Controls.Add(this.downBTN);
            this.controlPanel.Controls.Add(this.rightBTN);
            this.controlPanel.Location = new System.Drawing.Point(0, 130);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(765, 117);
            this.controlPanel.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Level";
            // 
            // levelLBL
            // 
            this.levelLBL.AutoSize = true;
            this.levelLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.levelLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLBL.Location = new System.Drawing.Point(96, 20);
            this.levelLBL.Name = "levelLBL";
            this.levelLBL.Size = new System.Drawing.Size(19, 19);
            this.levelLBL.TabIndex = 26;
            this.levelLBL.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Score";
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLBL.Location = new System.Drawing.Point(96, 48);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(19, 19);
            this.scoreLBL.TabIndex = 24;
            this.scoreLBL.Text = "0";
            // 
            // pauseBTN
            // 
            this.pauseBTN.Location = new System.Drawing.Point(612, 55);
            this.pauseBTN.Margin = new System.Windows.Forms.Padding(4);
            this.pauseBTN.Name = "pauseBTN";
            this.pauseBTN.Size = new System.Drawing.Size(100, 28);
            this.pauseBTN.TabIndex = 23;
            this.pauseBTN.Text = "Pause";
            this.pauseBTN.UseVisualStyleBackColor = true;
            this.pauseBTN.Click += new System.EventHandler(this.pauseBTN_Click);
            // 
            // startBTN
            // 
            this.startBTN.Location = new System.Drawing.Point(612, 20);
            this.startBTN.Margin = new System.Windows.Forms.Padding(4);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(100, 28);
            this.startBTN.TabIndex = 22;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Timer";
            // 
            // modeLBL
            // 
            this.modeLBL.AutoSize = true;
            this.modeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLBL.Location = new System.Drawing.Point(389, 48);
            this.modeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modeLBL.Name = "modeLBL";
            this.modeLBL.Size = new System.Drawing.Size(0, 17);
            this.modeLBL.TabIndex = 6;
            // 
            // timerLBL
            // 
            this.timerLBL.AutoSize = true;
            this.timerLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLBL.Location = new System.Drawing.Point(96, 76);
            this.timerLBL.Name = "timerLBL";
            this.timerLBL.Size = new System.Drawing.Size(19, 19);
            this.timerLBL.TabIndex = 20;
            this.timerLBL.Text = "0";
            // 
            // upBTN
            // 
            this.upBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upBTN.Location = new System.Drawing.Point(409, 2);
            this.upBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upBTN.Name = "upBTN";
            this.upBTN.Size = new System.Drawing.Size(35, 31);
            this.upBTN.TabIndex = 4;
            this.upBTN.Text = "▲";
            this.upBTN.UseVisualStyleBackColor = true;
            this.upBTN.Click += new System.EventHandler(this.upBTN_Click);
            // 
            // leftBTN
            // 
            this.leftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBTN.Location = new System.Drawing.Point(348, 38);
            this.leftBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftBTN.Name = "leftBTN";
            this.leftBTN.Size = new System.Drawing.Size(35, 32);
            this.leftBTN.TabIndex = 1;
            this.leftBTN.Text = "◀";
            this.leftBTN.UseVisualStyleBackColor = true;
            this.leftBTN.Click += new System.EventHandler(this.leftBTN_Click);
            // 
            // downBTN
            // 
            this.downBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downBTN.Location = new System.Drawing.Point(409, 76);
            this.downBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downBTN.Name = "downBTN";
            this.downBTN.Size = new System.Drawing.Size(35, 32);
            this.downBTN.TabIndex = 3;
            this.downBTN.Text = "▼";
            this.downBTN.UseVisualStyleBackColor = true;
            this.downBTN.Click += new System.EventHandler(this.downBTN_Click);
            // 
            // rightBTN
            // 
            this.rightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBTN.Location = new System.Drawing.Point(475, 38);
            this.rightBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightBTN.Name = "rightBTN";
            this.rightBTN.Size = new System.Drawing.Size(35, 32);
            this.rightBTN.TabIndex = 5;
            this.rightBTN.Text = "▶";
            this.rightBTN.UseVisualStyleBackColor = true;
            this.rightBTN.Click += new System.EventHandler(this.rightBTN_Click);
            // 
            // boardPanel
            // 
            this.boardPanel.Location = new System.Drawing.Point(0, 1);
            this.boardPanel.Margin = new System.Windows.Forms.Padding(4);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(267, 123);
            this.boardPanel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 252);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.controlPanel);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Label modeLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timerLBL;
        private System.Windows.Forms.Button pauseBTN;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label levelLBL;
        private System.Windows.Forms.Button upBTN;
        private System.Windows.Forms.Button leftBTN;
        private System.Windows.Forms.Button downBTN;
        private System.Windows.Forms.Button rightBTN;
    }
}

