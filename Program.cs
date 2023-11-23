using ExemploExplorando.Models;


Pessoa p1 = new Pessoa("João", "Siles");
Pessoa p2 = new Pessoa(nome: "Lais", sobrenome:"Siles");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();














// Pessoa p1 = new Pessoa();

// p1.Nome = "João";
// p1.Sobrenome = "Siles";
// p1.Idade = 36;

// p1.Apresentar();