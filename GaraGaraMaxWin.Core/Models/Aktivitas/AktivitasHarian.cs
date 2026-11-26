namespace GaraGaraMaxWin.Core.Models.Aktivitas;

/// <summary>
/// PEMILIK: Ridho | Bab 4 (Abstract Class).
/// Kerangka semua aktivitas harian Pak Hendra. Perilaku dasar (Nama, CetakInfo) sama untuk semua,
/// sedangkan efeknya beda-beda, jadi JalankanEfek dibuat abstract dan wajib di-override class turunan.
/// Abstract class tidak bisa diinstansiasi langsung (new AktivitasHarian(...) menyebabkan error compile).
/// Zian memakai class ini di List&lt;AktivitasHarian&gt; (Bab 5), koordinasikan sebelum mengubah tanda tangan method.
/// </summary>
public abstract class AktivitasHarian
{
    public string Nama { get; set; }

    protected AktivitasHarian(string nama)
    {
        Nama = nama;
    }

    // Method biasa: sama untuk semua aktivitas, tidak perlu ditulis ulang di class turunan.
    public void CetakInfo()
    {
        Console.WriteLine($"Aktivitas: {Nama}");
    }

    // Method abstract: tidak punya isi di sini, tiap aktivitas wajib menulis efeknya sendiri.
    public abstract void JalankanEfek(StatusKeluarga status, DompetKeluarga dompet);
}
