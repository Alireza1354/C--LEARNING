using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication.UserFoms
{
    public partial class RegisterBooksForm : Infrastructure.BaseForm
    {
        string strFilePath = "";
        Image defaultImage;
        Byte[] imageByteArray;

        public RegisterBooksForm()
        {
            InitializeComponent();
            defaultImage = booksPictureBox.Image;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strFilePath = ofd.FileName;
                booksPictureBox.Image = new Bitmap(strFilePath);
                if (searchTextBox.Text.Trim().Length == 0)
                    searchTextBox.Text = System.IO.Path.GetFileName(strFilePath);
            }
        }

        private void registerBook_Click(object sender, EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.Book book =
                    databaseContext.Books
                    .Where(current => string.Compare(current.ISBN, isbnTextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (book != null)
                {
                    System.Windows.Forms.MessageBox.Show
                        ("This book is already exist! Please choose another one...");
                    isbnTextBox.Focus();

                    return;
                }
                book = new Models.Book();
                book.ISBN = isbnTextBox.Text;
                book.AuthorName = authorNameTextBox.Text;
                book.Title = titleTextBox.Text;
                book.PublicationDate = DateTime.Now;

                Image temp = new Bitmap(strFilePath);
                System.IO.MemoryStream strm = new System.IO.MemoryStream();
                temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageByteArray = strm.ToArray();

                book.ImageByteArray = imageByteArray;


                databaseContext.Books.Add(book);
                databaseContext.SaveChanges();


                System.Windows.Forms.MessageBox.Show("Registration Done!");
                Close();
            }
            catch (Exception)

            {

                throw;
            }


        }
    }
}
