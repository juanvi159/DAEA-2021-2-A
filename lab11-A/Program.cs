using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;

namespace lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Consulta Simple
            ////
            //using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            //{
            //    var products = AWEntities.Product;
            //    IQueryable<string> productNames = from p in products
            //                                      select p.Name;
            //    Console.WriteLine("Productos:");
            //    foreach (var productName in productNames)
            //    {
            //        Console.WriteLine(productName);
            //    }
            //    Console.ReadKey();
            //}

            ////Consulta orientada a metodos
            ////
            //using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            //{
            //    var products = AWEntities.Product;
            //    IQueryable<string> productNames = products.Select(p => p.Name);
            //    Console.WriteLine("Productos:");
            //    foreach (var productName in productNames)
            //    {
            //        Console.WriteLine(productName);
            //    }
            //    Console.ReadKey();
            //}

            ////La primera consulta devuelve todos los productos, la segunda amplia la primera usando Where para devolver todos los productos de tamaño “L”:
            ////
            //using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            //{
            //    var products = AWEntities.Product;
            //    IQueryable<Product> productsQuery = from p in products
            //                                      select p;
            //    IQueryable<Product> largeProducts = productsQuery.Where(p => p.Size == "L");
            //    Console.WriteLine("Productos de tamaño 'L':");
            //    foreach (var product in largeProducts)
            //    {
            //        Console.WriteLine(product.Name);
            //    }
            //    Console.ReadKey();
            //}

            ////Usa el método Select para devolver todas las filas de la tabla Product y mostrar los nombres de producto
            ////
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{   
            //    IQueryable<Product> productsQuery = from product in context.Product
            //                                        select product;  
            //    Console.WriteLine("Productos: ");
            //    foreach (var prod in productsQuery)
            //    {
            //        Console.WriteLine(prod.Name);
            //    }
            //    Console.ReadKey();
            //}

            ////Usa el método Select para proyectar las propiedades Product.Name y Product.ProductID en una secuencia de tipos anónimos
            ////
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{

            //    var query = from product in context.Product
            //                select new
            //                {
            //                    ProductId = product.ProductID,
            //                    ProductName = product.Name
            //                };

            //    Console.WriteLine("Informacion de Productos: ");
            //    foreach (var productInfo in query)
            //    {
            //        Console.WriteLine("Product Id: {0} Product name: {1}",
            //            productInfo.ProductId, productInfo.ProductName);
            //    }
            //    Console.ReadKey();
            //}

            ////Usa From … From … (el equivalente del método SelectMany) para seleccionar todos los pedidos en los que TotalDue es inferior a 500,00
            ////
            //decimal totalDue = 500.00M;
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var contacts = context.Contact;
            //    var orders = context.SalesOrderHeader;
            //    var query = from contact in contacts
            //                from order in orders
            //                where contact.ContactID == order.Contact.ContactID
            //                && order.TotalDue < totalDue
            //                select new
            //                {
            //                    ContactID = contact.ContactID,
            //                    LastName = contact.LastName,
            //                    FirstName = contact.FirstName,
            //                    OrderID = order.SalesOrderID,
            //                    Total = order.TotalDue
            //                };
            //    foreach (var smallOrder in query)
            //    {
            //        Console.WriteLine("Contact ID: {0} \t Name: {1}, {2} \t order ID: {3}" + 
            //            "\tTotal Due: ${4}",
            //                    smallOrder.ContactID, smallOrder.LastName,
            //                    smallOrder.FirstName, smallOrder.OrderID, smallOrder.Total);
            //    }
            //    Console.ReadKey();
            //}

            ////Se devuelven los pedidos en los que la cantidad de pedido es superior a 2 e inferior a 6
            ////
            //int orderQtyMin = 2;
            //int orderQtMax = 6;
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var query = from order in context.SalesOrderDetail
            //                where order.OrderQty > orderQtyMin
            //                && order.OrderQty < orderQtMax
            //                select new
            //                {
            //                    SalesOrderID = order.SalesOrderID,
            //                    OrderQty = order.OrderQty
            //                };
            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("Order ID: {0} Order Quantity: {1}",
            //                order.SalesOrderID, order.OrderQty);
            //    }
            //    Console.ReadKey();
            //}

            ////Se devuelven todos los productos de color rojo
            ////
            //String color = "Red";
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var query = from product in context.Product
            //                where product.Color == color
            //                select new
            //                {
            //                    Name = product.Name,
            //                    ProductNumber = product.ProductNumber,
            //                    ListPrice = product.ListPrice
            //                };
            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Name: {0}", product.Name);
            //        Console.WriteLine("Product number: {0}", product.ProductNumber);
            //        Console.WriteLine("List price: ${0}", product.ListPrice);
            //        Console.WriteLine("");
            //    }
            //    Console.ReadKey();
            //}

            ////Usa una matriz como parte de una cláusula Where…Contains para encontrar todos los productos que tienen un ProductModelID que coincide con un valor de la matriz
            ////
            //using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            //{
            //    int?[] productModelIds = { 19, 26, 118 };
            //    var products = from p in AWEntities.Product
            //                   where productModelIds.Contains(p.ProductModelID)
            //                   select p;
            //    foreach (var product in products)
            //    {
            //        Console.WriteLine("{0}: {1}",
            //            product.ProductModelID, product.ProductID);
            //    }
            //    Console.ReadKey();
            //}

            ////Utiliza orderby… descending, que es equivalente al método OrderByDescending, para ordenar el precio de venta de mayor a menor
            ////
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    IQueryable<Decimal> sortedPrices = from p in context.Product
            //                                       orderby p.ListPrice descending
            //                                       select p.ListPrice;
            //    Console.WriteLine("Lista de precios desde el más alto al más bajo:");
            //    foreach (Decimal price in sortedPrices)
            //    {
            //        Console.WriteLine(price);
            //    }
            //    Console.ReadKey();
            //}

            ////Usa el método Average para encontrar el precio de venta promedio de los productos de cada estilo
            ////
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var products = context.Product;
            //    var query = from product in products
            //                group product by product.Style into g
            //                select new
            //                {
            //                    Style = g.Key,
            //                    AverageListPrice = g.Average(product => product.ListPrice)
            //                };
            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Estilo: {0} Precio promedio: {1}",
            //            product.Style, product.AverageListPrice);
            //    }
            //    Console.ReadKey();
            //}

            ////Se agrupan los productos por colores y se utiliza Count para devolver el número de productos de cada grupo de color
            ////
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            //{
            //    var products = context.Product;
            //    var query = from product in products
            //                group product by product.Color into g
            //                select new
            //                {
            //                    Color = g.Key,
            //                    ProductCount = g.Count()
            //                };
            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Color = {0} \t Cantidad = {1}",
            //            product.Color, product.ProductCount);
            //    }
            //    Console.ReadKey();
            //}

            ////Se utiliza el método Max para obtener el mayor importe total a pagar de cada identificador de contacto
            //using (AdventureWorksEntities eje16 = new AdventureWorksEntities())
            //{
            //    var orders = eje16.SalesOrderHeader;
            //    var query = from order in orders
            //                group order by order.SalesPersonID into g
            //                select new
            //                {
            //                    Category = g.Key,
            //                    maxTotalDue = g.Max(order => order.TotalDue)
            //                };
            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("Person ID: {0} TotalDue Máximo: {1}",
            //                order.Category, order.maxTotalDue);
            //    }
            //    Console.ReadKey();
            //}

        }
    }
}
