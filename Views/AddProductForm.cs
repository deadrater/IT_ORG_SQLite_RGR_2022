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
    public partial class AddProductForm : Form
    {
        ProductsController controller = null;
        List<Product> psItems = null;
        User mUser = null;
        Form Form = null;

        public AddProductForm(User _user = null, Form _form = null)
        {
            mUser = _user;
            Form = _form;
            controller = new ProductsController();
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            ProductsController controller = new ProductsController();
            Product obj = new Product
            {
                Name = nameAddBox.Text,
                Type = typeAddBox.Text,
                Price = Convert.ToInt32(priceAddBox.Text),
                ImgUrl = imgUrlBox.Text,
            };

            if (nameAddBox.Text != String.Empty)
            {
                    if (typeAddBox.Text != String.Empty)
                    {
                        if (priceAddBox.Text != String.Empty)
                        {
                            if (imgUrlBox.Text != String.Empty)
                            {
                                if (controller.AddSingleNewProduct(obj))
                                {
                                    nameAddBox.Text = String.Empty;
                                    typeAddBox.Text = String.Empty;
                                    priceAddBox.Text = String.Empty;
                                    imgUrlBox.Text = String.Empty;
                                    this.Close();
                                    //MessageBox.Show("Покупатель успешно добавлен!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    //MessageBox.Show("При добавлении произошла ошибка", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
