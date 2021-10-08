using System;
namespace Tanpa_Inheritance
{
    public class KomisiPegawai
    {
        public string NamaDepan { get; }
        public string NamaTerakhir { get; }
        public string NOKTP { get; }
        private decimal labaKotor;
        private decimal rateKomisi; // persentase komisi
        private decimal gajiPokok; // gaji pokok per minggu

        //constructor
        public KomisiPegawai(string namaDepan, string namaTerakhir, string noKTP,
            decimal labaKotor, decimal rateKomisi, decimal gajiPokok)
        {
            NamaDepan = namaDepan;
            NamaTerakhir = namaTerakhir;
            NOKTP = noKTP;
            LabaKotor = labaKotor;
            RateKomisi = rateKomisi;
            GajiPokok = gajiPokok;
        }
        public decimal LabaKotor
        {
            get
            {
                return labaKotor;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(LabaKotor)} harus >= 0");
                }
                labaKotor = value;
            }
        }
        public decimal RateKomisi
        {
            get
            {
                return rateKomisi;
            }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(rateKomisi)} harus > 0 dan < 1");
                }
                rateKomisi = value;
            }
        }
        public decimal GajiPokok
        {
            get
            {
                return gajiPokok;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,
                        $"{nameof(GajiPokok)} harus >= 0");
                }
                gajiPokok = value;
            }
        }
        //menghitung pendapatan
        public decimal Menghasilkan() =>
            gajiPokok + labaKotor * rateKomisi;
        public override string ToString() =>
        $"Komisi Pegawai:  { NamaDepan } { NamaTerakhir}\n" +
        $"Nomer KTP: {NOKTP}\n" +
        $"Laba Kotor: {labaKotor:C}\n" +
        $"Rate Komisi: {rateKomisi:F2}\n" +
        $"Gaji Pokok: {gajiPokok:F2}\n";
    }
}