﻿namespace _2_GenericTypes_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoriesOperation KatOperations = new CategoriesOperation();
            int count = KatOperations.List().Length;

            ProductOperation ProductOperations = new ProductOperation();    int sayi = ProductOperations.List().Length; 
        }
    }
}