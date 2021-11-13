using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.SqlClient;



namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //origen de datos
            NorthwndDataContext context = new NorthwndDataContext();

            //creacion de consulta: ALL PRODUCTS
            //var query = from p in context.Products
            //            select p;

            ////creacion de consulta: CATEGORIAS FILTRADAS "BEVERAGES"
            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Beverages"
            //            select p;

            ////creacion de consulta: POR PRECIO
            //var query = from p in context.Products
            //            where p.UnitPrice < 10
            //            select p;

            ////creacion de consulta: FILTRO NOMBRE 'QUESO'
            //var query = from p in context.Products
            //            where SqlMethods.Like(p.ProductName, "%Queso%")
            //            select p;

            ////creacion de consulta: presentación (QuantityPerUnit) productos cuya presentación sea paquetes (pkg o pkgs)
            //var query = from p in context.Products
            //            where SqlMethods.Like(p.QuantityPerUnit, "%pkg%")
            //            select p;

            ////creacion de consulta: Listar nombre, precio de productos que empiezan con la letra A
            //var query = from p in context.Products
            //            where SqlMethods.Like(p.ProductName, "A%")
            //            select p;


            ////creacion de consulta: Nombre de productos sin stock
            //var query = from p in context.Products
            //            where p.UnitsInStock == 0
            //            select p;

            //creacion de consulta: Nombre de productos descontinuados
            var query = from p in context.Products
                        where p.Discontinued == true
                        select p;


            //Ejecucion de consulta
            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice, prod.ProductName);
            }

            Console.ReadKey();
        }
    }
}
