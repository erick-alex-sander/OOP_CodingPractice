using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    public abstract class OperasiBilanganAbs
    {
        protected double a, b, c;
        protected internal abstract void set_a(double a);
        protected internal abstract void set_b(double b);
        protected internal abstract void set_c();
        protected internal abstract double get_a();
        protected internal abstract double get_b();
        protected internal abstract double get_c();
        protected internal abstract void tampil();
    }

    public class OperasiPenjumlahan : OperasiBilanganAbs
    {
        protected internal override void set_a(double a)
        {
            this.a = a;
        }

        protected internal override void set_b(double b)
        {
            this.b = b;
        }

        protected internal override void set_c()
        {
            c = a + b;
        }

        protected internal override double get_a()
        {
            return a;
        }

        protected internal override double get_b()
        {
            return b;
        }

        protected internal override double get_c()
        {
            return c;
        }

        protected internal override void tampil()
        {
            Console.WriteLine("Angka 1 : " + get_a());
            Console.WriteLine("Angka 2 : " + get_b());
            Console.WriteLine("Hasil Penjumlahan : " + get_c());
            Console.WriteLine("");
        }
        
       
    }

    public class OperasiPengurangan : OperasiBilanganAbs
    {
        protected internal override void set_a(double a)
        {
            this.a = a;
        }

        protected internal override void set_b(double b)
        {
            this.b = b;
        }

        protected internal override void set_c()
        {
            c = a - b;
        }

        protected internal override double get_a()
        {
            return a;
        }

        protected internal override double get_b()
        {
            return b;
        }

        protected internal override double get_c()
        {
            return c;
        }

        protected internal override void tampil()
        {
            Console.WriteLine("Angka 1 : " + get_a());
            Console.WriteLine("Angka 2 : " + get_b());
            Console.WriteLine("Hasil Pengurangan : " + get_c());
            Console.WriteLine("");
        }
    }

    public class OperasiPerkalian : OperasiBilanganAbs
    {
        protected internal override void set_a(double a)
        {
            this.a = a;
        }

        protected internal override void set_b(double b)
        {
            this.b = b;
        }

        protected internal override void set_c()
        {
            c = a * b;
        }

        protected internal override double get_a()
        {
            return a;
        }

        protected internal override double get_b()
        {
            return b;
        }

        protected internal override double get_c()
        {
            return c;
        }

        protected internal override void tampil()
        {
            Console.WriteLine("Angka 1 : " + get_a());
            Console.WriteLine("Angka 2 : " + get_b());
            Console.WriteLine("Hasil Perkalian : " + get_c());
            Console.WriteLine("");
        }
    }

    public class OperasiPembagian : OperasiBilanganAbs
    {
        protected internal override void set_a(double a)
        {
            this.a = a;
        }

        protected internal override void set_b(double b)
        {
            this.b = b;
        }

        protected internal override void set_c()
        {
            c = a / b;
        }

        protected internal override double get_a()
        {
            return a;
        }

        protected internal override double get_b()
        {
            return b;
        }

        protected internal override double get_c()
        {
            return c;
        }

        protected internal override void tampil()
        {
            Console.WriteLine("Angka 1 : " + get_a());
            Console.WriteLine("Angka 2 : " + get_b());
            Console.WriteLine("Hasil Pembagian : " + get_c());
            Console.WriteLine("");
        }
    }

}