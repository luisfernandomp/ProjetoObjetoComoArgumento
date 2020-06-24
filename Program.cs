using System;

namespace objetosComoArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto(1, "Hollow Knigth", 34.98f);
            Produto p2 = new Produto(2, "Good Of War", 55.98f);
            Produto p3 = new Produto(3, "Celeste", 43.99f);
            Produto p4 = new Produto(4, "The Last Of Us I", 88.97f);
            Produto p5 = new Produto(5, "The Last Of Us II", 77.98f);

            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);
            cart.Adicionar(p5);

            cart.Deletar(p3);

            Produto pAlterado = new Produto(4, "Cyberpunk 2077", 200f);
            cart.Alterar(2, pAlterado);

            cart.Ler();

            cart.MostrarTotal();



        }
    }
}
