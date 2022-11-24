namespace _6_Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");

            List<int> nums = new List<int> { 1,2,3,4,5,6,25,26,29,33,22,24,45};
            List<int> values = new List<int>();

            foreach (var item in nums)
                if (item < 3)
                    values.Add(item);


            List<int> ints = (from a in nums
                              where a <3
                              select a).ToList(); // Okunaklı olması için alt satıra geçilir...
            //intse tekrar değer atanır. 
       ints = ( from a in nums 
                where a>3 && a < 6
                select a).ToList();


            // elemanları sıralı alalım..Veriler OrderBy ile sıralanır.
            ints = ( from b in nums 
                     where b>20
                     orderby b
                     select b).ToList();

            foreach (var item in ints)

                    Console.WriteLine(item);

            ints = (from b in nums
                    where b < 20
                    orderby b descending
                    select b).ToList();

        }
    }
}