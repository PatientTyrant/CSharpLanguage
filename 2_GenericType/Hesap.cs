using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_GenericType
{
   public class Hesap
    {
        public object Sayi1 { get; set; }

        public object Sayi2 { get; set; }
        
        public object Toplam
        {
            get
            {
               
                return (double)Sayi1 + (double)Sayi2;
                
            }
        }
    }

    //c# dilinde <> operatörü generic operatörüdür..tipin generic olduğunu söyler.Eğer bu operatörü görüyorsanız alacağınız instance'da tip bbelirlemeniz gerekir.

    //Sınıf artık generic bir sınıf. Generic yapılarda üyelerde generic olabilir.Buda  sınıf üzerinde birden farklı tiplte çalışabileceğimizi söyler.

    public class Hesapla<Tip> 
    {
        // Generic tipli varlığımızın üyeleri generic olduğu için farklı tipleri üye olarak kullanabiliriz...
        public Tip Sayi1 { get; set; }
        public Tip Sayi2 { get; set; }  

       
    }

    // where ifadesi ile T'nin hangi türde olabileceğini belirtirsiniz. Bu Örnekte T'nin struct yapı olabileceğini belirttik bu yüzden string kullanılamaz ( class tır )
    public class Hesaplamali<T> where T : struct
    {
        public T Value { get; set; }    
    }
    //Birden fazla tipler belirleyerek te yapılabilir.
    public class Test <T, A, B, C>
    {

    }
}
