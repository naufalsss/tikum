namespace GaraGaraMaxWin.Core.Models;

/// <summary>
/// PEMILIK: Aris | Bab 2 (manual getter/setter + validasi, auto-property, read-only expression-bodied property).
/// Menyimpan kondisi keluarga yang berubah karena pilihan pemain.
/// </summary>
public class StatusKeluarga
{
    // TODO Aris (Bab 2): beri validasi supaya nilai tetap 0-100 (manual get/set dengan field private).
    public int TingkatStres { get; set; }
    public int KepercayaanIstri { get; set; } = 50;

    // TODO Aris (Bab 2): ubah jadi read-only expression-bodied property, mirip Status => ... di modul.
    public string Ringkasan => "TODO";
}
