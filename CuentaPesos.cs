class CuentaPesos : Cuenta
{
    public override void extraer(int monto, TipoExtraccion tipo)
    {
        if (plata - monto < -5000)
        {
            Console.WriteLine("Fondos insuficientes");
        }
        if (monto <= 20000 && tipo == TipoExtraccion.CajeroAutomatico)
        {
            plata -=monto;
        }
        if (tipo == TipoExtraccion.CajeroHumano)
        {
            plata -=monto;
        }
    }
}