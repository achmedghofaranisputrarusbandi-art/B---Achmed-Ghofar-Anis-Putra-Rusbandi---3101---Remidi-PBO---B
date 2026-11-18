public abstract class ProdukGalon
{
    
    private string idProduk;
    private string namaProduk;
    private int stokGudang;

    public ProdukGalon(string idProduk, string namaProduk, int stokGudang)
    {
        this.idProduk = idProduk;
        this.namaProduk = namaProduk;
        
        StokGudang = stokGudang;
    }

    
    public string IdProduk
    {
        get { return idProduk; }
        set { idProduk = value; }
    }

    public string NamaProduk
    {
        get { return namaProduk; }
        set { namaProduk = value; }
    }

  
    public int StokGudang
    {
        get { return stokGudang; }
        private set
        {
            if (value < 0)
            {
                Console.WriteLine("[PERINGATAN] Stok gudang tidak boleh negatif! Nilai diabaikan.");
                return;
            }
            stokGudang = value;
        }
    }

    
    public void TambahStok(int jumlah)
    {
        if (jumlah <= 0)
        {
            Console.WriteLine("[PERINGATAN] Jumlah tambah stok harus lebih dari 0.");
            return;
        }
        StokGudang = stokGudang + jumlah;
    }

    
    public void KurangiStok(int jumlah)
    {
        if (jumlah <= 0)
        {
            Console.WriteLine("[PERINGATAN] Jumlah pengurangan harus lebih dari 0.");
            return;
        }
        if (jumlah > stokGudang)
        {
            Console.WriteLine("[PERINGATAN] Pengurangan melebihi stok gudang, ditolak.");
            return;
        }
        StokGudang = stokGudang - jumlah;
    }


    public abstract int HitungBiaya(int jumlah);

    public virtual void TampilInfo()
    {
        Console.WriteLine($"[PRODUK] ID: {idProduk} | Nama: {namaProduk} | Stok Gudang: {stokGudang}");
    }
}
