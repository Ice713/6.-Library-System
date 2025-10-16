using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Library_System
{
    internal class Book
    {
        public string Title { get; set; }

        public Book(string title)
        {
            Title = title;
        }

        public virtual string GetTitleInfo()
        {
            return $"Book: {Title}";
        }
    }
}
