namespace _5_ExtensionsMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extension Methods");

            int a = Convert.ToInt32("55");
            string temo = a.ToString(); 

            string b = "345";

            int c = Convert.ToInt32(b);

          
            int x = DonusumIslemi.InteDonustur(b);
            int y = DonusumIslemi.InteDonustur(temo);

            // stringe uzantı yaptığımız metotları çağırdık...
            int v = b.ToInt();
            int n= temo.ToInt();
        }
    }
}