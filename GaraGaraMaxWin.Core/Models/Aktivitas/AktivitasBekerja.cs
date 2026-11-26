using GaraGaraMaxWin.Core.Interfaces;

namespace GaraGaraMaxWin.Core.Models.Aktivitas;

/// <summary>PEMILIK: Ridho | Bab 4. Jalur Good Ending: Pak Hendra mulai bekerja mencari nafkah.</summary>
public class AktivitasBekerja : AktivitasHarian, IPemberiNafkah, IDapatDievaluasi
{
    public int UpahHarian { get; set; } = 150_000;

    public AktivitasBekerja() : base("Bekerja")
    {
    }

    public override void JalankanEfek(StatusKeluarga status, DompetKeluarga dompet)
    {
        dompet.Tambah(HitungNafkah());
        status.KepercayaanIstri += 10;
        status.TingkatStres += 3;
    }

    // Implementasi IPemberiNafkah.
    public int HitungNafkah() => UpahHarian;

    // Implementasi IDapatDievaluasi.
    public string Evaluasi() => "Baik: menambah saldo dan memulihkan kepercayaan.";
}
