namespace LurgItDiceGameAndrianThet
{
    partial class LurgIt
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
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPlayer1 = new System.Windows.Forms.TextBox();
            this.btnDouble = new System.Windows.Forms.Button();
            this.tbxPlayer2 = new System.Windows.Forms.TextBox();
            this.btnComputer = new System.Windows.Forms.Button();
            this.tbxSetting = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBxSetting = new System.Windows.Forms.GroupBox();
            this.btnHold3 = new System.Windows.Forms.Button();
            this.btnHold2 = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.picBx3 = new System.Windows.Forms.PictureBox();
            this.picBx2 = new System.Windows.Forms.PictureBox();
            this.picBx1 = new System.Windows.Forms.PictureBox();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.tbxP1Score = new System.Windows.Forms.TextBox();
            this.tbxP2Score = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRound1 = new System.Windows.Forms.Label();
            this.lblRound2 = new System.Windows.Forms.Label();
            this.btnNextRound = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.grpBxSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSinglePlayer.Location = new System.Drawing.Point(51, 114);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(218, 29);
            this.btnSinglePlayer.TabIndex = 19;
            this.btnSinglePlayer.Text = "Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = true;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Player 1";
            // 
            // tbxPlayer1
            // 
            this.tbxPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlayer1.Location = new System.Drawing.Point(152, 25);
            this.tbxPlayer1.Name = "tbxPlayer1";
            this.tbxPlayer1.Size = new System.Drawing.Size(112, 22);
            this.tbxPlayer1.TabIndex = 14;
            this.tbxPlayer1.Text = "mm";
            // 
            // btnDouble
            // 
            this.btnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.Location = new System.Drawing.Point(51, 149);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(218, 29);
            this.btnDouble.TabIndex = 13;
            this.btnDouble.Text = "Player1 VS Player2";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // tbxPlayer2
            // 
            this.tbxPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlayer2.Location = new System.Drawing.Point(152, 68);
            this.tbxPlayer2.Name = "tbxPlayer2";
            this.tbxPlayer2.Size = new System.Drawing.Size(112, 22);
            this.tbxPlayer2.TabIndex = 16;
            this.tbxPlayer2.Text = "kk";
            // 
            // btnComputer
            // 
            this.btnComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer.Location = new System.Drawing.Point(51, 184);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(218, 29);
            this.btnComputer.TabIndex = 18;
            this.btnComputer.Text = "Play with Computer";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // tbxSetting
            // 
            this.tbxSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSetting.Location = new System.Drawing.Point(14, 279);
            this.tbxSetting.Multiline = true;
            this.tbxSetting.Name = "tbxSetting";
            this.tbxSetting.ReadOnly = true;
            this.tbxSetting.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxSetting.Size = new System.Drawing.Size(313, 217);
            this.tbxSetting.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Player 2";
            // 
            // grpBxSetting
            // 
            this.grpBxSetting.Controls.Add(this.btnSinglePlayer);
            this.grpBxSetting.Controls.Add(this.label1);
            this.grpBxSetting.Controls.Add(this.tbxPlayer1);
            this.grpBxSetting.Controls.Add(this.label2);
            this.grpBxSetting.Controls.Add(this.btnDouble);
            this.grpBxSetting.Controls.Add(this.tbxPlayer2);
            this.grpBxSetting.Controls.Add(this.btnComputer);
            this.grpBxSetting.Location = new System.Drawing.Point(14, 21);
            this.grpBxSetting.Name = "grpBxSetting";
            this.grpBxSetting.Size = new System.Drawing.Size(314, 234);
            this.grpBxSetting.TabIndex = 22;
            this.grpBxSetting.TabStop = false;
            this.grpBxSetting.Text = "Setting";
            // 
            // btnHold3
            // 
            this.btnHold3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold3.Location = new System.Drawing.Point(738, 151);
            this.btnHold3.Name = "btnHold3";
            this.btnHold3.Size = new System.Drawing.Size(90, 23);
            this.btnHold3.TabIndex = 21;
            this.btnHold3.Tag = "";
            this.btnHold3.Text = "Hold";
            this.btnHold3.UseVisualStyleBackColor = true;
            this.btnHold3.Click += new System.EventHandler(this.btnHold3_Click);
            // 
            // btnHold2
            // 
            this.btnHold2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold2.Location = new System.Drawing.Point(578, 151);
            this.btnHold2.Name = "btnHold2";
            this.btnHold2.Size = new System.Drawing.Size(90, 23);
            this.btnHold2.TabIndex = 20;
            this.btnHold2.Tag = "";
            this.btnHold2.Text = "Hold";
            this.btnHold2.UseVisualStyleBackColor = true;
            this.btnHold2.Click += new System.EventHandler(this.btnHold2_Click);
            // 
            // btnHold
            // 
            this.btnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.Location = new System.Drawing.Point(413, 151);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(90, 23);
            this.btnHold.TabIndex = 19;
            this.btnHold.Tag = "";
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(694, 198);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(156, 23);
            this.btnRoll.TabIndex = 17;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // picBx3
            // 
            this.picBx3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBx3.Location = new System.Drawing.Point(716, 27);
            this.picBx3.Name = "picBx3";
            this.picBx3.Size = new System.Drawing.Size(134, 118);
            this.picBx3.TabIndex = 16;
            this.picBx3.TabStop = false;
            // 
            // picBx2
            // 
            this.picBx2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBx2.Location = new System.Drawing.Point(555, 27);
            this.picBx2.Name = "picBx2";
            this.picBx2.Size = new System.Drawing.Size(134, 118);
            this.picBx2.TabIndex = 15;
            this.picBx2.TabStop = false;
            // 
            // picBx1
            // 
            this.picBx1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBx1.Location = new System.Drawing.Point(389, 27);
            this.picBx1.Name = "picBx1";
            this.picBx1.Size = new System.Drawing.Size(134, 118);
            this.picBx1.TabIndex = 14;
            this.picBx1.TabStop = false;
            // 
            // tbxOutput
            // 
            this.tbxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOutput.Location = new System.Drawing.Point(334, 279);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(568, 217);
            this.tbxOutput.TabIndex = 13;
            // 
            // tbxP1Score
            // 
            this.tbxP1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxP1Score.Location = new System.Drawing.Point(486, 202);
            this.tbxP1Score.Name = "tbxP1Score";
            this.tbxP1Score.Size = new System.Drawing.Size(112, 22);
            this.tbxP1Score.TabIndex = 20;
            // 
            // tbxP2Score
            // 
            this.tbxP2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxP2Score.Location = new System.Drawing.Point(486, 230);
            this.tbxP2Score.Name = "tbxP2Score";
            this.tbxP2Score.Size = new System.Drawing.Size(112, 22);
            this.tbxP2Score.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Player 1 Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Player 2 Score";
            // 
            // lblRound1
            // 
            this.lblRound1.AutoSize = true;
            this.lblRound1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound1.Location = new System.Drawing.Point(639, 204);
            this.lblRound1.Name = "lblRound1";
            this.lblRound1.Size = new System.Drawing.Size(17, 17);
            this.lblRound1.TabIndex = 27;
            this.lblRound1.Text = "0";
            // 
            // lblRound2
            // 
            this.lblRound2.AutoSize = true;
            this.lblRound2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound2.Location = new System.Drawing.Point(639, 233);
            this.lblRound2.Name = "lblRound2";
            this.lblRound2.Size = new System.Drawing.Size(17, 17);
            this.lblRound2.TabIndex = 28;
            this.lblRound2.Text = "0";
            // 
            // btnNextRound
            // 
            this.btnNextRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRound.Location = new System.Drawing.Point(694, 226);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(156, 23);
            this.btnNextRound.TabIndex = 29;
            this.btnNextRound.Text = "Next Round";
            this.btnNextRound.UseVisualStyleBackColor = true;
            this.btnNextRound.Click += new System.EventHandler(this.btnNextRound_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(621, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Round";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(343, 259);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 32;
            // 
            // LurgIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 515);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNextRound);
            this.Controls.Add(this.lblRound2);
            this.Controls.Add(this.lblRound1);
            this.Controls.Add(this.grpBxSetting);
            this.Controls.Add(this.picBx1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxP2Score);
            this.Controls.Add(this.tbxP1Score);
            this.Controls.Add(this.tbxSetting);
            this.Controls.Add(this.btnHold3);
            this.Controls.Add(this.btnHold2);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picBx3);
            this.Controls.Add(this.picBx2);
            this.Controls.Add(this.tbxOutput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LurgIt";
            this.Text = "LurgIt";
            this.grpBxSetting.ResumeLayout(false);
            this.grpBxSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPlayer1;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.TextBox tbxPlayer2;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.TextBox tbxSetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBxSetting;
        private System.Windows.Forms.Button btnHold3;
        private System.Windows.Forms.Button btnHold2;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox picBx3;
        private System.Windows.Forms.PictureBox picBx2;
        private System.Windows.Forms.PictureBox picBx1;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.TextBox tbxP1Score;
        private System.Windows.Forms.TextBox tbxP2Score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRound1;
        private System.Windows.Forms.Label lblRound2;
        private System.Windows.Forms.Button btnNextRound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMsg;
    }
}

