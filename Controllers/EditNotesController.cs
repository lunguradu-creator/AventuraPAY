using AventuraPAY.Models;
using AventuraPAY.Views;
using System;
using System.Collections.Generic;

namespace AventuraPAY.Controllers
{
    public class EditNotesController
    {
        private readonly EditNotesForm view;
        private readonly ReceiptModel model;

        public EditNotesController(EditNotesForm view)
        {
            this.view = view;
            this.model = new ReceiptModel();
        }

        public void LoadReceipts(string searchQuery = "", DateTime? filterDate = null)
        {
            List<Receipt> receipts = model.GetReceipts(searchQuery, filterDate);
            view.DisplayReceipts(receipts);
        }

        public void SaveReceipt(Receipt receipt)
        {
            model.UpdateReceipt(receipt);
        }

        public void DeleteReceipt(int receiptId)
        {
            model.DeleteReceipt(receiptId);
        }
    }
}
