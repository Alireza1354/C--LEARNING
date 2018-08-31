namespace MyApplication.UserFoms
{
    partial class UpdateBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBooksForm));
            this.titleLable = new Dtx.Windows.Forms.Label();
            this.AuthorNameLable = new Dtx.Windows.Forms.Label();
            this.ISBN_Lable = new Dtx.Windows.Forms.Label();
            this.titleTextBox = new Dtx.Windows.Forms.TextBox();
            this.authorNameTextBox = new Dtx.Windows.Forms.TextBox();
            this.isbnTextBox = new Dtx.Windows.Forms.TextBox();
            this.registerBook = new Dtx.Windows.Forms.Button();
            this.booksPictureBox = new Dtx.Windows.Forms.PictureBox();
            this.searchTextBox = new Dtx.Windows.Forms.TextBox();
            this.browsButton = new Dtx.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Location = new System.Drawing.Point(91, 30);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(31, 13);
            this.titleLable.TabIndex = 9;
            this.titleLable.Text = "Title";
            // 
            // AuthorNameLable
            // 
            this.AuthorNameLable.AutoSize = true;
            this.AuthorNameLable.Location = new System.Drawing.Point(91, 57);
            this.AuthorNameLable.Name = "AuthorNameLable";
            this.AuthorNameLable.Size = new System.Drawing.Size(78, 13);
            this.AuthorNameLable.TabIndex = 11;
            this.AuthorNameLable.Text = "AuthorName";
            // 
            // ISBN_Lable
            // 
            this.ISBN_Lable.AutoSize = true;
            this.ISBN_Lable.Location = new System.Drawing.Point(91, 84);
            this.ISBN_Lable.Name = "ISBN_Lable";
            this.ISBN_Lable.Size = new System.Drawing.Size(36, 13);
            this.ISBN_Lable.TabIndex = 14;
            this.ISBN_Lable.Text = "ISBN";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(176, 27);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(134, 21);
            this.titleTextBox.TabIndex = 10;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(176, 54);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(134, 21);
            this.authorNameTextBox.TabIndex = 13;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(176, 81);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(134, 21);
            this.isbnTextBox.TabIndex = 15;
            // 
            // registerBook
            // 
            this.registerBook.Location = new System.Drawing.Point(4, 137);
            this.registerBook.Name = "registerBook";
            this.registerBook.Size = new System.Drawing.Size(75, 23);
            this.registerBook.TabIndex = 18;
            this.registerBook.Text = "Register";
            this.registerBook.UseVisualStyleBackColor = true;
            this.registerBook.Click += new System.EventHandler(this.registerBook_Click);
            // 
            // booksPictureBox
            // 
            this.booksPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("booksPictureBox.Image")));
            this.booksPictureBox.Location = new System.Drawing.Point(329, 30);
            this.booksPictureBox.Name = "booksPictureBox";
            this.booksPictureBox.Size = new System.Drawing.Size(231, 280);
            this.booksPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.booksPictureBox.TabIndex = 12;
            this.booksPictureBox.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(103, 108);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(207, 21);
            this.searchTextBox.TabIndex = 16;
            // 
            // browsButton
            // 
            this.browsButton.Location = new System.Drawing.Point(4, 108);
            this.browsButton.Name = "browsButton";
            this.browsButton.Size = new System.Drawing.Size(75, 23);
            this.browsButton.TabIndex = 17;
            this.browsButton.Text = "Browse";
            this.browsButton.UseVisualStyleBackColor = true;
            this.browsButton.Click += new System.EventHandler(this.browsButton_Click);
            // 
            // UpdateBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 318);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.AuthorNameLable);
            this.Controls.Add(this.ISBN_Lable);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorNameTextBox);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.registerBook);
            this.Controls.Add(this.booksPictureBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.browsButton);
            this.Name = "UpdateBooksForm";
            this.Text = "UpdateBooksForm";
            this.Load += new System.EventHandler(this.UpdateBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dtx.Windows.Forms.Label titleLable;
        private Dtx.Windows.Forms.Label AuthorNameLable;
        private Dtx.Windows.Forms.Label ISBN_Lable;
        private Dtx.Windows.Forms.TextBox titleTextBox;
        private Dtx.Windows.Forms.TextBox authorNameTextBox;
        private Dtx.Windows.Forms.TextBox isbnTextBox;
        private Dtx.Windows.Forms.Button registerBook;
        private Dtx.Windows.Forms.PictureBox booksPictureBox;
        private Dtx.Windows.Forms.TextBox searchTextBox;
        private Dtx.Windows.Forms.Button browsButton;
    }
}