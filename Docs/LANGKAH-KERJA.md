# Langkah Kerja Tiap Anggota

Panduan ini untuk progres yang diminta dosen: **variable/get/set/method, inheritance, interface/abstract, collection/dictionary/generic**. Satu orang memegang satu topik.

| Anggota | Topik | Bab | Branch |
|---|---|---|---|
| Aris | Variable, get/set, method | 1, 2 | `feature/bab1-2-fondasi-entitas` |
| Naufal | Inheritance | 3 | `feature/bab3-pewarisan-karakter` |
| Ridho | Interface, abstract | 4 | `feature/bab4-aktivitas-kontrak` |
| Zian | Collection, dictionary, generic | 5 | `feature/bab5-koleksi-generik` |

## Urutan dan ketergantungan

```
Aris (Karakter, DompetKeluarga, StatusKeluarga)
   ├── Naufal  memakai Karakter
   ├── Ridho   memakai DompetKeluarga dan StatusKeluarga
   └── Zian    memakai Karakter dan AktivitasHarian (dari Ridho)
```

Aris menjadi penentu kecepatan. Selama Aris belum merge, tiga anggota lain tetap bisa mulai karena stub sudah ada di repo.

## Aturan untuk semua anggota

- Edit hanya file yang punya komentar `PEMILIK:` dengan nama kamu.
- Kalau perlu mengubah tanda tangan method yang dipakai orang lain (nama, parameter, tipe kembalian), kabari pemiliknya dulu.
- Commit kecil dan sering, dengan pesan jelas, misalnya `Aris: tambah validasi Saldo`.
- Jangan merge ke `main` tanpa Pull Request yang dibaca minimal satu anggota lain.
- Sebelum PR, pastikan solution bisa di-build tanpa error dan `GaraGaraMaxWin.Demo` berjalan.
- Tulis komentar singkat Bab berapa yang diterapkan di tiap class, seperti contoh di stub.

---

## Aris: Variable, Get/Set, Method (Bab 1 dan 2)

**Target:** class dasar yang aman (terenkapsulasi) dan bisa dipakai tiga anggota lain.
**File:** `Models/Karakter.cs`, `Models/DompetKeluarga.cs`, `Models/StatusKeluarga.cs`, `Peragaan/Demo1Encapsulation.cs`, `Docs/Progress/01-Aris-Variable-GetSet-Method.md`

### Langkah

1. Siapkan repo: jalankan "Langkah awal" di `README.md`, lalu pindah ke branch `feature/bab1-2-fondasi-entitas`.
2. **Karakter (Bab 1)**
   - Tambah field yang perlu, misalnya `Umur` dan `Peran`.
   - Pertahankan dua constructor yang sudah ada (default dan berparameter) sebagai *constructor overloading*.
   - Jangan ubah `Bicara()` dan `TampilkanInfo()` yang `virtual`, karena Naufal meng-override keduanya.
3. **DompetKeluarga (Bab 2)**
   - Ubah `Saldo` menjadi field `private int _saldo` dengan property `Saldo`.
   - Di `set`, tolak nilai negatif (pola `if (value >= 0)` seperti `JumlahStok` di modul).
   - Isi method `Tambah(int jumlah)` dan `Kurangi(int jumlah)`. Gunakan property `Saldo`, bukan mengubah field langsung.
   - Tanda tangan kedua method dipakai Ridho, jadi jangan diubah.
4. **StatusKeluarga (Bab 2)**
   - Buat `TingkatStres` dan `KepercayaanIstri` dengan field private dan manual get/set yang menjaga nilai tetap 0 sampai 100.
   - Ubah `Ringkasan` menjadi *read-only expression-bodied property* yang menghasilkan teks berdasarkan nilai, misalnya `KepercayaanIstri < 30 ? "Rapuh" : "Stabil"`.
   - Tambahkan satu auto-property biasa (`{ get; set; }`) supaya kedua gaya property terlihat.
5. **Demo1Encapsulation**
   - Buat objek `DompetKeluarga`, coba set `Saldo` negatif, lalu tampilkan bahwa nilainya tidak berubah.
   - Panggil `Tambah` dan `Kurangi`, tampilkan saldo sebelum dan sesudah.
   - Buat objek `StatusKeluarga`, set `TingkatStres` di luar 0 sampai 100, tampilkan hasilnya dan `Ringkasan`.
6. **Merge cepat.** Setelah langkah 2 sampai 4 build tanpa error, buka PR ke `main` meski demo belum rapi, supaya Naufal, Ridho, dan Zian bisa menarik versi terbaru.
7. **Progres PDF.** Isi `Docs/Progress/01-Aris-Variable-GetSet-Method.md`: screenshot kode (field private, property validasi, auto-property, property read-only, method) dan screenshot output demo.

### Selesai kalau

- [ ] `Saldo`, `TingkatStres`, dan `KepercayaanIstri` tidak bisa diisi nilai yang melanggar batas.
- [ ] Ada contoh manual get/set, auto-property, dan expression-bodied property.
- [ ] Demo1 menunjukkan nilai tidak valid ditolak.
- [ ] PR sudah di-merge ke `main`.

---

## Naufal: Inheritance (Bab 3)

**Target:** tiga tokoh mewarisi `Karakter`, masing-masing dengan perilaku sendiri, dan ditunjukkan lewat polimorfisme.
**File:** `Models/Karakters/PakHendra.cs`, `BuRahma.cs`, `Fajar.cs`, `Peragaan/Demo2Inheritance.cs`, `Docs/Progress/02-Naufal-Inheritance.md`

### Langkah

1. `git checkout main`, `git pull`, lalu buat atau pindah ke branch `feature/bab3-pewarisan-karakter`. Tarik `main` lagi setelah Aris merge.
2. Baca `Models/Karakter.cs`. Pahami constructor-nya dan dua method `virtual`.
3. **Tiap tokoh** (`PakHendra`, `BuRahma`, `Fajar`):
   - Tambah satu atau dua field khusus. Contoh: Pak Hendra punya `Utang`, Bu Rahma punya `GajiBulanan`, Fajar punya `NamaPesantren`.
   - Pastikan constructor memanggil `base(kode, nama)`.
   - Isi `Bicara()` dengan dialog khas tokoh itu. Pakai `override`.
   - Di `TampilkanInfo()`, panggil `base.TampilkanInfo()` dulu, lalu cetak field khusus tokoh (pola `BarangElektronik` di modul).
4. Pertahankan properti `KodeAsetGlb`. Nama file harus sama persis dengan file di `Assets3D/`.
5. **Demo2Inheritance**
   - Buat `Karakter[] keluarga` berisi `PakHendra`, `BuRahma`, dan `Fajar`.
   - Loop semua isi array, panggil `TampilkanInfo()` dan `Bicara()`. Setiap objek harus menampilkan versinya sendiri.
   - Tambahkan satu objek `Karakter` biasa ke array untuk membandingkan dengan versi `override`.
6. Uji sendiri: hapus kata `override` di satu method, build, lihat peringatannya, lalu kembalikan. Hasilnya berguna untuk esai post-test modul.
7. **Progres PDF.** Isi `Docs/Progress/02-Naufal-Inheritance.md`: screenshot kode (`: Karakter`, `base(...)`, `virtual`, `override`, array `Karakter[]`) dan screenshot output.

### Selesai kalau

- [ ] Tiga class turunan memakai `: Karakter` dan `base(...)`.
- [ ] Tiap tokoh punya `Bicara()` yang berbeda lewat `override`.
- [ ] Demo2 menampilkan polimorfisme lewat satu loop.
- [ ] PR sudah di-merge setelah milik Aris.

---

## Ridho: Interface dan Abstract (Bab 4)

**Target:** kerangka aktivitas harian (abstract class) dan kontrak perilaku (interface) yang dipakai lintas class.
**File:** `Models/Aktivitas/*`, `Interfaces/*`, `Peragaan/Demo3AbstractInterface.cs`, `Docs/Progress/03-Ridho-Interface-Abstract.md`

### Langkah

1. `git checkout main`, `git pull`, lalu buat atau pindah ke branch `feature/bab4-aktivitas-kontrak`. Tarik `main` lagi setelah Aris merge, karena kamu memakai `DompetKeluarga` dan `StatusKeluarga`.
2. **AktivitasHarian (abstract)**
   - Tentukan parameter `JalankanEfek` yang benar-benar dibutuhkan efek. Saat ini `StatusKeluarga` dan `DompetKeluarga`.
   - Kabari Zian jika tanda tangannya berubah, karena Zian menyimpan aktivitas di `List<AktivitasHarian>`.
3. **Empat aktivitas turunan**
   - `AktivitasJudol`: kurangi saldo, turunkan kepercayaan istri, naikkan stres.
   - `AktivitasMerokok`: kurangi sedikit saldo, turunkan stres sedikit.
   - `AktivitasMemancing`: saldo tetap, stres turun, kepercayaan istri sedikit turun karena waktu terbuang.
   - `AktivitasBekerja`: tambah saldo, naikkan kepercayaan istri.
   - Semua memakai `override`. Pakai property `Saldo`, `TingkatStres`, dan `KepercayaanIstri` milik Aris, jangan mengakses field langsung.
4. **Tiga interface**
   - `IMemicuKonflik`: dipakai `AktivitasJudol` dan `AktivitasMerokok`.
   - `IPemberiNafkah`: dipakai `AktivitasBekerja`. `BuRahma` (milik Naufal) juga cocok. Minta Naufal menambahkannya setelah interface-mu di-merge.
   - `IDapatDievaluasi`: dipakai minimal dua class yang tidak punya hubungan pewarisan, supaya perbedaannya dengan abstract class terlihat.
   - Sesuaikan anggota interface dengan kebutuhan game, lalu implementasikan di class yang sesuai.
5. **Demo3AbstractInterface**
   - Buat `DompetKeluarga` dan `StatusKeluarga`, jalankan beberapa aktivitas lewat `JalankanEfek`, tampilkan perubahan angkanya.
   - Cek dengan `is IMemicuKonflik` atau `as`, lalu panggil method interface untuk objek yang cocok.
   - Coba `new AktivitasHarian(...)` sekali sebagai komentar dan catat error-nya (abstract class tidak bisa diinstansiasi).
6. **Progres PDF.** Isi `Docs/Progress/03-Ridho-Interface-Abstract.md`: screenshot kode (`abstract class`, `abstract` method, `override`, `interface`, implementasi) dan screenshot output. Tulis alasan singkat kenapa `AktivitasHarian` abstract class sedangkan `IMemicuKonflik` interface.

### Selesai kalau

- [ ] `AktivitasHarian` abstract dengan satu `abstract` method dan satu method biasa.
- [ ] Empat aktivitas meng-override `JalankanEfek` dengan efek yang berbeda.
- [ ] Tiga interface diimplementasikan di class yang sesuai.
- [ ] Demo3 menjalankan efek dan memanggil method interface.

---

## Zian: Collection, Dictionary, Generic (Bab 5)

**Target:** pengelolaan data dinamis dengan `List<T>` dan `Dictionary<K,V>`, plus minimal satu method generic.
**File:** `Services/RiwayatAktivitasService.cs`, `Services/KatalogKarakterService.cs`, `Helpers/PencarianHelper.cs`, `Peragaan/Demo4Collection.cs`, `Docs/Progress/04-Zian-Collection-Dictionary-Generic.md`

### Langkah

1. `git checkout main`, `git pull`, lalu buat atau pindah ke branch `feature/bab5-koleksi-generik`. Kamu bergantung pada `Karakter` (Aris), tiga tokoh (Naufal), dan `AktivitasHarian` (Ridho). Selama menunggu, gunakan stub yang sudah ada.
2. **RiwayatAktivitasService (`List<T>`)**
   - Tambah method `Tambah(AktivitasHarian aktivitas)`.
   - Tambah method pencarian berdasarkan nama dengan `.Find()` dan lambda (`a => a.Nama == nama`). Ingat `Find()` mengembalikan `null` jika tidak ketemu.
   - Tambah method penghitung jumlah aktivitas, misalnya berapa kali judol dipilih.
3. **KatalogKarakterService (`Dictionary<K,V>`)**
   - Tambah `Daftarkan(Karakter karakter)` dengan `Kode` sebagai key. Tolak key ganda.
   - Tambah `Ambil(string kode)` dengan `ContainsKey` atau `TryGetValue`.
4. **PencarianHelper (generic)**
   - Isi `CariData<T>(List<T> daftar, Func<T, bool> kondisi)` supaya mengembalikan elemen pertama yang cocok.
   - Tambah satu method generic kedua, misalnya `AmbilPertama<T>(List<T> daftar)` (soal esai di modul Bab 5).
   - Opsional: buat class generic `LogGenerik<T>` untuk mencatat peristiwa game apa pun.
5. Setelah Ridho dan Naufal merge, ganti stub dengan class asli: isi katalog dengan `PakHendra`, `BuRahma`, `Fajar`, dan riwayat dengan empat aktivitas.
6. **Demo4Collection**
   - Isi riwayat dengan beberapa aktivitas, cari satu dengan `.Find()`, lalu dengan `CariData<T>`.
   - Daftarkan tiga tokoh ke katalog, ambil satu lewat kode `"HND"`, dan coba kode yang tidak ada.
   - Panggil `CariData<T>` pada dua tipe berbeda (`List<AktivitasHarian>` dan `List<Karakter>`) untuk menunjukkan generic bekerja untuk banyak tipe.
7. **Progres PDF.** Isi `Docs/Progress/04-Zian-Collection-Dictionary-Generic.md`: screenshot kode (`List<T>`, `.Find()`, `Dictionary`, `CariData<T>`) dan screenshot output. Tulis perbedaan List dan Dictionary dengan contoh dari game.

### Selesai kalau

- [ ] Ada `List<AktivitasHarian>`, `Dictionary<string, Karakter>`, dan pencarian dengan lambda.
- [ ] `CariData<T>` dipanggil untuk minimal dua tipe berbeda.
- [ ] Demo4 menampilkan kasus ditemukan dan tidak ditemukan.
- [ ] Demo4 memakai class asli milik Aris, Naufal, dan Ridho.

---

## Menggabungkan jadi satu PDF

1. Setelah keempat branch ter-merge ke `main`, jalankan `GaraGaraMaxWin.Demo` dan pastikan keempat demo menampilkan output.
2. Satu orang menggabungkan keempat file di `Docs/Progress/` (kode, output, dan penjelasan singkat) menjadi **1 PDF, maksimal 10 MB**.
3. Upload PDF ke form dosen.

## Setelah progres terkumpul (fase 2, Bab 6 sampai 11)

| Anggota | Bab |
|---|---|
| Aris | Bab 6 (exception dan file I/O) dan Bab 9 (EF Core) |
| Naufal | Bab 7 (SOLID dan Factory) dan Bab 8 (ASP.NET MVC) |
| Ridho | Bab 10 (CRUD dan validasi form) |
| Zian | Bab 11 (Web API) |

Pembagian ini masih sementara dan bisa disesuaikan setelah progres pertama selesai.
