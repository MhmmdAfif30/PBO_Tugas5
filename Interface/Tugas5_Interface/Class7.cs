using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas5_Interface
{
    public class Nota : IPayable
    {
        public string NomorBagian { get; }
        public string DeskripsiBagian { get; }
        private int kuantitas;
        private decimal hargaBarang;

        //4 paramater constructor
        public Nota(string nomorBagian, string deskripsiBagian,
            int kuantitas, decimal hargaBarang)
        {
            NomorBagian = nomorBagian;
            DeskripsiBagian = deskripsiBagian;
            Kuantitas = kuantitas;
            HargaPerBarang = hargaBarang;
        }
        public int Kuantitas
        {
            get
            {
                return kuantitas;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Kuantitas)} harus >= 0");
                }
                kuantitas = value;
            }
        }
        public decimal HargaPerBarang
        {
            get
            {
                return hargaBarang;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(HargaPerBarang)} harus >= 0");
                }
                hargaBarang = value;
            }
        }
        public override string ToString() =>
            $"\nNota: \nNomor Bagian: {NomorBagian} ({DeskripsiBagian})\n" +
            $"Kuantitas: {Kuantitas}\nHarga Per Barang: {HargaPerBarang:C}";
        //metode yang diperlukan untuk melaksanakan kontrak dengan antarmuka Bayar
        public decimal JumlahPembayaran() => Kuantitas * HargaPerBarang;
    }
}
