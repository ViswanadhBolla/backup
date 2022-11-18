using System;
using System.Collections.Generic;

namespace EntityFrameWorkeg.Models
{
    public partial class UserInfo
    {
        public string Username { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Userpassword { get; set; } = null!;
    }
}
