using System;

// Class Laptop sebagai kelas dasar
public class Laptop
{
    public string Merk;
    public string Tipe;

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} mati");
    }
}

// Class Vivobook, merupakan turunan dari class Laptop
public class Vivobook : Laptop
{
    public string Vga;
    public string Processor;

    // Konstruktor kelas Vivobook untuk menginisialisasi atribut tambahan
    public Vivobook()
    {
        Merk = "Asus";
        Tipe = "Vivobook";
        Vga = "Nvidia";
        Processor = "Core i5";
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }

    // Method untuk menampilkan spesifikasi
    public void TampilkanSpesifikasi()
    {
        Console.WriteLine($"Merk: {Merk}");
        Console.WriteLine($"VGA: {Vga}");
        Console.WriteLine($"Merk Processor: {Processor}");
    }
}

// Class IdeaPad, merupakan turunan dari class Laptop
public class IdeaPad : Laptop
{
    public string Vga;
    public string Processor;

    // Konstruktor kelas IdeaPad untuk menginisialisasi atribut tambahan
    public IdeaPad()
    {
        Merk = "Lenovo";
        Tipe = "IdeaPad";
        Vga = "AMD";
        Processor = "Ryzen";
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

// Class Predator, merupakan turunan dari class Laptop
public class Predator : Laptop
{
    public string Vga;
    public string Processor;

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek laptop1 dari kelas Vivobook
        Vivobook laptop1 = new Vivobook();

        // Membuat objek laptop2 dari kelas IdeaPad (kini IdeaPad adalah turunan dari Laptop)
        IdeaPad laptop2 = new IdeaPad();

        // Membuat objek predator dari kelas Predator
        Predator predator = new Predator
        {
            Merk = "Acer",
            Tipe = "Predator",
            Vga = "AMD",
            Processor = "Core i7"
        };

        Laptop acer = new Predator
        {
            Merk = "Acer",
            Tipe = "Predator",
            Vga = "AMD",
            Processor = "Core i7"
        };

        //no 1
        // Menjalankan method BermainGame pada laptop1, laptop2, dan predator
        //laptop2.LaptopDinyalakan();
        //laptop2.LaptopDimatikan();

        //no 2
        // Menampilkan spesifikasi laptop1
        // laptop1.TampilkanSpesifikasi();

        //no 3
        // predator.BermainGame();

        //no 4 
        // Ini akan menghasilkan kesalahan kompilasi karena method BermainGame() tidak ada dalam kelas Laptop.
        //acer.BermainGame(); 
    }
}
