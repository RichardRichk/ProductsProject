using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutosProjeto
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        public DateTime DataCadastro = DateTime.Now;

        public Usuario CadastradoPor { get; set; }

        public Marca Marca = new Marca(); 

        List<Produto> listaProdutos = new List<Produto>();


        public void Cadastrar()
        {
            Produto NovoProduto = new Produto();

            Console.WriteLine($"Qual o nome do produto ?");
            NovoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Qual o preco do produto ?");
            NovoProduto.Preco = float.Parse(Console.ReadLine());            
            
        }

        public void Listar()
        {
            //Logica
            //exibir os objetos cadastrados na lista
        }

        public void Deletar(int codigo)
        {
            //Logica
            //receber objeto pelo codigo e remove-lo
        }
    }
}