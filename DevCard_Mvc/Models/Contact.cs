using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="این فیلد اجباری است.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [EmailAddress(ErrorMessage="ایمیل معتبر نیست.")]
        public string  Email { get; set; }
        public string Message { get; set; }
        public int Service { get; set; }
        public SelectList Services { get; set; }
        
    }
}
