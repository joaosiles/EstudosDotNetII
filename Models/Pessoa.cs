using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome) 
        {
            // construtor padrão é caracterizado por ter o mesmo nome da minha classe e não tem retorno
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public Pessoa() 
        {

        }
        private string _nome;
        private int _idade;
        public string Nome 

        { 
            get  => _nome.ToUpper();
            // a linha acima demonstra uma body expression
            set 
            {
                if (value == "") 
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // body expression
        public int Idade 
        { 
            get => _idade; 
            set 
            {
                if (value < 0) 
                {
                    throw new ArgumentException("A idade não pode ser menor que 0.");
                }

                _idade = value;
            
            }
        }

        public void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");	
        }
    }
}