using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_StaticTypes
{
    //Sınıf üyelerine erişmek için instance alınır.Eğer instance alınmadan üyeye erişlimek isteniyorsa üye static tanımlanır.Static üyeler instance ile değil uygulama ile ayağa kalkar...
    public class Test
    {
        public int A {  get; set; }

        //Üye static olduğunda sınıf ismi üzerinden erişikir o üye için atanan değer sabittir.

        // Sabit üyeler tutmak için tanımlanır. Nesne bazlı özel değerden ziyade genel değer tutmak için kullanılır.Adresi sürekli değişmeyeceği için performanslı çalışırlar...
        public static string B { get; set; }

        string name;
        static string surname;

        public static void Demo()
        {
            // static üyelerde non-static üyelere erişilemez...

            //name non static olduğu için buradan erişilemez...
            surname = "Deneme Deneme";
        }
    }

    // static classlar vardır. Sadece static üye tanımlamak iiçin kullanılır.
    // new ifadesiyle instance alınmaz. İnstance alınmayacağı için de o alanın tanımlanmasına gerek yoktur.
    public static class Demo
    {
        //static sınıflara constructor static olarak tanımlanır...
        static Demo()
        {

        }
        public static string Test { get; set; } 
    }



}
