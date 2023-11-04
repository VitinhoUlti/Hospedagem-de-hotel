// See https://aka.ms/new-console-template for more information

using Classes.Classes;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes2 = new List<Pessoa>();


Pessoa p1 = new Pessoa(nome:"Vitor Miguel");
Pessoa p2 = new Pessoa(nome:"Elson Gambaroto");

hospedes2.Add(p1);
hospedes2.Add(p2);

Suite suite = new Suite("Premium", 3, 30);

Reserva reserva = new Reserva(30);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes2);

Console.WriteLine(reserva.ObterQuantidadeHospedes());
Console.WriteLine(reserva.CalcularValorDiaria());
