using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoButik2.Models
{
    public class CustomerModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int SocialSecurity { get; set; }
        public int Age { get; set; }
        public int ZipCode { get; set; }
        public string Adress { get; set; }

    }
}