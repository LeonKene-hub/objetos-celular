using objetos_celular;
Celular Xperia = new Celular();

Console.WriteLine(@$"
┌-----------------┐
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│    Precione 1   │
│    para ligar   │
├-----------------┤
│                 │
│                 │
└-----------------┘
");

string opcoes = Console.ReadLine();

if (opcoes == "1")
{
    Xperia.Ligar();
}

if (Xperia.Ligado)
{
    switch (opcoes)
    {
        case "2":
        Xperia.Fazerligacao();
            break;
        case "3":
        Xperia.EnviarMensagem();
            break;
        default:
            break;
    }
    
}
//ligado / desliagado
switch (Xperia.Ligado)
{
    case true:

    do
    {
    Console.WriteLine(@$"
┌-----------------┐
│                 │
│2 Fazer ligacao  │
│                 │
│3 Enviar mensagem│
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│0 desligar       │
├-----------------┤
│                 │
│                 │
└-----------------┘
");
opcoes = Console.ReadLine();
        
    } while (opcoes != "0");

  
        break;
    case false:
    Console.WriteLine(@$"
┌-----------------┐
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│                 │
│    Precione 1   │
│    para ligar   │
├-----------------┤
│                 │
│                 │
└-----------------┘
");
    
        break;
    default:
        break;
}
