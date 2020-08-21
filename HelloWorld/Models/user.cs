using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class user
    {
        [Required(ErrorMessage =" لطفا نام کاربری را وارد نمایید")]
        [Display(Name ="User")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Your Name")]
        public string  FullName { get; set; }
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }

    }
}
