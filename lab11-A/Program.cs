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
        }
    }
}
