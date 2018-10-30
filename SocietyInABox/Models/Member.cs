using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace SocietyInABox.Models
{
    public class Member
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name =  "Date of birth")]
        public DateTime DateOfBirth { get; set; }

        public string MembershipType { get; set; }

    }
}