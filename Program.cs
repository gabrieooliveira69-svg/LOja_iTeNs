Console.WriteLine("Ola jogador,me diga quantas moedas vc possui:");
int moedas = int.Parse(Console.ReadLine()!);

Console.WriteLine("Indique a quantidade de poçoes que deseja comprar");
int poçoes = int.Parse(Console.ReadLine()!);

int preçoPoçao = 15;

int Resultado = preçoPoçao * poçoes;

if ( moedas >= Resultado)
{
    Console.WriteLine("Compra realizada");
}
else
{
   Console.WriteLine("falta de recursos"); 
}

