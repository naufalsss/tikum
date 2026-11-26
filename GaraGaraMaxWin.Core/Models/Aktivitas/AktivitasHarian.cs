using GaraGaraMaxWin.Core.Models;

namespace GaraGaraMaxWin.Core.Models.Aktivitas;

/// <summary>
/// PEMILIK: Ridho | Bab 4 (Abstract Class).
/// Kerangka semua aktivitas harian Pak Hendra. Perilaku dasar (Nama, CetakInfo) sama untuk semua,
/// efeknya beda-beda, jadi JalankanEfek dibuat abstract.
/// Zian memakai class ini di List&lt;AktivitasHarian&gt; (Bab 5), koordinasikan sebelum mengubah tanda tangan method.
/// </summary>
public abstract class AktivitasHarian
{
    public string Nama { get; set; }

    protected AktivitasHarian(string nama)
    {
        Nama = nama;
    }

    public void CetakInfo()
    {
        Console.WriteLine($"Aktivitas: {Nama}");
    }

    // TODO Ridho (Bab 4): tentukan parameter yang dibutuhkan efek (status keluarga, dompet, atau lainnya).
    public abstract void JalankanEfek(StatusKeluarga status, DompetKeluarga dompet);
}
