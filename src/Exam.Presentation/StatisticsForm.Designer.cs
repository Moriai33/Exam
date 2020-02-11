namespace Exam
{
    partial class StatisticsForm
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
            this.statisticsGridView = new System.Windows.Forms.DataGridView();
            this.statisticsFormCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticsGridView
            // 
            this.statisticsGridView.AllowUserToAddRows = false;
            this.statisticsGridView.AllowUserToDeleteRows = false;
            this.statisticsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticsGridView.Location = new System.Drawing.Point(31, 18);
            this.statisticsGridView.Name = "statisticsGridView";
            this.statisticsGridView.ReadOnly = true;
            this.statisticsGridView.Size = new System.Drawing.Size(444, 250);
            this.statisticsGridView.TabIndex = 0;
            // 
            // statisticsFormCloseButton
            // 
            this.statisticsFormCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statisticsFormCloseButton.Location = new System.Drawing.Point(583, 407);
            this.statisticsFormCloseButton.Name = "statisticsFormCloseButton";
            this.statisticsFormCloseButton.Size = new System.Drawing.Size(181, 31);
            this.statisticsFormCloseButton.TabIndex = 3;
            this.statisticsFormCloseButton.Text = global::Exam.PresentationResource.Statisticsform_CloseButton_Text;
            this.statisticsFormCloseButton.UseVisualStyleBackColor = true;
            this.statisticsFormCloseButton.Click += new System.EventHandler(this.statisticsFormCloseButton_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statisticsFormCloseButton);
            this.Controls.Add(this.statisticsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statisticsGridView;
        private System.Windows.Forms.Button statisticsFormCloseButton;
    }
}