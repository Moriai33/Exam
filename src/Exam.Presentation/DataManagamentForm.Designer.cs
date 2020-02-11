namespace Exam
{
    partial class DataManagementForm
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
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.dataManagamentFormCloseButton = new System.Windows.Forms.Button();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorNameTextBox.Location = new System.Drawing.Point(57, 86);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(196, 31);
            this.authorNameTextBox.TabIndex = 0;
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bookTitleTextBox.Location = new System.Drawing.Point(279, 283);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(196, 31);
            this.bookTitleTextBox.TabIndex = 0;
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bookTitleLabel.Location = new System.Drawing.Point(274, 238);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(129, 25);
            this.bookTitleLabel.TabIndex = 1;
            this.bookTitleLabel.Text = "Könyv címe:";
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorNameLabel.Location = new System.Drawing.Point(52, 238);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(165, 25);
            this.authorNameLabel.TabIndex = 1;
            this.authorNameLabel.Text = "Könyv szerzője:";
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addAuthorButton.Location = new System.Drawing.Point(526, 87);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(181, 31);
            this.addAuthorButton.TabIndex = 2;
            this.addAuthorButton.Text = "Író felvétele";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
            // 
            // dataManagamentFormCloseButton
            // 
            this.dataManagamentFormCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataManagamentFormCloseButton.Location = new System.Drawing.Point(526, 371);
            this.dataManagamentFormCloseButton.Name = "dataManagamentFormCloseButton";
            this.dataManagamentFormCloseButton.Size = new System.Drawing.Size(181, 31);
            this.dataManagamentFormCloseButton.TabIndex = 2;
            this.dataManagamentFormCloseButton.Text = global::Exam.PresentationResource.DataManagementForm_CloseButton;
            this.dataManagamentFormCloseButton.UseVisualStyleBackColor = true;
            this.dataManagamentFormCloseButton.Click += new System.EventHandler(this.DataManagamentFormCloseButton_Click);
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(57, 281);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(196, 33);
            this.AuthorComboBox.TabIndex = 3;
            // 
            // addBookButton
            // 
            this.addBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addBookButton.Location = new System.Drawing.Point(526, 283);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(181, 31);
            this.addBookButton.TabIndex = 4;
            this.addBookButton.Text = "Könyv felvétele";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Könyv szerzője:";
            // 
            // DataManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.AuthorComboBox);
            this.Controls.Add(this.dataManagamentFormCloseButton);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.bookTitleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorNameLabel);
            this.Controls.Add(this.bookTitleTextBox);
            this.Controls.Add(this.authorNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataManagementForm";
            this.Text = "DataManagementForm";
            this.Load += new System.EventHandler(this.DataManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authorNameTextBox;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.Button dataManagamentFormCloseButton;
        private System.Windows.Forms.ComboBox AuthorComboBox;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Label label1;
    }
}