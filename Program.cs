using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        
        Console.WriteLine("=== 1. CLASS & OBJECT: AGEN ===");
        Agen agen1 = new Agen("AG-001", "Agen Bayangan", 10);
        Agen agen2 = new Agen("AG-002", "Agen Gelap Malam", 5);
        agen1.TampilInfo();
        agen2.TampilInfo();

        
        Console.WriteLine("\n=== 2. ENCAPSULATION ===");
        GalonAkua akua = new GalonAkua("PR-01", "Galon Akua Murni", 100);
        GalonBerkeran berkeran = new GalonBerkeran("PR-02", "Galon Berkeran Impor Misterius", 50, "Keran Tuas");
        akua.TampilInfo();
        akua.KurangiStok(10);
        Console.WriteLine($"Stok Akua setelah KurangiStok(10): {akua.StokGudang}");
        akua.KurangiStok(1000); 
        Console.WriteLine($"Stok Akua setelah KurangiStok(1000): {akua.StokGudang}");
        akua.TambahStok(10);    

        
        Console.WriteLine("\n=== 3-5. INHERITANCE, POLYMORPHISM, ABSTRACT ===");
        
        ProdukGalon[] daftarProduk = { akua, berkeran };
        foreach (ProdukGalon p in daftarProduk)
        {
            
            Console.WriteLine($"{p.NamaProduk} x 3 galon = Rp{p.HitungBiaya(3):N0}");
        }

        
        Console.WriteLine("\n=== 6. INTERFACE: DISTRIBUSI GALON ===");
        DapatDidistribusikan kirim1 = new DistribusiGalon(agen1, akua, 20);       
        DapatDidistribusikan kirim2 = new DistribusiGalon(agen2, berkeran, 0);    
        DapatDidistribusikan kirim3 = new DistribusiGalon(agen2, berkeran, 999);  
        DapatDidistribusikan kirim4 = new DistribusiGalon(agen2, berkeran, 15);   
        kirim1.KirimPaket();
        kirim2.KirimPaket();
        kirim3.KirimPaket();
        kirim4.KirimPaket();

        Console.WriteLine();
        agen1.TampilInfo();
        agen2.TampilInfo();
        akua.TampilInfo();
        berkeran.TampilInfo();

        
        Console.WriteLine("\n=== 7. SINDIKAT GALON ===");
        SindikatGalon sindikat = new SindikatGalon();
        sindikat.TambahAgen(agen1);
        sindikat.TambahAgen(agen2);
        sindikat.TambahProduk(akua);
        sindikat.TambahProduk(berkeran);
        Console.WriteLine();
        sindikat.TampilkanSindikat();

        Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
        Console.ReadKey();
    }
}
