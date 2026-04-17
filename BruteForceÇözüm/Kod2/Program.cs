using System;
using System.Collections.Generic;

public class BruteForceTurnuva
{
    public static void Main()
    {
        List<string> yarismacilar = new List<string>() { "Mustafa", "Hasan", "Elif", "Mahmut", "Ayşe", "Emre", "Yağmur", "Pelin" };

        if (yarismacilar.Count % 2 != 0)
        {
            yarismacilar.Add("Bay (Dinleniyor)");
        }

        int n = yarismacilar.Count;
        int toplamTur = n - 1;

        bool[,] macYapildi = new bool[n, n];

        Console.WriteLine("=== BRUTE FORCE FİKSTÜR (O(N^3)) ===\n");

        for (int tur = 1; tur <= toplamTur; tur++)
        {
            Console.WriteLine($"--- {tur}. TUR MAÇLARI ---");

            bool[] buTurOynadi = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (buTurOynadi[i]) continue;

                for (int j = 0; j < n; j++)
                {
                    if (i != j && !buTurOynadi[j] && !macYapildi[i, j])
                    {
                        Console.WriteLine($"{yarismacilar[i]} VS {yarismacilar[j]}");

                        buTurOynadi[i] = true;
                        buTurOynadi[j] = true;

                        macYapildi[i, j] = true;
                        macYapildi[j, i] = true;

                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}