using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocietyInABox.Models;

namespace SocietyInABox.ViewModels
{
    public class RegisterAndMemberViewModel
    {
        public Member Member { get; set; }
        public RegisterViewModel Register { get; set; }
    }
}