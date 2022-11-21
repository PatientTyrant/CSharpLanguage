namespace _3_GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic Collection => Collections'a göre daha kullanışlı olan tip güvenliği sağlanan koleksiyon yapıdır...

            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");


            List<int> nums = new List<int>();
                nums.Add(1);
            nums.Add(2);
            nums.Add(3);

            List<bool> bools = new List<bool>();
            bools.Add(true);
            bools.Add(false);

            //bools.Add("aaaa"); // bools nesnesi bool tipinde olduğu için string değeri alamaz

            Dictionary<int, string> dicList = new Dictionary<int, string>();
            dicList.Add(0, "Umut");
            dicList.Add(1, "İsmail");
            dicList.Add(2, "Ekrem");

            string temp = dicList[1];
            dicList[1] = "İsmail Kurtoğlu";

            Dictionary<string, string> dicList2 = new Dictionary<string, string>();
            dicList2.Add("A", "Umut");
            dicList2.Add("B", "İsmail");
            dicList2.Add("C", "Ekrem");

            temp = dicList2["B"];
            dicList2["B"] = "İsmail Kurtuğlu";

            //KeyValuePair => Dictionary'nin elamınını temsil eder...
            foreach (KeyValuePair<string, string> item in dicList2)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

         
        }
    }
}