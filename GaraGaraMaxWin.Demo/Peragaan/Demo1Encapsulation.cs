using System.Globalization;
using GaraGaraMaxWin.Core.Models;

namespace GaraGaraMaxWin.Demo.Peragaan;

/// <summary>PEMILIK: Aris | Peragaan Bab 1 dan 2: variable, get/set, method.</summary>
public static class Demo1Encapsulation
{
    private static string Rp(int jumlah) =>
        "Rp " + jumlah.ToString("N0", new CultureInfo("id-ID"));

    public static void Jalankan()
    {
        Console.WriteLine("=== Demo 1: Variable, Get/Set, Method (Aris) ===");

        // Bab 1: deklarasi, instansiasi, constructor overloading, method TampilkanInfo().
        Console.WriteLine("\n-- Bab 1: Class, Object, Constructor, Method --");
        Karakter hendra = new Karakter("HND", "Pak Hendra", "Ayah", 45);
        Karakter kosong = new Karakter();
        hendra.TampilkanInfo();
        kosong.TampilkanInfo();

        // Bab 2: property dengan validasi pada Karakter.
        hendra.Umur = -5;
        Console.WriteLine($"Set Umur = -5, hasilnya tetap: {hendra.Umur}");

        // Bab 2: private field + property Saldo, ditambah method Tambah dan Kurangi.
        Console.WriteLine("\n-- Bab 2: DompetKeluarga --");
        DompetKeluarga dompet = new DompetKeluarga(500_000);
        Console.WriteLine($"Saldo awal: {Rp(dompet.Saldo)}");

        dompet.Saldo = -100_000;
        Console.WriteLine($"Set Saldo = -100.000, hasilnya tetap: {Rp(dompet.Saldo)}");

        dompet.Tambah(1_000_000);
        Console.WriteLine($"Setelah kiriman Bu Rahma +1.000.000: {Rp(dompet.Saldo)}");

        dompet.Kurangi(2_000_000);
        Console.WriteLine($"Kurangi 2.000.000 (tidak cukup), saldo tetap: {Rp(dompet.Saldo)}");

        dompet.Kurangi(300_000);
        Console.WriteLine($"Kurangi 300.000 (bermain judol): {Rp(dompet.Saldo)}");
        Console.WriteLine($"Masih ada uang? {dompet.AdaUang}");

        // Bab 2: manual get/set, auto-property, dan expression-bodied property pada StatusKeluarga.
        Console.WriteLine("\n-- Bab 2: StatusKeluarga --");
        StatusKeluarga status = new StatusKeluarga();
        Console.WriteLine($"Awal: stres {status.TingkatStres}, kepercayaan istri {status.KepercayaanIstri} -> {status.Ringkasan}");

        status.TingkatStres = 150;
        Console.WriteLine($"Set TingkatStres = 150, dipotong jadi: {status.TingkatStres} -> {status.Ringkasan}");

        status.KepercayaanIstri = 10;
        status.CatatanHari = "Kalah judol lagi";
        Console.WriteLine($"KepercayaanIstri = 10 -> {status.Ringkasan} (catatan: {status.CatatanHari})");
    }
}
