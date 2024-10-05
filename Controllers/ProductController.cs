using AventuraPAY.Models;
using AventuraPAY.Views;
using System;
using System.Collections.Generic;
using System.Data;

namespace AventuraPAY.Controllers
{
    public class ProductController
    {
        private readonly ProductModel model;
        private readonly Products view;
        private Views.produse produse;

        public ProductController(Products view)
        {
            this.model = new ProductModel();
            this.view = view;
        }

        public ProductController(Views.produse produse)
        {
            this.produse = produse;
        }

        public void LoadAllProducts()
        {
            DataTable products = model.GetAllProducts();
            view.UpdateProductPanel(products);
        }

        public void LoadProductNames()
        {
            List<string> productNames = model.GetProductNames();
            view.UpdateProductComboBox(productNames);
        }

        public void AddProduct(string produs, string pret, string categorie)
        {
            model.AddProduct(produs, pret, categorie);
            LoadAllProducts();
            LoadProductNames();
        }

        public void UpdateProduct(string produs, string newProdus, string pret, string categorie)
        {
            model.UpdateProduct(produs, newProdus, pret, categorie);
            LoadAllProducts();
            LoadProductNames();
        }

        public void DeleteProduct(string produs)
        {
            model.DeleteProduct(produs);
            LoadAllProducts();
            LoadProductNames();
        }

        public void LoadProductDetails(string produs)
        {
            DataRow productDetails = model.GetProductDetails(produs);
            if (productDetails != null)
            {
                view.DisplayProductDetails(productDetails);
            }
        }
    }
}
