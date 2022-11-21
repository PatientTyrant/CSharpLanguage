﻿namespace _2_GenericType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic Type => bir işlemi birden fazla tip kullanılarak yapılabilmesini sağlar. Örnek arraylist'e eleman eklerken sadece object tipinde ekleyebiliriz. Eğer arraylist generic bir tip olsaydı object dışında diğer tipleride ekleyebilirdik. 

            // Generic tipler c# dilinde tip güvenliğini sağlamak için kullanılır.

            Hesap h = new Hesap();
                h.Sayi1 = 1.1;
            h.Sayi2 = 1.2;

            Hesap hh = new Hesap();
            hh.Sayi1 = "Bt";
            hh.Sayi2 = "Akademi";


            Console.WriteLine(h.Toplam);

            Hesapla<double> h1 = new Hesapla<double>();
            h1.Sayi1 = 1.1;
                h1.Sayi2 = 1.2;

            Hesapla<int> h2 = new Hesapla<int>();
            h2.Sayi1 = 1;
            h2.Sayi2 = 1;

            Hesapla<string> h3 = new Hesapla<string>();
            h3.Sayi1 = "Bt";
            h3.Sayi2 = "Akademi";

            Hesaplamali<int> hesaplamali = new Hesaplamali<int>();
            hesaplamali.Value = 4;
            Hesaplamali<bool> hesaplamali1 = new Hesaplamali<bool>();
            hesaplamali1.Value = false;
            Hesaplamali<float> hesaplamali2 = new Hesaplamali<float>();
            hesaplamali2.Value = 5.1f;
           // Hesaplamali<string> hesaplamali3 = new Hesaplamali<string>();
           // hesaplamali3.Value = "Deneme";






        }
    }
}