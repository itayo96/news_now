using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsNow.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public bool isWriter { get; set; }

        public int GetUserId()
        {
            return this.UserId;
        }
    }
}
