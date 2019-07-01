using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    internal class ArticleEventArgs : EventArgs
    {
        public ArticleEventArgs(double price)
        {
            Price = price;
        }

        public ArticleEventArgs()
        {
        }

        public double Price { get; set; }

        public event EventHandler<ArticleEventArgs> ChangeOfPrice;

        public void OnChangePrice(ArticleEventArgs e)
        {
            Console.WriteLine("Ingrese el nuevo precio del artículo");
            Price = Double.Parse(Console.ReadLine());

            EventHandler<ArticleEventArgs> handler = ChangeOfPrice;

            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}