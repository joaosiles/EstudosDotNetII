using ExemploExplorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 82.40M;

Console.WriteLine($"{valorMonetario:C}"); // Formata em moeda
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // Formata em Especifica
Console.WriteLine(valorMonetario.ToString("C1"));
Console.WriteLine(valorMonetario.ToString("N2"));

double porcentagem = 0.3421;
Console.WriteLine(porcentagem.ToString("P")); // Formata em porcentagem

int formato = 20201231;
Console.WriteLine(formato.ToString("##-##-####")); // cria um formato

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss")); // Formata em data e hora
Console.WriteLine(data.ToShortDateString()); // Formata em data

string dataString = "2020-12-31 18:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida);
if (sucesso)
{
    Console.WriteLine($"Data convertida: {dataConvertida}");
}
else
{
    Console.WriteLine("Data inválida");
}



// Pessoa p1 = new Pessoa("João", "Siles");
// Pessoa p2 = new Pessoa(nome: "Lais", sobrenome:"Siles");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();



// Pessoa p1 = new Pessoa();

// p1.Nome = "João";
// p1.Sobrenome = "Siles";
// p1.Idade = 36;

// p1.Apresentar();