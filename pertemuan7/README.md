# Praktik Pemrograman Visual (Vispro) Pertemuan 7
**Topik:** Validasi Input, Error Handling & Naming Convention  
**Nama Proyek:** `FormPendaftaran`  
**Target Framework:** `.NET 10.0 (Windows Forms App - Visual Basic .NET)`  
**Startup Form:** `FrmUtama`  
**Opsi Kompilasi:** `Option Strict On`

---

## 1. Ringkasan Proyek

Proyek ini dibuat sebagai implementasi praktikum Pemrograman Visual Pertemuan 7 sesuai dengan panduan resmi `praktik.md`. Aplikasi terdiri dari tiga form utama dan satu modul validasi:

1. **`FrmUtama`**: Form navigasi utama yang menyediakan tombol akses ke form uji konversi dan form pendaftaran.
2. **`FrmUjiKonversi`**: Demonstrasi dan komparasi berbagai metode konversi tipe data dan penanganan kesalahan di VB.NET (`CInt`, `Val`, `Integer.TryParse`, `Try...Catch`, dan `Catch Bertingkat`).
3. **`ModValidasi`**: Modul pembantu berisi fungsi validasi yang dapat dipakai ulang (`Kosong`, `SemuaDigit`, dan `CobaDesimal`).
4. **`FrmPendaftaran`**: Form pendaftaran mahasiswa dengan validasi lengkap menggunakan `ErrorProvider`, penyimpanan sementara in-memory, pencegahan duplikasi NIM, dan ekspor data ke file CSV menggunakan `StreamWriter`.

---

## 2. Struktur File dan Direktori

```text
pertemuan7/
├── FormPendaftaran.sln              # File Solution format standar Visual Studio
├── FormPendaftaran.slnx             # File Solution format baru Visual Studio 2022/2026
├── pertemuan7.slnx                  # Solution bawaan workspace
├── data-mahasiswa.csv               # File CSV hasil ekspor data mahasiswa
├── README.md                        # Dokumentasi dan panduan pengujian
├── screenshots/                     # Tangkapan layar asli hasil pengujian aplikasi
│   ├── 01_FrmUtama.png
│   ├── 02_FrmUjiKonversi_Valid.png
│   ├── 03_FrmUjiKonversi_TryParse_Invalid.png
│   ├── 04_FrmUjiKonversi_CatchBertingkat_DivideByZero.png
│   ├── 05_FrmPendaftaran_Normal.png
│   ├── 06_FrmPendaftaran_ErrorProvider.png
│   ├── 07_FrmPendaftaran_DataTersimpan.png
│   └── 08_FrmPendaftaran_EksporCSV.png
└── pertemuan7/                      # Direktori proyek utama
    ├── FormPendaftaran.vbproj       # File konfigurasi proyek .NET 10 VB.NET
    ├── FormPendaftaran.vbproj.user  # Konfigurasi designer Windows Forms
    ├── FrmUtama.vb                  # Kode logika Form Utama
    ├── FrmUtama.Designer.vb         # Tata letak kontrol FrmUtama
    ├── FrmUtama.resx                # Sumber daya FrmUtama
    ├── FrmUjiKonversi.vb            # Logika pengujian konversi dan exception
    ├── FrmUjiKonversi.Designer.vb   # Tata letak kontrol FrmUjiKonversi
    ├── FrmUjiKonversi.resx          # Sumber daya FrmUjiKonversi
    ├── ModValidasi.vb               # Modul fungsi validasi input
    ├── FrmPendaftaran.vb            # Logika form pendaftaran mahasiswa & ekspor
    ├── FrmPendaftaran.Designer.vb   # Tata letak kontrol FrmPendaftaran
    ├── FrmPendaftaran.resx          # Sumber daya FrmPendaftaran
    └── My Project/
        ├── Application.myapp        # Konfigurasi Application Framework VB
        └── Application.Designer.vb  # Entry point dan inisialisasi Startup Form
```

---

## 3. Cara Membuka dan Menjalankan Proyek di Visual Studio

1. **Buka Proyek:**
   - Buka Visual Studio 2022 (atau versi lebih baru yang mendukung .NET 10).
   - Pilih menu **File** > **Open** > **Project/Solution...**
   - Pilih file `FormPendaftaran.sln` atau `pertemuan7.slnx` yang berada di folder root workspace.
2. **Kompilasi / Build:**
   - Tekan tombol `Ctrl + Shift + B` atau klik **Build** > **Build Solution**.
   - Pastikan build berhasil dengan `0 Error(s)` dan `0 Warning(s)`.
3. **Menjalankan Aplikasi:**
   - Tekan tombol `F5` atau tombol **Start** dengan ikon hijau.
   - Aplikasi akan membuka form pembuka `FrmUtama`.

---

## 4. Tabel Hasil Pengujian

Seluruh skenario pengujian telah dijalankan dan diverifikasi secara langsung menggunakan test runner otomatis pada runtime .NET 10 Windows Forms:

### A. Pengujian Praktik 1 (`FrmUjiKonversi`)

| No | Input | Tombol / Metode | Perilaku & Hasil | Status |
|:---:|---|---|---|:---:|
| 1 | `25` | `btnCInt` | Menghasilkan nilai integer 25 (`CInt berhasil: 25`). | **Berhasil** |
| 2 | `abc` | `btnCInt` | Melempar `InvalidCastException` tanpa penanganan (sesuai tujuan demonstrasi risiko crash). | **Berhasil** |
| 3 | `25` | `btnVal` | Menghasilkan nilai numerik 25. | **Berhasil** |
| 4 | `12abc` | `btnVal` | Mengambil angka di awal teks saja (menghasilkan 12). | **Berhasil** |
| 5 | `25` | `btnTryParse` | Konversi sukses tanpa exception (`Valid. Nilai angka = 25`). | **Berhasil** |
| 6 | `abc` | `btnTryParse` | Menampilkan pesan bahwa input bukan bilangan bulat, tanpa crash. | **Berhasil** |
| 7 | `abc` | `btnTryCatch` | Menangkap exception dan menampilkan MessageBox peringatan; program tetap berjalan normal. | **Berhasil** |
| 8 | `0` | `btnCatchBertingkat` | Menangkap `DivideByZeroException` dengan pesan pembagian dengan nol tidak diperbolehkan. | **Berhasil** |
| 9 | `99999999999` | `btnCatchBertingkat` | Menangkap `OverflowException` dengan pesan angka terlalu besar untuk tipe Integer. | **Berhasil** |
| 10 | `abc` | `btnCatchBertingkat` | Menangkap `FormatException` dengan pesan format salah. | **Berhasil** |
| 11 | `25` | `btnCatchBertingkat` | Menghitung pembagian bulat `1000 \ 25 = 40`. | **Berhasil** |
| 12 | Kosong (`""`) | Semua Metode | Masing-masing metode memberikan respon sesuai karakteristik (CInt crash, Val 0, TryParse gagal aman). | **Berhasil** |

### B. Pengujian Praktik 2 (`FrmPendaftaran`)

| No | Kasus Uji | Perilaku yang Diharapkan | Hasil Pengujian | Status |
|:---:|---|---|---|:---:|
| 1 | Simpan formulir kosong | ErrorProvider muncul di seluruh input yang wajib diisi; status menampilkan pesan kesalahan | Seluruh input bertanda merah dan status diperbarui | **Berhasil** |
| 2 | Validasi NIM saat kursor keluar (`Validating`) | Event `txtNim_Validating` memeriksa panjang digit saat kursor meninggalkan kontrol | ErrorProvider langsung menandai NIM jika < 9 digit | **Berhasil** |
| 3 | NIM kurang dari 9 digit | Validasi gagal dengan pesan "NIM harus 9 digit angka." | Ditandai tanda seru merah ErrorProvider | **Berhasil** |
| 4 | NIM mengandung huruf | Validasi gagal karena karakter bukan digit 0–9 | Ditandai tanda seru merah ErrorProvider | **Berhasil** |
| 5 | Angkatan < 2015 | Validasi gagal dengan pesan batas minimal tahun 2015 | Ditandai tanda seru merah ErrorProvider | **Berhasil** |
| 6 | Angkatan > tahun sekarang | Validasi gagal karena melebihi tahun berjalan | Ditandai tanda seru merah ErrorProvider | **Berhasil** |
| 7 | IPK < 0 atau IPK > 4 | Validasi gagal dengan batas nilai 0,00 s.d. 4,00 | Ditandai tanda seru merah ErrorProvider | **Berhasil** |
| 8 | Simpan data valid (IPK koma: `3,45`) | Data masuk ke `lstMahasiswa`, formulir dibersihkan, status diperbarui | Data tersimpan dengan format 2 desimal | **Berhasil** |
| 9 | Simpan data valid (IPK titik: `3.8`) | Diterima dan diformat otomatis menjadi 2 desimal | Data tersimpan dan ditampilkan dengan benar | **Berhasil** |
| 10 | Simpan NIM duplikat | Validasi gagal dengan pesan "NIM sudah terdaftar." | Duplikasi dicegah, data dalam daftar tetap | **Berhasil** |
| 11 | Tombol Bersihkan | Mengosongkan form isian dan menghapus ikon ErrorProvider | Form bersih, data di daftar tetap utuh | **Berhasil** |
| 12 | Ekspor saat daftar kosong | Menampilkan peringatan bahwa belum ada data | Pesan peringatan tampil tanpa membuat file kosong | **Berhasil** |
| 13 | Ekspor data ke CSV | Menyimpan data mahasiswa ke file `data-mahasiswa.csv` lengkap dengan header kolom | File berhasil ditulis dengan format CSV standar | **Berhasil** |
| 14 | Penanganan error file terkunci | Menangkap `IOException` dengan MessageBox informatif jika file sedang dibuka oleh program lain | Kesalahan ditangani aman menggunakan `Try...Catch` | **Berhasil** |

---

## 5. Ringkasan Fitur yang Selesai

- [x] Konfigurasi proyek .NET 10 dengan `Option Strict On`.
- [x] Form Utama (`FrmUtama`) dengan navigasi modal (`ShowDialog()`).
- [x] Form Uji Konversi (`FrmUjiKonversi`) dengan perbandingan lengkap 5 metode konversi dan error handling.
- [x] Modul Validasi (`ModValidasi`) dengan fungsi `Kosong`, `SemuaDigit`, dan `CobaDesimal`.
- [x] Form Pendaftaran Mahasiswa (`FrmPendaftaran`) dengan tata letak rapi, `ErrorProvider`, dan batasan panjang teks (`MaxLength`).
- [x] Event `Validating` pada kontrol NIM untuk validasi real-time saat fokus berpindah.
- [x] Pencegahan duplikasi NIM menggunakan koleksi in-memory `List(Of String)`.
- [x] Fitur ekspor file CSV dengan header, escaping karakter khusus, dan penanganan resource otomatis melalui blok `Using`.
- [x] Komentar kode dalam bahasa Indonesia yang natural, informatif, dan sesuai standar tugas mahasiswa.
- [x] Seluruh 8 screenshot tangkapan layar pengujian asli tersedia di folder `screenshots/`.

---

## 6. Daftar Kendala

Tidak ada kendala yang belum terselesaikan. Seluruh komponen proyek, form designer, logika validasi, error handling, dan ekspor CSV telah teruji 100% dan siap digunakan di Visual Studio.

