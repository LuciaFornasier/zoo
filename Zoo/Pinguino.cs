namespace Zoo;

public class Pinguino
{
    private double VelocitaNuoto;

    public Pinguino()
    {
        VelocitaNuoto = 0;
    }

    public Pinguino(double VelocitaNuoto)
    {
        this.VelocitaNuoto = VelocitaNuoto;
    }
    public double Nuoto()
    {
        return VelocitaNuoto;
    }
}