using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
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

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye Deper DÖndürmeyen String Parametreli Metotlar

            //void WriterMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriterMethod("Ahmet");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //CustomerCard("Ahmet", "Koçyiğit");
            //CustomerCard("Ecehan", "Saruhan");

            #endregion

            #region Geriye Deper DÖndürmeyen Int Parametreli Metotlar

            //void Sum(int n1, int n2, int n3)
            //{
            //    int result = n1 + n2 + n3;
            //    Console.WriteLine(result);
            //}
            //Sum(10, 32, 75);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region  Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Byarak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Gİriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int n1, int n2)
            //{
            //    int result = n1 + n2;
            //    return result;
            //}

            //Console.WriteLine(Sum(32,654));
            //Console.WriteLine(Sum(654,1312));
            //Console.WriteLine(Sum(162,867));
            //Console.WriteLine(Sum(472,064));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int e1, int e2, int e3)
            {
                int result = (e1 + e2 + e3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti" + " ortalama" + result;
                }
                else
                {
                    return student + " isimli öğrenci Başarısız" + " ortalama" + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 43, 87, 92));
            Console.WriteLine(ExamResult("Veli", 13, 27, 32));

            #endregion

            Console.Read();
        }
    }
}
