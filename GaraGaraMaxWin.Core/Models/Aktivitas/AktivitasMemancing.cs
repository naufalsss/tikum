using GaraGaraMaxWin.Core.Interfaces;

namespace GaraGaraMaxWin.Core.Models.Aktivitas;

/// <summary>PEMILIK: Ridho | Bab 4. Efek: waktu terbuang, stres turun, tidak menghasilkan uang.</summary>
public class AktivitasMemancing : AktivitasHarian, IDapatDievaluasi
{
    public AktivitasMemancing() : base("Memancing")
    {
    }

    public override void JalankanEfek(StatusKeluarga status, DompetKeluarga dompet)
    {
        // Saldo tidak berubah, tapi waktu terbuang membuat istri makin kecewa.
        status.TingkatStres -= 10;
        status.KepercayaanIstri -= 3;
    }

    public string Evaluasi() => "Tidak boros, tapi waktu terbuang tanpa penghasilan.";
}
