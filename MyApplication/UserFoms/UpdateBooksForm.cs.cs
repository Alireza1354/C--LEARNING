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
    public partial class UpdateBooksForm : Infrastructure.BaseForm
    {
        string strFilePath = "";
        Image defaultImage;
        Byte[] imageByteArray;


        public UpdateBooksForm()
        {
            InitializeComponent();
            defaultImage = booksPictureBox.Image;
        }

        public Models.Book SelectedBook { get; set; }

        private void UpdateBooksForm_Load(object sender, EventArgs e)
        {
            Models.DatabaseContext databaseContext = new Models.DatabaseContext();

            try
            {
                Models.Book foundedBook = databaseContext.Books
                .Where(current => current.Id == SelectedBook.Id)
                .FirstOrDefault();

                if (foundedBook == null)
                {
                    System.Windows.Forms.MessageBox.Show("There is no such a book anymore");
                    Close();
                }

                authorNameTextBox.Text = foundedBook.AuthorName;
                titleTextBox.Text = foundedBook.Title;
                isbnTextBox.Text = foundedBook.ISBN;

                byte[] ImageArray = (byte[])foundedBook.ImageByteArray;
                if (ImageArray.Length == 0)
                    booksPictureBox.Image = defaultImage;
                else
                    booksPictureBox.Image = Image.FromStream(new System.IO.MemoryStream(ImageArray));
                               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                Close();
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }



        }

        private void registerBook_Click(object sender, EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                Models.Book foundedBook =
                    databaseContext.Books
                    .Where(current => current.Id == SelectedBook.Id)
                    .FirstOrDefault();
                if (foundedBook == null)
                {
                    System.Windows.Forms.MessageBox.Show("There is no such a book anymore");
                    Close();
                }

                foundedBook.ISBN = isbnTextBox.Text;
                foundedBook.Title = titleTextBox.Text;
                foundedBook.AuthorName = authorNameTextBox.Text;
                if (searchTextBox.Text!="")
                {
                    Image temp = new Bitmap(strFilePath);
                    System.IO.MemoryStream strm = new System.IO.MemoryStream();
                    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageByteArray = strm.ToArray();

                    foundedBook.ImageByteArray = imageByteArray;
                }
                

                databaseContext.SaveChanges();
                Close();

            }
            catch (Exception)
            {

                throw;
            }




        }

        private void browsButton_Click(object sender, EventArgs e)
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
    }
}
