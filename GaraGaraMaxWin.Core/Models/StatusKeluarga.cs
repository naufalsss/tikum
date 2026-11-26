namespace GaraGaraMaxWin.Core.Models;

/// <summary>
/// PEMILIK: Aris | Bab 2 (manual getter/setter + validasi, auto-property, read-only expression-bodied property).
/// Menyimpan kondisi keluarga yang berubah karena pilihan pemain.
/// </summary>
public class StatusKeluarga
{
    private int _tingkatStres;
    private int _kepercayaanIstri = 50;

    // Bab 2: manual get/set. Nilai dijaga tetap 0 sampai 100 (di luar batas dipotong ke batas terdekat).
    public int TingkatStres
    {
        get => _tingkatStres;
        set => _tingkatStres = Math.Clamp(value, 0, 100);
    }

    public int KepercayaanIstri
    {
        get => _kepercayaanIstri;
        set => _kepercayaanIstri = Math.Clamp(value, 0, 100);
    }

    // Bab 2: auto-property untuk data bebas tanpa validasi.
    public string CatatanHari { get; set; } = "";

    // Bab 2: read-only expression-bodied property. Dihitung dari nilai lain, tidak punya setter.
    public string Ringkasan =>
        KepercayaanIstri < 30 ? "Keluarga rapuh"
        : TingkatStres > 70 ? "Penuh tekanan"
        : "Stabil";
}
