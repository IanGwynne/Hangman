namespace AssignmentTwo
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
            this.pTwoScoreLabel = new System.Windows.Forms.Label();
            this.pOneScoreLabel = new System.Windows.Forms.Label();
            this.pTwoName = new System.Windows.Forms.Label();
            this.pOneName = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.beginGuess = new System.Windows.Forms.Button();
            this.playerTwoScore = new System.Windows.Forms.TextBox();
            this.playerOneScore = new System.Windows.Forms.TextBox();
            this.playerTwoName = new System.Windows.Forms.TextBox();
            this.playerOneName = new System.Windows.Forms.TextBox();
            this.playerGuess = new System.Windows.Forms.TextBox();
            this.startGame = new System.Windows.Forms.Button();
            this.targetWord = new System.Windows.Forms.TextBox();
            this.scoreBox = new System.Windows.Forms.PictureBox();
            this.imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pTwoScoreLabel
            // 
            this.pTwoScoreLabel.AutoSize = true;
            this.pTwoScoreLabel.Location = new System.Drawing.Point(118, 51);
            this.pTwoScoreLabel.Name = "pTwoScoreLabel";
            this.pTwoScoreLabel.Size = new System.Drawing.Size(91, 13);
            this.pTwoScoreLabel.TabIndex = 28;
            this.pTwoScoreLabel.Text = "Player Two Score";
            // 
            // pOneScoreLabel
            // 
            this.pOneScoreLabel.AutoSize = true;
            this.pOneScoreLabel.Location = new System.Drawing.Point(118, 9);
            this.pOneScoreLabel.Name = "pOneScoreLabel";
            this.pOneScoreLabel.Size = new System.Drawing.Size(90, 13);
            this.pOneScoreLabel.TabIndex = 27;
            this.pOneScoreLabel.Text = "Player One Score";
            // 
            // pTwoName
            // 
            this.pTwoName.AutoSize = true;
            this.pTwoName.Location = new System.Drawing.Point(15, 51);
            this.pTwoName.Name = "pTwoName";
            this.pTwoName.Size = new System.Drawing.Size(60, 13);
            this.pTwoName.TabIndex = 26;
            this.pTwoName.Text = "Player Two";
            // 
            // pOneName
            // 
            this.pOneName.AutoSize = true;
            this.pOneName.Location = new System.Drawing.Point(12, 9);
            this.pOneName.Name = "pOneName";
            this.pOneName.Size = new System.Drawing.Size(59, 13);
            this.pOneName.TabIndex = 25;
            this.pOneName.Text = "Player One";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(319, 67);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(69, 13);
            this.guessLabel.TabIndex = 24;
            this.guessLabel.Text = "Player Guess";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(319, 25);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(38, 13);
            this.targetLabel.TabIndex = 23;
            this.targetLabel.Text = "Target";
            // 
            // beginGuess
            // 
            this.beginGuess.Location = new System.Drawing.Point(319, 130);
            this.beginGuess.Name = "beginGuess";
            this.beginGuess.Size = new System.Drawing.Size(100, 26);
            this.beginGuess.TabIndex = 22;
            this.beginGuess.Text = "Click to Guess";
            this.beginGuess.UseVisualStyleBackColor = true;
            this.beginGuess.Click += new System.EventHandler(this.beginGuess_Click_1);
            // 
            // playerTwoScore
            // 
            this.playerTwoScore.Location = new System.Drawing.Point(121, 67);
            this.playerTwoScore.Name = "playerTwoScore";
            this.playerTwoScore.ReadOnly = true;
            this.playerTwoScore.Size = new System.Drawing.Size(100, 20);
            this.playerTwoScore.TabIndex = 21;
            // 
            // playerOneScore
            // 
            this.playerOneScore.Location = new System.Drawing.Point(121, 25);
            this.playerOneScore.Name = "playerOneScore";
            this.playerOneScore.ReadOnly = true;
            this.playerOneScore.Size = new System.Drawing.Size(100, 20);
            this.playerOneScore.TabIndex = 20;
            // 
            // playerTwoName
            // 
            this.playerTwoName.Location = new System.Drawing.Point(15, 67);
            this.playerTwoName.Name = "playerTwoName";
            this.playerTwoName.Size = new System.Drawing.Size(100, 20);
            this.playerTwoName.TabIndex = 19;
            // 
            // playerOneName
            // 
            this.playerOneName.Location = new System.Drawing.Point(15, 25);
            this.playerOneName.Name = "playerOneName";
            this.playerOneName.Size = new System.Drawing.Size(100, 20);
            this.playerOneName.TabIndex = 18;
            // 
            // playerGuess
            // 
            this.playerGuess.Location = new System.Drawing.Point(319, 80);
            this.playerGuess.MaxLength = 1;
            this.playerGuess.Name = "playerGuess";
            this.playerGuess.Size = new System.Drawing.Size(100, 20);
            this.playerGuess.TabIndex = 17;
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(15, 101);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(75, 23);
            this.startGame.TabIndex = 16;
            this.startGame.Text = "Start!";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // targetWord
            // 
            this.targetWord.Location = new System.Drawing.Point(319, 44);
            this.targetWord.Name = "targetWord";
            this.targetWord.ReadOnly = true;
            this.targetWord.Size = new System.Drawing.Size(100, 20);
            this.targetWord.TabIndex = 15;
            // 
            // scoreBox
            // 
            this.scoreBox.Location = new System.Drawing.Point(171, 162);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(430, 260);
            this.scoreBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scoreBox.TabIndex = 29;
            this.scoreBox.TabStop = false;
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(168, 143);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(67, 13);
            this.imageLabel.TabIndex = 30;
            this.imageLabel.Text = "Turn\'s Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.pTwoScoreLabel);
            this.Controls.Add(this.pOneScoreLabel);
            this.Controls.Add(this.pTwoName);
            this.Controls.Add(this.pOneName);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.beginGuess);
            this.Controls.Add(this.playerTwoScore);
            this.Controls.Add(this.playerOneScore);
            this.Controls.Add(this.playerTwoName);
            this.Controls.Add(this.playerOneName);
            this.Controls.Add(this.playerGuess);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.targetWord);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pTwoScoreLabel;
        private System.Windows.Forms.Label pOneScoreLabel;
        private System.Windows.Forms.Label pTwoName;
        private System.Windows.Forms.Label pOneName;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Button beginGuess;
        private System.Windows.Forms.TextBox playerTwoScore;
        private System.Windows.Forms.TextBox playerOneScore;
        private System.Windows.Forms.TextBox playerTwoName;
        private System.Windows.Forms.TextBox playerOneName;
        private System.Windows.Forms.TextBox playerGuess;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.TextBox targetWord;
        private System.Windows.Forms.PictureBox scoreBox;
        private System.Windows.Forms.Label imageLabel;
    }
}

