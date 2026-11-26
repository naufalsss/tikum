namespace GaraGaraMaxWin.Core.Models;

/// <summary>
/// PEMILIK: Aris | Bab 1 (Class, Object, Field, Method, Constructor) dan Bab 2 (Encapsulation).
/// Class induk semua tokoh. Naufal mewarisi class ini di Bab 3,
/// jadi nama class, constructor (kode, nama), dan method virtual di bawah jangan diubah tanpa kabar ke Naufal.
/// </summary>
public class Karakter
{
    // Bab 2: field private + property dengan validasi (umur tidak boleh negatif).
    private int _umur;

    // Bab 2: auto-property untuk data yang tidak butuh validasi.
    public string Kode { get; set; }
    public string Nama { get; set; }
    public string Peran { get; set; }

    // Bab 2: manual getter/setter dengan validasi.
    public int Umur
    {
        get => _umur;
        set
        {
            if (value >= 0) _umur = value;
        }
    }

    // Bab 1: constructor overloading. Constructor tanpa parameter (nilai default).
    public Karakter()
    {
        Kode = "UNKNOWN";
        Nama = "Tanpa Nama";
        Peran = "Tidak diketahui";
        Umur = 0;
    }

    // Bab 1: constructor berparameter. Dipakai class turunan lewat base(kode, nama).
    public Karakter(string kode, string nama)
    {
        Kode = kode;
        Nama = nama;
        Peran = "Tidak diketahui";
        Umur = 0;
    }

    // Bab 1: constructor lengkap.
    public Karakter(string kode, string nama, string peran, int umur)
    {
        Kode = kode;
        Nama = nama;
        Peran = peran;
        Umur = umur;
    }

    // Kontrak untuk Bab 3: Naufal mem-override kedua method ini di PakHendra, BuRahma, Fajar.
    public virtual string Bicara() => "...";

    // Bab 1: method yang menampilkan informasi objek itu sendiri.
    public virtual void TampilkanInfo()
    {
        Console.WriteLine($"[{Kode}] {Nama} - {Peran}, {Umur} tahun");
    }
}
