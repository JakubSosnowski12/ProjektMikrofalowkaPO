public class Danie
{
    public string Nazwa { get; set; }
    public int SugerowanaMoc { get; set; }
    public int CzasPrzygotowania { get; set; }

    public Danie(string nazwa, int sugerowanaMoc, int czasPrzygotowania)
    {
        Nazwa = nazwa;
        SugerowanaMoc = sugerowanaMoc;
        CzasPrzygotowania = czasPrzygotowania;
    }
}
