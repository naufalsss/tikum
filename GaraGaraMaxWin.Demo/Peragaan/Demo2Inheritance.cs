using GaraGaraMaxWin.Core.Models;
using GaraGaraMaxWin.Core.Models.Karakters;

namespace GaraGaraMaxWin.Demo.Peragaan;

/// <summary>PEMILIK: Naufal | Peragaan Bab 3: inheritance, virtual/override, polimorfisme.</summary>
public static class Demo2Inheritance
{
    public static void Jalankan()
    {
        Console.WriteLine();
        Console.WriteLine("=== Demo 2: Inheritance (Naufal) ===");

        // Bab 3: array bertipe induk (Karakter[]) berisi objek turunan dan satu objek Karakter biasa.
        Karakter[] semua =
        {
            new PakHendra(),
            new BuRahma(),
            new Fajar(),
            new Karakter("NPC01", "Tetangga", "Warga", 50)
        };

        // Polimorfisme: satu loop, tapi tiap objek menjalankan versi override miliknya sendiri.
        Console.WriteLine("\n-- Loop Karakter[] (polimorfisme) --");
        foreach (Karakter k in semua)
        {
            k.TampilkanInfo();
            Console.WriteLine($"  {k.Nama}: \"{k.Bicara()}\"");
        }

        // Tipe asli objek tetap terjaga walau variabelnya bertipe Karakter.
        Console.WriteLine("\n-- Tipe asli tiap objek --");
        foreach (Karakter k in semua)
        {
            string aset = k switch
            {
                PakHendra p => p.KodeAsetGlb,
                BuRahma b => b.KodeAsetGlb,
                Fajar f => f.KodeAsetGlb,
                _ => "(tidak ada aset 3D)"
            };
            Console.WriteLine($"{k.Nama} bertipe {k.GetType().Name}, aset 3D: {aset}");
        }

        // Constructor overloading pada class turunan.
        Console.WriteLine("\n-- Constructor PakHendra(int utangAwal) --");
        Karakter hendraBangkrut = new PakHendra(50_000_000);
        hendraBangkrut.TampilkanInfo();
    }
}
