using System;
using System.Collections.Generic;
using System.Security.Policy;
using ElLib.Common.Entity;

namespace ElLib.Web.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookCategory> Categories { get; set; }
        public ICollection<Author> Authors { get; set; }
        public DateTime PublishingDate { get; set; }
        public string Language { get; set; }
        public PublishingModel Publishing { get; set; }
        public Url Picture { get; set; }
        public Url File { get; set; }
    }
}