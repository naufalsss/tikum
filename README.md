# Gara-gara MaxWin

Game 3D edukasi sosial tentang bahaya judi online. Tugas besar Pemrograman Berorientasi Objek (Semester 3), C# di .NET 10 dengan Visual Studio 2026.

## Anggota dan pembagian

| Anggota | Topik progres dosen | Bab | Branch | File yang dipegang |
|---|---|---|---|---|
| **Aris** | Variable, get/set, method | 1, 2 | `feature/bab1-2-fondasi-entitas` | `Models/Karakter.cs`, `Models/DompetKeluarga.cs`, `Models/StatusKeluarga.cs`, `Peragaan/Demo1Encapsulation.cs` |
| **Naufal** | Inheritance | 3 | `feature/bab3-pewarisan-karakter` | `Models/Karakters/*`, `Peragaan/Demo2Inheritance.cs` |
| **Ridho** | Interface, abstract | 4 | `feature/bab4-aktivitas-kontrak` | `Models/Aktivitas/*`, `Interfaces/*`, `Peragaan/Demo3AbstractInterface.cs` |
| **Zian** | Collection, dictionary, generic | 5 | `feature/bab5-koleksi-generik` | `Services/*`, `Helpers/*`, `Peragaan/Demo4Collection.cs` |

Setiap file di `GaraGaraMaxWin.Core` punya komentar `PEMILIK:` di atasnya. Edit hanya file milik sendiri. Kalau perlu mengubah file orang lain, kabari pemiliknya dulu.

## Struktur

```
GaraGaraMaxWin.slnx
GaraGaraMaxWin.Core/     class library: Models, Interfaces, Services, Helpers, Factories, Exceptions
GaraGaraMaxWin.Demo/     console app untuk memperagakan tiap topik (screenshot untuk PDF progres)
GaraGaraMaxWin.Web/      ASP.NET Core MVC dan Web API (Bab 8-11, fase 2)
Assets3D/                PakHendra.glb, BuRahma.glb, Fajar.glb, Prop_HP_MaxWin.glb
Docs/Progress/           potongan kode dan screenshot tiap anggota untuk PDF progres
```

Folder `Factories/` dan `Exceptions/` sengaja kosong. Isinya dikerjakan di Bab 6 dan 7 (fase 2).

## Urutan kerja

Topik dosen saling menumpuk, jadi urutannya Aris, Naufal, Ridho, lalu Zian.

1. Aris menyelesaikan `Karakter` dan `DompetKeluarga`, lalu merge ke `main` secepatnya.
2. Naufal, Ridho, dan Zian membuat branch dari `main` dan mulai dari stub yang sudah ada. Tanda tangan method di stub adalah kontrak awal. Kalau mau diubah, kabari anggota lain.
3. Merge ke `main` lewat Pull Request, urut Aris, Naufal, Ridho, Zian. Minimal satu anggota lain membaca PR sebelum merge.

## Langkah awal (sekali saja, oleh Aris)

```bash
git init -b main
git add .
git commit -m "Kerangka awal solusi"
git remote add origin <URL-repo-GitHub>
git push -u origin main

git branch feature/bab1-2-fondasi-entitas
git branch feature/bab3-pewarisan-karakter
git branch feature/bab4-aktivitas-kontrak
git branch feature/bab5-koleksi-generik
git push origin --all
```

Anggota lain:

```bash
git clone <URL-repo-GitHub>
git checkout feature/<branch-masing-masing>
```

## Menjalankan

Buka `GaraGaraMaxWin.slnx` di Visual Studio, set `GaraGaraMaxWin.Demo` sebagai startup project, lalu tekan F5. Setiap demo mencetak "(belum dikerjakan)" sampai anggotanya mengisi.

## Konvensi kode

- `PascalCase` untuk class, method, dan property. `_camelCase` untuk private field.
- Tiap file satu class, nama file sama dengan nama class.
- Tulis komentar singkat Bab berapa yang diterapkan, seperti contoh di stub.

## Progres untuk dosen

Dosen meminta 1 PDF berisi potongan kode: variable/get/set/method, inheritance, interface/abstract, collection/dictionary/generic. Tiap anggota mengisi file miliknya di `Docs/Progress/`, lalu satu orang menggabungkannya jadi 1 PDF.
