using GaraGaraMaxWin.Core.Models.Aktivitas;

namespace GaraGaraMaxWin.Core.Services;

/// <summary>
/// PEMILIK: Zian | Bab 5 (List&lt;T&gt;, .Find() dengan lambda).
/// Mencatat riwayat aktivitas harian yang dipilih pemain.
/// </summary>
public class RiwayatAktivitasService
{
    private readonly List<AktivitasHarian> _riwayat = new();

    // TODO Zian (Bab 5): tambah method Tambah, Cari berdasarkan nama (pakai .Find()), HitungJumlah, dan sebagainya.
    public IReadOnlyList<AktivitasHarian> Semua => _riwayat;
}
