using System.Globalization;

namespace GaraGaraMaxWin.Core.Models.Karakters;

/// <summary>
/// PEMILIK: Naufal | Bab 3 (Inheritance dan Polymorphism).
/// Istri yang bekerja sebagai TKW dan menjadi tulang punggung keluarga.
/// Bab 4 (Ridho): class ini nanti mengimplementasikan IPemberiNafkah, koordinasikan dengan Ridho.
/// </summary>
public class BuRahma : Karakter
{
    // Field khusus Bu Rahma.
    public int GajiBulanan { get; set; }
    public string NegaraKerja { get; set; }

    public string KodeAsetGlb => "BuRahma.glb";

    // Bab 3: base(...) mengisi kode dan nama lewat constructor induk.
    public BuRahma() : base("RHM", "Bu Rahma")
    {
        Peran = "Istri (TKW)";
        Umur = 40;
        GajiBulanan = 6_000_000;
        NegaraKerja = "Hong Kong";
    }

    public override string Bicara() => "Mas, uang kiriman ini untuk sekolah Fajar, jangan dipakai judi ya.";

    public override void TampilkanInfo()
    {
        base.TampilkanInfo();
        Console.WriteLine($"  Bekerja di {NegaraKerja}, gaji Rp {GajiBulanan.ToString("N0", new CultureInfo("id-ID"))} per bulan");
    }
}
