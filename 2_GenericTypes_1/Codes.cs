using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _2_GenericTypes_1
{
    // Single Responsibility Prensibi = Tel sorumluluk prensibi => Varlıkların tek bir sorumluluğu olmalıdır. Yani varlıklara tek sorumluluk yüklenmeilidir...
    public
        class Categories
    {
        public string Name { get; set; }
    }

    public class Products
    {
        public string Name { get; set; }

        public string Price { get; set; }

    }

    public interface IOperation<T>
    {
        T[] List();
    }

    public class CategoriesOperation : IOperation<Categories>
    {
      public Categories[] List()
        {
            return new Categories[30]; // 30 Adet kategori dönüyoruz.

        }
    }

    public class ProductOperation : IOperation<Products>
    {
        public Products[] List()
        {
            return new Products[10]; // 10 Adet product dönüyoruz...

        }
    }
}
