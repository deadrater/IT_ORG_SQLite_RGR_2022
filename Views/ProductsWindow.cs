using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT_ORG_SQLite_RGR_2022.Services;
using IT_ORG_SQLite_RGR_2022.Database;
using IT_ORG_SQLite_RGR_2022.Database.Models;
using IT_ORG_SQLite_RGR_2022.Controllers;
using IT_ORG_SQLite_RGR_2022.Views;

namespace IT_ORG_SQLite_RGR_2022.Views
{
    public partial class ProductsWindow : Form
    {
        public bool action = false;

        ProductsController controller = null;
        List<Product> psItems = null;
        User mUser = null;

        public ProductsWindow(User _user)
        {
            mUser = _user;
            controller = new ProductsController();
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exceptionTitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpdateForm(string search = "", string field = "")
        {
            try
            {
                psItems = controller.GetAllProductByFilter(search, field);
                if (psItems != null)
                {
                    productsDataGrid.Rows.Clear();
                    for (int i = 0; i < psItems.Count; i++)
                    {
                        productsDataGrid.Rows.Add(psItems[i]);
                        productsDataGrid[0, i].Value = psItems[i].Id;
                        productsDataGrid[1, i].Value = psItems[i].Name;
                        productsDataGrid[2, i].Value = psItems[i].Type;
                        productsDataGrid[3, i].Value = psItems[i].Price;
                        productsDataGrid[4, i].Value = "Сохранить";
                        productsDataGrid[5, i].Value = "Удалить";
                        productsDataGrid[6, i].Value = psItems[i].ImgUrl;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductsWindow_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void productsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            action = true;

            if (e.ColumnIndex == 8)
            {
                Product obj = new Product
                {
                    Id = Convert.ToInt32(productsDataGrid[0, e.RowIndex].Value),
                    Name = productsDataGrid[1, e.RowIndex].Value.ToString(),
                    Type = productsDataGrid[2, e.RowIndex].Value.ToString(),
                    Price = Convert.ToInt32(productsDataGrid[3, e.RowIndex].Value),
                    ImgUrl = productsDataGrid[6, e.RowIndex].Value.ToString(),
                };

                if (controller.UpdateSingleProduct(obj))
                {
                    action = false;
                    UpdateForm();
                }
                else
                {
                    MessageBox.Show("При обновлении ошибка", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Product obj = new Product
                {
                    Id = Convert.ToInt32(productsDataGrid[0, e.RowIndex].Value),
                    Name = productsDataGrid[1, e.RowIndex].Value.ToString(),
                    Type = productsDataGrid[2, e.RowIndex].Value.ToString(),
                    Price = Convert.ToInt32(productsDataGrid[3, e.RowIndex].Value),
                    ImgUrl = productsDataGrid[6, e.RowIndex].Value.ToString(),
                };

                if (e.ColumnIndex == 9)
                {
                    if (controller.DeleteSingleProduct(obj))
                    {
                        UpdateForm();
                    }
                    else
                    {
                        MessageBox.Show("При удалении ошибка", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        imgBox.Load(obj.ImgUrl);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }


        }
    }
}
