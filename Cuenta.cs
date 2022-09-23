public enum TipoExtraccion
{
    CajeroHumano=1,
    CajeroAutomatico=2
}

public class Cuenta
{
    public int plata;

    public void insercion(int monto)
    {
        this.plata +=monto;
    }
}