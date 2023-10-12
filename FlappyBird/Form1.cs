namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            pbxBird.Top += gravity;
            pbxTop.Left -= pipeSpeed;
            pbxUnder.Left -= pipeSpeed;
            lblScore.Text = "Score: " + score;
            if (pbxUnder.Left < -150)
            {
                pbxUnder.Left = 800;
                score++;
            }
            if (pbxTop.Left < -180)

            {
                pbxTop.Left = 950;
                score++;
            }
            if (pbxBird.Bounds.IntersectsWith(pbxUnder.Bounds) ||
                pbxBird.Bounds.IntersectsWith(pbxTop.Bounds) ||
                pbxBird.Bounds.IntersectsWith(pbxGround.Bounds) || pbxBird.Top < -25)
            {
                EndGame();
            }
            if (score > 5)
            {
                pipeSpeed = 15;
            }
        }

        private void BirdDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void BirdUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
        private void EndGame()
        {
            gameTimer.Stop();
            lblScore.Text = " Game over!";
        }
    }
}
