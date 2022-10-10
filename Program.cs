using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace c_sharp_list_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            // list oluşturma

            List<string> sehirler = new List<string>();

            // liste nesne ekleme

            sehirler.Add("istanbul");
            sehirler.Add("monaco");
            sehirler.Add("venedik");
            sehirler.Add("paris");
            sehirler.Add("izmir");
            sehirler.Add("ankara");

            foreach (string s in sehirler)
            {
                Console.WriteLine(s);
            }
            // nesne sayısını öğrenme
            Console.WriteLine(sehirler.Count);

            // listten nesne çıkarma ( removeAt & remove ) 

            sehirler.Remove("istanbul"); // istanbulu siler
            sehirler.RemoveAt(3); // izmiri siler

            sehirler.ForEach(s => Console.WriteLine(s));

            // liste içinde arama

            if(sehirler.Contains("ankara"))
            {
                Console.WriteLine("ankara bu listede var");
            }
            Console.ReadLine();

          









        }
    }
}
