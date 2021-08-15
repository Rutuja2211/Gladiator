using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationExampleProject.Models
{
    [MetadataType(typeof(UserValidationMetadata))]
    public partial class user
    {

    }

    public class UserValidationMetadata
    {
        [Required(ErrorMessage = "Username cannot be empty")]
        public string username { get; set; }
        [Required(ErrorMessage = "Password cannot be empty")]
        [MinLength(4,ErrorMessage ="Minimum 4 chars should be present")]
        [RegularExpression("[0-9]{4,}", ErrorMessage = "Didn't match pattern")]
        public string password { get; set; }
        public string role { get; set; }
        public string isActive { get; set; }
    }
}