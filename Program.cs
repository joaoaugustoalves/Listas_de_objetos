using System;
using System.Collections.Generic;
using Listas_de_objetos.Classes;

namespace Listas_de_objetos 
{
    class Program
    {
        static void Main(string[] args)
        {
                List<Produto> produtos = new List<Produto>();

                Produto[] arrayProdutos = {};

                produtos.Add(new Produto(5, "Apple Watch", 3522.56f));
                produtos.Add(new Produto(8, "Xiomi Watch", 1522.56f));
                produtos.Add(new Produto(78, "Zenfone ASUS", 4522.56f));
                produtos.Add(new Produto(2, "Sansung ", 4522.56f));
                produtos.Add(new Produto(3, "Motorola G8", 6522.56f));

                Produto p1 = new Produto();
                p1.Codigo = 67;
                p1.Nome = "Iphone XII";
                p1.Preco = 8952.56f;

                produtos.Add(p1);

                foreach (Produto item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }

                produtos.RemoveAt(3);

                Console.WriteLine("\nRemoção Feita: \n");
                foreach (Produto item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }

                produtos.RemoveAll(x => x.Nome == "Iphone XII");
                
                Console.WriteLine("\nRemoção da Sansung feita: \n");
                foreach (Produto item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }

        }
    }
}
