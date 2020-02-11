namespace Exam
{
    partial class GameForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.checkLabel = new System.Windows.Forms.Button();
            this.answerOneRadioButton = new System.Windows.Forms.RadioButton();
            this.answerTwoRadioButton = new System.Windows.Forms.RadioButton();
            this.answerThreeRadioButton = new System.Windows.Forms.RadioButton();
            this.answerFourRadioButton = new System.Windows.Forms.RadioButton();
            this.progressLabel = new System.Windows.Forms.Label();
            this.slashLabel = new System.Windows.Forms.Label();
            this.maxQuestionNumberLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gameFormCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.Location = new System.Drawing.Point(115, 34);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(326, 25);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Melyik szerző írta ezt a könyvet?";
            this.questionLabel.Visible = false;
            // 
            // checkLabel
            // 
            this.checkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkLabel.Location = new System.Drawing.Point(762, 411);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(181, 38);
            this.checkLabel.TabIndex = 1;
            this.checkLabel.Text = global::Exam.PresentationResource.GameForm_CheckButton_Text;
            this.checkLabel.UseVisualStyleBackColor = true;
            this.checkLabel.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // answerOneRadioButton
            // 
            this.answerOneRadioButton.AutoSize = true;
            this.answerOneRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerOneRadioButton.Location = new System.Drawing.Point(137, 193);
            this.answerOneRadioButton.Name = "answerOneRadioButton";
            this.answerOneRadioButton.Size = new System.Drawing.Size(14, 13);
            this.answerOneRadioButton.TabIndex = 2;
            this.answerOneRadioButton.TabStop = true;
            this.answerOneRadioButton.UseVisualStyleBackColor = true;
            this.answerOneRadioButton.Visible = false;
            // 
            // answerTwoRadioButton
            // 
            this.answerTwoRadioButton.AutoSize = true;
            this.answerTwoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerTwoRadioButton.Location = new System.Drawing.Point(137, 240);
            this.answerTwoRadioButton.Name = "answerTwoRadioButton";
            this.answerTwoRadioButton.Size = new System.Drawing.Size(14, 13);
            this.answerTwoRadioButton.TabIndex = 2;
            this.answerTwoRadioButton.TabStop = true;
            this.answerTwoRadioButton.UseVisualStyleBackColor = true;
            this.answerTwoRadioButton.Visible = false;
            // 
            // answerThreeRadioButton
            // 
            this.answerThreeRadioButton.AutoSize = true;
            this.answerThreeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerThreeRadioButton.Location = new System.Drawing.Point(137, 288);
            this.answerThreeRadioButton.Name = "answerThreeRadioButton";
            this.answerThreeRadioButton.Size = new System.Drawing.Size(14, 13);
            this.answerThreeRadioButton.TabIndex = 2;
            this.answerThreeRadioButton.TabStop = true;
            this.answerThreeRadioButton.UseVisualStyleBackColor = true;
            this.answerThreeRadioButton.Visible = false;
            // 
            // answerFourRadioButton
            // 
            this.answerFourRadioButton.AutoSize = true;
            this.answerFourRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerFourRadioButton.Location = new System.Drawing.Point(137, 338);
            this.answerFourRadioButton.Name = "answerFourRadioButton";
            this.answerFourRadioButton.Size = new System.Drawing.Size(14, 13);
            this.answerFourRadioButton.TabIndex = 2;
            this.answerFourRadioButton.TabStop = true;
            this.answerFourRadioButton.UseVisualStyleBackColor = true;
            this.answerFourRadioButton.Visible = false;
            // 
            // progressLabel
            // 
            this.progressLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.progressLabel.Location = new System.Drawing.Point(839, 38);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 20);
            this.progressLabel.TabIndex = 3;
            // 
            // slashLabel
            // 
            this.slashLabel.AutoSize = true;
            this.slashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.slashLabel.Location = new System.Drawing.Point(878, 38);
            this.slashLabel.Name = "slashLabel";
            this.slashLabel.Size = new System.Drawing.Size(13, 20);
            this.slashLabel.TabIndex = 3;
            this.slashLabel.Text = "/";
            // 
            // maxQuestionNumberLabel
            // 
            this.maxQuestionNumberLabel.AutoSize = true;
            this.maxQuestionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxQuestionNumberLabel.Location = new System.Drawing.Point(897, 38);
            this.maxQuestionNumberLabel.Name = "maxQuestionNumberLabel";
            this.maxQuestionNumberLabel.Size = new System.Drawing.Size(0, 20);
            this.maxQuestionNumberLabel.TabIndex = 3;
            // 
            // gameFormCloseButton
            // 
            this.gameFormCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameFormCloseButton.Location = new System.Drawing.Point(762, 527);
            this.gameFormCloseButton.Name = "gameFormCloseButton";
            this.gameFormCloseButton.Size = new System.Drawing.Size(181, 31);
            this.gameFormCloseButton.TabIndex = 4;
            this.gameFormCloseButton.Text = global::Exam.PresentationResource.GameForm_CloseButton_Text;
            this.gameFormCloseButton.UseVisualStyleBackColor = true;
            this.gameFormCloseButton.Click += new System.EventHandler(this.gameFormCloseButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 627);
            this.Controls.Add(this.gameFormCloseButton);
            this.Controls.Add(this.maxQuestionNumberLabel);
            this.Controls.Add(this.slashLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.answerFourRadioButton);
            this.Controls.Add(this.answerThreeRadioButton);
            this.Controls.Add(this.answerTwoRadioButton);
            this.Controls.Add(this.answerOneRadioButton);
            this.Controls.Add(this.checkLabel);
            this.Controls.Add(this.questionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkLabel;
        private System.Windows.Forms.RadioButton answerOneRadioButton;
        private System.Windows.Forms.RadioButton answerTwoRadioButton;
        private System.Windows.Forms.RadioButton answerThreeRadioButton;
        private System.Windows.Forms.RadioButton answerFourRadioButton;
        private System.Windows.Forms.Label slashLabel;
        public System.Windows.Forms.Label progressLabel;
        public System.Windows.Forms.Label maxQuestionNumberLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button gameFormCloseButton;
    }
}