using DIO.Models;
Console.Title = "Sistema Estacionamento";
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

int horas = 0;
decimal precoInicial = 0;
decimal precoPorHora = 0;
decimal precoFinal = precoInicial + (precoPorHora * horas);


Console.WriteLine("Qual é o preço inicial?");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Qual é o preço por hora?");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento e = new Estacionamento(precoInicial, precoPorHora);

bool mostrarMenu = true;

while(mostrarMenu) {
    Console.Clear();
    Console.WriteLine("SIG Estacionamento");
    Console.WriteLine("Opções: ");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Listar Veículos ");
    Console.WriteLine("3 - Remover Veículo");
    Console.WriteLine("4 - Sair do Menu ");

    switch(Console.ReadLine()) {
        case "1":
            Console.Clear();
            e.CadastrarVeiculo();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            
            break;
        case "2":
            Console.Clear();
            e.MostrarVeiculosCadastrados();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadLine();
            break;
        case "3":
            Console.Clear();
            e.MostrarVeiculosCadastrados();
            Console.WriteLine("Digite a placa do carro que deseja remover : ");
            string veiculoARemover = string.Empty; 
            veiculoARemover = Console.ReadLine();
            e.RemoverVeiculo(veiculoARemover.ToUpper());
            break;
        case "4": 
            Console.WriteLine("Programa Finalizado. Até a próxima!");
            e.MostrarFaturamento();
            mostrarMenu = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opção Inválida");
            break;
    }
}

