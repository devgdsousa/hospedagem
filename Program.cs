using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;


Console.Write("Digite o número de hóspedes: ");
int quantidadeHospedes = int.Parse(Console.ReadLine());

List<Pessoa> hospedes = new List<Pessoa>();

// Loop para adicionar cada hóspede com entrada de nome
for (int i = 1; i <= quantidadeHospedes; i++)
{
    Console.Write($"Digite o nome do hóspede {i}: ");
    string nomeHospede = Console.ReadLine();
    hospedes.Add(new Pessoa(nome: nomeHospede));
}


Console.Write("Digite o tipo da suíte: ");
string tipoSuite = Console.ReadLine();

Console.Write("Digite a capacidade da suíte: ");
int capacidadeSuite = int.Parse(Console.ReadLine());

Console.Write("Digite o valor da diária da suíte: ");
decimal valorDiaria = decimal.Parse(Console.ReadLine());


Suite suite = new Suite(tipoSuite: tipoSuite, capacidade: capacidadeSuite, valorDiaria: valorDiaria);


Console.Write("Digite a quantidade de dias reservados: ");
int diasReservados = int.Parse(Console.ReadLine());


Reserva reserva = new Reserva(diasReservados: diasReservados);
reserva.CadastrarSuite(suite);

try
{
    reserva.CadastrarHospedes(hospedes);

    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor total da estadia: {reserva.CalcularValorDiaria():C}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
