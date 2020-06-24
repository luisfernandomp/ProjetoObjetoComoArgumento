using System;
using System.Collections.Generic;

namespace objetosComoArgumentos
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        public int MyProperty { get; set; }
        
        List<Produto> carrinho = new List<Produto>();
        
        public void Adicionar(Produto _prod){
            carrinho.Add(_prod);
        }

        public void Deletar (Produto _prod){
            carrinho.Remove(_prod);
        }

        public void Ler (){
            foreach (Produto item in carrinho)
            {
                Console.WriteLine($"\nNome: {item.Nome} - R${item.Preco}");
            }
        }

        public void Alterar (int _codigo, Produto _produtoAlterado){
            carrinho.Find(z => z.Codigo == _codigo).Nome = _produtoAlterado.Nome;
            carrinho.Find(z => z.Codigo == _codigo).Preco = _produtoAlterado.Preco;

        }
        public void MostrarTotal (){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            System.Console.WriteLine("Valor total: R$"+ValorTotal);
        }
    }
}