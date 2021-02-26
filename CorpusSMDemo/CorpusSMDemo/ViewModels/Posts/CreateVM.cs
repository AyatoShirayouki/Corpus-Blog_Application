using CorpusSMDemo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.ViewModels.Posts
{
    public class CreateVM
    {
        public User User { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string Content { get; set; }
        public string ImageName { get; set; }
    }
}
