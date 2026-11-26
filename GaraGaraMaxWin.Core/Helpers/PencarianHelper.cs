namespace GaraGaraMaxWin.Core.Helpers;

/// <summary>
/// PEMILIK: Zian | Bab 5 (Generic Class/Method).
/// Method generic yang ditulis sekali, lalu dipakai untuk List&lt;Karakter&gt;, List&lt;AktivitasHarian&gt;, List&lt;int&gt;, dan lainnya.
/// </summary>
public static class PencarianHelper
{
    // Mengembalikan elemen pertama yang memenuhi kondisi, atau default (null untuk tipe referensi) kalau tidak ada.
    // List.Find() meminta Predicate<T>, jadi Func<T,bool> dibungkus dengan lambda.
    public static T? CariData<T>(List<T> daftar, Func<T, bool> kondisi)
    {
        return daftar.Find(item => kondisi(item));
    }

    // Mengembalikan elemen pertama, atau default kalau daftar kosong.
    public static T? AmbilPertama<T>(List<T> daftar)
    {
        return daftar.Count > 0 ? daftar[0] : default;
    }
}
