namespace GaraGaraMaxWin.Core.Models.Karakters;

/// <summary>
/// PEMILIK: Naufal | Bab 3 (Inheritance dan Polymorphism).
/// Istri yang bekerja sebagai TKW dan menjadi tulang punggung keluarga.
/// Bab 4 (Ridho): class ini nanti mengimplementasikan IPemberiNafkah, koordinasikan dengan Ridho.
/// </summary>
public class BuRahma : Karakter
{
    // TODO Naufal (Bab 3): tambah field khusus Bu Rahma (misal GajiBulanan, NegaraKerja).
    public string KodeAsetGlb => "BuRahma.glb";

    public BuRahma() : base("RHM", "Bu Rahma")
    {
    }

    // TODO Naufal (Bab 3): isi dialog khas Bu Rahma.
    public override string Bicara() => "TODO";

    public override void TampilkanInfo()
    {
        base.TampilkanInfo();
    }
}
