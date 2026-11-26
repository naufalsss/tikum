namespace GaraGaraMaxWin.Core.Interfaces;

/// <summary>
/// PEMILIK: Ridho | Bab 4 (Interface).
/// Kontrak untuk apa pun yang bisa memicu konflik keluarga (judol, merokok).
/// Interface hanya mendeklarasikan anggota, tanpa implementasi.
/// </summary>
public interface IMemicuKonflik
{
    // Alasan konflik, ditampilkan kepada pemain.
    string AlasanKonflik { get; }

    // Besarnya dampak konflik, skala 0 sampai 100.
    int HitungDampakKonflik();
}
