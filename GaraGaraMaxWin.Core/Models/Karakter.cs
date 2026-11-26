namespace GaraGaraMaxWin.Core.Models;

/// <summary>
/// PEMILIK: Aris | Bab 1 (Class, Object, Field, Method, Constructor) dan Bab 2 (Encapsulation).
/// Class induk semua tokoh. Naufal mewarisi class ini di Bab 3,
/// jadi nama class dan method virtual di bawah jangan diubah tanpa kabar ke Naufal.
/// </summary>
public class Karakter
{
    // TODO Aris (Bab 1): tambah field lain yang perlu (misal Umur, Peran).
    // TODO Aris (Bab 2): ubah field yang butuh validasi jadi private + property.
    public string Kode { get; set; }
    public string Nama { get; set; }

    // TODO Aris (Bab 1): constructor overloading, satu default dan satu berparameter.
    public Karakter()
    {
        Kode = "UNKNOWN";
        Nama = "Tanpa Nama";
    }

    public Karakter(string kode, string nama)
    {
        Kode = kode;
        Nama = nama;
    }

    // Kontrak untuk Bab 3: Naufal mem-override kedua method ini di PakHendra, BuRahma, Fajar.
    public virtual string Bicara() => "...";

    public virtual void TampilkanInfo()
    {
        Console.WriteLine($"[{Kode}] {Nama}");
    }
}
