using System;
using System.Collections.Generic;

namespace ElLib.Common.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookCategory> Categories { get; set; }
        public ICollection<Author> Authors { get; set; }
        public DateTime PublishingDate { get; set; }
        public Language Language { get; set; }
        public ICollection<Publishing> Publishing { get; set; }
        public Picture Picture { get; set; }
        public File File { get; set; }
    }
}
