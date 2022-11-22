using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Struct
{
   
struct Urun 
    {
        //structlarda default constructor tanımlanamaz ama parametre alan constructor tanımlanabilir.
        // Eğer bir constructor tanımlanıyorsa üyelerin varsayılan değerleri ctor'da atanmalıdır.
        public Urun(string a, decimal f)
        {
            Adi = a;
            Fiyat = f;
        }

        public string Adi;

        public decimal Fiyat;
    }

    // Structlardan kalıtım yapılamaz...miras veremez,başka bir structan veya classtan miras alamaz... Ancak interfacelerden miras alabilir.

    readonly struct Categories
    {
        //public string test;
        //ctor tab tab yaparsanız constructor oluşturur.

        public Categories(string n, string d)
        {
            Name = n;
            Desc = d;
        }
        public string Name { get; }
        public string Desc { get; }
    }

    class Product
    {
        public Product ()
        {

        }
        public Product (string a )
        {

        }

        public string? Name;
        public decimal? Price;
    }

    interface ITEST { }

    struct Test : ITEST
    {

    }
}
