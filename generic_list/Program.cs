using System.Collections.Generic;

namespace generic_list
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            // List<T> sınıfı
            // System.Collections.Generic
            // T -> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count (Eleman Sayısı)
            Console.WriteLine(renkListesi.Count); // Renk listesinin eleman sayısını yazdırır
            Console.WriteLine(sayiListesi.Count); // Sayı listesinin eleman sayısını yazdırır
            Console.WriteLine();
            // Listelerde Elemanlara Erişim
            Console.WriteLine(sayiListesi[0]); // Sayı listesinin 0. indeksindeki elemanı (23) yazdırır
            Console.WriteLine(renkListesi[2]); // Renk listesinin 2. indeksindeki elemanı ("Turuncu") yazdırır
            Console.WriteLine();
            // Listelerde Elemanlarla Döngü
            Console.WriteLine("Sayı Listesi Elemanları:");
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\nRenk Listesi Elemanları:");
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            // Listeden Eleman Çıkarma
            sayiListesi.Remove(4); // 4 değerini listeden kaldırır
            renkListesi.RemoveAt(3); // 3. indeksteki elemanı ("Sarı") listeden kaldırır

            Console.WriteLine("\nEleman Çıkarıldıktan Sonra Sayı Listesi:");
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));

            Console.WriteLine("\nEleman Çıkarıldıktan Sonra Renk Listesi:");
            renkListesi.ForEach(renk=> Console.WriteLine(renk));
            
            Console.WriteLine();
            
            //Liste içerisinde arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 Liste içerisinde bulundu");
                else
                Console.WriteLine("sayi bulunamadı");

            //Eleman ile index 'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Yeşil"));
            Console.WriteLine();

            //Diziyi liste çevirme 
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);
            hayvanListesi.ForEach(hayvan=> Console.WriteLine(hayvan));
            Console.WriteLine();
            // Listeyi Temizleme
            hayvanListesi.Clear();
            Console.WriteLine("Hayvan Listesi: " + hayvanListesi.Count);
            
            Console.WriteLine();
            
            //List içerisinde nesne tutmak
            List<Kullacınılar> kullacınıListesi = new List<Kullacınılar>();
            Kullacınılar kullanıcı1 = new Kullacınılar();
            Kullacınılar kullanıcı2 = new Kullacınılar();
            Kullacınılar kullanıcı3 = new Kullacınılar();

            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılar";
            kullanıcı1.Yas = 22;

            kullanıcı2.Isim = "Kerim";
            kullanıcı2.Soyisim = "Kermes";
            kullanıcı2.Yas = 52;

            kullanıcı3.Isim = "Nadya";
            kullanıcı3.Soyisim = "Erlion";
            kullanıcı3.Yas = 19;

            kullacınıListesi.Add(kullanıcı1);
            kullacınıListesi.Add(kullanıcı2);
            kullacınıListesi.Add(kullanıcı3);

            List<Kullacınılar> yeniListe= new List<Kullacınılar>();
            yeniListe.Add(new Kullacınılar(){
                Isim="Ahsen",
                Soyisim="Nur",
                Yas=2
                
            });
            yeniListe.Add(new Kullacınılar(){
                Isim="Kadir",
                Soyisim="Tezel",
                Yas=24
            });

            foreach(var item in kullacınıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+ item.Isim);
                Console.WriteLine("Kullanıcı Soyadı: "+ item.Soyisim);
                Console.WriteLine("Kullanıcı Yası: "+ item.Yas);
                Console.WriteLine();
            }

            foreach(var item in yeniListe)
            {
                Console.WriteLine("Kullanıcı Adı: "+ item.Isim);
                Console.WriteLine("Kullanıcı Soyadı: "+ item.Soyisim);
                Console.WriteLine("Kullanıcı Yas: "+ item.Yas);
            }

            yeniListe.Clear();
            
        }
    }
    public class Kullacınılar{
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
