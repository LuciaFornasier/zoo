namespace Zoo;

public class Zoo
{
    public List<Animale> animali
    {
        get=>animali;
        set=>animali=value;
    }

    public Animale AggiungiAnimale(Animale a)
    {
        animali.Add(a);
        return a;
    }

    public void EseguiAppello()
    {
        foreach (Animale a in animali)
        {
            Console.WriteLine($"{a.FaiVerso()},");

        }
    }


    
}