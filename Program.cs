using objetos_celular;
Celular Xperia = new Celular();

Console.WriteLine(@$"
======================
|   Seja bem vindo!  |
|   a nossa loja de  |
|   celulares        |
======================

Ha algum modelo que o interresa?
");
Xperia.Modelo = Console.ReadLine();

Console.WriteLine($"Otimo, qual tamanho de tela voce gosta?");
Xperia.Tamanho = float.Parse(Console.ReadLine());

Console.WriteLine($"Alguma cor em especial?");
Xperia.Cor = Console.ReadLine();

Console.WriteLine($"Aqui esta, modelo {Xperia.Modelo}, da cor {Xperia.Cor} que voce pediu. A tela e de {Xperia.Tamanho} polegadas.");

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
do
{
    
if (Xperia.Ligado == true)
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
    
    switch (opcoes)
    {
        case "2":
            Xperia.Fazerligacao();
            break;
        case "3":
        Xperia.EnviarMensagem();
            break;
        case "0":
            Xperia.Desligar();
            Console.WriteLine($"Fim!");
            break;
        default:
            break;
    }
    
}
} while (Xperia.Ligado == true);