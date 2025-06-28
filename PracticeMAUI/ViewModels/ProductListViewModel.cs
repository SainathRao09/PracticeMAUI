using PracticeMAUI.Models;
using PracticeMAUI.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PracticeMAUI.ViewModels
{
    public class ProductListViewModel: BaseViewModel
    {
        private readonly ProductService _service;
        public ObservableCollection<Product> Products { get; set; }

        public ICommand LoadProductsCommand { get; }

        public ProductListViewModel()
        {
            _service = new ProductService();
            Products = new ObservableCollection<Product>();
            LoadProductsCommand = new Command(async () => await LoadProductsAsync());
            LoadProductsCommand.Execute(null);
        }

        private async Task LoadProductsAsync()
        {
            var products = await _service.GetProductsAsync();
            Products.Clear();
            foreach (var product in products)
                Products.Add(product);
        }
    }
}
