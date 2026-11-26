using GaraGaraMaxWin.Core.Models;

namespace GaraGaraMaxWin.Core.Services;

/// <summary>
/// PEMILIK: Zian | Bab 5 (Dictionary&lt;K,V&gt;).
/// Indeks cepat tokoh berdasarkan kode unik ("HND", "RHM", "FJR"), mirip indeksBarang di modul.
/// </summary>
public class KatalogKarakterService
{
    private readonly Dictionary<string, Karakter> _indeks = new();

    // TODO Zian (Bab 5): tambah method Daftarkan, Ambil (pakai ContainsKey / TryGetValue), dan sebagainya.
    public int Jumlah => _indeks.Count;
}
