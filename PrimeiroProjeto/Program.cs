// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
List<string> ListaDasBandas = new List<string> { "Imagine dragons", "Coldplay", "Calypso" };
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolida = Console.ReadLine()!;
    int opcaoEscolidaNumerica = int.Parse(opcaoEscolida);
    switch (opcaoEscolidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção  " + opcaoEscolidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção  " + opcaoEscolidaNumerica);
            break;
        case -1: Console.WriteLine("Obrigado por usar o Screen Sound :)");
            break;
        default: Console.WriteLine("opção inválida");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("******************");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("******************\n");
    Console.Write("Digite o nome da banda ou artista que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    ListaDasBandas.Add(nomeDaBanda);
    Console.Write($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(1500);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************\n");
    //for(int i = 0; i < ListaDasBandas.Count; i++)
   // {
      //  Console.WriteLine($"Banda : {ListaDasBandas[i]}");
    //}
    foreach(string banda in ListaDasBandas)
    {
        Console.WriteLine($"Banda : {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();





