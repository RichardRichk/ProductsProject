using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutosProjeto
{
    public class Usuario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public  DateTime DataCadastro = DateTime.Now.Date;
        private Random randNum = new Random();
        List<Usuario> usuarios = new List<Usuario>();


        public Usuario()
        {
            CadastrarUser();
        }   

        public void CadastrarUser()
        {   
            Usuario NovoUsuario = new Usuario();

            Console.WriteLine($"Qual seu nome ?");
            Nome = Console.ReadLine();

            Console.WriteLine($"Qual seu email ?");
            Email = Console.ReadLine();

            Console.WriteLine($"Qual sua senha ?");
            Senha = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Usuario cadastrado com sucesso!!!");
            Thread.Sleep(1200);
            Console.WriteLine($"");

            Console.WriteLine($"Codigo de cadastro: {Codigo = randNum.Next(1000,10000)}");
            Console.WriteLine($"Data de cadastro: {DataCadastro}");
            
            usuarios.Add(NovoUsuario);
        }

        public void DeletarUser()
        {
        }
    }
}