using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "mavi";
            //colors[1] = "sarı";
            //colors[2] = "yeşil";
            //colors[3] = "kırmızı";

            //Console.WriteLine(colors[0]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[3]);

            //int[] numbers = new int[7];
            //numbers[0] = 50;
            //numbers[1] = 24;
            //numbers[2] = 14;
            //numbers[3] = 6;
            //numbers[4] = 98;
            //numbers[5] = 100;

            //Console.WriteLine(numbers[6]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara" };

            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki Tüm Elemanları Listemele

            //string[] colors = { "Sarı", "Lacivert", "Kırmızı", "Mavi", "Yeşil" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string[] colorss = { "Sarı", "Lacivert", "Kırmızı", "Mavi", "Yeşil" };
            //for (int i = 0; i < colorss.Length; i++)
            //{
            //    Console.WriteLine(colorss[i]);
            //}

            //int[] numbers = { 4, 85, 54, 876, 34, 87, 9, 5, 845, 098 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]); 
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd', 'e' , '-'};
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myarray = { 432, 543, 32, 654, 76, 23, 6432, 76 };
            //int max = myarray[0];
            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    if (myarray[i] > max)
            //    {
            //        max = myarray[i];
            //    }
            //}
            //Console.WriteLine(max);

            #endregion

            #region Dizi Metotları

            //string[] persons = { "Ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 2, 54, 8734, 98, 45, 18, 43, 218, };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 2, 54, 8734, 98, 45, 18, 43, 218 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "ali", "buse", "ayşe", "mehmet", "can", "çınar" };
            //int index = Array.IndexOf(customers, "can");
            //Console.WriteLine(index);

            //int[] number = { 21, 43, 786, 32, 98, 23, 85, 32, 978, 1 };
            //Console.WriteLine("Dizinin en büyüğü : " + number.Max() + " Dizini en küçüğü : " + number.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] number = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum += number[i];
            //}
            //Console.WriteLine(sum);

            //int[] number = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift sayılar");

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 2 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Tek sayılar");
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 2 == 1)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}
            #endregion

            Console.Read();
        }
    }
}
