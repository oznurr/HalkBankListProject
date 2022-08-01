using HalkBank.Collections;
using HalkBank.Collections.Generics;
using System.Collections;

namespace ArraylistDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayListDemo();

            HalkBankList.MaxElemanSayisi = 50;

            var liste = new HalkBankList(30);
            //liste.MaxElemanSayisi = 10;

            liste.Ekle("Salih");
            liste.Ekle(100);
            liste.Ekle(false);
            liste.Ekle("Ahmet");
            liste.Ekle("Mustafa");
            liste.Ekle("Mustafa 2");

            //liste.Count = 50;

            Console.WriteLine("Eleman Sayısı: {0}", liste.ElemanSayisi);

            liste[1] = "Mehmet";

            Console.WriteLine("İlk Eleman: {0}", liste[0]);

            liste.Sil(2);

            //for (int i = 0; i < liste.ElemanSayisi; i++)
            //{
            //    Console.WriteLine(liste[i]);
            //}

            foreach (var eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            liste.Temizle();

            var sayilar = new HalkBankList();
            //sayilar.MaxElemanSayisi = 10;

            Console.WriteLine("Eleman Sayısı: {0}", liste.ElemanSayisi);

            Console.WriteLine("*****************");
            HalkBankList<string> isimler = new HalkBankList<string>();
            isimler.Ekle("Salih");
            isimler.Ekle("Ahmet");
            isimler.Ekle("Mustafa");
            isimler.Ekle("Mustafa 2");

            string ilkIsim = isimler[0];
            Console.WriteLine("*****************OZNUR********Tersine Çevirme******");
            TersineCevrilecekListe(liste);
            Console.WriteLine("*****************OZNUR******Sondan Arama İle Index Alma******");
            SondanIndexBul(liste);

            Console.WriteLine("*****************OZNUR*****Index Bulma******");
            IndexBul(liste);
            Console.WriteLine("*****************OZNUR*****Koşullu  Silme******");

            var sehirler = new HalkBankList(12);
            sehirler.Ekle("Ankara");
            sehirler.Ekle("İstanbul");
            sehirler.Ekle("İzmir");
            sehirler.Ekle("İzmit");
            sehirler.Ekle("Van");
            sehirler.Ekle("Çorum");
            Console.WriteLine("Şehirler Listesi");
            foreach (var sehir in sehirler)
            {
                Console.WriteLine( sehir);
            }
           
           

            HalkBankList sehirlerDizi = sehirler.KosulluSil(sehirler, sehirler => sehirler.Length == 5);
            Console.WriteLine("5 harfli Olan  Silinen Şehirler");
            foreach (var sehirDizi in sehirlerDizi)
            {
                Console.WriteLine(sehirDizi);
            }



        }

        private static void IndexBul(HalkBankList liste)
        {
            liste.Ekle("Salih");
            liste.Ekle("Hakan");
            liste.Ekle("Hakkı");
            liste.Ekle("Ebru");
            liste.Ekle("Ipek");
            liste.Ekle("Poyraz");
            Console.WriteLine("IndexBul={0}", liste.IndexBul("Poyraz"));
        }

        private static void SondanIndexBul(HalkBankList liste)
        {
            liste.Ekle("Salih");
            liste.Ekle("Hakan");
            liste.Ekle("Hakkı");
            liste.Ekle("Ebru");
            liste.Ekle("Ipek");
            liste.Ekle("Poyraz");
            Console.WriteLine("Sondan Numaralandırmaaa={0}", liste.SondanIndexleme("Hakkı"));
        }

        private static void TersineCevrilecekListe(HalkBankList liste)
        {
            liste.Ekle("Oznur");
            liste.Ekle(100);
            liste.Ekle(false);
            liste.Ekle("OZge");
            liste.Ekle("Ozlem");
            liste.Ekle("Ercan");

            Console.WriteLine("Tersine Çevrilecek Liste", liste);
            foreach (var list in liste)
            {
                Console.WriteLine(list);
            }
            Console.WriteLine("Tersine Çevrilmiş Liste");
            liste.TersineCevir();
            foreach (var eleman in liste)
            {
                Console.WriteLine(eleman);
            }
        }

        



        private static void ArrayListDemo()
        {
            ArrayList liste = new ArrayList();
            liste.Add("Salih");
            liste.Add("Hakan");
            liste.Add("Hakkı");
            liste.Add("Ebru");
            liste.Add("Ipek");
            liste.Add("Poyraz");

            //liste.Count = 50;

            Console.WriteLine("Eleman Sayısı: {0}", liste.Count);

            liste[1] = "Mehmet";

            Console.WriteLine("İlk Eleman: {0}", liste[0]);

           
            Console.WriteLine("listtttt={0}", liste.LastIndexOf("Hakkı"));
            Console.WriteLine("listtttt={0}", liste.LastIndexOf("Hakkı",1));

            
            liste.RemoveAt(2);
            liste.Clear();
        }
    }
}