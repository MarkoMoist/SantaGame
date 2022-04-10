
namespace S4ta
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.hut = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.sleight = new System.Windows.Forms.PictureBox();
            this.Snowflakes = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snowflakes)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-8, 595);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(790, 237);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // hut
            // 
            this.hut.Image = ((System.Drawing.Image)(resources.GetObject("hut.Image")));
            this.hut.Location = new System.Drawing.Point(608, 478);
            this.hut.Name = "hut";
            this.hut.Size = new System.Drawing.Size(165, 147);
            this.hut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hut.TabIndex = 1;
            this.hut.TabStop = false;
            // 
            // tree
            // 
            this.tree.Image = ((System.Drawing.Image)(resources.GetObject("tree.Image")));
            this.tree.Location = new System.Drawing.Point(412, 511);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(78, 125);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 2;
            this.tree.TabStop = false;
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(28, 12);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(145, 121);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 3;
            this.moon.TabStop = false;
            // 
            // sleight
            // 
            this.sleight.Image = ((System.Drawing.Image)(resources.GetObject("sleight.Image")));
            this.sleight.Location = new System.Drawing.Point(-8, 556);
            this.sleight.Name = "sleight";
            this.sleight.Size = new System.Drawing.Size(206, 96);
            this.sleight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sleight.TabIndex = 4;
            this.sleight.TabStop = false;
            // 
            // Snowflakes
            // 
            this.Snowflakes.Image = ((System.Drawing.Image)(resources.GetObject("Snowflakes.Image")));
            this.Snowflakes.Location = new System.Drawing.Point(608, -6);
            this.Snowflakes.Name = "Snowflakes";
            this.Snowflakes.Size = new System.Drawing.Size(174, 161);
            this.Snowflakes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Snowflakes.TabIndex = 5;
            this.Snowflakes.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(206, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(159, 46);
            this.Score.TabIndex = 6;
            this.Score.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.SystemColors.HotTrack;
            this.playAgain.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.Location = new System.Drawing.Point(178, 195);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(333, 218);
            this.playAgain.TabIndex = 8;
            this.playAgain.Text = "PLAY AGAIN";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(773, 821);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Snowflakes);
            this.Controls.Add(this.sleight);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.hut);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snowflakes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox hut;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox sleight;
        private System.Windows.Forms.PictureBox Snowflakes;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button playAgain;
    }
}

