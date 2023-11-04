/*using Classes.Classes;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

bool menu = true;

List<Pessoa> hospedes2 = new List<Pessoa>();
List<string> nomes = new List<string>();
List<string> nomessuites = new List<string>();
List<Suite> Suites = new List<Suite>();

while (menu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma das opções");
    Console.WriteLine("1-Cadastrar Hospede");
    Console.WriteLine("2-Remover Hospede");
    Console.WriteLine("3-Cadastrar Suite");
    Console.WriteLine("4-Obter Quantidade de Hospedes");
    Console.WriteLine("5-Listar Suites");
    Console.WriteLine("6-Listar Hospedes");
    Console.WriteLine("7-Fazer Reserva");
    Console.WriteLine("8-Calcular valor diario");
    Console.WriteLine("9-Sair");

    var opcao = Console.ReadLine();
    Console.Clear();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o nome do Hospede");
            var hospedenome = Console.ReadLine();
            Pessoa p1 = new Pessoa(hospedenome);
            hospedes2.Add(p1);
            nomes.Add(hospedenome);
            break;
        case "2":
            Console.WriteLine("Digite o nome do Hospede");
            var nome2 = Console.ReadLine();
            nomes.Remove(nome2);
            break;
        case "3":
            Console.WriteLine("Digite o nome da Suite");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de hospedes permitida");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de dinheiro por dias");
            var diasvalor = Convert.ToDecimal(Console.ReadLine());

            Suite s1 = new Suite(nome, quantidade, diasvalor);

            Suites.Add(s1);
            nomessuites.Add(nome);
            break;
        case "4":
            break;
        case "5":
            foreach (var item in nomessuites)
            {
                Console.WriteLine(item);
            }
            break;
        case "6":
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
            break;
        case "7":
            Console.WriteLine("Digite o numero de dias");
            var dias = Convert.ToInt32(Console.ReadLine());
            Reserva reserva = new Reserva(dias);
            Console.WriteLine("cadastre uma suite existente");
            break;
        case "8":
            break;
        case "9":
            menu = false;
            break;
        default:
            Console.WriteLine("Opção Indefinida");
            break;
    }
    if (menu)
    {
        Console.WriteLine("Digite algo para voltar");
        Console.ReadKey();
    }
}
*/