
namespace Assignment4
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
            this.gameStatusGroup = new System.Windows.Forms.GroupBox();
            this.gameStatsGroup = new System.Windows.Forms.GroupBox();
            this.startGame = new System.Windows.Forms.Button();
            this.gameStatus = new System.Windows.Forms.RichTextBox();
            this.player1WinLabel = new System.Windows.Forms.Label();
            this.playerTwoWinsLabel = new System.Windows.Forms.Label();
            this.tiesLabel = new System.Windows.Forms.Label();
            this.player1WinTotal = new System.Windows.Forms.Label();
            this.player2WinTotal = new System.Windows.Forms.Label();
            this.tiesTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leftTopBox = new System.Windows.Forms.Label();
            this.leftMidBox = new System.Windows.Forms.Label();
            this.leftBottomBox = new System.Windows.Forms.Label();
            this.midBox = new System.Windows.Forms.Label();
            this.midTopBox = new System.Windows.Forms.Label();
            this.midBottomBox = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rightBottomBox = new System.Windows.Forms.Label();
            this.rightTopBox = new System.Windows.Forms.Label();
            this.rightMidBox = new System.Windows.Forms.Label();
            this.gameStatusGroup.SuspendLayout();
            this.gameStatsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameStatusGroup
            // 
            this.gameStatusGroup.Controls.Add(this.gameStatus);
            this.gameStatusGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatusGroup.Location = new System.Drawing.Point(12, 363);
            this.gameStatusGroup.Name = "gameStatusGroup";
            this.gameStatusGroup.Size = new System.Drawing.Size(198, 75);
            this.gameStatusGroup.TabIndex = 0;
            this.gameStatusGroup.TabStop = false;
            this.gameStatusGroup.Text = "Game Status";
            // 
            // gameStatsGroup
            // 
            this.gameStatsGroup.Controls.Add(this.tiesTotal);
            this.gameStatsGroup.Controls.Add(this.player2WinTotal);
            this.gameStatsGroup.Controls.Add(this.player1WinTotal);
            this.gameStatsGroup.Controls.Add(this.tiesLabel);
            this.gameStatsGroup.Controls.Add(this.playerTwoWinsLabel);
            this.gameStatsGroup.Controls.Add(this.player1WinLabel);
            this.gameStatsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatsGroup.Location = new System.Drawing.Point(216, 363);
            this.gameStatsGroup.Name = "gameStatsGroup";
            this.gameStatsGroup.Size = new System.Drawing.Size(339, 75);
            this.gameStatsGroup.TabIndex = 1;
            this.gameStatsGroup.TabStop = false;
            this.gameStatsGroup.Text = "Game Statistics";
            // 
            // startGame
            // 
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(237, 12);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(104, 28);
            this.startGame.TabIndex = 2;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // gameStatus
            // 
            this.gameStatus.Enabled = false;
            this.gameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatus.Location = new System.Drawing.Point(7, 19);
            this.gameStatus.Name = "gameStatus";
            this.gameStatus.Size = new System.Drawing.Size(185, 50);
            this.gameStatus.TabIndex = 0;
            this.gameStatus.Text = "Awaiting Game Start";
            // 
            // player1WinLabel
            // 
            this.player1WinLabel.AutoSize = true;
            this.player1WinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1WinLabel.Location = new System.Drawing.Point(10, 22);
            this.player1WinLabel.Name = "player1WinLabel";
            this.player1WinLabel.Size = new System.Drawing.Size(85, 15);
            this.player1WinLabel.TabIndex = 0;
            this.player1WinLabel.Text = "Player 1 wins: ";
            // 
            // playerTwoWinsLabel
            // 
            this.playerTwoWinsLabel.AutoSize = true;
            this.playerTwoWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoWinsLabel.Location = new System.Drawing.Point(10, 37);
            this.playerTwoWinsLabel.Name = "playerTwoWinsLabel";
            this.playerTwoWinsLabel.Size = new System.Drawing.Size(85, 15);
            this.playerTwoWinsLabel.TabIndex = 1;
            this.playerTwoWinsLabel.Text = "Player 2 wins: ";
            // 
            // tiesLabel
            // 
            this.tiesLabel.AutoSize = true;
            this.tiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiesLabel.Location = new System.Drawing.Point(10, 54);
            this.tiesLabel.Name = "tiesLabel";
            this.tiesLabel.Size = new System.Drawing.Size(33, 15);
            this.tiesLabel.TabIndex = 2;
            this.tiesLabel.Text = "Ties:";
            // 
            // player1WinTotal
            // 
            this.player1WinTotal.AutoSize = true;
            this.player1WinTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1WinTotal.Location = new System.Drawing.Point(101, 22);
            this.player1WinTotal.Name = "player1WinTotal";
            this.player1WinTotal.Size = new System.Drawing.Size(14, 15);
            this.player1WinTotal.TabIndex = 3;
            this.player1WinTotal.Text = "0";
            // 
            // player2WinTotal
            // 
            this.player2WinTotal.AutoSize = true;
            this.player2WinTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2WinTotal.Location = new System.Drawing.Point(101, 37);
            this.player2WinTotal.Name = "player2WinTotal";
            this.player2WinTotal.Size = new System.Drawing.Size(14, 15);
            this.player2WinTotal.TabIndex = 4;
            this.player2WinTotal.Text = "0";
            // 
            // tiesTotal
            // 
            this.tiesTotal.AutoSize = true;
            this.tiesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiesTotal.Location = new System.Drawing.Point(101, 52);
            this.tiesTotal.Name = "tiesTotal";
            this.tiesTotal.Size = new System.Drawing.Size(14, 15);
            this.tiesTotal.TabIndex = 5;
            this.tiesTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(236, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 276);
            this.label1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(151, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 11);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(151, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 10);
            this.label4.TabIndex = 6;
            // 
            // leftTopBox
            // 
            this.leftTopBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leftTopBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTopBox.Location = new System.Drawing.Point(151, 49);
            this.leftTopBox.Name = "leftTopBox";
            this.leftTopBox.Size = new System.Drawing.Size(85, 85);
            this.leftTopBox.TabIndex = 7;
            this.leftTopBox.Tag = "LT";
            this.leftTopBox.Text = "X";
            this.leftTopBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftTopBox.Click += new System.EventHandler(this.boxClicked);
            // 
            // leftMidBox
            // 
            this.leftMidBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leftMidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMidBox.Location = new System.Drawing.Point(151, 145);
            this.leftMidBox.Name = "leftMidBox";
            this.leftMidBox.Size = new System.Drawing.Size(85, 85);
            this.leftMidBox.TabIndex = 8;
            this.leftMidBox.Tag = "LM";
            this.leftMidBox.Text = "X";
            this.leftMidBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftMidBox.Click += new System.EventHandler(this.boxClicked);
            // 
            // leftBottomBox
            // 
            this.leftBottomBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leftBottomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBottomBox.Location = new System.Drawing.Point(151, 240);
            this.leftBottomBox.Name = "leftBottomBox";
            this.leftBottomBox.Size = new System.Drawing.Size(85, 85);
            this.leftBottomBox.TabIndex = 9;
            this.leftBottomBox.Tag = "LB";
            this.leftBottomBox.Text = "X";
            this.leftBottomBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftBottomBox.Click += new System.EventHandler(this.boxClicked);
            // 
            // midBox
            // 
            this.midBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.midBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midBox.Location = new System.Drawing.Point(246, 145);
            this.midBox.Name = "midBox";
            this.midBox.Size = new System.Drawing.Size(85, 85);
            this.midBox.TabIndex = 10;
            this.midBox.Tag = "M";
            this.midBox.Text = "X";
            this.midBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.midBox.Click += new System.EventHandler(this.boxClicked);
            // 
            // midTopBox
            // 
            this.midTopBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.midTopBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midTopBox.Location = new System.Drawing.Point(246, 49);
            this.midTopBox.Name = "midTopBox";
            this.midTopBox.Size = new System.Drawing.Size(85, 85);
            this.midTopBox.TabIndex = 11;
            this.midTopBox.Tag = "MT";
            this.midTopBox.Text = "X";
            this.midTopBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.midTopBox.Click += new System.EventHandler(this.boxClicked);
            // 
            // midBottomBox
            // 
            this.midBottomBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.midBottomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midBottomBox.Location = new System.Drawing.Point(246, 240);
            this.midBottomBox.Name = "midBottomBox";
            this.midBottomBox.Size = new System.Drawing.Size(85, 85);
            this.midBottomBox.TabIndex = 12;
            this.midBottomBox.Tag = "MB";
            this.midBottomBox.Text = "X";
            this.midBottomBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.midBottomBox.Click += new System.EventHandler(this.boxClicked);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(331, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 276);
            this.label9.TabIndex = 13;
            // 
            // rightBottomBox
            // 
            this.rightBottomBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rightBottomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBottomBox.Location = new System.Drawing.Point(341, 240);
            this.rightBottomBox.Name = "rightBottomBox";
            this.rightBottomBox.Size = new System.Drawing.Size(85, 85);
            this.rightBottomBox.TabIndex = 16;
            this.rightBottomBox.Tag = "RB";
            this.rightBottomBox.Text = "X";
            this.rightBottomBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightBottomBox.Click += new System.EventHandler(this.boxClicked);
            // 
            // rightTopBox
            // 
            this.rightTopBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rightTopBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightTopBox.Location = new System.Drawing.Point(341, 49);
            this.rightTopBox.Name = "rightTopBox";
            this.rightTopBox.Size = new System.Drawing.Size(85, 85);
            this.rightTopBox.TabIndex = 15;
            this.rightTopBox.Tag = "RT";
            this.rightTopBox.Text = "X";
            this.rightTopBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightTopBox.Click += new System.EventHandler(this.boxClicked);
            // 
            // rightMidBox
            // 
            this.rightMidBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rightMidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightMidBox.Location = new System.Drawing.Point(341, 145);
            this.rightMidBox.Name = "rightMidBox";
            this.rightMidBox.Size = new System.Drawing.Size(85, 85);
            this.rightMidBox.TabIndex = 14;
            this.rightMidBox.Tag = "RM";
            this.rightMidBox.Text = "X";
            this.rightMidBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightMidBox.Click += new System.EventHandler(this.boxClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.rightBottomBox);
            this.Controls.Add(this.rightTopBox);
            this.Controls.Add(this.rightMidBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.midBottomBox);
            this.Controls.Add(this.midTopBox);
            this.Controls.Add(this.midBox);
            this.Controls.Add(this.leftBottomBox);
            this.Controls.Add(this.leftMidBox);
            this.Controls.Add(this.leftTopBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.gameStatsGroup);
            this.Controls.Add(this.gameStatusGroup);
            this.MaximumSize = new System.Drawing.Size(584, 489);
            this.MinimumSize = new System.Drawing.Size(584, 489);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.gameStatusGroup.ResumeLayout(false);
            this.gameStatsGroup.ResumeLayout(false);
            this.gameStatsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gameStatusGroup;
        private System.Windows.Forms.GroupBox gameStatsGroup;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.RichTextBox gameStatus;
        private System.Windows.Forms.Label tiesLabel;
        private System.Windows.Forms.Label playerTwoWinsLabel;
        private System.Windows.Forms.Label player1WinLabel;
        private System.Windows.Forms.Label tiesTotal;
        private System.Windows.Forms.Label player2WinTotal;
        private System.Windows.Forms.Label player1WinTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label leftTopBox;
        private System.Windows.Forms.Label leftMidBox;
        private System.Windows.Forms.Label leftBottomBox;
        private System.Windows.Forms.Label midBox;
        private System.Windows.Forms.Label midTopBox;
        private System.Windows.Forms.Label midBottomBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label rightBottomBox;
        private System.Windows.Forms.Label rightTopBox;
        private System.Windows.Forms.Label rightMidBox;
    }
}

