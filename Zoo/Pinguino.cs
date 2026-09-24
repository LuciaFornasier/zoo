namespace Zoo;

public class Pinguino:Animale
{
    public double VelocitaNuoto
    {
        get=> VelocitaNuoto;
        set=> VelocitaNuoto = value;
    }

    public double Nuoto()
    {
        return VelocitaNuoto;
    }

    public override string FaiVerso()
    {
        return "Squittio acuto!";
    }
    
}