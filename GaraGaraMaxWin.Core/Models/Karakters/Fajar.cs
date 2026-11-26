using System.Globalization;

namespace GaraGaraMaxWin.Core.Models.Karakters;

/// <summary>
/// PEMILIK: Naufal | Bab 3 (Inheritance dan Polymorphism).
/// Anak yang belajar di pesantren dan berharap keluarganya tetap utuh.
/// </summary>
public class Fajar : Karakter
{
    // Field khusus Fajar.
    public string NamaPesantren { get; set; }
    public int BiayaBulanan { get; set; }

    public string KodeAsetGlb => "Fajar.glb";

    // Bab 3: base(...) mengisi kode dan nama lewat constructor induk.
    public Fajar() : base("FJR", "Fajar")
    {
        Peran = "Anak (santri)";
        Umur = 15;
        NamaPesantren = "Pesantren Al-Hidayah";
        BiayaBulanan = 1_500_000;
    }

    public override string Bicara() => "Yah, Fajar cuma ingin keluarga kita utuh lagi.";

    public override void TampilkanInfo()
    {
        base.TampilkanInfo();
        Console.WriteLine($"  Santri di {NamaPesantren}, biaya Rp {BiayaBulanan.ToString("N0", new CultureInfo("id-ID"))} per bulan");
    }
}
