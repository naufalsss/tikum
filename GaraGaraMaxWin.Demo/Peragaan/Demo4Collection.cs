using System.Globalization;
using GaraGaraMaxWin.Core.Helpers;
using GaraGaraMaxWin.Core.Models;
using GaraGaraMaxWin.Core.Models.Aktivitas;
using GaraGaraMaxWin.Core.Models.Karakters;
using GaraGaraMaxWin.Core.Services;

namespace GaraGaraMaxWin.Demo.Peragaan;

/// <summary>PEMILIK: Zian | Peragaan Bab 5: List, Dictionary, Generic.</summary>
public static class Demo4Collection
{
    private static string Rp(int jumlah) =>
        "Rp " + jumlah.ToString("N0", new CultureInfo("id-ID"));

    public static void Jalankan()
    {
        Console.WriteLine();
        Console.WriteLine("=== Demo 4: Collection, Dictionary, Generic (Zian) ===");

        // Bab 5: List<T> lewat RiwayatAktivitasService.
        Console.WriteLine("\n-- List<T>: RiwayatAktivitasService --");
        var riwayat = new RiwayatAktivitasService();
        riwayat.Tambah(new AktivitasMemancing());
        riwayat.Tambah(new AktivitasMerokok());
        riwayat.Tambah(new AktivitasJudol());
        riwayat.Tambah(new AktivitasJudol());
        riwayat.Tambah(new AktivitasBekerja());
        Console.WriteLine($"Jumlah aktivitas tercatat: {riwayat.Jumlah}");

        AktivitasHarian? ketemu = riwayat.CariBerdasarkanNama("Merokok");
        Console.WriteLine($"Cari \"Merokok\": {(ketemu != null ? "ditemukan -> " + ketemu.Nama : "tidak ditemukan")}");

        AktivitasHarian? tidakAda = riwayat.CariBerdasarkanNama("Mabuk");
        Console.WriteLine($"Cari \"Mabuk\": {(tidakAda != null ? "ditemukan -> " + tidakAda.Nama : "tidak ditemukan")}");

        Console.WriteLine($"Berapa kali \"Bermain Judol\": {riwayat.HitungBerdasarkanNama("Bermain Judol")}");

        // Bab 5: Dictionary<K,V> lewat KatalogKarakterService.
        Console.WriteLine("\n-- Dictionary<K,V>: KatalogKarakterService --");
        var katalog = new KatalogKarakterService();
        Console.WriteLine($"Daftarkan HND: {katalog.Daftarkan(new PakHendra())}");
        Console.WriteLine($"Daftarkan RHM: {katalog.Daftarkan(new BuRahma())}");
        Console.WriteLine($"Daftarkan FJR: {katalog.Daftarkan(new Fajar())}");
        Console.WriteLine($"Daftarkan HND lagi: {katalog.Daftarkan(new PakHendra())}");
        Console.WriteLine($"Jumlah tokoh: {katalog.Jumlah}");

        Console.WriteLine("Ambil \"HND\":");
        katalog.Ambil("HND")?.TampilkanInfo();

        Karakter? hilang = katalog.Ambil("XXX");
        Console.WriteLine($"Ambil \"XXX\": {(hilang != null ? hilang.Nama : "tidak ditemukan")}");

        // Bab 5: method generic. Satu method CariData<T> dipakai untuk beberapa tipe berbeda.
        Console.WriteLine("\n-- Generic: CariData<T> --");
        var daftarAktivitas = new List<AktivitasHarian>(riwayat.Semua);
        var daftarTokoh = new List<Karakter> { new PakHendra(), new BuRahma(), new Fajar() };
        var daftarAngka = new List<int> { 3, 8, 15, 22 };

        AktivitasHarian? kerja = PencarianHelper.CariData(daftarAktivitas, a => a.Nama == "Bekerja");
        Console.WriteLine($"Aktivitas bernama \"Bekerja\": {kerja?.Nama}");

        Karakter? anak = PencarianHelper.CariData(daftarTokoh, k => k.Umur < 18);
        Console.WriteLine($"Tokoh di bawah 18 tahun: {anak?.Nama}");

        Karakter? kakek = PencarianHelper.CariData(daftarTokoh, k => k.Umur > 100);
        Console.WriteLine($"Tokoh di atas 100 tahun: {(kakek != null ? kakek.Nama : "tidak ditemukan")}");

        int besar = PencarianHelper.CariData(daftarAngka, n => n > 10);
        Console.WriteLine($"Angka pertama di atas 10: {besar}");

        Console.WriteLine($"AmbilPertama(angka): {PencarianHelper.AmbilPertama(daftarAngka)}");
        Console.WriteLine($"AmbilPertama(tokoh): {PencarianHelper.AmbilPertama(daftarTokoh)?.Nama}");

        // Bab 5: generic class. Kelas yang sama dipakai dengan tipe string dan int.
        Console.WriteLine("\n-- Generic class: LogGenerik<T> --");
        var logPilihan = new LogGenerik<string>();
        logPilihan.Catat("Hari 1: Memancing");
        logPilihan.Catat("Hari 2: Bekerja");
        Console.WriteLine($"Log pilihan (string), jumlah {logPilihan.Jumlah}, terakhir: {logPilihan.Terakhir()}");

        var logSaldo = new LogGenerik<int>();
        logSaldo.Catat(500_000);
        logSaldo.Catat(800_000);
        logSaldo.Catat(1_200_000);
        Console.WriteLine($"Log saldo (int), jumlah {logSaldo.Jumlah}, terakhir: {Rp(logSaldo.Terakhir())}");
    }
}
