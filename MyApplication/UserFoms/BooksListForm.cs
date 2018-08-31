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
    public partial class BooksListForm : Infrastructure.BaseForm
    {
        Image defaultImage;

        public BooksListForm()
        {
            InitializeComponent();
            defaultImage = bookPictureBox.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchBook();
        }

        private void addBooksButton_Click(object sender, EventArgs e)
        {
            RegisterBooksForm registerBooksForm = new RegisterBooksForm();
            registerBooksForm.ShowDialog();
        }

        private void deleteBooksButton_Click(object sender, EventArgs e)
        {
            if (booksListbox.SelectedItems.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("You did not select any book for deleting!");

                return;
            }

            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                foreach (var selectedItem in booksListbox.SelectedItems)
                {
                    
                    Models.Book selectedBook = selectedItem as Models.Book;

                    if (selectedBook != null)
                    {
                    
                            databaseContext.Entry(selectedBook).State = System.Data.Entity.EntityState.Deleted;

                            // Note: Does Not Work!
                            //databaseContext.Users.Remove(selectedUser);

                            databaseContext.SaveChanges();
                    
                    }
                }

                SearchBook();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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

        private void SearchBook()
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext =
                    new Models.DatabaseContext();
                System.Collections.Generic.List<Models.Book> books = null;

                bookNameTextBox.Text = bookNameTextBox.Text.Trim();

                while (bookNameTextBox.Text.Contains("  "))
                {
                    bookNameTextBox.Text =
                        bookNameTextBox.Text.Replace("  ", " ");
                }

                if (bookNameTextBox.Text == string.Empty)
                {
                    books =
                        databaseContext.Books
                        .OrderBy(current => current.Title)
                        .ToList()
                        ;
                }
                else
                {


                    books =
                        databaseContext.Books
                        .Where(current => current.Title.Contains(bookNameTextBox.Text))
                        .OrderBy(current => current.Title)
                        .ToList()
                        ;
                }

                // Unbinding

                //usersListBox.Items.Clear();

                //foreach (var item in users)
                //{
                //	usersListBox.Items.Add(item.DisplayName);
                //}

                // Binding
                //usersListBox.DataSource = null;

                booksListbox.ValueMember = "Id";
                //usersListBox.DisplayMember = "FullName";
                booksListbox.DisplayMember = "DisplayName";
                booksListbox.DataSource = books;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void booksListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Book book = booksListbox.SelectedItem as Models.Book;


            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.Book selectedBook =
                    databaseContext.Books
                    .Where(current => current.Id == book.Id)
                    .FirstOrDefault();

                byte[] ImageArray = (byte[])selectedBook.ImageByteArray;
                if (ImageArray.Length == 0)
                    bookPictureBox.Image = defaultImage;
                else
                    bookPictureBox.Image = Image.FromStream(new System.IO.MemoryStream(ImageArray));

                
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void booksListbox_DoubleClick(object sender, EventArgs e)
        {
            Models.Book selectedBook = booksListbox.SelectedItem as Models.Book;

            if (selectedBook!=null)
            {
                UpdateBooksForm updateBooksForm = new UpdateBooksForm();
                updateBooksForm.SelectedBook = selectedBook;
                updateBooksForm.ShowDialog();
                SearchBook();

            }



        }
    }
}
