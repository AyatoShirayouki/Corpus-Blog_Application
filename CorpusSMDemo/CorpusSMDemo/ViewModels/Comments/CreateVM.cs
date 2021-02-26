using CorpusSMDemo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.ViewModels.Comments
{
    public class CreateVM
    {
        
        public int PostId { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string Content { get; set; }
    }
}
