using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas5_Interface
{
    public abstract class Pegawai : IPayable
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NOKTP { get; }

        //3 parameter constructor
        public Pegawai(string namaDepan, string namaBelakang, string noKTP)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NOKTP = noKTP;
        }
        //mengembalikan representasi string dari objek Karyawan, menggunakan properti
        public override string ToString() => $"{ NamaDepan } {NamaBelakang}\n" +
            $"NO KTP: {NOKTP}";

        //metode abstrak diganti oleh kelas turunan
        public abstract decimal Pendapatan();
        //menerapkan JumlahPembayaran di sini seluruh Karyawan
        //hierarki kelas untuk digunakan dalam aplikasi yang memproses Bayar
        public decimal JumlahPembayaran() => Pendapatan();
    }
}
