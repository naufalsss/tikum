namespace GaraGaraMaxWin.Core.Helpers;

/// <summary>
/// PEMILIK: Zian | Bab 5 (Generic Class/Method).
/// Method pencarian generik yang bisa dipakai untuk List&lt;Karakter&gt;, List&lt;AktivitasHarian&gt;, dan lainnya.
/// </summary>
public static class PencarianHelper
{
    // TODO Zian (Bab 5): isi method. Tipe kembalian T? karena Find() bisa mengembalikan null/default.
    public static T? CariData<T>(List<T> daftar, Func<T, bool> kondisi)
    {
        throw new NotImplementedException();
    }
}
