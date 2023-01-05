﻿using System;
using System.Collections.Generic;

namespace YazılımGercekleme.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FullName { get; set; }

        public DateTime CreatedDate { get; set; }

        // collection navigation property
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }





}
