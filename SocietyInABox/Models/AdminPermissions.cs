using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocietyInABox.Models
{
    public class AdminPermissions
    {
        public short Id { get; set; }
        public string PermissionsName { get; set; }

        public bool EditPermission { get; set; }
        public bool RemovePermission { get; set; }
        public bool PostPermission { get; set; }

    }
}