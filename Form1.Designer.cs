﻿namespace Snake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.save_b = new System.Windows.Forms.Button();
            this.load_b = new System.Windows.Forms.Button();
            this.resume_b = new System.Windows.Forms.Button();
            this.restart_b = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbCanvas.Location = new System.Drawing.Point(13, 13);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(432, 434);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Click += new System.EventHandler(this.pbCanvas_Click);
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(604, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 37);
            this.lblScore.TabIndex = 2;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGameOver.Font = new System.Drawing.Font("Yu Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(12, 66);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(130, 48);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "label2";
            this.lblGameOver.Visible = false;
            this.lblGameOver.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // save_b
            // 
            this.save_b.Location = new System.Drawing.Point(458, 110);
            this.save_b.Name = "save_b";
            this.save_b.Size = new System.Drawing.Size(103, 48);
            this.save_b.TabIndex = 7;
            this.save_b.Text = "Save";
            this.save_b.UseVisualStyleBackColor = true;
            this.save_b.Click += new System.EventHandler(this.save_b_Click);
            this.save_b.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Save_Game);
            // 
            // load_b
            // 
            this.load_b.Location = new System.Drawing.Point(567, 110);
            this.load_b.Name = "load_b";
            this.load_b.Size = new System.Drawing.Size(103, 48);
            this.load_b.TabIndex = 7;
            this.load_b.Text = "Load";
            this.load_b.UseVisualStyleBackColor = true;
            this.load_b.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Load_Game);
            // 
            // resume_b
            // 
            this.resume_b.Location = new System.Drawing.Point(458, 164);
            this.resume_b.Name = "resume_b";
            this.resume_b.Size = new System.Drawing.Size(103, 48);
            this.resume_b.TabIndex = 7;
            this.resume_b.Text = "Resume";
            this.resume_b.UseVisualStyleBackColor = true;
            this.resume_b.Click += new System.EventHandler(this.resume_b_Click);
            this.resume_b.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Resume_Game);
            // 
            // restart_b
            // 
            this.restart_b.Location = new System.Drawing.Point(567, 164);
            this.restart_b.Name = "restart_b";
            this.restart_b.Size = new System.Drawing.Size(103, 48);
            this.restart_b.TabIndex = 7;
            this.restart_b.Text = "Restart";
            this.restart_b.UseVisualStyleBackColor = true;
            this.restart_b.Click += new System.EventHandler(this.button1_Click);
            this.restart_b.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Restart_Game);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 240);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(723, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.load_b);
            this.Controls.Add(this.restart_b);
            this.Controls.Add(this.resume_b);
            this.Controls.Add(this.save_b);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button save_b;
        private System.Windows.Forms.Button load_b;
        private System.Windows.Forms.Button resume_b;
        private System.Windows.Forms.Button restart_b;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

