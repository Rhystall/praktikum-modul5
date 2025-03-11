using System;

class Penjumlahan
{
    public static double JumlahTigaAngka<T>(T a, T b, T c) where T : struct, IConvertible
    {
        return Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c);
    }

    public static void Main(string[] args)
    {
        double angka1 = 22.0, angka2 = 11.0, angka3 = 10.0;
        Console.WriteLine("Hasil: " + JumlahTigaAngka(angka1, angka2, angka3));
    }
}
