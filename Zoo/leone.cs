namespace Zoo;

public class leone:Animale
{
    private int volumeRuggito;
    public int VolumeRuggito
    {
        get => volumeRuggito;
        set => volumeRuggito = (value < 1 || value > 10) ? 1 : value;
    }

    public override string FaiVerso()
    {
        return "ROAAR!";
    }

    public override string Mangia()
    {
        return "Il leone mangia carne fresca";
    }
}