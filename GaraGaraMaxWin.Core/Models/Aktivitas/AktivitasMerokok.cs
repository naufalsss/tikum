namespace GaraGaraMaxWin.Core.Models.Aktivitas;

/// <summary>PEMILIK: Ridho | Bab 4. Efek: stres turun sedikit, uang habis untuk rokok.</summary>
public class AktivitasMerokok : AktivitasHarian
{
    public AktivitasMerokok() : base("Merokok")
    {
    }

    // TODO Ridho (Bab 4): isi efek ke status dan dompet. Pertimbangkan implement IMemicuKonflik.
    public override void JalankanEfek(StatusKeluarga status, DompetKeluarga dompet)
    {
    }
}
