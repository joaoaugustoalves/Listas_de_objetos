using System;

namespace Listas_de_objetos.Classes
{
    public class Produto
    {
        
         public int Codigo { get; set; }

         public string Nome { get; set; }

          public float Preco { get; set; }


          public Produto(){

          }

          public Produto(int _codigo, string _nome, float _preco) {
              this.Codigo = _codigo;
              this.Nome = _nome;
              this.Preco = _preco;
          }

        internal static void RemoveALL(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}