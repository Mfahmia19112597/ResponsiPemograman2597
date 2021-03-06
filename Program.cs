﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2597
{
    
    class Program
    {
        static void Main(string[] args)
        {
        
            Karyawan krywn = new Karyawan(01, 19112597, "Paijo", 500000);
            Karyawan krywn2 = new Karyawan(02, 19112597, "Jono", 1000);


            Console.WriteLine("No \tNIK \t \t  Nama \t  Gaji bulanan");
            Console.WriteLine("--------------------------------------");
            krywn.showKaryawan();
            krywn2.showKaryawan();

            Console.WriteLine("\n\n Horeee naik gaji nih 10% \n\n");

            Console.WriteLine("No \tNIK \t \t  Nama \t  Gaji bulanan");
            Console.WriteLine("--------------------------------------");
            krywn.naikGaji();
            krywn2.naikGaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int No { get; set; }
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }
        public Karyawan(int no ,int nik, string nama, int gaji )
        {
            this.No = no;
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajiBulanan = 0;
            }
            else
            {
                this.gajiBulanan = gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0}\t{01}\t  {2}\t  {3}", No , nik, nama, gajiBulanan);
        }

        public void naikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * gajiBulanan;
            gajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0}\t{1}\t  {2}\t  {3}", No , nik, nama, gajiBulanan);
        }
    }
}