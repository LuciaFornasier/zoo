namespace Zoo;

public class Leone:Animale
{
    
    public int VolumeRuggito
    {
        get => VolumeRuggito;
        set => VolumeRuggito = (value < 1 || value > 10) ? 1 : value;
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