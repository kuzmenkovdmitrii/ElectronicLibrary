﻿using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace ElLib.Common.Entity
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookCategory> Categories { get; set; }
        public ICollection<Author> Authors { get; set; }
        public DateTime PublishingDate { get; set; }
        public string Language { get; set; }
        public Publishing Publishing { get; set; }
        public Url Picture { get; set; }
        public Url File { get; set; }
    }
}
