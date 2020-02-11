namespace Exam
{
    partial class MainForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.newGame = new System.Windows.Forms.ToolStripMenuItem();
            this.beginnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(26, 27);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1068, 582);
            this.mainPanel.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGame,
            this.statisticsToolStripMenuItem,
            this.addDataToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1101, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // newGame
            // 
            this.newGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginnerToolStripMenuItem,
            this.advancedToolStripMenuItem,
            this.customToolStripMenuItem});
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(58, 20);
            this.newGame.Text = global::Exam.PresentationResource.MainForm_Menu_NewGame;
            // 
            // beginnerToolStripMenuItem
            // 
            this.beginnerToolStripMenuItem.Name = "beginnerToolStripMenuItem";
            this.beginnerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.beginnerToolStripMenuItem.Text = global::Exam.PresentationResource.MainForm_Menu_NewGame_Beginner;
            this.beginnerToolStripMenuItem.Click += new System.EventHandler(this.BeginnerToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.advancedToolStripMenuItem.Text = global::Exam.PresentationResource.MainForm_Menu_NewGame_Advanced;
            this.advancedToolStripMenuItem.Click += new System.EventHandler(this.AdvancedToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.customToolStripMenuItem.Text = global::Exam.PresentationResource.MainForm_Menu_NewGame_Custom;
            this.customToolStripMenuItem.Click += new System.EventHandler(this.CustomToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.statisticsToolStripMenuItem.Text = global::Exam.PresentationResource.MainForm_Menu_Statistics;
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.StatisticsToolStripMenuItem_Click);
            // 
            // addDataToolStripMenuItem
            // 
            this.addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            this.addDataToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.addDataToolStripMenuItem.Text = global::Exam.PresentationResource.MainForm_Menu_AddData;
            this.addDataToolStripMenuItem.Click += new System.EventHandler(this.AddDataToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 620);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Quiz";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem newGame;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
    }
}

