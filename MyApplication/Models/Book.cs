using System;

namespace Models
{
    public class Book:BaseEntity
    {
        public Book():base()
        {

        }

        public string ISBN { get; set; }
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public Byte[] ImageByteArray { get; set; }

        public string DisplayName
        {
            get
            {
                string result = string.Empty;

                if (string.IsNullOrWhiteSpace(Title) == false)
                {
                    result = Title;
                }
                if (result != string.Empty)
                {
                    result += " - ";
                }
                result += $"{AuthorName}";
                return (result);
            }
        }


    }
}
