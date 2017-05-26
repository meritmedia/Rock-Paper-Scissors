namespace RockPaperScissorsGUI
{
    partial class frmRPS
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblComputerWinner = new System.Windows.Forms.Label();
            this.lblYouWins = new System.Windows.Forms.Label();
            this.lblCompWins = new System.Windows.Forms.Label();
            this.lblYouPlayer = new System.Windows.Forms.Label();
            this.lblPlayerComputer = new System.Windows.Forms.Label();
            this.btnDonate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(254, 54);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.Image = global::RockPaperScissorsGUI.Properties.Resources.computer;
            this.btnComputer.Location = new System.Drawing.Point(316, 234);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(156, 64);
            this.btnComputer.TabIndex = 3;
            this.btnComputer.UseVisualStyleBackColor = true;
            // 
            // btnScissors
            // 
            this.btnScissors.Image = global::RockPaperScissorsGUI.Properties.Resources.scissors_l;
            this.btnScissors.Location = new System.Drawing.Point(46, 304);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(156, 64);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Image = global::RockPaperScissorsGUI.Properties.Resources.paper_l;
            this.btnPaper.Location = new System.Drawing.Point(46, 230);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(156, 68);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnRock
            // 
            this.btnRock.Image = global::RockPaperScissorsGUI.Properties.Resources.rock_l;
            this.btnRock.Location = new System.Drawing.Point(46, 156);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(156, 68);
            this.btnRock.TabIndex = 0;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(53, 381);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 25);
            this.lblWinner.TabIndex = 5;
            // 
            // lblComputerWinner
            // 
            this.lblComputerWinner.AutoSize = true;
            this.lblComputerWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWinner.Location = new System.Drawing.Point(318, 381);
            this.lblComputerWinner.Name = "lblComputerWinner";
            this.lblComputerWinner.Size = new System.Drawing.Size(0, 25);
            this.lblComputerWinner.TabIndex = 6;
            // 
            // lblYouWins
            // 
            this.lblYouWins.AutoSize = true;
            this.lblYouWins.BackColor = System.Drawing.Color.Transparent;
            this.lblYouWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouWins.Location = new System.Drawing.Point(53, 413);
            this.lblYouWins.Name = "lblYouWins";
            this.lblYouWins.Size = new System.Drawing.Size(91, 25);
            this.lblYouWins.TabIndex = 7;
            this.lblYouWins.Text = "Wins: 0";
            // 
            // lblCompWins
            // 
            this.lblCompWins.AutoSize = true;
            this.lblCompWins.BackColor = System.Drawing.Color.Transparent;
            this.lblCompWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompWins.Location = new System.Drawing.Point(320, 413);
            this.lblCompWins.Name = "lblCompWins";
            this.lblCompWins.Size = new System.Drawing.Size(91, 25);
            this.lblCompWins.TabIndex = 8;
            this.lblCompWins.Text = "Wins: 0";
            // 
            // lblYouPlayer
            // 
            this.lblYouPlayer.AutoSize = true;
            this.lblYouPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblYouPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouPlayer.Location = new System.Drawing.Point(90, 107);
            this.lblYouPlayer.Name = "lblYouPlayer";
            this.lblYouPlayer.Size = new System.Drawing.Size(78, 37);
            this.lblYouPlayer.TabIndex = 9;
            this.lblYouPlayer.Text = "You";
            // 
            // lblPlayerComputer
            // 
            this.lblPlayerComputer.AutoSize = true;
            this.lblPlayerComputer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerComputer.Location = new System.Drawing.Point(310, 107);
            this.lblPlayerComputer.Name = "lblPlayerComputer";
            this.lblPlayerComputer.Size = new System.Drawing.Size(166, 37);
            this.lblPlayerComputer.TabIndex = 10;
            this.lblPlayerComputer.Text = "Computer";
            // 
            // btnDonate
            // 
            this.btnDonate.Location = new System.Drawing.Point(272, 441);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(242, 54);
            this.btnDonate.TabIndex = 11;
            this.btnDonate.Text = "Donate $0.99 to the Be Your Own Hero Foundation";
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // frmRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RockPaperScissorsGUI.Properties.Resources.bkg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(526, 519);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.lblPlayerComputer);
            this.Controls.Add(this.lblYouPlayer);
            this.Controls.Add(this.lblCompWins);
            this.Controls.Add(this.lblYouWins);
            this.Controls.Add(this.lblComputerWinner);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnComputer);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "frmRPS";
            this.Text = "Rock, Paper, Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblComputerWinner;
        private System.Windows.Forms.Label lblYouWins;
        private System.Windows.Forms.Label lblCompWins;
        private System.Windows.Forms.Label lblYouPlayer;
        private System.Windows.Forms.Label lblPlayerComputer;
        private System.Windows.Forms.Button btnDonate;
    }
}

