namespace GaraGaraMaxWin.Core.Helpers;

/// <summary>
/// PEMILIK: Zian | Bab 5 (Generic Class).
/// Pencatat peristiwa game untuk tipe apa pun: LogGenerik&lt;string&gt; untuk pilihan pemain,
/// LogGenerik&lt;int&gt; untuk riwayat saldo, dan seterusnya.
/// </summary>
public class LogGenerik<T>
{
    private readonly List<T> _entri = new();

    public int Jumlah => _entri.Count;

    public IReadOnlyList<T> Semua => _entri;

    public void Catat(T entri)
    {
        _entri.Add(entri);
    }

    // Entri paling akhir, atau default kalau log masih kosong.
    public T? Terakhir()
    {
        return _entri.Count > 0 ? _entri[^1] : default;
    }
}
