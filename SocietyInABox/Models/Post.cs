using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocietyInABox.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Header   { get; set; }
        public string Content { get; set; }
        public dynamic image { get; set; }
    }
}