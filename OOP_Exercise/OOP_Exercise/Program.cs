using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{

    sealed class OperasiBilanganAbsCetak 
    {
        private void cetakSemua(OperasiBilanganAbs[] OB, double a, double b)
        {
            
            for(int i = 0; i < OB.Length; i++)
            {
                OB[i].set_a(a);
                OB[i].set_b(b);
                OB[i].set_c();
                OB[i].get_a();
                OB[i].get_b();
                OB[i].get_c();
                OB[i].tampil();
            }
        }
        

        static void Main(String[] args)
        {
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            
            try
            {
                double aa = Convert.ToDouble(a);
                double bb = Convert.ToDouble(b);
                Console.WriteLine();
                OperasiBilanganAbs[] operasi = new OperasiBilanganAbs[4];
                operasi[0] = new OperasiPenjumlahan();
                operasi[1] = new OperasiPengurangan();
                operasi[2] = new OperasiPerkalian();
                operasi[3] = new OperasiPembagian();

                OperasiBilanganAbsCetak cetak = new OperasiBilanganAbsCetak();
                cetak.cetakSemua(operasi, aa, bb);
                
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Kesalahan pada masukan.");
            }

            finally
            {
                Console.WriteLine("Program Selesai Dijalankan.");
            }
            
        }
    }
}
