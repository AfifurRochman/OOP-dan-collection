using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using Tugas_Lab_8.ClassAnak;
using Tugas_Lab_8.ClassInduk;

namespace Tugas_Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Anbstaction & Collection";

            // membuat objek untuk semua karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "343.321.532";
            karyawanTetap.Nama = "bambang";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "374.987.235";
            karyawanHarian.Nama = "kang agus";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerjam =11000;

            Sales sales = new Sales();
            sales.NIK = "098.243.342";
            sales.Nama = "abang";
            sales.JumlahPenjualan = 50;
            sales.Komisi = 60000;

            // objek class collectio
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3:NO}", noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
