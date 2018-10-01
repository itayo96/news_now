using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsNow.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }

        public int ArticleId { get; set; }

        public virtual Article Article{ get; set; }
    }
}