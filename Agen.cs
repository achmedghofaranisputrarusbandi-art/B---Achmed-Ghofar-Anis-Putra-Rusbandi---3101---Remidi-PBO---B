public class Agen
{
    
    public string idAgen;
    public string namaAgen;
    public int stokAgen;

    public Agen(string idAgen, string namaAgen, int stokAgen)
    {
        this.idAgen = idAgen;
        this.namaAgen = namaAgen;
        this.stokAgen = stokAgen;
    }

    
    public void TampilInfo()
    {
        Console.WriteLine($"[AGEN] ID: {idAgen} | Nama: {namaAgen} | Stok: {stokAgen} galon");
    }
}
