using System;

namespace DapperNewsHW.Models
{
    public class Comment
    {
        public string NameCommentary { get; set; }
        public string Commetary { get; set; }
        public DateTime DateCommentary { get; set; }
        public Guid ArticleId { get; set; }
        public Comment()
        {
            DateCommentary = DateTime.Now;
        }
    }
}