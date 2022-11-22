namespace _4_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Uye u = new Uye();
            u.KullaniciAdi = "btuser";
            u.Password = "123";
            u.Rol = Role.Uye;
            u.Cinsiyet = Cinsiyet.Kadin;
            // 0,1,2,3... Şeklinde numaralandırılır Enum içerisindekiler.


          
        }
    }
}