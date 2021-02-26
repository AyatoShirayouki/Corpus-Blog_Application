using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.Entities
{
    public class Post : BaseEntity
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageName { get; set; }

        [ForeignKey("UserId")]
        public User ParentUser { get; set; }
    }
}
