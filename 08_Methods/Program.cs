using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //Metotlar sonuna () alırlar ve solunda mor renk küp vardır
            //Geriye değer döndürmeyen metotlar
            //Customer - Listele, ekle, sil, güncelle
            //Void

            void CustomerList()
            {
                Console.WriteLine("Ali Yıldız");
                Console.WriteLine("Ayşe Yıldız");
                Console.WriteLine("Hakan Öztürk");
                Console.WriteLine("Merve Çınar");
            }

            CustomerList();

            #endregion
            Console.Read();
        }
    }
}
