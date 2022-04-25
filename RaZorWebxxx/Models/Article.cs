using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaZorWebxxx.Models
{
    public class Article
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public DateTime Created { set; get; }
        public string Content { set; get; }

    }
}
