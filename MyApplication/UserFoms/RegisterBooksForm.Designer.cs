namespace MyApplication.UserFoms
{
    partial class RegisterBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterBooksForm));
            this.searchTextBox = new Dtx.Windows.Forms.TextBox();
            this.searchButton = new Dtx.Windows.Forms.Button();
            this.booksPictureBox = new Dtx.Windows.Forms.PictureBox();
            this.registerBook = new Dtx.Windows.Forms.Button();
            this.isbnTextBox = new Dtx.Windows.Forms.TextBox();
            this.authorNameTextBox = new Dtx.Windows.Forms.TextBox();
            this.titleTextBox = new Dtx.Windows.Forms.TextBox();
            this.ISBN_Lable = new Dtx.Windows.Forms.Label();
            this.AuthorNameLable = new Dtx.Windows.Forms.Label();
            this.titleLable = new Dtx.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(100, 108);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(216, 21);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(10, 108);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Browse";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // booksPictureBox
            // 
            this.booksPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("booksPictureBox.Image")));
            this.booksPictureBox.Location = new System.Drawing.Point(335, 30);
            this.booksPictureBox.Name = "booksPictureBox";
            this.booksPictureBox.Size = new System.Drawing.Size(231, 280);
            this.booksPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.booksPictureBox.TabIndex = 2;
            this.booksPictureBox.TabStop = false;
            // 
            // registerBook
            // 
            this.registerBook.Location = new System.Drawing.Point(162, 169);
            this.registerBook.Name = "registerBook";
            this.registerBook.Size = new System.Drawing.Size(75, 23);
            this.registerBook.TabIndex = 8;
            this.registerBook.Text = "Register";
            this.registerBook.UseVisualStyleBackColor = true;
            this.registerBook.Click += new System.EventHandler(this.registerBook_Click);
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(182, 81);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(134, 21);
            this.isbnTextBox.TabIndex = 5;
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(182, 54);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(134, 21);
            this.authorNameTextBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(182, 27);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(134, 21);
            this.titleTextBox.TabIndex = 1;
            // 
            // ISBN_Lable
            // 
            this.ISBN_Lable.AutoSize = true;
            this.ISBN_Lable.Location = new System.Drawing.Point(97, 84);
            this.ISBN_Lable.Name = "ISBN_Lable";
            this.ISBN_Lable.Size = new System.Drawing.Size(36, 13);
            this.ISBN_Lable.TabIndex = 4;
            this.ISBN_Lable.Text = "ISBN";
            // 
            // AuthorNameLable
            // 
            this.AuthorNameLable.AutoSize = true;
            this.AuthorNameLable.Location = new System.Drawing.Point(97, 57);
            this.AuthorNameLable.Name = "AuthorNameLable";
            this.AuthorNameLable.Size = new System.Drawing.Size(78, 13);
            this.AuthorNameLable.TabIndex = 2;
            this.AuthorNameLable.Text = "AuthorName";
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Location = new System.Drawing.Point(97, 30);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(31, 13);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Title";
            // 
            // RegisterBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 325);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.AuthorNameLable);
            this.Controls.Add(this.ISBN_Lable);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorNameTextBox);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.registerBook);
            this.Controls.Add(this.booksPictureBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Name = "RegisterBooksForm";
            this.Text = "RegisterBooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.booksPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dtx.Windows.Forms.Button searchButton;
        private Dtx.Windows.Forms.TextBox searchTextBox;
        private Dtx.Windows.Forms.PictureBox booksPictureBox;
        private Dtx.Windows.Forms.Button registerBook;
        private Dtx.Windows.Forms.TextBox isbnTextBox;
        private Dtx.Windows.Forms.TextBox authorNameTextBox;
        private Dtx.Windows.Forms.TextBox titleTextBox;
        private Dtx.Windows.Forms.Label ISBN_Lable;
        private Dtx.Windows.Forms.Label AuthorNameLable;
        private Dtx.Windows.Forms.Label titleLable;
    }
}