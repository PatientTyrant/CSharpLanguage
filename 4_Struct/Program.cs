namespace _4_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct");
            Urun u=new Urun();
            Console.WriteLine(u.Adi);

                Urun u1=new Urun("Televizyon",800);
            Console.WriteLine(u1.Adi);

            Urun urn;
            urn.Adi = "Tel";
            Console.WriteLine(urn.Adi);
            // Value Type => Değer Tiplwe

            Categories c = new Categories("İçecek", "İçecek Ürünleri");

            Console.WriteLine(c.Name);

            // değer atanamaz çünkü readonly struct'dır.

            //Referance Type => Referans tutan tipler

            Urun u2 = new Urun();
            u2.Adi = "Elma";

            Urun u3 = u2;
            u3.Adi = "mUZ";

            Console.WriteLine(u2.Adi);
            Console.WriteLine(u3.Adi);

            Console.WriteLine("********************");

            Product p1 = new Product();
            p1.Name = "Armut";

            Product p2 = p1;
            p2.Name = "Ayva";

            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);
        }
    }
}