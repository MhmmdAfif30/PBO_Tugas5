using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas5_Interface
{
    public class GajiKaryawan : IPayable
    {
        private decimal gajiMingguan;
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NOKTP { get; }
        public GajiKaryawan(string namaDepan, string namaBelakang, string noKTP,
            decimal gajiMingguan)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NOKTP = noKTP;
            GajiMingguan = gajiMingguan;
        }
        public decimal GajiMingguan
        {
            get
            {
                return gajiMingguan;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(GajiMingguan)} harus >= 0");
                }
                gajiMingguan = value;
            }
        }
        public decimal JumlahPembayaran() => GajiMingguan;
        public override string ToString() =>
            $"Gaji Karyawan: {NamaDepan} {NamaBelakang}\n" +
            $"No KTP: {NOKTP}\n" +
            $"Gaji Per Minggu: {GajiMingguan:C}";
    }
}
