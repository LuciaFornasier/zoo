namespace Zoo;

public abstract class Animale
{
    protected string nome;
    protected int eta;
    protected bool isdiurno;

    public Animale()
    {
        nome = "";
        eta = 0;
        isdiurno = false;
    }

    public Animale(string nome, int eta, bool isdiurno)
    {
        this.nome = nome;
        this.eta = eta;
        this.isdiurno = isdiurno;
    }

    public virtual string FaiVerso()
    {
        throw new NotImplementedException();
    }

    public virtual string Mangia()
    {
        throw new NotImplementedException();
    }

    public virtual string GetInfo()
    {
        throw new NotImplementedException();
    }
}