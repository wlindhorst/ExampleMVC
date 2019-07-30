using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleMVC.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Success { get; set; }
        public string MailingList { get; set; }

    }
}