# Progres 4: Collection, Dictionary, Generic (Zian)

Bab 5 (Collection dan Generic Class/Method).

## Potongan kode

Ambil screenshot dari Visual Studio untuk bagian berikut, lalu simpan di `Docs/Progress/img/`.

| Bagian | File | Yang di-screenshot |
|---|---|---|
| List dan `.Find()` | `Services/RiwayatAktivitasService.cs` | `List<AktivitasHarian> _riwayat`, `Tambah`, dan `CariBerdasarkanNama` (`Find` dengan lambda) |
| Dictionary | `Services/KatalogKarakterService.cs` | `Dictionary<string, Karakter> _indeks`, `Daftarkan` (`ContainsKey`), dan `Ambil` (`TryGetValue`) |
| Generic method | `Helpers/PencarianHelper.cs` | `CariData<T>` dan `AmbilPertama<T>` |
| Generic class | `Helpers/LogGenerik.cs` | `class LogGenerik<T>` |
| Pemakaian | `Peragaan/Demo4Collection.cs` | `CariData` dipanggil dengan `List<AktivitasHarian>`, `List<Karakter>`, dan `List<int>`; `LogGenerik<string>` dan `LogGenerik<int>` |

## Output

Screenshot output console blok `=== Demo 4: Collection, Dictionary, Generic (Zian) ===` dari `GaraGaraMaxWin.Demo`.

## Penjelasan singkat

`List<AktivitasHarian>` dipakai untuk riwayat aktivitas karena jumlahnya bertambah setiap hari dan perlu dicari dengan `.Find()` dan lambda. `Dictionary<string, Karakter>` dipakai untuk katalog tokoh karena tokoh selalu dicari lewat kode unik (`"HND"`, `"RHM"`, `"FJR"`), dan pencarian lewat kunci lebih cepat daripada menelusuri list. `CariData<T>` dan `LogGenerik<T>` ditulis sekali lalu dipakai untuk banyak tipe (aktivitas, karakter, angka, string) tanpa menulis ulang dan tetap aman tipe.
