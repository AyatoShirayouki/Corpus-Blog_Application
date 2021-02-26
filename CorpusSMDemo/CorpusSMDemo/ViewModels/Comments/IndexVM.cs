using CorpusSMDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.ViewModels.Comments
{
    public class IndexVM
    {
        public int ParentId { get; set; }
        public Post Post { get; set; }
        public List<Comment> Items { get; set; }
    }
}
