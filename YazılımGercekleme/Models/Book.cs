using System;
using System.Collections.Generic;

namespace YazılımGercekleme.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public DateTime CreatedDate { get; set; }

        public decimal Price { get; set; }

        public string ImageURL { get; set; }

        // foreign key
        public int? CategoryId { get; set; }

        // simple navigation property
        public Category Category { get; set; }

        // navigation property
        public BookDetail BookDetail { get; set; }

        // collection navigation property
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }





}
