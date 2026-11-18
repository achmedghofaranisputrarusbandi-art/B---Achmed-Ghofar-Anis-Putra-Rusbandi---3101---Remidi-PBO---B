public class SindikatGalon
{
    private List<Agen> daftarAgen = new List<Agen>();
    private List<ProdukGalon> daftarProduk = new List<ProdukGalon>();

    
    public void TambahAgen(Agen agen)
    {
        daftarAgen.Add(agen);
        Console.WriteLine($"[REKRUT] Agen {agen.namaAgen} resmi bergabung dengan sindikat.");
    }

    
    public void TambahProduk(ProdukGalon produk)
    {
        daftarProduk.Add(produk);
        Console.WriteLine($"[PASOKAN] Produk {produk.NamaProduk} masuk gudang pusat.");
    }

    
    public void TampilkanSindikat()
    {
        Console.WriteLine("========== ASET SINDIKAT MAFIA GALON ==========");
        Console.WriteLine("--- Daftar Agen ---");
        foreach (Agen a in daftarAgen)
        {
            a.TampilInfo();
        }
        Console.WriteLine("--- Daftar Produk Galon ---");
        foreach (ProdukGalon p in daftarProduk)
        {
            p.TampilInfo();
        }
        Console.WriteLine("===============================================");
    }
}
