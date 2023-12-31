using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidaDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);            
        }

        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine($"Nome: {aluno.NomeCompleto}");

                for(int count = 0; count < Alunos.Count; count++)
                {
                    // string texto = "N " + count + " - " + Alunos[count].NomeCompleto ;
                    int exibicao = count + 1;
                    string texto = $"N {exibicao} - {Alunos[count].NomeCompleto}";
                    Console.WriteLine(texto);
                }
            }
        }
    }
}