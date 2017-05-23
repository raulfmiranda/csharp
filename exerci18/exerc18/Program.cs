/* 
 * Aluno: Raul Figueira Miranda
 * Exercício 18  [20/05/2017]
 * 
 * Usando os métodos de extensão OrderBy() e ThenBy() com expressões lambdas 
 * ordene os estudantes pelo primeiro e último nome em ordem descendente.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc18
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante e1 = new Estudante("Raul", "Miranda");
            Estudante e2 = new Estudante("Hugaleno", "Autômato");
            Estudante e3 = new Estudante("Adalberto", "Girafalles");
            Estudante e5 = new Estudante("Hugaleno", "Bezerra");
            Estudante e6 = new Estudante("Adalberto", "Silva");
            Estudante e4 = new Estudante("Souza", "Carrara");                

            List<Estudante> estudantes = new List<Estudante>();
            estudantes.Add(e1);
            estudantes.Add(e2);
            estudantes.Add(e3);
            estudantes.Add(e4);
            estudantes.Add(e5);
            estudantes.Add(e6);

            Console.WriteLine("\n Estudantes na ordem em que foram cadastrados: \n");

            foreach (Estudante estudante in estudantes)
            {
                Console.WriteLine(" {0} {1}", estudante.PrimeiroNome, estudante.UltimoNome);
            }

            Console.WriteLine("\n Estudantes ordenados pelo primeiro e último nome em ordem descendente: \n");

            List<Estudante> nomeOrdenados = estudantes.OrderByDescending(x => x.PrimeiroNome).ThenBy(x => x.UltimoNome).ToList();

            foreach (Estudante estudante in nomeOrdenados)
            {
                Console.WriteLine(" {0} {1}", estudante.PrimeiroNome, estudante.UltimoNome);
            }         

            Console.ReadLine();

        }
    }

    public class Estudante
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }

        public Estudante(string primeiroNome, string ultimoNome)
        {
            this.PrimeiroNome = primeiroNome;
            this.UltimoNome = ultimoNome;
        }
    }
}
