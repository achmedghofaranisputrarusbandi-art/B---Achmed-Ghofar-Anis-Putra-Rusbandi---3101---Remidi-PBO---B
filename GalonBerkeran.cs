public class GalonBerkeran : ProdukGalon
{
    public string JenisKeran { get; set; }

    public GalonBerkeran(string idProduk, string namaProduk, int stokGudang, string jenisKeran)
        : base(idProduk, namaProduk, stokGudang)
    {
        JenisKeran = jenisKeran;
    }

    public override int HitungBiaya(int jumlah)
    {
        return jumlah * 12000;
    }

    public override void TampilInfo()
    {
        base.TampilInfo();
        Console.WriteLine($"         Jenis Keran: {JenisKeran}");
    }
}
