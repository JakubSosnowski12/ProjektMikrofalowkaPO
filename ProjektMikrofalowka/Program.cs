class Program
{
    static void Main()
    {
        InterfejsUzytkownika interfejs = new InterfejsUzytkownika();
        Mikrofala mikrofala = new Mikrofala();

        while (true)
        {
            interfejs.UstawMocICzas(mikrofala);

            Console.WriteLine("Czy chcesz skorzystać z mikrofalówki ponownie? (T/N)");
            string odpowiedz = Console.ReadLine().ToLower();
            Console.Clear();

            if (odpowiedz != "t")
            {
                break;
            }
        }

        Console.WriteLine("Dziękujemy za skorzystanie z mikrofalówki!");
    }
}
