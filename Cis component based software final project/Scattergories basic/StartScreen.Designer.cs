
namespace Scattergories_basic
{
    partial class StartScreen
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
            this.lblScattergories = new System.Windows.Forms.Label();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.cbPlayers = new System.Windows.Forms.ComboBox();
            this.cbRounds = new System.Windows.Forms.ComboBox();
            this.lblRounds = new System.Windows.Forms.Label();
            this.cbTimer = new System.Windows.Forms.ComboBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPlayerOneName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPlayerTwoName = new System.Windows.Forms.TextBox();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnLeaderBoards = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScattergories
            // 
            this.lblScattergories.AutoSize = true;
            this.lblScattergories.Font = new System.Drawing.Font("Copperplate Gothic Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScattergories.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblScattergories.Location = new System.Drawing.Point(136, 73);
            this.lblScattergories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScattergories.Name = "lblScattergories";
            this.lblScattergories.Size = new System.Drawing.Size(477, 52);
            this.lblScattergories.TabIndex = 0;
            this.lblScattergories.Text = "SCATTERGORIES";
            this.lblScattergories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(21, 190);
            this.lblPlayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(85, 26);
            this.lblPlayers.TabIndex = 1;
            this.lblPlayers.Text = "Players";
            // 
            // cbPlayers
            // 
            this.cbPlayers.FormattingEnabled = true;
            this.cbPlayers.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbPlayers.Location = new System.Drawing.Point(26, 228);
            this.cbPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.cbPlayers.Name = "cbPlayers";
            this.cbPlayers.Size = new System.Drawing.Size(92, 21);
            this.cbPlayers.TabIndex = 2;
            // 
            // cbRounds
            // 
            this.cbRounds.FormattingEnabled = true;
            this.cbRounds.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbRounds.Location = new System.Drawing.Point(469, 228);
            this.cbRounds.Margin = new System.Windows.Forms.Padding(2);
            this.cbRounds.Name = "cbRounds";
            this.cbRounds.Size = new System.Drawing.Size(92, 21);
            this.cbRounds.TabIndex = 4;
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.Location = new System.Drawing.Point(464, 190);
            this.lblRounds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(87, 26);
            this.lblRounds.TabIndex = 3;
            this.lblRounds.Text = "Rounds";
            // 
            // cbTimer
            // 
            this.cbTimer.FormattingEnabled = true;
            this.cbTimer.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbTimer.Location = new System.Drawing.Point(630, 228);
            this.cbTimer.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(110, 21);
            this.cbTimer.TabIndex = 6;
            this.cbTimer.Text = "Select a duration...";
            this.cbTimer.SelectedIndexChanged += new System.EventHandler(this.cbTimer_SelectedIndexChanged);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(625, 190);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(67, 26);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "Timer";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(603, 402);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 36);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(328, 325);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 36);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Player one Name:";
            // 
            // txtBoxPlayerOneName
            // 
            this.txtBoxPlayerOneName.Location = new System.Drawing.Point(161, 229);
            this.txtBoxPlayerOneName.Name = "txtBoxPlayerOneName";
            this.txtBoxPlayerOneName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPlayerOneName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter Player two Name:";
            // 
            // txtBoxPlayerTwoName
            // 
            this.txtBoxPlayerTwoName.Location = new System.Drawing.Point(311, 229);
            this.txtBoxPlayerTwoName.Name = "txtBoxPlayerTwoName";
            this.txtBoxPlayerTwoName.Size = new System.Drawing.Size(115, 20);
            this.txtBoxPlayerTwoName.TabIndex = 12;
            this.txtBoxPlayerTwoName.TextChanged += new System.EventHandler(this.txtBoxPlayerTwoName_TextChanged);
            // 
            // btnRules
            // 
            this.btnRules.Location = new System.Drawing.Point(26, 402);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(80, 36);
            this.btnRules.TabIndex = 13;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnLeaderBoards
            // 
            this.btnLeaderBoards.Location = new System.Drawing.Point(129, 402);
            this.btnLeaderBoards.Name = "btnLeaderBoards";
            this.btnLeaderBoards.Size = new System.Drawing.Size(88, 37);
            this.btnLeaderBoards.TabIndex = 17;
            this.btnLeaderBoards.Text = "Show LeaderBoards";
            this.btnLeaderBoards.UseVisualStyleBackColor = true;
            this.btnLeaderBoards.Click += new System.EventHandler(this.btnLeaderBoards_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(783, 462);
            this.Controls.Add(this.btnLeaderBoards);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.txtBoxPlayerTwoName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPlayerOneName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbTimer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.cbRounds);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.cbPlayers);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lblScattergories);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartScreen";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScattergories;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.ComboBox cbPlayers;
        private System.Windows.Forms.ComboBox cbRounds;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.ComboBox cbTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPlayerOneName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPlayerTwoName;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnLeaderBoards;
    }
}