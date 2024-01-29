﻿using Microsoft.EntityFrameworkCore; // Include extension method
using System.Diagnostics;
using WorkingWithEFCore.AutoGen;
using Northwind = WorkingWithEFCore.AutoGen.Northwind; // Northwind, Category, Product
partial class Program
{
    static void QueryingCategories()
    {
        using (Northwind db = new())
        {
            SectionTitle("Categories and how many products they have:");
            // a query to get all categories and their related products
            IQueryable<Category>? categories = db.Categories?
              .Include(c => c.Products);
            if ((categories is null) || (!categories.Any()))
            {
                Fail("No categories found.");
                return;
            }
            // execute query and enumerate results
            foreach (Category c in categories)
            {
                WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
            }
        }
    }

    static void FilteredIncludes()
    {
        using (Northwind db = new())
        {
            SectionTitle("Products with a minimum number of units in stock.");
            string? input;
            int stock;
            do
            {
                Write("Enter a minimum for units in stock: ");
                input = ReadLine();
            } while (!int.TryParse(input, out stock));
            IQueryable<Category>? categories = db.Categories?
              .Include(c => c.Products.Where(p => p.UnitsInStock >= stock));
            if ((categories is null) || (!categories.Any()))
            {
                Fail("No categories found.");
                return;
            }

            Info($"ToQueryString: {categories.ToQueryString()}");
            foreach (Category c in categories)
            {
                WriteLine($"{c.CategoryName} has {c.Products.Count} products with a minimum of {stock} units in stock.");
                foreach (Product p in c.Products)
                {
                    WriteLine($"  {p.ProductName} has {p.UnitsInStock} units in stock.");
                }
            }
        }
    }

    static void QueryingProducts()
    {
        using (Northwind db = new())
        {
            SectionTitle("Products that cost more than a price, highest at top.");
            string? input;
            decimal price;
            do
            {
                Write("Enter a product price: ");
                input = ReadLine();
            } while (!decimal.TryParse(input, out price));

            IQueryable<Product>? products = db.Products?
              .TagWith("Products filtered by price and sorted.")
              .Where(product => product.UnitPrice > price)
              .OrderByDescending(product => product.UnitPrice);

            if ((products is null) || (!products.Any()))
            {
                Fail("No products found.");
                return;
            }

            Info($"ToQueryString: {products.ToQueryString()}");
            foreach (Product p in products)
            {
                WriteLine(
                  "{0}: {1} costs {2:$#,##0.00} and has {3} in stock.",
                  p.ProductId, p.ProductName, p.UnitPrice, p.UnitsInStock);
            }
        }
    }
}