Console.WriteLine("A que cuenta quiere acceder");
Console.WriteLine("Cuenta en pesos [1]");
Console.WriteLine("Cuenta en dolares [2]");
Console.WriteLine("Caja de ahorros en pesos [3]");
int input = Convert.ToInt32(Console.ReadLine());
Cuenta cuenta = null;


switch (input)
{
    case 1: cuenta = new CuentaPesos();
    break;
    case 2: cuenta = new CuentaDolares();
    break;
    case 3: cuenta = new CuentaAhorroPesos();
    break;
}
int monto=0;
TipoExtraccion tipo= TipoExtraccion.CajeroAutomatico;
int selector;
int flag= 1;
do
{
    Console.WriteLine("-------------OPERACIONES-------------");
    Console.WriteLine("[1] Extraer");
    Console.WriteLine("[2] Depositar");
    Console.WriteLine("[3] Ver Saldo");
    input = Convert.ToInt32(Console.ReadLine());
    if (input < 3)
    {
        Console.WriteLine("Ingrese un monto");
        monto = Convert.ToInt32(Console.ReadLine());
        if (input == 1)
        {
            Console.WriteLine("Por que cajero esta extrayendo");
            Console.WriteLine("[1] Humano");
            Console.WriteLine("[2] Automatico");
            selector = Convert.ToInt32(Console.ReadLine());
            switch (selector)
            {
                case 1: tipo = TipoExtraccion.CajeroHumano;
                break;
                case 2: tipo = TipoExtraccion.CajeroAutomatico;  
                break;
            }
            
        }
    }
    switch (input)
    {
        case 1: cuenta.extraer(monto,tipo);
        break;
        case 2: cuenta.insercion(monto);
        break;
        case 3: Console.WriteLine(cuenta.getSaldo());
        break;
    }
    Console.WriteLine("Quiere realizar otra operacion? [1] Si [0] No");
    flag= Convert.ToInt32(Console.ReadLine());
} while (flag > 0);
