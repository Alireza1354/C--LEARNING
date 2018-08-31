namespace MyApplication.UserFoms
{
    partial class BooksListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksListForm));
            this.addBooksButton = new Dtx.Windows.Forms.Button();
            this.deleteBooksButton = new Dtx.Windows.Forms.Button();
            this.booksListbox = new Dtx.Windows.Forms.ListBox();
            this.bookNameTextBox = new Dtx.Windows.Forms.TextBox();
            this.bookNameLable = new Dtx.Windows.Forms.Label();
            this.searchButton = new Dtx.Windows.Forms.Button();
            this.bookPictureBox = new Dtx.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addBooksButton
            // 
            this.addBooksButton.Location = new System.Drawing.Point(112, 322);
            this.addBooksButton.Name = "addBooksButton";
            this.addBooksButton.Size = new System.Drawing.Size(109, 23);
            this.addBooksButton.TabIndex = 5;
            this.addBooksButton.Text = "AddBooks";
            this.addBooksButton.UseVisualStyleBackColor = true;
            this.addBooksButton.Click += new System.EventHandler(this.addBooksButton_Click);
            // 
            // deleteBooksButton
            // 
            this.deleteBooksButton.Location = new System.Drawing.Point(227, 322);
            this.deleteBooksButton.Name = "deleteBooksButton";
            this.deleteBooksButton.Size = new System.Drawing.Size(109, 23);
            this.deleteBooksButton.TabIndex = 4;
            this.deleteBooksButton.Text = "DeleteBooks";
            this.deleteBooksButton.UseVisualStyleBackColor = true;
            this.deleteBooksButton.Click += new System.EventHandler(this.deleteBooksButton_Click);
            // 
            // booksListbox
            // 
            this.booksListbox.FormattingEnabled = true;
            this.booksListbox.Location = new System.Drawing.Point(112, 68);
            this.booksListbox.Name = "booksListbox";
            this.booksListbox.Size = new System.Drawing.Size(271, 238);
            this.booksListbox.TabIndex = 3;
            this.booksListbox.SelectedIndexChanged += new System.EventHandler(this.booksListbox_SelectedIndexChanged);
            this.booksListbox.DoubleClick += new System.EventHandler(this.booksListbox_DoubleClick);
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(112, 12);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(271, 21);
            this.bookNameTextBox.TabIndex = 2;
            // 
            // bookNameLable
            // 
            this.bookNameLable.AutoSize = true;
            this.bookNameLable.Location = new System.Drawing.Point(23, 15);
            this.bookNameLable.Name = "bookNameLable";
            this.bookNameLable.Size = new System.Drawing.Size(69, 13);
            this.bookNameLable.TabIndex = 1;
            this.bookNameLable.Text = "BookName";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(112, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(109, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookPictureBox
            // 
            this.bookPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("bookPictureBox.Image")));
            this.bookPictureBox.Location = new System.Drawing.Point(389, 68);
            this.bookPictureBox.Name = "bookPictureBox";
            this.bookPictureBox.Size = new System.Drawing.Size(191, 238);
            this.bookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookPictureBox.TabIndex = 6;
            this.bookPictureBox.TabStop = false;
            // 
            // BooksListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 357);
            this.Controls.Add(this.bookPictureBox);
            this.Controls.Add(this.addBooksButton);
            this.Controls.Add(this.deleteBooksButton);
            this.Controls.Add(this.booksListbox);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.bookNameLable);
            this.Controls.Add(this.searchButton);
            this.Name = "BooksListForm";
            this.Text = "BooksList";
            ((System.ComponentModel.ISupportInitialize)(this.bookPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dtx.Windows.Forms.Button searchButton;
        private Dtx.Windows.Forms.Label bookNameLable;
        private Dtx.Windows.Forms.TextBox bookNameTextBox;
        private Dtx.Windows.Forms.ListBox booksListbox;
        private Dtx.Windows.Forms.Button deleteBooksButton;
        private Dtx.Windows.Forms.Button addBooksButton;
        private Dtx.Windows.Forms.PictureBox bookPictureBox;
    }
}