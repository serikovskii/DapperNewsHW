using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperNewsHW.Models
{
    class Article : Entity
    {
        public string Theme { get; set; }
        public string Text { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public DateTime DateArticle { get; set; }

        public Article()
        {
            DateArticle = DateTime.Now;
        }
    }
}
