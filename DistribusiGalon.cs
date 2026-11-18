public class DistribusiGalon : DapatDidistribusikan
{
    public Agen AgenTujuan { get; set; }
    public ProdukGalon Produk { get; set; }
    public int Jumlah { get; set; }

    public DistribusiGalon(Agen agenTujuan, ProdukGalon produk, int jumlah)
    {
        AgenTujuan = agenTujuan;
        Produk = produk;
        Jumlah = jumlah;
    }

    public bool KirimPaket()
    {
        
        if (Jumlah <= 0)
        {
            Console.WriteLine($"[GAGAL] Pengiriman ke {AgenTujuan.namaAgen} dibatalkan: jumlah galon harus lebih dari 0.");
            return false;
        }

        
        if (Jumlah > Produk.StokGudang)
        {
            Console.WriteLine($"[GAGAL] Pengiriman ke {AgenTujuan.namaAgen} dibatalkan: stok gudang {Produk.NamaProduk} hanya {Produk.StokGudang}, diminta {Jumlah}.");
            return false;
        }

        
        Produk.KurangiStok(Jumlah);
        AgenTujuan.stokAgen += Jumlah;

        Console.WriteLine($"[SUKSES] Paket berhasil dikirimkan ke agen {AgenTujuan.namaAgen}! ({Jumlah} galon {Produk.NamaProduk}). Rahasia aman, kartel tetap berjaya.");
        return true;
    }
}
