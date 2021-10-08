using System;
namespace Tanpa_Inheritance
{
    class Program
    {
        static void Main(String[] args)
        {
            var pegawai = new KomisiPegawai("Bob", "Lewis", 
                "333-33-3333", 5000.00M, .04M, 300.00M);
            //menampilkan data KomisiPegawai
            Console.WriteLine("Informasi karyawan diperoleh dengan properti dan metode: \n");
            Console.WriteLine($"Nama Depan: {pegawai.NamaDepan}");
            Console.WriteLine($"Nama Terakhir: {pegawai.NamaTerakhir}");
            Console.WriteLine($"No KTP: {pegawai.NOKTP}");
            Console.WriteLine($"Laba: {pegawai.LabaKotor:C}");
            Console.WriteLine($"Rate Komisi: {pegawai.RateKomisi:F2}");
            Console.WriteLine($"Menghasilkan: {pegawai.Menghasilkan():C}");
            Console.WriteLine($"Gaji Pokok adalah {pegawai.GajiPokok:C}");
            pegawai.GajiPokok = 1000.00M; // mengatur gaji
            Console.WriteLine("\nMemperbarui Informasi Pegawai diperoleh dari ToString:\n");
            Console.Write(pegawai);
            Console.WriteLine($"Menghasilkan: {pegawai.Menghasilkan():C}");
        }
    }
}