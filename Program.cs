using System;

namespace Deconstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var p = new Pessoa{
                Nome = "Flávio",
                SobreNome = "Formis"
            };

            (string x, string y) = p;

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }

    public class Pessoa{
        public string Nome {get;set;}
        public string SobreNome {get;set;}

        public void Deconstruct(out string nome, out string sobrenome) => (nome, sobrenome) = (Nome, SobreNome);
    }
}
