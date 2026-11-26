namespace GaraGaraMaxWin.Core.Interfaces;

/// <summary>
/// PEMILIK: Ridho | Bab 4 (Interface).
/// Kontrak untuk objek yang bisa dinilai dampaknya, mirip IPeriksaKadaluarsa di modul Bab 4.
/// </summary>
public interface IDapatDievaluasi
{
    // Penilaian singkat tentang dampak objek ini bagi keluarga.
    string Evaluasi();
}
