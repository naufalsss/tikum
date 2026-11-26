namespace GaraGaraMaxWin.Core.Models.Aktivitas;

/// <summary>PEMILIK: Ridho | Bab 4. Jalur Good Ending: Pak Hendra mulai bekerja mencari nafkah.</summary>
public class AktivitasBekerja : AktivitasHarian
{
    public AktivitasBekerja() : base("Bekerja")
    {
    }

    // TODO Ridho (Bab 4): isi efek (saldo bertambah, kepercayaan istri naik). Implement IPemberiNafkah.
    public override void JalankanEfek(StatusKeluarga status, DompetKeluarga dompet)
    {
    }
}
