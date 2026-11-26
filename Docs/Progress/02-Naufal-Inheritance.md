# Progres 2: Inheritance (Naufal)

Bab 3 (Inheritance dan Polymorphism Dasar).

## Potongan kode

Ambil screenshot dari Visual Studio untuk bagian berikut, lalu simpan di `Docs/Progress/img/`.

| Bagian | File | Yang di-screenshot |
|---|---|---|
| Method `virtual` di induk | `Models/Karakter.cs` | `Bicara()` dan `TampilkanInfo()` |
| Pewarisan dan `base(...)` | `Models/Karakters/PakHendra.cs` | `class PakHendra : Karakter` dan constructor `: base("HND", "Pak Hendra")` |
| `override` | `Models/Karakters/PakHendra.cs`, `BuRahma.cs`, `Fajar.cs` | `Bicara()` dan `TampilkanInfo()` (dengan `base.TampilkanInfo()`) |
| Polimorfisme | `Peragaan/Demo2Inheritance.cs` | array `Karakter[]` dan loop `foreach` |

## Output

Screenshot output console blok `=== Demo 2: Inheritance (Naufal) ===` dari `GaraGaraMaxWin.Demo`.

## Penjelasan singkat

`PakHendra`, `BuRahma`, dan `Fajar` mewarisi `Karakter` dengan `:` dan memanggil constructor induk lewat `base(kode, nama)`, sehingga kode dan nama tidak perlu ditulis ulang. `Bicara()` dan `TampilkanInfo()` ditandai `virtual` di induk dan di-`override` di tiap tokoh agar dialog dan informasinya berbeda. Pada loop `Karakter[]`, setiap objek menjalankan versi miliknya sendiri walaupun variabelnya bertipe `Karakter`, itulah polimorfisme.
