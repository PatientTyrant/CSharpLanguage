using System.Collections;

namespace _1_Collections_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Object => Sınıfı c# dilinde bütün tiplerin atasıdır...

            #region Boxing ve Unboxing İşlemi
            //Console.WriteLine("Collections");

            //int[] nums = {1, 2, 3 };   
            
            //Ogrenci ogr = new Ogrenci();
            //ogr.Adi = "İsmail";
            //ogr.SoyAdi = "KurtOğlu";

            //int a = 1000;
            //string tem = ogr.ToString();
            //string temp2 = a.ToString(); 

            ////boxing işlemi => Object'e dönüşümdür.
            //object obj=ogr;
            //object o = 1;
            //object isim = "bt";
            //object c = 'A';
            //object e = new string[4];
            //// Unboxing 

            //int i = (int)o;
            //Ogrenci ogr2 = (Ogrenci)obj;

            #endregion

            ArrayList list = new ArrayList();


            list.Add("İsmail");
            list.Add("Ekrem");
            list.Add("Umut");

            list[0] = "İsmail Kurtoğlu";
            string isim = (string) list[0];

            // Üyelerin keylerinin tarafımızdan verilmesi hashtable ile yapılır ve dizilerden farkı budur...Elelmanlara indexten değil keylerden erişilir.

            // Hastable => genelde keyler tarafımızdan verileceğinde kullanılır...
            // Key'lerin unique olmasına dikkat etmek gerekmektedir.

            Hashtable hashtable = new Hashtable();
            hashtable.Add("A", "İsmail");
            hashtable.Add("B", "Ekrem");
            hashtable.Add("C", "Umut");

            hashtable["A"] = "İsmail Kurtoğlu";

            string name = (string) hashtable["A"];
            //Console.WriteLine metodu ekranda gösterilen değişkenleri string'e dönüştürerek yazdırır.

            Hashtable odemeBilgisi = new Hashtable();
            hashtable.Add("KarNo", "12312312312");
            odemeBilgisi.Add("İsimSoyİsim", "bt akademi");
            odemeBilgisi.Add("SKT", "112027");
            odemeBilgisi.Add("CVV", "345");


        }
    }
}