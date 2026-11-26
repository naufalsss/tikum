namespace GaraGaraMaxWin.Core.Models;

/// <summary>
/// PEMILIK: Aris | Bab 1 (Method, Constructor) dan Bab 2 (Encapsulation dan Properties).
/// Uang kiriman Bu Rahma dan biaya pesantren Fajar. Dipakai oleh aktivitas di Bab 4 (Ridho).
/// </summary>
public class DompetKeluarga
{
    // Bab 2: field private, tidak bisa diubah langsung dari luar class.
    private int _saldo;

    // Bab 2: property dengan validasi. Nilai negatif ditolak, saldo tetap seperti sebelumnya.
    public int Saldo
    {
        get => _saldo;
        set
        {
            if (value >= 0) _saldo = value;
        }
    }

    // Bab 2: read-only expression-bodied property.
    public bool AdaUang => Saldo > 0;

    // Bab 1: constructor dengan nilai default (parameter opsional).
    public DompetKeluarga(int saldoAwal = 0)
    {
        Saldo = saldoAwal;
    }

    // Bab 1: method. Jumlah harus positif, lalu ditambahkan lewat property Saldo.
    // Tanda tangan method ini dipakai Ridho, jangan diubah.
    public void Tambah(int jumlah)
    {
        if (jumlah > 0) Saldo += jumlah;
    }

    // Bab 1: method. Jika saldo tidak cukup, saldo tidak berubah.
    // Catatan: di Bab 6 kasus saldo tidak cukup akan diganti SaldoTidakCukupException.
    public void Kurangi(int jumlah)
    {
        if (jumlah > 0 && CukupUntuk(jumlah)) Saldo -= jumlah;
    }

    // Method bantu agar pemanggil bisa mengecek dulu sebelum mengurangi.
    public bool CukupUntuk(int jumlah) => jumlah <= Saldo;
}
