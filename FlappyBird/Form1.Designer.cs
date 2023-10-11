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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbxGround = new PictureBox();
            pbxTop = new PictureBox();
            pbxBird = new PictureBox();
            pbxUnder = new PictureBox();
            lblScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbxGround).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxUnder).BeginInit();
            SuspendLayout();
            // 
            // pbxGround
            // 
            pbxGround.Image = (Image)resources.GetObject("pbxGround.Image");
            pbxGround.Location = new Point(-5, 572);
            pbxGround.Name = "pbxGround";
            pbxGround.Size = new Size(670, 62);
            pbxGround.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxGround.TabIndex = 0;
            pbxGround.TabStop = false;
            // 
            // pbxTop
            // 
            pbxTop.Image = (Image)resources.GetObject("pbxTop.Image");
            pbxTop.Location = new Point(355, -1);
            pbxTop.Name = "pbxTop";
            pbxTop.Size = new Size(76, 155);
            pbxTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxTop.TabIndex = 1;
            pbxTop.TabStop = false;
            // 
            // pbxBird
            // 
            pbxBird.Image = (Image)resources.GetObject("pbxBird.Image");
            pbxBird.Location = new Point(52, 286);
            pbxBird.Name = "pbxBird";
            pbxBird.Size = new Size(83, 61);
            pbxBird.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBird.TabIndex = 2;
            pbxBird.TabStop = false;
            // 
            // pbxUnder
            // 
            pbxUnder.Image = (Image)resources.GetObject("pbxUnder.Image");
            pbxUnder.Location = new Point(539, 362);
            pbxUnder.Name = "pbxUnder";
            pbxUnder.Size = new Size(72, 213);
            pbxUnder.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxUnder.TabIndex = 3;
            pbxUnder.TabStop = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.AntiqueWhite;
            lblScore.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.Location = new Point(23, 18);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(86, 25);
            lblScore.TabIndex = 4;
            lblScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(662, 633);
            Controls.Add(pbxBird);
            Controls.Add(lblScore);
            Controls.Add(pbxUnder);
            Controls.Add(pbxTop);
            Controls.Add(pbxGround);
            Name = "Form1";
            Text = "Flappy Bird";
            KeyDown += birdDown;
            KeyUp += birdUp;
            ((System.ComponentModel.ISupportInitialize)pbxGround).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxUnder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxGround;
        private PictureBox pbxTop;
        private PictureBox pbxBird;
        private PictureBox pbxUnder;
        private Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}