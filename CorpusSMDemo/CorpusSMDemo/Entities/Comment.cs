using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.Entities
{
    public class Comment :BaseEntity
    {
        public int PostId { get; set; }
        public string Content { get; set; }

        [ForeignKey("PostId")]
        public Post ParentPost { get; set; }

    }
}
