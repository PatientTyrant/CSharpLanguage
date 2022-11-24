using System.Net.Mail;

namespace _6_Linq3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Users> users = new List<Users>();
            users.Add(new Users() { UserName = "ayilmaz", Gender = Gender.E });
            users.Add(new Users() { UserName = "ikurtoglu", Gender = Gender.E });
            users.Add(new Users() { UserName = "aaydogdu", Gender = Gender.K });
            users.Add(new Users() { UserName = "mtugan", Gender = Gender.K });
            users.Add(new Users() { UserName = "gcalıskan", Gender = Gender.E });

            List<Users> utemp = new List<Users>();

            foreach (var item in users)
                if (item.Gender == Gender.K) ;

            //nesenelerde kriter belirleme...

            IEnumerable<Users> kusers = (from u in users
                                  where u.Gender == Gender.K
                                  select u).ToList();

            //select ifadesi
            //query'de select ile ne seçilirse sonuç kümesi o tipte olacaktır.
            //bütün userları seçme

            IEnumerable<Users> allusers = (from u in users
                                           select u); // Users listesi çıkar...

                List<Gender> genders = (from a in users
                                    select a.Gender).ToList();

            //Enum olarak alalım

            Gender x = genders[0];
            int gvalue = (int)genders[0];


            IEnumerable<string> usernames = (from a in users
                                            select a.UserName);


            List<int> li = new List<int>() { 4, 1, 8, 4 };
            var nums = (from l in li
                        select l); // int koleksiyonu döner...

            // select ile new ifadesini kullanarak tip belirleyebiliriz...New UserDTO ile kümeden çıkacak elemanların tipini UserDTO olarak belirliyoruz...

            // Eğer kümeden birden fazla alan çıkacaksa select new ifadesi kullanılmalıdır. Çünkü selectten sonra , ile alan ayırmak yerine new ifadesi'nin amacı aslında kümeden çıkacak verinin tipini belirlemektir. (Tip Güvenliği)

            IEnumerable<UserDTO> userDTOs = (from a in users
                                             select new UserDTO
                                             {
                                                 KAdi = a.UserName,
                                                 Mail = a.Email
                                             }); 
                                             

        }
       
       
    }
}