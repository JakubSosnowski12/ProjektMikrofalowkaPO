using System;

public class Mikrofala
{
    private int mocWat;
    private int czasSekundy;
    private bool czyPracuje;

    public Mikrofala()
    {
        mocWat = 800;
        czasSekundy = 60;
        czyPracuje = false;
    }

    public void UstawMoc(int mocWat)
    {
        if (mocWat > 0)
        {
            this.mocWat = mocWat;
            Console.WriteLine($"Ustawiono moc mikrofali na {this.mocWat} W");
        }
        else
        {
            Console.WriteLine("Moc mikrofali musi być większa od zera.");
        }
    }

    public int PobierzMoc()
    {
        return mocWat;
    }

    public void UstawCzas(int czasSekundy)
    {
        if (czasSekundy > 0)
        {
            this.czasSekundy = czasSekundy;
            Console.WriteLine($"Ustawiono czas na {this.czasSekundy} sekund");
        }
        else
        {
            Console.WriteLine("Czas musi być większy od zera.");
        }
    }
    public int PobierzCzas()
    {
        return czasSekundy;
    }

    public void StartMikrofala()
    {
        if (!czyPracuje)
        {
            Console.WriteLine($"Rozpoczęto mikrofalowanie przez {czasSekundy} sekund z mocą {mocWat} W");
            czyPracuje = true;
            Console.WriteLine("Mikrofalowanie...");
            int simulatedTime = Math.Min(czasSekundy, 2);
            System.Threading.Thread.Sleep(simulatedTime * 1000);
            czyPracuje = false;
        }
        else
        {
            Console.WriteLine("Kuchenka już pracuje.");
        }
    }

    public void StopMikrofala()
    {
        if (czyPracuje)
        {
            Console.WriteLine("Zatrzymano mikrofalowanie.");
            czyPracuje = false;
        }
        else
        {
            Console.WriteLine("Kuchenka nie jest włączona.");
        }
    }
}
