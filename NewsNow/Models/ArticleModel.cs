using System;

namespace NewsNow.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        public DateTime? DateCreated { get; set; }

        // Detailed page

        public string DetailedHeader { get; set; }

        public string DetailedContent { get; set; }

        // Home page

        public string HomeHeader { get; set; }

        public string HomeContent { get; set; }

        public string HomeImage { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}