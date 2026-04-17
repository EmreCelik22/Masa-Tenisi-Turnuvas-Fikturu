using System;
using System.Collections.Generic;

public class MasaTenisiTurnuvasi
{
    public static void Main()
    {
        List<string> yarismacilar = new List<string>() { "Hasan", "Elif", "Mahmut", "Ayşe", "Emre", "Yağmur", "Pelin", "Pınar" };

        // Oyuncu sayısı tek ise adil eşleşme için "Bay Geçti" durumu eklenir
        if (yarismacilar.Count % 2 != 0)
        {
            yarismacilar.Add("Bay (Dinleniyor)");
        }

        int toplamOyuncu = yarismacilar.Count;
        int toplamTur = toplamOyuncu - 1;
        int turBasinaMac = toplamOyuncu / 2;

        // Kaydırma işlemi için ilk oyuncu hariç diğerlerini ayrı bir listeye alıyoruz
        List<string> donenOyuncular = new List<string>(yarismacilar);
        donenOyuncular.RemoveAt(0);

        Console.WriteLine("=== 4. MASA TENİSİ TURNUVASI FİKSTÜRÜ ===\n");

        // Fikstürü oluştur (O(N) karmaşıklık)
        for (int tur = 1; tur <= toplamTur; tur++)
        {
            Console.WriteLine($"--- {tur}. TUR MAÇLARI ---");

            // Sabit kalan 1. oyuncunun maçı  sabiti 0 indeksi ile eşleştiriyoruz
            Console.WriteLine($"{yarismacilar[0]} VS {donenOyuncular[0]}");

            // Diğer eşleşmeler: Listenin başından ve sonundan karşılıklı eşleştir (O(N) karmaşıklık)
            for (int i = 1; i < turBasinaMac; i++)
            {
                int ilkOyuncuIndeksi = i;
                int ikinciOyuncuIndeksi = donenOyuncular.Count - i;
                // dönen oyunculardaki 1. indekisi sondaki oyuncuyla eşleştir

                Console.WriteLine($"{donenOyuncular[ilkOyuncuIndeksi]} VS {donenOyuncular[ikinciOyuncuIndeksi]}");
            }
            Console.WriteLine("-----------------------------------");

            // Dairesel Kaydırma Mantığı: Dönen listenin son elemanını alıp en başa ekliyoruz
            //son oyuncuyu listeden silip 0. indekse ekle
            string sonOyuncu = donenOyuncular[donenOyuncular.Count - 1];
            donenOyuncular.RemoveAt(donenOyuncular.Count - 1);
            donenOyuncular.Insert(0, sonOyuncu);
        }
    }
}