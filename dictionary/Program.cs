using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10,"Butik Ali");
            kullanıcılar.Add(12,"Ahmet Özdemir");
            kullanıcılar.Add(18,"Rukiye Özdemir");
            kullanıcılar.Add(20,"Fehmi Özdemir");

            //Dizinin elemanlarına erişim
            Console.WriteLine("*****ELEMANLARA ERİŞİM*****");    
            Console.WriteLine(kullanıcılar[12]);
            Console.WriteLine();
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            //count
            Console.WriteLine("*****Count******");
            Console.WriteLine(kullanıcılar.Count);
            //contains
            Console.WriteLine("*****Contains******");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("kdrlllll"));

            //remove 
            Console.WriteLine("*******Remove********");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******Keys********");
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("*******Values********");
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
