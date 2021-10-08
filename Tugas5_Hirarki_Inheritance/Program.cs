using System;
namespace Tugas5_Hirarki_Inheritance
{
    class Polymorphism
    {
        static void Main()
        {
            var Komisi = new Komisi("Sue", "Jones", "222-22-2222", 10000.00M, .06M);
            var Pegawai = new Pegawai("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);
            Console.WriteLine("Memanggil Komisi ToString and Menghasilkan methods " +
                "dengan referensi kelas dasar ke objek kelas dasar");
            Console.WriteLine(Komisi.ToString());
            Console.WriteLine($"Menghasilkan: {Komisi.Menghasilkan()}\n");
            //aktifkan ToString dan Earnings pada objek kelas turunan
            //menggunakan kelas dasar
            Console.WriteLine("Memanggil KomisiPegawai ToString and Menghasilkan methods " +
                "dengan referensi kelas turunan");
            Console.WriteLine(Pegawai.ToString());
            Console.WriteLine($"Menghasilkan: {Pegawai.Menghasilkan()}\n");
            Komisi karyawan = Pegawai;
            Console.WriteLine(karyawan.ToString());
            Console.WriteLine($"Menghasilkan: {Pegawai.Menghasilkan()}\n");
        }
    }
}
