using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Library_System
{
    internal class Ebook : Book
    {
        public string FileSize { get; set; }

        public Ebook(string title, string fileSize) : base(title)
        {
            FileSize = fileSize;
        }

        public string GetFileSizeInfo()
        {
            return $"Ebook Filesize: {FileSize}";
        }

        public override string GetTitleInfo()
        {
            return base.GetTitleInfo() + $"\n{GetFileSizeInfo()}";
        }
    }
}
