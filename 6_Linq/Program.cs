namespace _6_Linq
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("LINQ");

            /* 
             Language Integrated Query => Veriler üzerinden query yapısına benzer sorgulamalar için kullanılır..

            LINQ 3 Ana grupta incelenir 
            => LINQ TO OBJECT
            => LINQ TO XML
            => LINQ TO SQL

             */
            // Nums dizisindeki değerleri ints dizisine aktarıyoruz.
            List<int> nums = new List<int> { 1, 2, 3,4,5,6,7,8,9 };

            List<int> ints = new List<int>  ();

            
            foreach ( int item in ints)
                Console.WriteLine(item);

            // select * from koleksiyon ( koleksiyondan bütün alanları seç(SQL de))
            //nums dizisindeki değerleri arr dizisine aktarıyoruz
            IEnumerable<int> arr = (from n in nums where n<5 select n); // Kayıt çekeceğimiz veya göstereceğimizde ADD komutu vs. olmadığı için IEnumerable kullanılır.
            // Datayı aldıktaktan sonra üzerinde işlem yapılacaksa List<> kullanılmalı.
            EkrandaYzdir(arr.ToList());

            List<int> arr1 = (from sayi in nums select sayi).ToList();
            EkrandaYzdir(arr1);

            // ints'in kayıtları olduğu için kayıtlarını geçiyoruz.
           
        }

        static  void EkrandaYzdir(List<int> param)
        {
            foreach (var item in param)
                Console.WriteLine(item);

        }
    }
}