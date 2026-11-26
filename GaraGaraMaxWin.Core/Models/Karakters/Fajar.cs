namespace GaraGaraMaxWin.Core.Models.Karakters;

/// <summary>
/// PEMILIK: Naufal | Bab 3 (Inheritance dan Polymorphism).
/// Anak yang belajar di pesantren dan berharap keluarganya tetap utuh.
/// </summary>
public class Fajar : Karakter
{
    // TODO Naufal (Bab 3): tambah field khusus Fajar (misal NamaPesantren, BiayaBulanan).
    public string KodeAsetGlb => "Fajar.glb";

    public Fajar() : base("FJR", "Fajar")
    {
    }

    // TODO Naufal (Bab 3): isi dialog khas Fajar.
    public override string Bicara() => "TODO";

    public override void TampilkanInfo()
    {
        base.TampilkanInfo();
    }
}
