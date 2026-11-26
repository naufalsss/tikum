# Progres 1: Variable, Get/Set, Method (Aris)

Bab 1 (Class, Object, Field, Method, Constructor) dan Bab 2 (Encapsulation dan Properties).

## Potongan kode

Ambil screenshot dari Visual Studio untuk bagian berikut, lalu simpan di `Docs/Progress/img/`.

| Bagian | File | Yang di-screenshot |
|---|---|---|
| Variable (field) | `Models/DompetKeluarga.cs` | `private int _saldo;` |
| Get/set dengan validasi | `Models/DompetKeluarga.cs` | property `Saldo` (`get => _saldo;`, `set` dengan `if (value >= 0)`) |
| Get/set dengan batas | `Models/StatusKeluarga.cs` | property `TingkatStres` dan `KepercayaanIstri` (`Math.Clamp`) |
| Auto-property | `Models/Karakter.cs` | `Kode`, `Nama`, `Peran` dengan `{ get; set; }` |
| Read-only property | `Models/StatusKeluarga.cs` | `Ringkasan =>` |
| Method | `Models/DompetKeluarga.cs` | `Tambah`, `Kurangi`, `CukupUntuk` |
| Constructor overloading | `Models/Karakter.cs` | tiga constructor `Karakter(...)` |

## Output

Screenshot output console dari `Demo1Encapsulation` (jalankan `GaraGaraMaxWin.Demo`).

## Penjelasan singkat

Field `_saldo`, `_tingkatStres`, `_kepercayaanIstri`, dan `_umur` dibuat `private` supaya nilainya tidak bisa diubah langsung dari luar. Akses dilakukan lewat property dengan `get` dan `set` yang menolak atau membatasi nilai tidak wajar, misalnya saldo negatif atau stres di atas 100. Perilaku objek ditulis sebagai method (`Tambah`, `Kurangi`, `TampilkanInfo`), dan `Karakter` punya tiga constructor (default, kode dan nama, serta lengkap) sebagai penerapan constructor overloading.
