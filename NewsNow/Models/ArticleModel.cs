using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsNow.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        public DateTime? DateCreated { get; set; }

        public string Header { get; set; }

        public string Summery { get; set; }
        
        public string Content { get; set; }

        public string HomeImageUrl { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public string Location { get; set; }

        public bool IsShowMap { get; set; }

        public List<Comment> Comments { get; set; }
    }
}