using System;
using System.Collections.Generic;
namespace Tugas5_Interface
{
    class Interface
    {
        static void Main()
        {
            var Pembayaran = new List<IPayable>()
            {
                new Nota("01234", "seat",2, 375.00M),
                new Nota("56789", "tire", 4, 79.95M),
                new GajiKaryawan("John", "Smith", "111-11-1111", 800.00M),
                new GajiKaryawan("Lisa", "Barnes", "888-88-8888", 1200.00M)
            };

            Console.Write("Nota dan Employees diproses dengan polymorphism");
            foreach (var payable in Pembayaran)
            {
                Console.WriteLine($"\n{payable}");
                Console.WriteLine($"Jatuh Tempo Pembayaran: " +
                    $"{payable.JumlahPembayaran():C}");
            }
        }
    }
}
