using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_ORG_SQLite_RGR_2022.Database;
using IT_ORG_SQLite_RGR_2022.Database.Models;
using IT_ORG_SQLite_RGR_2022.Services;

namespace IT_ORG_SQLite_RGR_2022.Controllers
{
    public class ProductsController
    {
        private SettingsDatabase settingsDatabase = new SettingsDatabase();
        public List<Product> GetAllProductByFilter(string search = "", string field = "")
        {
            List<Product> products = null;

            try
            {
                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if (search == "")
                    {
                        products = db.Products.OrderBy(g => g.Name).ToList();
                    }
                    else
                    {
                        var list = db.Products.ToList();
                        switch (field)
                        {
                            case "common":
                                products = list
                                    .Where(
                                        g => g.Name.ToString().ToLower().Contains(search.ToLower())
                                        || g.Type.ToString().ToLower().Contains(search.ToLower())
                                        || g.Price.ToString().ToLower().Contains(search.ToLower())
                                    ).OrderBy(g => g.Name).ToList();
                                break;

                            case "name":
                                products = list
                                    .Where(
                                        g => g.Name.ToString().ToLower().Contains(search.ToLower())
                                    ).OrderBy(g => g.Name).ToList();
                                break;

                            case "type":
                                products = list
                                    .Where(
                                        g => g.Type.ToString().ToLower().Contains(search.ToLower())
                                    ).OrderBy(g => g.Name).ToList();
                                break;

                            case "price":
                                products = list
                                    .Where(
                                        g => g.Price.ToString().ToLower().Contains(search.ToLower())
                                    ).OrderBy(g => g.Name).ToList();
                                break;
                            default:
                                products = list.OrderBy(g => g.Name).ToList();
                                break;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }

            return products;
        }

        public Product GetSingleProduct(int _id)
        {
            Product product = null;

            try
            {
                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if (db.Products.Any(g => g.Id == _id))
                    {
                        product = db.Products.FirstOrDefault(g => g.Id == _id);
                    }
                }
            }
            catch
            {
                return null;
            }

            return product;
        }

        public bool AddSingleNewProduct(Product obj)
        {
            bool result = false;

            try
            {
                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    db.Products.Add(obj);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public bool DeleteSingleProduct(Product obj)
        {
            bool result = false;

            try
            {
                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if (db.Products.Any(g => g.Id == obj.Id))
                    {
                        db.Products.Remove(obj);
                        db.SaveChanges();
                        result = true;
                    }
                }
            }
            catch
            {
                return false;
            }

            return result;
        }

        public bool UpdateSingleProduct(Product obj)
        {
            bool result = false;

            try
            {
                using (_ContextDb db = new _ContextDb(settingsDatabase.GetDbContextOptions()))
                {
                    if (db.Products.Any(g => g.Id == obj.Id))
                    {
                        db.Products.Update(obj);
                        db.SaveChanges();
                        result = true;
                    }
                }
            }
            catch
            {
                return false;
            }

            return result;
        }
    }
}
