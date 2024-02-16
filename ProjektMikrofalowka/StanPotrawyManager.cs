public class StanPotrawyManager
{
    public string SprawdzStanPotrawy(int sugerowanaMoc, int sugerowanyCzas, int ustawionaMoc, int ustawionyCzas)
    {
        if (ustawionaMoc < sugerowanaMoc || ustawionyCzas < sugerowanyCzas)
        {
            return "Potrawa jest niedopieczona!";
        }
        else if (ustawionaMoc == sugerowanaMoc && ustawionyCzas == sugerowanyCzas)
        {
            return "Potrawa gotowa, wszystko jest dopieczone!";
        }

        else if (ustawionaMoc > sugerowanaMoc || ustawionyCzas > sugerowanyCzas * 2)
        {
            return "Potrawa spalona!";
        }
        else
        {
            return "Potrawa niegotowa - ustalone parametry poza zalecanymi granicami.";
        }
    }
}
