# Progres 3: Interface dan Abstract (Ridho)

Bab 4 (Abstract Class vs Interface).

## Potongan kode

Ambil screenshot dari Visual Studio untuk bagian berikut, lalu simpan di `Docs/Progress/img/`.

| Bagian | File | Yang di-screenshot |
|---|---|---|
| Abstract class dan abstract method | `Models/Aktivitas/AktivitasHarian.cs` | `public abstract class AktivitasHarian`, method biasa `CetakInfo()`, dan `abstract JalankanEfek(...)` |
| Override | `Models/Aktivitas/AktivitasJudol.cs` | `class AktivitasJudol : AktivitasHarian, IMemicuKonflik, IDapatDievaluasi` dan `override JalankanEfek` |
| Interface | `Interfaces/IMemicuKonflik.cs`, `IPemberiNafkah.cs`, `IDapatDievaluasi.cs` | deklarasi interface |
| Interface lintas class | `Models/Karakters/BuRahma.cs` dan `Models/Aktivitas/AktivitasBekerja.cs` | `: IPemberiNafkah` dan `HitungNafkah()` |
| Pemakaian | `Peragaan/Demo3AbstractInterface.cs` | `a is IMemicuKonflik pemicu` dan array `IPemberiNafkah[]` |

## Output

Screenshot output console blok `=== Demo 3: Abstract dan Interface (Ridho) ===` dari `GaraGaraMaxWin.Demo`.

## Penjelasan singkat

`AktivitasHarian` dibuat abstract class karena semua aktivitas punya perilaku dasar yang sama (`Nama` dan `CetakInfo()`), tetapi efeknya berbeda sehingga `JalankanEfek()` dibuat abstract dan wajib di-override. Interface dipakai untuk kontrak yang melewati pohon pewarisan: `IPemberiNafkah` dipakai `BuRahma` (turunan `Karakter`) dan `AktivitasBekerja` (turunan `AktivitasHarian`), sedangkan `IMemicuKonflik` dipakai `AktivitasJudol` dan `AktivitasMerokok`. Satu class hanya boleh mewarisi satu class, tetapi boleh mengimplementasikan banyak interface.
