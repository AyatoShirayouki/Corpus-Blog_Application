using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.Entities
{
    public class Admin : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
