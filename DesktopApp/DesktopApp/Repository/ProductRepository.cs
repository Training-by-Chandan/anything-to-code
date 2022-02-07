using DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Repository
{
    public static class ProductRepository
    {
        public static InventoryContext db = new InventoryContext();

        public static List<Product> GetAll(string query = "")
        {
            var data = db.Products.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(query))
            {
                query = query.Trim().ToLower();
                data = data.Where(p => p.Name.ToLower().Contains(query) || p.Code.ToLower().Contains(query));
            }
            return data.ToList();
        }

        public static (bool, string) Create(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                return (true, "Added Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.ToString());
            }
        }

        public static (bool, string) Edit(Product product)
        {
            try
            {
                var existin = db.Products.Find(product.Id);
                if (existin == null) return (false, "Record not found");
                existin.Name = product.Name;
                existin.Code = product.Code;
                existin.Price = product.Price;
                existin.Unit = product.Unit;
                existin.Quantity = product.Quantity;
                db.Entry(existin).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return (true, "Updated Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.ToString());
            }
        }

        public static (bool, string) Delete(int id)
        {
            try
            {
                var existin = db.Products.Find(id);
                if (existin == null) return (false, "Record not found");
                db.Products.Remove(existin);
                db.SaveChanges();
                return (true, "Updated Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.ToString());
            }
        }

        public static Product FindById(int id)
        {
            return db.Products.Find(id);
        }
    }
}