using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public void Add(Products newValue)
        {
            context.Products.Add(newValue);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productoAEliminar = context.Products.Find(id);
            context.Products.Remove(productoAEliminar);
            context.SaveChanges();
        }

        public void Update(Products value)
        {
            var productUpdate = context.Products.Find(value.ProductID);

            productUpdate.ProductName = value.ProductName;
            productUpdate.QuantityPerUnit = value.QuantityPerUnit;
            productUpdate.UnitPrice = value.UnitPrice;

            context.SaveChanges();
        }
    }
}
