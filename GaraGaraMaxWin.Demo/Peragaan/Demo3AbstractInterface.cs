using System.Globalization;
using GaraGaraMaxWin.Core.Interfaces;
using GaraGaraMaxWin.Core.Models;
using GaraGaraMaxWin.Core.Models.Aktivitas;
using GaraGaraMaxWin.Core.Models.Karakters;

namespace GaraGaraMaxWin.Demo.Peragaan;

/// <summary>PEMILIK: Ridho | Peragaan Bab 4: abstract class dan interface.</summary>
public static class Demo3AbstractInterface
{
    private static string Rp(int jumlah) =>
        "Rp " + jumlah.ToString("N0", new CultureInfo("id-ID"));

    public static void Jalankan()
    {
        Console.WriteLine();
        Console.WriteLine("=== Demo 3: Abstract dan Interface (Ridho) ===");

        // Abstract class tidak bisa diinstansiasi. Baris di bawah akan error compile (CS0144) kalau dibuka:
        // AktivitasHarian salah = new AktivitasHarian("Tidak bisa");
        Console.WriteLine("\n-- Abstract class --");
        Console.WriteLine("AktivitasHarian bersifat abstract, hanya class turunannya yang bisa dibuat.");

        var memancing = new AktivitasMemancing();
        var merokok = new AktivitasMerokok();
        var judol = new AktivitasJudol();
        var bekerja = new AktivitasBekerja();

        // Semua disimpan sebagai tipe induk, JalankanEfek() memanggil versi override masing-masing.
        AktivitasHarian[] jadwal = { memancing, merokok, judol, judol, bekerja };
        AktivitasHarian[] semua = { memancing, merokok, judol, bekerja };

        DompetKeluarga dompet = new DompetKeluarga(1_000_000);
        StatusKeluarga status = new StatusKeluarga();
        Console.WriteLine($"\nKondisi awal: saldo {Rp(dompet.Saldo)} | stres {status.TingkatStres} | kepercayaan {status.KepercayaanIstri}");

        Console.WriteLine("\n-- Menjalankan jadwal aktivitas (abstract JalankanEfek) --");
        foreach (AktivitasHarian a in jadwal)
        {
            a.CetakInfo();
            a.JalankanEfek(status, dompet);
            Console.WriteLine($"  -> saldo {Rp(dompet.Saldo)} | stres {status.TingkatStres} | kepercayaan {status.KepercayaanIstri} | {status.Ringkasan}");
        }

        // Interface: kontrak perilaku. Dicek lewat 'is', dipanggil lewat tipe interface.
        Console.WriteLine("\n-- Interface IMemicuKonflik --");
        foreach (AktivitasHarian a in semua)
        {
            if (a is IMemicuKonflik pemicu)
            {
                Console.WriteLine($"{a.Nama}: dampak konflik {pemicu.HitungDampakKonflik()} ({pemicu.AlasanKonflik})");
            }
        }

        // IPemberiNafkah dipakai dua class yang tidak sepohon: AktivitasBekerja dan BuRahma.
        Console.WriteLine("\n-- Interface IPemberiNafkah (lintas class) --");
        IPemberiNafkah[] pencariNafkah = { new AktivitasBekerja(), new BuRahma() };
        foreach (IPemberiNafkah p in pencariNafkah)
        {
            Console.WriteLine($"{p.GetType().Name}: {Rp(p.HitungNafkah())}");
        }

        Console.WriteLine("\n-- Interface IDapatDievaluasi --");
        foreach (AktivitasHarian a in semua)
        {
            if (a is IDapatDievaluasi penilai)
            {
                Console.WriteLine($"{a.Nama}: {penilai.Evaluasi()}");
            }
        }
    }
}
