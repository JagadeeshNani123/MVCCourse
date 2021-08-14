using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_Course.Models
{
    public class WebinarInvites
    {
        [Required(ErrorMessage="Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter valid Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        
        public bool? WillJoin { get; set; }
    }
}
