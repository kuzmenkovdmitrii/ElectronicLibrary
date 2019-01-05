using System;
using System.Collections.Generic;
using System.Security.Policy;

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
        public ICollection<Publishing> Publishings { get; set; }
        public Url Picture { get; set; }
        public Url File { get; set; }
    }
}
