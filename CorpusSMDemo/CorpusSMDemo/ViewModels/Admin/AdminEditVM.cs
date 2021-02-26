using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorpusSMDemo.ViewModels.Admin
{
    public class AdminEditVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string Email { get; set; }
        public string ImageName { get; set; }
    }
}
