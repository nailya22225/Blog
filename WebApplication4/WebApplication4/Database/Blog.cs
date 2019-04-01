using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Database
{
    public class Blog
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Headline { get; set; }
        public bool IsOpen { get; set; }
        public int UserId { get; set; }
        //public long Date { get; set; }
    }
}
