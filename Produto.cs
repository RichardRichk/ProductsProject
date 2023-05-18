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

        public DateTime DataCadastro { get; set; }

        public Marca Marca = new Marca(); 

        public Usuario CadastradoPor { get; set; }

        List<Produto> listaProdutos = new List<Produto>();


        public void Cadastrar()
        {
            //Logica
            //instanciar objeto
            //receber os dados e cadastrar nesse objeti
            //armazenar o objeto na lista
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