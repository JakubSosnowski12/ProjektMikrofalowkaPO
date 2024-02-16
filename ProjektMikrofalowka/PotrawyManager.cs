using System.Collections.Generic;

public class PotrawyManager
{
    private List<Danie> potrawy;

    public PotrawyManager()
    {
        potrawy = new List<Danie>
        {
            new Danie("Zupa", 600, 180),
            new Danie("Makaron", 800, 240),
            new Danie("Stek", 900, 300),
            new Danie("Ziemniaki", 600, 180),
            new Danie("Schabowy", 600, 250),
            new Danie("Pierogi", 650, 300),
            new Danie("Spaghetti", 400, 200),
            new Danie("Ryż z warzywami", 600, 180),
            new Danie("Naleśniki", 400, 300),
            new Danie("Krokiety", 600, 120),
        };
    }

    public List<Danie> PobierzPotrawy()
    {
        return potrawy;
    }

    public Danie WybierzPotrawe(int indeks)
    {
        if (indeks >= 0 && indeks < potrawy.Count)
        {
            return potrawy[indeks];
        }
        return null;
    }
}
