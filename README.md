File OperasiBilangan.cs :
	
	Class abstract OperasiBilanganAbs :
		protected double a,b,c
		method void set_a input double a
		method void set_b input double b
		method void set_c 
		method double get_a
		method double get_b
		method double get_c
		method void tampil

	class OperasiPenjumlahan extends OperasiBilanganAbs :
		method void set_a input double a
			this.a = a
		method void set_b input double b
			this.b = b
		method void set_c
			c = a + b 
		method double get_a
			return a
		method double get_b
			return b
		method double get_c
			return c
		method void tampil
			print("Angka 1 : " + get_a());
            		print("Angka 2 : " + get_b());
            		print("Hasil Penjumlahan : " + get_c());
            		print("");

	class OperasiPengurangan extends OperasiBilanganAbs :
		method void set_a input double a
			this.a = a
		method void set_b input double b
			this.b = b
		method void set_c
			c = a - b 
		method double get_a
			return a
		method double get_b
			return b
		method double get_c
			return c
		method void tampil
			print("Angka 1 : " + get_a());
            		print("Angka 2 : " + get_b());
            		print("Hasil Pengurangan: " + get_c());
            		print("");

	class OperasiPerkalian extends OperasiBilanganAbs :
		method void set_a input double a
			this.a = a
		method void set_b input double b
			this.b = b
		method void set_c
			c = a * b 
		method double get_a
			return a
		method double get_b
			return b
		method double get_c
			return c
		method void tampil
			print("Angka 1 : " + get_a());
            		print("Angka 2 : " + get_b());
            		print("Hasil Perkalian" + get_c());
            		print("");

	class OperasiPembagian extends OperasiBilanganAbs :
		method void set_a input double a
			this.a = a
		method void set_b input double b
			this.b = b
		method void set_c
			c = a / b 
		method double get_a
			return a
		method double get_b
			return b
		method double get_c
			return c
		method void tampil
			print("Angka 1 : " + get_a());
            		print("Angka 2 : " + get_b());
            		print("Hasil Pembagian" + get_c());
            		print("");

File Program.cs (Main) :

	final class OperasiBilanganAbsCetak :
		method cetakSemua input class OperasiBilanganAbs array, double a, double b
			for int i from zero until OperasiBilanganAbs length :
				call all method

	Main method :
		input double a, b

		try :
			define array object OperasiBilanganAbs length 4
			OperasiBilanganAbs[0] as OperasiPenjumlahan Polymorph
			OperasiBilanganAbs[1] as OperasiPengurangan Polymorph
			OperasiBilanganAbs[2] as OperasiPerkalian Polymorph
			OperasiBilanganAbs[3] as OperasiPembagian Polymorph

			define OperasiBilanganAbsCetak object as cetak
			call void cetakSemua from cetak with OperasiBilanganAbs, a, b as input.

		catch when input a or b is not number :
			print("Kesalahan pada masukan.")

		finally :
			print("Program Selesai Dijalankan")