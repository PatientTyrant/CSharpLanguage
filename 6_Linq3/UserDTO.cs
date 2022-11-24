using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Linq3
{
    // Users listesinden userName ve Email alanlarını tutacak bir class tanımlıyoruz
    // DTO ( Data Transfer Object )
    public class UserDTO 
    {
        public string KAdi { get; set; }

        public string Mail { get; set; }
    }
}
