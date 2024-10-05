using AventuraPAY.Models;
using AventuraPAY.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AventuraPAY.Controllers
{
    public class SalesController
    {
        private readonly SalesModel model;
        private readonly Sales view;

        public SalesController(Sales view)
        {
            this.model = new SalesModel();
            this.view = view;
        }

        public void LoadProducts()
        {
            var products = model.GetProducts();
            view.PopulateProducts(products);
        }

        public void AddProductToReceipt(string productName, int quantity)
        {
            double price = model.GetProductPrice(productName);
            double totalPrice = price * quantity;
            view.AddProductToReceiptList(productName, quantity, price, totalPrice);
            view.UpdateTotalAmount(totalPrice);
        }

        public void FinalizeReceipt(string products, double totalAmount, string paymentMethod, string clientDetails)
        {
            string username = model.GetLastLoggedInUser();
            int receiptId = model.SaveReceipt(products, totalAmount, paymentMethod, clientDetails, username);
            view.PrintReceipt(receiptId);
            view.ResetForm();
        }
    }
}
