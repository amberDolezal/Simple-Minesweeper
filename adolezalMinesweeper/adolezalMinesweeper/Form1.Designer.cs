namespace adolezalMinesweeper
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.theMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createdByAmberDolezalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classCS3020ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.date1182022ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wins0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.games0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageTime0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.theMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 42);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timerLabel
            // 
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(100, 32);
            this.timerLabel.Text = "Timer: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // theMenuStrip
            // 
            this.theMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.theMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.theMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.theMenuStrip.Name = "theMenuStrip";
            this.theMenuStrip.Size = new System.Drawing.Size(800, 40);
            this.theMenuStrip.TabIndex = 1;
            this.theMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.fileToolStripMenuItem.Text = "Game";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createdByAmberDolezalToolStripMenuItem,
            this.classCS3020ToolStripMenuItem,
            this.date1182022ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // createdByAmberDolezalToolStripMenuItem
            // 
            this.createdByAmberDolezalToolStripMenuItem.Name = "createdByAmberDolezalToolStripMenuItem";
            this.createdByAmberDolezalToolStripMenuItem.Size = new System.Drawing.Size(432, 44);
            this.createdByAmberDolezalToolStripMenuItem.Text = "Created By: Amber Dolezal";
            // 
            // classCS3020ToolStripMenuItem
            // 
            this.classCS3020ToolStripMenuItem.Name = "classCS3020ToolStripMenuItem";
            this.classCS3020ToolStripMenuItem.Size = new System.Drawing.Size(432, 44);
            this.classCS3020ToolStripMenuItem.Text = "Class: CS 3020";
            // 
            // date1182022ToolStripMenuItem
            // 
            this.date1182022ToolStripMenuItem.Name = "date1182022ToolStripMenuItem";
            this.date1182022ToolStripMenuItem.Size = new System.Drawing.Size(432, 44);
            this.date1182022ToolStripMenuItem.Text = "Date: 11/8/2022";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wins0ToolStripMenuItem,
            this.games0ToolStripMenuItem,
            this.averageTime0ToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // wins0ToolStripMenuItem
            // 
            this.wins0ToolStripMenuItem.Name = "wins0ToolStripMenuItem";
            this.wins0ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.wins0ToolStripMenuItem.Text = "Wins: 0";
            // 
            // games0ToolStripMenuItem
            // 
            this.games0ToolStripMenuItem.Name = "games0ToolStripMenuItem";
            this.games0ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.games0ToolStripMenuItem.Text = "Games: 0";
            // 
            // averageTime0ToolStripMenuItem
            // 
            this.averageTime0ToolStripMenuItem.Name = "averageTime0ToolStripMenuItem";
            this.averageTime0ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.averageTime0ToolStripMenuItem.Text = "Average Time: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.statusStrip1.BackColor = Color.CornflowerBlue;
            this.theMenuStrip.BackColor = Color.CornflowerBlue;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.theMenuStrip);
            this.MainMenuStrip = this.theMenuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.theMenuStrip.ResumeLayout(false);
            this.theMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel timerLabel;
        private System.Windows.Forms.Timer gameTimer;
        private MenuStrip theMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem instructionsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem createdByAmberDolezalToolStripMenuItem;
        private ToolStripMenuItem classCS3020ToolStripMenuItem;
        private ToolStripMenuItem date1182022ToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem wins0ToolStripMenuItem;
        private ToolStripMenuItem games0ToolStripMenuItem;
        private ToolStripMenuItem averageTime0ToolStripMenuItem;
    }
}