using System;

namespace EventHandler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double price;
            Console.WriteLine("Ingrese el precio que tendrá el artículo");
            price = Double.Parse(Console.ReadLine());

            ArticleEventArgs article = new ArticleEventArgs(price);
            Console.WriteLine($"El precio del artículo es: {article.Price}");

            article.ChangeOfPrice += Article_ChangeOfPrice;

            article.OnChangePrice(article);

            Console.ReadKey();
        }

        private static void Article_ChangeOfPrice(object sender, ArticleEventArgs e)
        {
            Console.WriteLine("El precio del artículo fue alterado");
            Console.WriteLine($"El nuevo precio es:  {e.Price}");
        }
    }
}