using CorpusSMDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.ViewModels.Posts
{
    public class ShareVM
    {
        public User User { get; set; }
        public List<int> UserIds { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public List<User> SharedWith { get; set; }
        public List<User> Users { get; set; }
    }
}
