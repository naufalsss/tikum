using GaraGaraMaxWin.Core.Interfaces;

namespace GaraGaraMaxWin.Core.Models.Aktivitas;

/// <summary>
/// PEMILIK: Ridho | Bab 4. Aktivitas inti game: bermain judol demi "MaxWin".
/// Mewarisi AktivitasHarian dan mengimplementasikan dua interface (satu class boleh banyak interface).
/// </summary>
public class AktivitasJudol : AktivitasHarian, IMemicuKonflik, IDapatDievaluasi
{
    public int Taruhan { get; set; }

    public AktivitasJudol(int taruhan = 300_000) : base("Bermain Judol")
    {
        Taruhan = taruhan;
    }

    // Wajib di-override karena abstract di class induk.
    public override void JalankanEfek(StatusKeluarga status, DompetKeluarga dompet)
    {
        // Taruhan tidak bisa melebihi saldo yang ada.
        dompet.Kurangi(Math.Min(Taruhan, dompet.Saldo));
        status.KepercayaanIstri -= 15;
        status.TingkatStres += 10;
    }

    // Implementasi IMemicuKonflik.
    public string AlasanKonflik => "Uang kiriman istri dipakai berjudi";

    public int HitungDampakKonflik() => Taruhan >= 500_000 ? 60 : 40;

    // Implementasi IDapatDievaluasi.
    public string Evaluasi() => "Sangat berbahaya: uang habis dan kepercayaan istri anjlok.";
}
