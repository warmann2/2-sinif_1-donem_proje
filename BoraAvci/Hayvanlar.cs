
using BoraAvci;

public class Hayvanlar : Hayvan, IHayvan
{
    public Hayvanlar() { }


    
    public string? HayvanAdi { get; set; }
    public string? Turu { get; set; }
    public int? Yasi { get; set; }
    public Hayvanlar(int id, string hayvanAdi, string turuu, int yas)
    {
        HayvanID = id;
        HayvanAdi = hayvanAdi;
        Turu = turuu;
        Yasi = yas;
    }

    string IHayvan.Besle()
    {

        return "hav hav ";
    }
}
