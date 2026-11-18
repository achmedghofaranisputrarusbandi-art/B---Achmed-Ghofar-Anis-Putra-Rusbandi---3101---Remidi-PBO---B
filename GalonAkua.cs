public class GalonAkua : ProdukGalon
{
    public GalonAkua(string idProduk, string namaProduk, int stokGudang)
        : base(idProduk, namaProduk, stokGudang)
    {
    }

    
    public override int HitungBiaya(int jumlah)
    {
        return jumlah * 20000;
    }
}
