using GaraGaraMaxWin.Core.Interfaces;

namespace GaraGaraMaxWin.Core.Models.Aktivitas;

/// <summary>PEMILIK: Ridho | Bab 4. Efek: stres turun sedikit, uang habis untuk rokok.</summary>
public class AktivitasMerokok : AktivitasHarian, IMemicuKonflik, IDapatDievaluasi
{
    public int BiayaRokok { get; set; } = 35_000;

    public AktivitasMerokok() : base("Merokok")
    {
    }

    public override void JalankanEfek(StatusKeluarga status, DompetKeluarga dompet)
    {
        dompet.Kurangi(Math.Min(BiayaRokok, dompet.Saldo));
        status.TingkatStres -= 5;
    }

    public string AlasanKonflik => "Uang belanja dibakar jadi asap";

    public int HitungDampakKonflik() => 10;

    public string Evaluasi() => "Merugikan pelan-pelan: uang belanja terbakar.";
}
