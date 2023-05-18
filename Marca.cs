using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutosProjeto
{
    public class Marca
    {
        public int CodigoMarca { get; set; }

        public string NomeMarca { get; set; }

        public DateTime DataCadastro;

        Random CodigoRandom = new Random();

        List<Marca> marcas = new List<Marca>();


        public void CadastrarMarca()
        {
            Marca NewMarca = new Marca();

            Console.WriteLine($"Qual o nome da marca ?");
            NewMarca.NomeMarca = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Marca cadastrada com sucesso!!!");
            Thread.Sleep(12000);
            Console.WriteLine($"");

            NewMarca.CodigoMarca = CodigoRandom.Next(100,1000);
            NewMarca.DataCadastro = DateTime.Today;     

            Console.WriteLine($"Codigo de cadastro: {NewMarca.CodigoMarca}");
            Console.WriteLine($"Data de cadastro: {NewMarca.DataCadastro}");
                        
            marcas.Add(NewMarca);
        }

        public void Listar()
        {
            
        }

        public void DeletarMarca()
        {

        }
    }
}