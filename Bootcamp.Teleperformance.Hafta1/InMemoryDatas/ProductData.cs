using Bootcamp.Teleperformance.Hafta1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Teleperformance.Hafta1.InMemoryDatas
{
    public class ProductData
    {
        private List<IModel> _products;

        public List<IModel> ProductsList
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
            }
        }

        public ProductData()
        {
            _products = new List<IModel>();

            ProductsList.Add(new Product { Id = 1, CategoryId = 1, Name = "Şarj Aleti", StockId = 1 });
            ProductsList.Add(new Product { Id = 2, CategoryId = 2, Name = "Şarj", StockId = 2 });
            ProductsList.Add(new Product { Id = 3, CategoryId = 3, Name = "Takvim", StockId = 3 });
            ProductsList.Add(new Product { Id = 4, CategoryId = 4, Name = "Kulaklık", StockId = 4 });
            ProductsList.Add(new Product { Id = 5, CategoryId = 5, Name = "Mouse", StockId = 5 });
            ProductsList.Add(new Product { Id = 6, CategoryId = 6, Name = "Monitör", StockId = 6 });
            ProductsList.Add(new Product { Id = 7, CategoryId = 7, Name = "Klavye", StockId = 7 });
            ProductsList.Add(new Product { Id = 8, CategoryId = 8, Name = "Cep Telefonu", StockId = 8 });
            ProductsList.Add(new Product { Id = 9, CategoryId = 9, Name = "Akıllı Saat", StockId = 9 });
        }

    }
}
