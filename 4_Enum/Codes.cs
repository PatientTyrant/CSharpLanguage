using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _4_Enum
{
    public enum Role 
    {
        Admin,
        Uye,
        Anonim
    }

    //Enumlarda sabitlerimiz otomatik numaralandırılır fakat istersek değiştirebiliriz.
    public enum Cinsiyet
    {
        Kadin=1,
        Erkek=3
    }
    public class Uye
    {
        public string? KullaniciAdi { get; set; }

        public string? Password { get; set; }

        //public string Rol { get; set; }
        public Role Rol { get; set; }
        
        public Cinsiyet Cinsiyet { get; set; }
    }


 
}
