using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 12;
        int pipeSpeed = 6;
        int score = 0;
        int gap = 160; // �st ve alt boru aras�ndaki bo�luk
        bool gameOver = false;
        Random rnd = new Random();

        int startPipeX1 = 500;
        int startPipeX2 = 800;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // T�klama kullan�lm�yorsa bo� b�rak�labilir
        }
        void InitializeGame()
        {
            // Ba�lang�� konumlar�
            flappyBird.Location = new Point(100, 150);

            // �ki set boru kullanaca��z (pipeTop/pipeBottom mevcut � ikincisini dinamik ekleyelim)
            EnsureSecondPipeSet();

            // �lk set
            SetPipePair(pipeTop, pipeBottom, startPipeX1);
            // �kinci set
            var (top2, bottom2) = GetSecondPipePair();
            SetPipePair(top2, bottom2, startPipeX2);

            score = 0;
            pipeSpeed = 6;
            gravity = 12;
            scoreText.Text = "Skor: 0";
            gameOver = false;

            gameTimer.Enabled = true;
            flappyBird.BringToFront();
        }

        // Zaten formda bir set var (pipeTop/pipeBottom). �kinci seti kodla ekleyelim:
        void EnsureSecondPipeSet()
        {
            if (Controls.OfType<PictureBox>().Any(pb => pb.Name == "pipeTop2")) return;

            var pipeTop2 = new PictureBox
            {
                Name = "pipeTop2",
                Size = new Size(pipeTop.Width, pipeTop.Height),
                BackColor = pipeTop.BackColor,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Tag = "pipe",
                Image = pipeTop.Image // g�rsel kulland�ysan payla�
            };
            Controls.Add(pipeTop2);

            var pipeBottom2 = new PictureBox
            {
                Name = "pipeBottom2",
                Size = new Size(pipeBottom.Width, pipeBottom.Height),
                BackColor = pipeBottom.BackColor,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Tag = "pipe",
                Image = pipeBottom.Image
            };
            Controls.Add(pipeBottom2);
        }

        (PictureBox top2, PictureBox bottom2) GetSecondPipePair()
        {
            var top2 = Controls.OfType<PictureBox>().First(pb => pb.Name == "pipeTop2");
            var bottom2 = Controls.OfType<PictureBox>().First(pb => pb.Name == "pipeBottom2");
            return (top2, bottom2);
        }

        void SetPipePair(PictureBox top, PictureBox bottom, int x)
        {
            // Rastgele bir alt boru y�ksekli�i se�, �st� bo�luktan hesapla
            int bottomY = rnd.Next(240, 370);
            bottom.Location = new Point(x, bottomY);

            top.Location = new Point(x, bottomY - gap - top.Height);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (gameOver) return;

            flappyBird.Top += gravity;

            // T�m borular� hareket ettir
            foreach (var pb in Controls.OfType<PictureBox>().Where(p => (p.Tag as string) == "pipe"))
            {
                pb.Left -= pipeSpeed;

                // Ekran d���na ��kan borular� sa�a ta�� ve skor ver
                if (pb.Right < 0)
                {
                    // ayn� �ifti bul
                    var pairIsTop = pb.Name.Contains("Top");
                    PictureBox top, bottom;

                    if (pairIsTop)
                    {
                        top = pb;
                        bottom = Controls.OfType<PictureBox>().First(x => x.Name == pb.Name.Replace("Top", "Bottom"));
                    }
                    else
                    {
                        bottom = pb;
                        top = Controls.OfType<PictureBox>().First(x => x.Name == pb.Name.Replace("Bottom", "Top"));
                    }

                    // �ifti birlikte ileri al
                    int newX = ClientSize.Width + rnd.Next(50, 150);
                    SetPipePair(top, bottom, newX);

                    // Sadece bir kez skor say (�st boru yerine alt borudan sayal�m)
                    if (!pairIsTop)
                    {
                        score++;
                        scoreText.Text = "Skor: " + score;

                        // Zorluk art���
                        if (score % 5 == 0 && pipeSpeed < 14)
                            pipeSpeed++;
                    }
                }
            }

            // �arp��malar
            if (Collides(flappyBird, ground) ||
                flappyBird.Top < -10 ||
                Controls.OfType<PictureBox>().Where(p => (p.Tag as string) == "pipe")
                        .Any(p => p.Bounds.IntersectsWith(flappyBird.Bounds)))
            {
                EndGame();
            }
        }

        bool Collides(Control a, Control b)
        {
            return a.Bounds.IntersectsWith(b.Bounds);
        }

        private void EndGame()
        {
            gameTimer.Enabled = false;
            gameOver = true;
            scoreText.Text = $"Oyun Bitti! Skor: {score}  |  Yeniden ba�lat: R";
        }

        private void RestartGame()
        {
            InitializeGame();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !gameOver)
            {
                gravity = -12; // z�plama
            }
            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !gameOver)
            {
                gravity = 12;
            }
        }
    }
}