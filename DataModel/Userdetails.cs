using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel
{
 public  class Userdetails
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
