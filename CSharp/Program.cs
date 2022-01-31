using System;
using Interface;
using Classes;
using Enum;


namespace CSharp
{
    class Program
    {
        static void Main(string[] Args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.João;
            Pessoas pessoa3 = (Pessoas)4;


        Pessoa person = new Pessoa();

        person.Nome = "Oliver";
        person.Idade = 48;
        person.Estado = "SP";

        var person2 = new Pessoa();

        person2.Nome = "Fernanda";
        person2.Idade = 45;
        person2.Estado = "SP";

        var animal = new Animal();

        animal.Nome = "Rex";
        animal.NomeDono = "Pedro";
        animal.Especie = "Cachotto";

            Console.WriteLine(pessoa3);
        }
    }
}
