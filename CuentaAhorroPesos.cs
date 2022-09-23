public class CuentaAhorroPesos : Cuenta
{
    public override void extraer (int monto, TipoExtraccion tipo)
    {
        if (plata <= 0)
        {
            Console.WriteLine("Fondos insifucientes");
        }
        if (monto <= 10000 && tipo == TipoExtraccion.CajeroAutomatico)
        {
            plata -= monto;
        }
        if (tipo == TipoExtraccion.CajeroHumano)
        {
            plata -= monto;
        }
    }
}
