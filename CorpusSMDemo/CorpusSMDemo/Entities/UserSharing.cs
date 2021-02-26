using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.Entities
{
    public class UserSharing : BaseEntity
    {
        public int UserId { get; set; }
        public int PostId { get; set; }

        [ForeignKey("UserId")]
        public User ParentUser { get; set; }

        [ForeignKey("PostId")]
        public Post ParentPost { get; set; }
    }
}
