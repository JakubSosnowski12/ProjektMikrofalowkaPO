using CsvHelper;
using System;
using System.Globalization;
using System.IO;

public class InterfejsUzytkownika
{
    private PotrawyManager manager;

    public InterfejsUzytkownika()
    {
        manager = new PotrawyManager();
    }

    public void WyswietlPotrawy()
    {
        int index = 0;
        foreach (Danie danie in manager.PobierzPotrawy())
        {
            Console.WriteLine($"{index+1}. {danie.Nazwa}");
            index++;
        }
    }

    public Danie WybierzDanie()
    {
        Console.WriteLine("Wybierz potrawę:");
        WyswietlPotrawy();
        int wybor = Convert.ToInt32(Console.ReadLine());

        Danie wybraneDanie = manager.WybierzPotrawe(wybor-1);
        Console.Clear();

        if (wybraneDanie != null)
        {
            Console.WriteLine($"Wybrano: {wybraneDanie.Nazwa}");
            Console.WriteLine($"Sugerowana moc mikrofalówki: {wybraneDanie.SugerowanaMoc} W");
            Console.WriteLine($"Czas przygotowania: {wybraneDanie.CzasPrzygotowania} sekund");
            Console.WriteLine("Możesz teraz ustawić własną moc i czas mikrofalówki.");
        }
        else
        {
            Console.WriteLine("Niepoprawny wybór.");
        }

        return wybraneDanie;
    }

    public void UstawMocICzas(Mikrofala mikrofala)
    {
        Danie wybraneDanie = WybierzDanie();

        if (wybraneDanie != null)
        {
            Console.WriteLine("Podaj moc mikrofalówki (w Watach):");
            int moc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj czas mikrofalowania (w sekundach):");
            int czas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            mikrofala.UstawMoc(moc);
            mikrofala.UstawCzas(czas);
            Console.WriteLine("Rozpoczęcie mikrofalowania:");
            mikrofala.StartMikrofala();

            StanPotrawyManager stanPotrawyManager = new StanPotrawyManager();
            string stanPotrawy = stanPotrawyManager.SprawdzStanPotrawy(
                wybraneDanie.SugerowanaMoc, wybraneDanie.CzasPrzygotowania, moc, czas);

            Console.WriteLine(stanPotrawy);

            ZapiszDoPlikuTekstowego(wybraneDanie.Nazwa, moc, czas, stanPotrawy);
        }
    }

    private void ZapiszDoPlikuTekstowego(string nazwaPotrawy, int moc, int czas, string status)
    {
        using (StreamWriter sw = new StreamWriter("wybory_uzytkownika.txt", true))
        using (CsvWriter csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
        {
            csv.WriteRecord(new { Potrawa = nazwaPotrawy, Moc = moc, Czas = czas, Status = status });
            csv.NextRecord();
        }
    }
}
