using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ExtensionsMethod
{
    //c# dilinde sabit ön tanımlı tipler'de değişiklik yapılamaz...(Örn int tipinin içerisinde custom metot yazılamaz)
    //ancak ön tanımlı tiplere ek metotlar yazılabilir...Yani ilgili tipler genişletilebilir.
   public class DonusumIslemi
    {
        public static int InteDonustur(string deger)
        {
            return Convert.ToInt32(deger);
        }
    }

    public static class ConvertOperation
    {
        // this => Bulunulan instance üzerinden alınacak parametreyi ifade eder.

        public static int ToInt(this string deger)
        {
            return Convert.ToInt32(deger);
        }
    }
}
