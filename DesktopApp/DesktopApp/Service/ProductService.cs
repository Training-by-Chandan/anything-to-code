using DesktopApp.Models;
using DesktopApp.Repository;
using DesktopApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Service
{
    public class ProductService
    {
        private readonly EmailService emailService;

        public ProductService()
        {
            this.emailService = new EmailService();
        }

        public List<ProductViewModel> GetAll(string query = "")
        {
            var data = ProductRepository.GetAll(query);
            if (data != null)
            {
                return data.Select(p => new ProductViewModel
                {
                    Code = p.Code,
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    Unit = p.Unit
                }).ToList();
            }
            return null;
        }

        public (bool, string) Create(ProductViewModel model)
        {
            var product = new Product()
            {
                Code = model.Code,
                Name = model.Name,
                Price = model.Price,
                Quantity = model.Quantity,
                Unit = model.Unit
            };
            var result = ProductRepository.Create(product);
            if (result.Item1)
            {
                Task t1 = new Task(() => { emailService.SendEmail(); });
                t1.Start();
            }
            return result;
        }

        public (bool, string) Edit(ProductViewModel model)
        {
            var product = new Product()
            {
                Code = model.Code,
                Name = model.Name,
                Price = model.Price,
                Quantity = model.Quantity,
                Unit = model.Unit
            };
            return ProductRepository.Edit(product);
        }

        public (bool, string) Delete(int id)
        {
            return ProductRepository.Delete(id);
        }
    }
}