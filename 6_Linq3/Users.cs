using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Linq3
{
   public class Users
    {
        public string UserName { get; set; }

        public Gender Gender { get; set; }

        public string Email { 
            
            get
            {
                return $"{UserName}@btakademi.com";
            }
                
                }
      
    }
}
