using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.ViewModels.Home
{
    public class LoginVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Password { get; set; }
    }
}
