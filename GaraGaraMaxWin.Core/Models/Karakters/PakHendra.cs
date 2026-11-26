namespace GaraGaraMaxWin.Core.Models.Karakters;

/// <summary>
/// PEMILIK: Naufal | Bab 3 (Inheritance dan Polymorphism).
/// Protagonis: pengangguran, kecanduan judol, sering merokok dan memancing.
/// </summary>
public class PakHendra : Karakter
{
    // TODO Naufal (Bab 3): tambah field khusus Pak Hendra (misal Utang, JumlahRokok).
    public string KodeAsetGlb => "PakHendra.glb";

    public PakHendra() : base("HND", "Pak Hendra")
    {
    }

    // TODO Naufal (Bab 3): isi dialog khas Pak Hendra, lalu panggil base.TampilkanInfo() di TampilkanInfo.
    public override string Bicara() => "TODO";

    public override void TampilkanInfo()
    {
        base.TampilkanInfo();
    }
}
