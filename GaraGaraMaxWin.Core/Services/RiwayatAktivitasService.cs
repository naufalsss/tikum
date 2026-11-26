using GaraGaraMaxWin.Core.Models.Aktivitas;

namespace GaraGaraMaxWin.Core.Services;

/// <summary>
/// PEMILIK: Zian | Bab 5 (List&lt;T&gt;, .Find() dengan lambda).
/// Mencatat riwayat aktivitas harian yang dipilih pemain.
/// </summary>
public class RiwayatAktivitasService
{
    // Bab 5: List<T> menyimpan banyak objek bertipe sama dan jumlahnya dinamis.
    private readonly List<AktivitasHarian> _riwayat = new();

    // Hanya bisa dibaca dari luar, perubahan harus lewat method service ini.
    public IReadOnlyList<AktivitasHarian> Semua => _riwayat;

    public int Jumlah => _riwayat.Count;

    public void Tambah(AktivitasHarian aktivitas)
    {
        ArgumentNullException.ThrowIfNull(aktivitas);
        _riwayat.Add(aktivitas);
    }

    // Bab 5: .Find() dengan lambda expression. Hasilnya null kalau tidak ada yang cocok.
    public AktivitasHarian? CariBerdasarkanNama(string nama)
    {
        return _riwayat.Find(a => a.Nama == nama);
    }

    // Menghitung berapa kali sebuah aktivitas dipilih pemain.
    public int HitungBerdasarkanNama(string nama)
    {
        return _riwayat.FindAll(a => a.Nama == nama).Count;
    }
}
