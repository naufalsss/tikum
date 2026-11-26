using GaraGaraMaxWin.Core.Models;

namespace GaraGaraMaxWin.Core.Services;

/// <summary>
/// PEMILIK: Zian | Bab 5 (Dictionary&lt;K,V&gt;).
/// Indeks cepat tokoh berdasarkan kode unik ("HND", "RHM", "FJR"), mirip indeksBarang di modul.
/// </summary>
public class KatalogKarakterService
{
    // Bab 5: Dictionary menyimpan pasangan kunci-nilai, pencarian cepat lewat kunci.
    private readonly Dictionary<string, Karakter> _indeks = new();

    public int Jumlah => _indeks.Count;

    // Mengembalikan false kalau kode sudah dipakai tokoh lain (key dictionary harus unik).
    public bool Daftarkan(Karakter karakter)
    {
        ArgumentNullException.ThrowIfNull(karakter);

        if (_indeks.ContainsKey(karakter.Kode))
        {
            return false;
        }

        _indeks[karakter.Kode] = karakter;
        return true;
    }

    public bool Ada(string kode) => _indeks.ContainsKey(kode);

    // Mengembalikan null kalau kode tidak terdaftar.
    public Karakter? Ambil(string kode)
    {
        return _indeks.TryGetValue(kode, out Karakter? karakter) ? karakter : null;
    }
}
