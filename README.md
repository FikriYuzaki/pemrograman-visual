# 🖥️ Pemrograman Visual

[![D3 Teknik Informatika USU](https://img.shields.io/badge/Prodi-D3_Teknik_Informatika_USU-006633?style=for-the-badge&logo=academic-cap&logoColor=white)](https://usu.ac.id)
[![Mata Kuliah](https://img.shields.io/badge/Matkul-Pemrograman_Visual-8A2BE2?style=for-the-badge)](#)
[![IDE](https://img.shields.io/badge/IDE-Visual_Studio_2022-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)
[![Language](https://img.shields.io/badge/Language-Visual_Basic_.NET-5C2D91?style=for-the-badge&logo=dotnet&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/visual-basic/)

Selamat datang di repositori catatan dan dokumentasi praktikum **Pemrograman Visual**. Repositori ini mencatat perkembangan belajar, materi perkuliahan, serta penyelesaian tugas praktikum mata kuliah Pemrograman Visual pada Program Studi **D3 Teknik Informatika, Universitas Sumatera Utara (USU)**.

---

## 📌 Identitas Praktikan

| Informasi | Detail |
| :--- | :--- |
| **Nama Mahasiswa** | Fikri |
| **Repositori Utama** | [FikriYuzaki/pemrograman-visual](https://github.com/FikriYuzaki/pemrograman-visual) |
| **Program Studi** | D3 Teknik Informatika |
| **Fakultas / Kampus** | Vokasi / Universitas Sumatera Utara |
| **Tahun Ajaran** | 2024 / 2025 |

---

## 📖 Daftar Isi Praktikum

- [📘 Pertemuan 1 - Pengenalan Visual Programming](#-pertemuan-1---pengenalan-visual-programming)
  - [Apa itu Visual Programming?](#-apa-itu-visual-programming)
  - [Karakteristik Utama](#-karakteristik-utama-pemrograman-visual)
  - [Manfaat & Keterbatasan](#-manfaat--keterbatasan)
  - [Platform Populer](#️-platform-pemrograman-visual-yang-populer)
  - [Software & Panduan Instalasi](#-lingkungan-kerja--software-praktikum)
- [📙 Pertemuan 2 - Komponen Visual & Event Handling](#-pertemuan-2---komponen-visual--event-handling)
  - [Konsep Dasar Form & Komponen](#-konsep-dasar-komponen-visual--form)
  - [Event & Event-Driven Programming](#-event--event-driven-programming)
  - [Komponen Utama yang Digunakan](#-komponen-utama-yang-digunakan)
  - [Implementasi Kode Program (`Form1.vb`)](#-implementasi-kode-program-form1vb)
  - [Penjelasan Logika & Sintaksis](#-penjelasan-logika--sintaksis)
  - [Alur Pengujian Aplikasi](#-alur-pengujian-aplikasi)
- [📕 Pertemuan 3 - Operator dan Percabangan](#-pertemuan-3---operator-dan-percabangan)
  - [Konsep Operator & Struktur Percabangan](#-konsep-operator--struktur-percabangan)
  - [Validasi Input & KeyPress Event](#-validasi-input--keypress-event)
  - [Implementasi Kode Program (`Form1.vb`)](#-implementasi-kode-program-pertemuan-3-form1vb)
  - [Penjelasan Logika Percabangan](#-penjelasan-logika-percabangan)
  - [Alur Pengujian Aplikasi Pertemuan 3](#-alur-pengujian-aplikasi-pertemuan-3)
- [📗 Pertemuan 4 - Struktur Perulangan (Looping)](#-pertemuan-4---struktur-perulangan-looping)
  - [Konsep Dasar Struktur Perulangan](#-konsep-dasar-struktur-perulangan)
  - [Komponen Visual yang Digunakan](#-komponen-visual-yang-digunakan-pertemuan-4)
  - [Validasi Input & KeyPress Event](#-validasi-input--keypress-event-pertemuan-4)
  - [Implementasi Kode Program (`frmPerulangan.vb`)](#-implementasi-kode-program-frmperulanganvb)
  - [Penjelasan Logika Perulangan For...Next & Step](#-penjelasan-logika-perulangan-fornext--step)
  - [Alur Pengujian Aplikasi Pertemuan 4](#-alur-pengujian-aplikasi-pertemuan-4)

---

# 📘 Pertemuan 1 - Pengenalan Visual Programming

## 💡 Apa itu Visual Programming?

**Pemrograman Visual (*Visual Programming*)** adalah paradigma pengembangan perangkat lunak yang memungkinkan pemrogram membuat aplikasi menggunakan elemen grafis, blok logika, serta antarmuka visual dibanding sekadar menulis sintaksis kode berbasis teks secara manual.

Dengan pendekatan ini, struktur program, tata letak antarmuka (*UI*), dan aliran logika dapat dirancang secara intuitif melalui manipulasi langsung (*direct manipulation*) pada kanvas desain.

---

## ⚙️ Karakteristik Utama Pemrograman Visual

1. **Abstraksi Berbasis Grafis**  
   Logika dan aliran eksekusi program diwakili oleh komponen visual, diagram alir, atau blok pembangun yang saling terhubung.
   
2. **Antarmuka Drag-and-Drop**  
   Elemen antarmuka pengguna (*User Interface*) seperti tombol, tabel, teks input, dan kontrol lainnya ditempatkan ke dalam form dengan cara digeser dan dilepas (*drag-and-drop*).

3. **Prinsip WYSIWYG (*What You See Is What You Get*)**  
   Tampilan aplikasi saat dirancang pada *designer window* akan sama persis dengan hasil akhir saat aplikasi dijalankan.

4. **Arsitektur Berorientasi Kejadian (*Event-Driven*)**  
   Alur kerja aplikasi berpusat pada aksi atau kejadian (*event*) yang dilakukan pengguna, seperti dikliknya tombol, pergerakan mouse, atau penekanan tombol keyboard.

---

## 🎯 Manfaat & Keterbatasan

### Keunggulan
* **Kemudahan Pembelajaran**: Mempercepat pemahaman alur pemrograman bagi pemula tanpa terhambat oleh kesalahan sintaksis (*syntax error*).
* **Pengembangan Cepat (*Rapid Application Development*)**: Mempercepat pembuatan prototipe dan antarmuka aplikasi desktop secara visual.
* **Struktur Tervisualisasi**: Memudahkan pelacakan logika dan tata letak komponen secara langsung.
* **Meminimalisir Kesalahan Penulisan**: Mengurangi risiko *typo* pada nama variabel atau fungsi bawaan antarmuka.

### Keterbatasan
* **Fleksibilitas Terbatas**: Kurang fleksibel jika dibandingkan dengan pemrograman teks *low-level* untuk algoritma yang sangat kompleks.
* **Performa & Overhead**: Beberapa platform visual memerlukan *runtime environment* yang membutuhkan konsumsi memori lebih besar.
* **Skalabilitas**: Kurang efisien apabila digunakan untuk membangun proyek sistem berskala sangat besar (*enterprise level*).

---

## 🛠️ Platform Pemrograman Visual yang Populer

| Platform / Tool | Lingkup Penggunaan & Keterangan |
| :--- | :--- |
| **Scratch** | Lingkungan belajar berbasis blok visual yang ideal untuk pemula dan pemahaman logika dasar. |
| **MIT App Inventor** | Platform pembuatan aplikasi mobile (Android/iOS) menggunakan blok logika visual berbasis web. |
| **Microsoft Visual Basic (.NET)** | Lingkungan IDE profesional berbasis komponen GUI visual yang digunakan dalam perkuliahan. |
| **JavaFX / Scene Builder** | Framework perancangan GUI interaktif berbasis drag-and-drop untuk ekosistem Java. |
| **Node-RED** | Tools visual programming berorientasi *flow-based* untuk integrasi perangkat IoT dan API. |

---

## 💻 Lingkungan Kerja & Software Praktikum

Dalam kegiatan praktikum perkuliahan **Pemrograman Visual**, software utama yang digunakan adalah **Microsoft Visual Studio** dengan bahasa **Visual Basic (.NET Framework)**. 

Visual Studio menyediakan *Form Designer* berbasis visual yang memudahkan perancangan antarmuka aplikasi Windows Desktop berbasis *Event-Driven*.

---

## 📥 Panduan Instalasi Visual Studio

Berikut adalah langkah-langkah pemasangan perangkat lunak untuk praktikum:

1. **Unduh Installer Official**  
   Kunjungi situs resmi Microsoft Visual Studio di [visualstudio.microsoft.com](https://visualstudio.microsoft.com/) dan pilih tombol **Download Visual Studio**.

2. **Pilih Edisi Community**  
   Pilih varian **Visual Studio Community** (disarankan versi **2022** atau edisi stabil terbaru). Edisi ini bersifat gratis untuk penggunaan edukasi dan individu.

3. **Konfigurasi Workload (.NET Desktop Development)**  
   Setelah *Visual Studio Installer* terbuka, centang pada bagian **.NET Desktop Development** (Pengembangan Desktop .NET). Workload ini mencakup library Visual Basic, Windows Forms Designer, dan .NET SDK.

4. **Penyesuaian Component**  
   Pada tab *Installation Details*, pastikan opsi penunjang seperti *.NET Framework Development Tools* dan *Visual Basic Core* sudah tercentang.

5. **Proses Pemasangan**  
   Klik **Install / Modify** dan berikan izin (*administrator allowance*). Tunggu hingga proses pengunduhan serta pemasangan selesai hingga muncul status **"All installations are up to date"**.

6. **Uji Coba Pertama**  
   Buka Visual Studio, pilih **Create a new project**, lalu cari template **Windows Forms App (.NET Framework)** menggunakan bahasa **Visual Basic**.

---

# 📙 Pertemuan 2 - Komponen Visual & Event Handling

Dokumentasi praktikum **Pertemuan 2** berfokus pada pengenalan **Komponen Visual (Controls)**, manipulasi **Properties**, serta penerapan **Event Handling** dasar menggunakan bahasa **Visual Basic (.NET Framework)** di Microsoft Visual Studio.

---

## 💡 Konsep Dasar Komponen Visual & Form

Pada lingkungan **Windows Forms (WinForms)**, antarmuka pengguna dibangun di atas sebuah jendela yang disebut **Form** dengan menempatkan berbagai komponen GUI visual di atasnya:

1. **Form (`System.Windows.Forms.Form`)**  
   Kontainer utama tempat seluruh elemen antarmuka (*UI*) diletakkan dan berinteraksi.
2. **Komponen Visual (*Controls*)**  
   Elemen grafis interaktif seperti tombol, kotak input teks, label, dan checkbox yang digunakan pengguna untuk berinteraksi dengan aplikasi.
3. **Properties (Atribut)**  
   Karakteristik dari sebuah komponen yang menentukan nama variabel, tampilan visual, posisi, hingga perilakunya. Properti dapat diatur melalui jendela **Properties (F4)** saat *design time* maupun secara terprogram (*run time*).

---

## ⚙️ Event & Event-Driven Programming

Aplikasi GUI modern bekerja berbasis **Event-Driven Programming**, di mana alur program dijalankan saat terjadi peristiwa (*event*) tertentu:

* **Event**: Aksi yang dihasilkan dari interaksi pengguna (misalnya mengklik tombol `Click`, mengubah isi teks `TextChanged`) atau dari sistem (misalnya saat form dimuat `Load`).
* **Event Handler**: Sub-prosedur khusus dalam kode yang merespons event tersebut. Dalam Visual Basic, event handler ditandai dengan sintaks `Handles <NamaKomponen>.<NamaEvent>`.

---

## 🛠️ Komponen Utama yang Digunakan

Pada praktikum Pertemuan 2 ini, digunakan 3 jenis komponen dasar Windows Forms:

| Komponen | Nama Variabel (*Design Name*) | Fungsi & Peranan |
| :--- | :--- | :--- |
| **Label** | `Label1`, `Label2`, `Label3` | Menampilkan teks statis sebagai petunjuk input (*Nama*, *NIM*, *KOM*). |
| **TextBox** | `nama`, `nim`, `kom` | Kotak input interaktif untuk menerima data teks dari pengguna. |
| **Button** | `tampilkan`, `hapus`, `keluar` | Tombol aksi untuk memicu fungsi eksekusi program (*Tampilkan*, *Hapus*, *Keluar*). |

---

## 📝 Implementasi Kode Program (`Form1.vb`)

Berikut adalah kode sumber (*source code*) lengkap yang diimplementasikan pada `Form1.vb`:

```vb
Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tampilkan_Click(sender As Object, e As EventArgs) Handles tampilkan.Click
        MessageBox.Show("Hello!" & vbCrLf &
            "Nama: " & nama.Text & vbCrLf &
            "NIM: " & nim.Text & vbCrLf &
            "KOM : " & kom.Text
        )
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        nama.Clear()
        nim.Clear()
        kom.Clear()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Me.Close()
    End Sub
End Class
```

---

## 🔍 Penjelasan Logika & Sintaksis

### 1. Menampilkan Pesan (`tampilkan_Click`)
```vb
MessageBox.Show("Hello!" & vbCrLf &
    "Nama: " & nama.Text & vbCrLf &
    "NIM: " & nim.Text & vbCrLf &
    "KOM : " & kom.Text
)
```
* **`MessageBox.Show()`**: Menampilkan kotak dialog modal (*pop-up*) berisi pesan konfirmasi/informasi.
* **Operator `&`**: Digunakan untuk menggabungkan (*string concatenation*) antara teks string statis dengan nilai input dari properti `.Text` komponen `TextBox`.
* **`vbCrLf`**: Konstanta bawaan Visual Basic (*Carriage Return + Line Feed*) untuk membuat baris baru pada string.

### 2. Mengosongkan Input (`hapus_Click`)
```vb
nama.Clear()
nim.Clear()
kom.Clear()
```
* **`nama.Clear()`**: Method bawaan pada kontrol `TextBox` yang berfungsi untuk menghapus seluruh teks di dalam kotak input `nama`, `nim`, dan `kom` secara bersamaan.

### 3. Menutup Form (`keluar_Click`)
```vb
Me.Close()
```
* **`Me.Close()`**: Keyword `Me` merepresentasikan instance form aktif saat ini (`Form1`), dan method `.Close()` dipanggil untuk menutup form serta menghentikan jalannya aplikasi.

---

## 🚀 Alur Pengujian Aplikasi

1. **Jalankan Aplikasi**: Tekan `F5` atau tombol **Start** pada Visual Studio.
2. **Input Data**: Isikan data pada kotak teks `Nama`, `NIM`, dan `KOM`.
3. **Uji Tombol Tampilkan**: Klik tombol **Tampilkan**, aplikasi akan mengeluarkan *Message Box* dialog yang menampilkan data gabungan yang diinputkan.
4. **Uji Tombol Hapus**: Klik tombol **Hapus**, seluruh isian pada ketiga `TextBox` akan dibersihkan (*cleared*).
5. **Uji Tombol Keluar**: Klik tombol **Keluar**, form akan ditutup secara aman.

---

# 📕 Pertemuan 3 - Operator dan Percabangan

## 💡 Konsep Operator & Struktur Percabangan

Pada pertemuan ini, dipelajari mengenai penggunaan **operator** (aritmatika, perbandingan, logika) dan **struktur kendali percabangan** (*Conditional Statements*) menggunakan `If...Then...ElseIf...Else...End If` dalam Visual Basic .NET.

Percabangan memungkinkan program mengambil keputusan dan mengeksekusi blok instruksi yang berbeda sesuai dengan kondisi atau kriteria nilai yang terpenuhi.

---

## 🛡️ Validasi Input & KeyPress Event

Untuk menjaga integritas data input:
- Event `txtNilai_KeyPress` digunakan agar pengguna hanya dapat memasukkan karakter angka (*digits*) dan tombol kontrol (seperti Backspace).
- `Integer.TryParse` digunakan untuk memvalidasi apakah teks input benar-benar numerik.
- Pengecekan rentang nilai (*range validation*) memastikan nilai yang dimasukkan berada pada batas **0 - 100**.

---

## 💻 Implementasi Kode Program Pertemuan 3 (`Form1.vb`)

```vb
Imports System.Net.Mime.MediaTypeNames
Imports System.Drawing

Public Class Form1
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilai As Integer

        If Not Integer.TryParse(txtNilai.Text, nilai) Then
            MessageBox.Show("Masukan dalam bentuk angka")
            txtNilai.Focus()
            Return
        End If

        If nilai < 0 OrElse nilai > 100 Then
            MessageBox.Show("Masukan Nilai 0 sampai 100")
            txtNilai.Focus()
            Return
        End If

        If nilai <= 50 Then
            picImage.Image = System.Drawing.Image.FromFile("Assets\tsukasa-dance.gif")
        ElseIf nilai <= 70 Then
            picImage.Image = System.Drawing.Image.FromFile("Assets\img1.png")
        Else
            picImage.Image = System.Drawing.Image.FromFile("Assets\img2.png")
        End If
    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub picImage_Click(sender As Object, e As EventArgs) Handles picImage.Click

    End Sub
End Class
```

---

## 🔍 Penjelasan Logika Percabangan

| Rentang Nilai | Kondisi Percabangan | Output Gambar / Aksi |
| :--- | :--- | :--- |
| `Nilai < 0` atau `Nilai > 100` | `nilai < 0 OrElse nilai > 100` | Menampilkan MessageBox peringatan `Masukan Nilai 0 sampai 100` |
| `0 <= Nilai <= 50` | `nilai <= 50` | Menampilkan animasi `Assets\tsukasa-dance.gif` pada `PictureBox` |
| `51 <= Nilai <= 70` | `ElseIf nilai <= 70` | Menampilkan gambar `Assets\img1.png` pada `PictureBox` |
| `71 <= Nilai <= 100` | `Else` | Menampilkan gambar `Assets\img2.png` pada `PictureBox` |

---

## 🚀 Alur Pengujian Aplikasi Pertemuan 3

1. **Jalankan Aplikasi**: Tekan `F5` pada Visual Studio.
2. **Uji Validasi Karakter**: Coba ketik huruf atau simbol pada kolom input nilai; input selain angka akan dicegah secara otomatis.
3. **Uji Validasi Rentang**: Masukkan angka di luar rentang (misal `150`), klik tombol **Input**, sistem akan memunculkan dialog peringatan.
4. **Uji Rentang 0 - 50**: Masukkan angka `45`, gambar animasi Tsukasa dance akan ditampilkan pada `PictureBox`.
5. **Uji Rentang 51 - 70**: Masukkan angka `65`, gambar `img1.png` akan ditampilkan.
6. **Uji Rentang 71 - 100**: Masukkan angka `90`, gambar `img2.png` akan ditampilkan.

---

# 📗 Pertemuan 4 - Struktur Perulangan (Looping)

## 💡 Konsep Dasar Struktur Perulangan

Dalam pemrograman, **struktur kendali perulangan (*looping / iteration*)** digunakan untuk mengeksekusi sekumpulan instruksi atau blok kode secara berulang-ulang berdasarkan kondisi tertentu atau rentang pencacah (*counter*) yang telah ditentukan.

Pada Visual Basic .NET, beberapa struktur perulangan yang umum digunakan meliputi:
1. **`For...Next`**: Digunakan ketika jumlah iterasi atau perulangan sudah diketahui secara pasti (berdasarkan nilai awal, nilai akhir, dan interval kenaikan/penurunan *step*).
2. **`Do While / Do Until...Loop`**: Digunakan untuk perulangan dengan evaluasi kondisi di awal atau di akhir blok iterasi.
3. **`While...End While`**: Digunakan untuk mengeksekusi blok kode selama kondisi bernilai benar (*True*).

Pada praktikum Pertemuan 4 ini, fokus utama pembelajaran adalah penerapan **`For...Next` dengan interval `Step` negatif (perulangan mundur)** serta integrasi data visual dengan kontrol **`ListBox`**.

---

## 🛠️ Komponen Visual yang Digunakan (Pertemuan 4)

Antarmuka form dirancang pada `frmPerulangan` menggunakan komponen-komponen Windows Forms berikut:

| Komponen | Nama Variabel (*Name*) | Teks / Properti | Fungsi & Peran |
| :--- | :--- | :--- | :--- |
| **Label** | `lblNilaiAwal` | `Nilai Awal :` | Label penunjuk untuk input batas awal perulangan. |
| **Label** | `lblNilaiAkhir` | `Nilai Akhir :` | Label penunjuk untuk input batas akhir perulangan. |
| **TextBox** | `txtNilaiAwal` | *(kosong)* | Kotak input teks untuk menerima nilai awal perulangan. |
| **TextBox** | `txtNilaiAkhir` | *(kosong)* | Kotak input teks untuk menerima nilai akhir perulangan. |
| **Button** | `btnInput` | `Input` | Tombol untuk memicu validasi dan mengeksekusi algoritma perulangan. |
| **ListBox** | `lstHasil` | *(kosong)* | Komponen daftar visual untuk menampilkan seluruh deret angka hasil iterasi. |

---

## 🛡️ Validasi Input & KeyPress Event (Pertemuan 4)

Sebelum perulangan diproses, program menerapkan dua lapis validasi untuk menjaga keabsahan data:

1. **Pencegahan Karakter Non-Angka (`KeyPress`)**:
   - Event `KeyPress` pada `txtNilaiAwal` dan `txtNilaiAkhir` memeriksa setiap tombol yang ditekan. Karakter selain digit angka atau tombol kontrol (seperti *Backspace*) akan diabaikan (`e.Handled = True`).
   ```vb
   If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
       e.Handled = True
   End If
   ```

2. **Validasi Parsing Numerik (`Integer.TryParse`)**:
   - Memastikan teks yang dimasukkan dapat dikonversi ke tipe bilangan bulat (`Integer`).
   - Apabila input kosong atau tidak valid, program menampilkan kotak dialog peringatan `"Masukkan dalam bentuk angka"`, mengarahkan fokus ke kontrol terkait dengan `.Focus()`, lalu menghentikan prosedur menggunakan perintah `Return`.

---

## 💻 Implementasi Kode Program (`frmPerulangan.vb`)

Berikut adalah kode sumber lengkap yang diimplementasikan pada `frmPerulangan.vb`:

```vb
Public Class frmPerulangan
    Private Sub txtNilaiAwal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilaiAwal.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNilaiAkhir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilaiAkhir.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilaiAwal As Integer
        Dim nilaiAkhir As Integer

        If Not Integer.TryParse(txtNilaiAwal.Text, nilaiAwal) Then
            MessageBox.Show("Masukkan dalam bentuk angka")
            txtNilaiAwal.Focus()
            Return
        End If

        If Not Integer.TryParse(txtNilaiAkhir.Text, nilaiAkhir) Then
            MessageBox.Show("Masukkan dalam bentuk angka")
            txtNilaiAkhir.Focus()
            Return
        End If

        lstHasil.Items.Clear()

        For i As Integer = nilaiAwal To nilaiAkhir Step -2
            lstHasil.Items.Add(i)
        Next

    End Sub

End Class
```

---

## 🔍 Penjelasan Logika Perulangan For...Next & Step

### 1. Mengosongkan ListBox (`lstHasil.Items.Clear()`)
```vb
lstHasil.Items.Clear()
```
Sebelum memulai perulangan baru, method `.Clear()` pada koleksi `Items` dipanggil. Tujuannya adalah menghapus hasil perhitungan sebelumnya agar data pada `ListBox` tidak menumpuk saat tombol **Input** diklik berulang kali.

### 2. Struktur `For...Next` dengan `Step` Negatif
```vb
For i As Integer = nilaiAwal To nilaiAkhir Step -2
    lstHasil.Items.Add(i)
Next
```
* **`For i As Integer = nilaiAwal`**: Mendeklarasikan variabel pencacah iterasi `i` bertipe data `Integer` yang dimulai dari nilai `nilaiAwal`.
* **`To nilaiAkhir`**: Menentukan batas akhir perulangan.
* **`Step -2`**: Menentukan interval perubahan nilai pencacah di setiap siklus:
  - Tanpa parameter `Step`, nilai pencacah bertambah `+1` secara default (*increment*).
  - Dengan `Step -2`, nilai pencacah akan berkurang 2 di setiap putaran iterasi (*decrementing loop*).
  - **Contoh Kasus**: Jika `nilaiAwal = 20` dan `nilaiAkhir = 10`, maka urutan nilai `i` yang dihasilkan adalah:
    $$\text{20, 18, 16, 14, 12, 10}$$
* **`lstHasil.Items.Add(i)`**: Menambahkan nilai variabel `i` saat iterasi berjalan ke dalam daftar tampilan komponen `ListBox`.
* **`Next`**: Melanjutkan ke iterasi perulangan berikutnya atau keluar jika kondisi batas akhir telah terlampaui.

---

## 🚀 Alur Pengujian Aplikasi Pertemuan 4

1. **Jalankan Aplikasi**: Tekan `F5` atau klik tombol **Start** pada Visual Studio.
2. **Uji Validasi Input Teks**:
   - Coba ketikkan huruf atau simbol pada kotak `Nilai Awal` atau `Nilai Akhir`. Sistem akan menolak karakter selain angka secara otomatis.
3. **Uji Validasi Input Kosong**:
   - Biarkan salah satu kotak teks kosong lalu klik tombol **Input**. Muncul kotak dialog peringatan: `"Masukkan dalam bentuk angka"`.
4. **Uji Perulangan Mundur (Step -2)**:
   - Masukkan `Nilai Awal: 20`
   - Masukkan `Nilai Akhir: 10`
   - Klik tombol **Input**.
   - Pada komponen `lstHasil` (ListBox) akan muncul deret angka menurun:
     ```text
     20
     18
     16
     14
     12
     10
     ```
5. **Uji Reset / Pembersihan ListBox**:
   - Ubah nilai input, misalnya `Nilai Awal: 14` dan `Nilai Akhir: 4`.
   - Klik tombol **Input**, amati bahwa data lama (20 s/d 10) dibersihkan secara otomatis dan digantikan oleh deret angka baru (14, 12, 10, 8, 6, 4).

---

<div align="center">
  <p>📚 <i>Repositori ini akan terus diperbarui secara berkala sesuai dengan perkembangan materi perkuliahan Pemrograman Visual — D3 Teknik Informatika USU.</i></p>
</div>

