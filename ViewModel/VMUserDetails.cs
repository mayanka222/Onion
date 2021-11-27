using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel
{
   public class VMUserDetails
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string message { get; set; }
        public bool Status { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
