﻿using System.Collections.Generic;

namespace YazılımGercekleme.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        // collection navigation property
        public ICollection<Book> Books { get; set; }
    }





}
