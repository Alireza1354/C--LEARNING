﻿using System;
using System.Linq;

namespace MyApplication
{
	internal static class Program
	{
		static Program()
		{
		}

		[System.STAThread]
		internal static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				//int adminCount =
				//	databaseContext.Users
				//	.Where(current => current.IsAdmin)
				//	.Count();

				//int userCount =
				//	databaseContext.Users
				//	.Count();

				bool hasAnyUser =
					databaseContext.Users
					.Any();

				if (hasAnyUser == false)
				{
					Models.User adminUser = new Models.User();

					adminUser.IsAdmin = true;
					adminUser.IsActive = true;

					adminUser.Username = "Dariush";
					adminUser.Password = "1234512345";
					adminUser.FullName = "Mr. Dariush Tasdighi";

					databaseContext.Users.Add(adminUser);

					databaseContext.SaveChanges();
				}
                
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);

				return;
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}

            try
            {
                databaseContext = new Models.DatabaseContext();
                bool hasAnyBook = databaseContext.Books.Any();
                if (hasAnyBook==false)
                {
                    Models.Book myBook = new Models.Book();

                    myBook.AuthorName = "charsDikens";
                    myBook.ISBN = "kdfjksjflk";
                    myBook.PublicationDate =DateTime.Now;
                    myBook.Title = "Beuti";

                    databaseContext.Books.Add(myBook);
                    databaseContext.SaveChanges();
                }


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if(databaseContext!=null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
          

			// **************************************************

			// **************************************************
			//#region Solution (1)
			//Infrastructure.BaseForm startupForm = new LoginForm();
			////Infrastructure.BaseForm startupForm = new RegisterForm();

			//System.Windows.Forms.Application.Run(startupForm);

			//if (startupForm != null)
			//{
			//	if (startupForm.IsDisposed == false)
			//	{
			//		startupForm.Dispose();
			//	}

			//	startupForm = null;
			//}
			//#endregion /Solution (1)
			// **************************************************

			// **************************************************
			#region Solution (2)
			System.Windows.Forms.Application.Run(Infrastructure.Utility.LoginForm);
			#endregion /Solution (2)
			// **************************************************
		}
	}
}