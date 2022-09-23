public enum TipoExtraccion
{
    CajeroHumano=1,
    CajeroAutomatico=2
}

public class Cuenta
{
    protected int plata;

    public int getSaldo()
    {
        return plata;
    }

    public void insercion(int monto)
    {
        this.plata +=monto;
    }

    public virtual void extraer(int monto, TipoExtraccion tipo)
    {
        this.plata -= monto;
    }

    public Cuenta()
    {
        plata=50000;
    }
}