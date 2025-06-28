using PracticeMAUI.Models;
using PracticeMAUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMAUI.ViewModels
{
    public class ProductDetailViewModel: BaseViewModel
    {
        private readonly ProductService _service;

        public Product Product { get; set; }

        public ProductDetailViewModel(int productId)
        {
            _service = new ProductService();
            LoadProduct(productId);
        }

        private async void LoadProduct(int id)
        {
            Product = await _service.GetProductByIdAsync(id);
            OnPropertyChanged(nameof(Product));
        }
    }
}
