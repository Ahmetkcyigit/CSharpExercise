using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //1. Değişken Türü
            //2. Değişken Adı
            //3. In
            //4. Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "budapeşte", "roma", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 432, 65, 321, 987, 23, 87, 230, 56, 987 };

            //foreach (var x in numbers)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 432, 65, 321, 987, 23, 87, 230, 56, 987 };

            //foreach (var x in numbers)
            //{
            //    if (x % 2 == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}

            //int[] numbers = { 432, 65, 321, 987, 23, 87, 230, 56, 987 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> number = new List<int>()
            //{
            //    1,2,4,6,8,9
            //};

            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** Sınav Listesi ***** ");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("**********");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Öğrenci sınav girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double values = double.Parse(Console.ReadLine());
                    totalExamResult += values; //Notları toplama işlemi
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} Adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı. ");
                }
            }
            Console.Read();
            #endregion
        }
    }
}
