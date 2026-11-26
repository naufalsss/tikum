namespace GaraGaraMaxWin.Core.Interfaces;

/// <summary>
/// PEMILIK: Ridho | Bab 4 (Interface).
/// Kontrak untuk siapa atau apa pun yang menghasilkan uang untuk keluarga.
/// Dipakai oleh dua class yang tidak sepohon: BuRahma (turunan Karakter) dan AktivitasBekerja (turunan AktivitasHarian).
/// </summary>
public interface IPemberiNafkah
{
    // Jumlah uang (rupiah) yang dihasilkan untuk keluarga.
    int HitungNafkah();
}
