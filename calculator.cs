class calculator
{
	static void main (string[] args)
	{
		int a = 10;
		int b = 6;
		
		console.WriteLine("Hasil penambahan : {0} + {1}", a, b, penambahan(a, b));
		console.WriteLine("Hasil penambahan : {0} - {1}", a, b, pengurangan(a, b ));
		
		console.WriteLine("\nTekan sembarang key untuk keluar");
		console.ReadKey();
	}
	
	static int Penambahan( int a,int b )
	{
		return a+b;
	}
	
	static int pengurangan(int a, int b)
	{
		return a-b;
	}
}

