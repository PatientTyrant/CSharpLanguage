namespace _2_GenericTypes_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HNullable ve Non-Nullable");

            // Reference Typelar nullable iken, Value Typelar Non-Nullable'dir...

            // null => bir değeri olmayan boş...
            string str = null;
            object o = null;
            Urun u = null;

            // Bullable Type => Value Type'ları null olabilir ekilde ayarlamaktır.

            // NOT : Value type'lar null olamazlar...
           
             Nullable<int> a = null;

            //Nullable yapmanın 2.yolu
            float? b = null;
            decimal? c = null;
           
          

            Urun urun= new Urun();
            urun.Stok = null;

        }
    }
}