using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{ 
    public class User:IEntity
    {
        public int UserId { get; set; }
        public string UserMail { get; set; }
        public string UserName { get; set; }
        public bool Status { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
