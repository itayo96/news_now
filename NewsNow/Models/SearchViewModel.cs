using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsNow.Models
{
    public class SearchViewModel
    {
        public IEnumerable<Article> allArticles { get; set; }
        public IEnumerable<Comment> allComments { get; set; }

    }
}
