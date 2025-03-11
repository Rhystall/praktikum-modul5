using System;
using System.Collections.Generic;

class Penjumlahan
{
    public static double JumlahTigaAngka<T>(T a, T b, T c) where T : struct, IConvertible
    {
        return Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c);
    }
}

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        double angka1 = 22.0, angka2 = 11.0, angka3 = 10.0;
        Console.WriteLine("Hasil: " + Penjumlahan.JumlahTigaAngka(angka1, angka2, angka3));

        // Menggunakan SimpleDataBase untuk menyimpan data
        SimpleDataBase<double> database = new SimpleDataBase<double>();
        database.AddNewData(angka1);
        database.AddNewData(angka2);
        database.AddNewData(angka3);

        // Menampilkan semua data yang telah disimpan
        database.PrintAllData();
    }
}
