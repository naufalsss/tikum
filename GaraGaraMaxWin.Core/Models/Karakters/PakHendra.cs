using System.Globalization;

namespace GaraGaraMaxWin.Core.Models.Karakters;

/// <summary>
/// PEMILIK: Naufal | Bab 3 (Inheritance dan Polymorphism).
/// Protagonis: pengangguran, kecanduan judol, sering merokok dan memancing.
/// </summary>
public class PakHendra : Karakter
{
    // Field khusus Pak Hendra (tidak dimiliki class induk).
    public int Utang { get; set; }
    public int JumlahRokokPerHari { get; set; }

    public string KodeAsetGlb => "PakHendra.glb";

    // Bab 3: constructor turunan memanggil constructor induk lewat base(...).
    public PakHendra() : base("HND", "Pak Hendra")
    {
        Peran = "Ayah";
        Umur = 45;
        Utang = 12_500_000;
        JumlahRokokPerHari = 20;
    }

    // Constructor overloading: memakai constructor di atas lewat this(), lalu mengubah utang awal.
    public PakHendra(int utangAwal) : this()
    {
        Utang = utangAwal;
    }

    // Bab 3: override mengganti perilaku method virtual milik Karakter.
    public override string Bicara() => "Sekali lagi saja, pasti MaxWin!";

    // Bab 3: base.TampilkanInfo() dipanggil dulu, lalu ditambah info khusus Pak Hendra.
    public override void TampilkanInfo()
    {
        base.TampilkanInfo();
        Console.WriteLine($"  Utang: Rp {Utang.ToString("N0", new CultureInfo("id-ID"))}, rokok {JumlahRokokPerHari} batang per hari");
    }
}
