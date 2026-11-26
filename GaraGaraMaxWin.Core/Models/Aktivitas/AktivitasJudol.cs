namespace GaraGaraMaxWin.Core.Models.Aktivitas;

/// <summary>PEMILIK: Ridho | Bab 4. Aktivitas inti game: bermain judol demi "MaxWin".</summary>
public class AktivitasJudol : AktivitasHarian
{
    public AktivitasJudol() : base("Bermain Judol")
    {
    }

    // TODO Ridho (Bab 4): isi efek (saldo berkurang, kepercayaan istri turun). Implement IMemicuKonflik.
    public override void JalankanEfek(StatusKeluarga status, DompetKeluarga dompet)
    {
    }
}
