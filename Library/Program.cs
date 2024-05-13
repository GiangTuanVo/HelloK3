using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        public enum Color
        {
            Red,
            Green,
            Blue
        }

        public enum Size
        {
            Small,
            Medium,
            Large,
            Yuge
        }

        public class Product
        {
            public string Name;
            public Color Color;
            public Size Size;

            public Product(string name, Color color, Size size)
            {
                if (name == null)
                {
                    throw new ArgumentNullException(paramName: nameof(name));
                }

                Name = name;
                Color = color;
                Size = size;
            }
        }

        public class ProductFilter
        {
            //public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
            //{
            //    foreach (var p in products)
            //        if (p.Size == size)
            //            yield return p;
            //}

            //public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
            //{
            //    foreach (var p in products)
            //        if (p.Color == color)
            //            yield return p;
            //}

            //public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
            //{
            //    foreach (var p in products)
            //        if (p.Size == size && p.Color == color)
            //            yield return p;
            //}

            //Different ways
            public List<Product> FilterBySize(List<Product> products, Color color, Size size)
            {
                List<Product> product = new List<Product>();
                foreach (var item in products)
                    if (item.Size == size)
                        product.Add(item);
                return product;
            }
        }

        public class Rectang
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }

            public Rectang()
            {
            }

            public Rectang(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public override string ToString()
            {
                return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
            }
        }

        public class Square : Rectang
        {
            public override int Width
            {
                set { base.Width = base.Height = value; }
            }

            public override int Height
            {
                set { base.Width = base.Height = value; }
            }
        }
        static public int Area(Rectang r) => r.Width * r.Height;
        static void Main(string[] args)
        {
            //var apple = new Product("Apple", Color.Green, Size.Small);
            //var tree = new Product("Tree", Color.Green, Size.Large);
            //var house = new Product("House", Color.Blue, Size.Large);
            //Product[] products = { apple, tree, house };
            //var pf = new ProductFilter();
            //WriteLine("Green products (old):");
            //foreach (var item in pf.FilterByColor(products, Color.Green))
            //{
            //    WriteLine($"- {item.Name} is green");
            //}

            //Rectang rc = new Rectang(3, 4);
            //WriteLine($"{rc} has area {Area(rc)}");
            //Square sq = new Square();
            //sq.Width = 4;
            //WriteLine($"{sq} has area {Area(sq)}");
        }
    }
}
