using CorpusSMDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.ViewModels.Posts
{
    public class IndexVM
    {
        public List<Post> Items { get; set; }
        public User User { get; set; }
    }
}
