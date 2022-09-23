public class CuentaDolares : Cuenta
{
    public void extraer(int monto, TipoExtraccion tipo)
    {
        int dolaresExtraidos=0;
        DateTime today= DateTime.Today;
        if (dolaresExtraidos < 200 && today == DateTime.Today && tipo == TipoExtraccion.CajeroAutomatico)
        {
            dolaresExtraidos+=monto;
            plata -= monto;
        }else if (TipoExtraccion.CajeroHumano == tipo)
        {
            plata -= monto;
        }
    }
} 