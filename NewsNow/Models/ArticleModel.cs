using System;

namespace NewsNow.Models
{
    public class ArticleModel
    {
        public int ID { get; set; }

        // Detailed page

        public string DetailedHeader { get; set; }

        public string DetailedContent { get; set; }

        // Home page

        public string HomeHeader { get; set; }

        public string HomeContent { get; set; }

        public string HomeImage { get; set; }
    }
}