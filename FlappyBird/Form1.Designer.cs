namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flappyBird = new PictureBox();
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.BackColor = Color.Transparent;
            flappyBird.Image = Properties.Resources.flappy_bird;
            flappyBird.Location = new Point(100, 150);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(50, 40);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            flappyBird.Click += pictureBox1_Click;
            // 
            // pipeTop
            // 
            pipeTop.BackColor = Color.ForestGreen;
            pipeTop.Location = new Point(500, -50);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(80, 250);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            pipeTop.Tag = "pipe";
            // 
            // pipeBottom
            // 
            pipeBottom.BackColor = Color.ForestGreen;
            pipeBottom.Location = new Point(500, 300);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(80, 250);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            pipeBottom.Tag = "pipe";
            // 
            // ground
            // 
            ground.BackColor = Color.Sienna;
            ground.Dock = DockStyle.Bottom;
            ground.Location = new Point(0, 402);
            ground.Name = "ground";
            ground.Size = new Size(782, 50);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Transparent;
            scoreText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            scoreText.ForeColor = SystemColors.ActiveCaptionText;
            scoreText.Location = new Point(10, 10);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(86, 31);
            scoreText.TabIndex = 4;
            scoreText.Text = "Skor: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(782, 452);
            Controls.Add(flappyBird);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flappy Bird";
            KeyDown += Form1_KeyDown;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
