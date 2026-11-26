namespace GaraGaraMaxWin.Core.Models;

/// <summary>
/// PEMILIK: Aris | Bab 2 (Encapsulation dan Properties).
/// Uang kiriman Bu Rahma dan biaya pesantren Fajar. Dipakai oleh aktivitas di Bab 4 (Ridho).
/// </summary>
public class DompetKeluarga
{
    // TODO Aris (Bab 2): ganti jadi field private "_saldo" + property Saldo dengan validasi (tidak boleh negatif),
    // seperti pola private jumlahStok + property JumlahStok di modul Bab 2.
    public int Saldo { get; set; }

    public DompetKeluarga(int saldoAwal = 0)
    {
        Saldo = saldoAwal;
    }

    // TODO Aris (Bab 1): isi method. Tanda tangan method ini dipakai Ridho, jadi jangan diubah.
    public void Tambah(int jumlah)
    {
    }

    public void Kurangi(int jumlah)
    {
    }
}
