using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IctBaden.Api1NCE;
using IctBaden.Api1NCE.Models;
using IctBaden.Stonehenge3.Core;
using IctBaden.Stonehenge3.ViewModel;
// ReSharper disable MemberCanBePrivate.Global

namespace IctBaden._1NCE.Dashboard.ViewModels
{
    public class ProductsVm : ActiveViewModel
    {
        public List<Product> Products => GetProducts();


        public ProductsVm(AppSession session) : base(session)
        {
        }

        private List<Product> _products;
        private List<Product> GetProducts()
        {
            if (_products != null)
            {
                return _products;
            }
            
            _products = new List<Product>
            {
                new Product { Name = "loading..." }
            };

            Task.Run(() =>
            {
                try
                {
                    var products = new ProductsV1(DefaultUrls.Api, Program.ApiToken);
                    _products = products.GetProducts()
                        .OrderBy(prod => prod.Name)
                        .ToList();
                }
                catch (Exception ex)
                {
                    _products = new List<Product>
                    {
                        new Product { Name = ex.Message }
                    };
                }
                    
                NotifyPropertyChanged(nameof(Products));
            });

            return _products;
        }
        
    }
}
