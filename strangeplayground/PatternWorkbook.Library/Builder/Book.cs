using System;
using System.Collections.Generic;
using System.Text;

namespace PatternWorkbook.Library.Builder
{

    /// <summary>
    /// This is the Jon Skeet-type implementation.
    /// </summary>
    public class Book
    {
        private readonly int pages;
        private readonly string title;

        public int Pages { get { return pages; } }
        public string Title { get { return title; } }

        private Book(BookBuilder builder)
        {
            this.pages = builder.Pages;
            this.title = builder.Title;
        }

        public sealed class BookBuilder
        {
            public int Pages { get; set; }
            public string Title { get; set; }
            public Book Build()
            {
                return new Book(this);
            }
        }

    }
}
