using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Post : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Post() { }
        public Post(int id, string title, string content)
        {
            (Id, Title, Content) = (id, title, content);            
        }
    }
}
