using DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Forms.Products
{
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }

        private InventoryContext db = new InventoryContext();

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //write in database
            try
            {
                db.Products.Add(new Product()
                {
                    Name = nameTxt.Text,
                    Code = codeTxt.Text,
                    Price = Convert.ToDecimal(priceTxt.Text),
                    Quantity = Convert.ToInt32(quantityTxt.Text),
                    Unit = unitCombo.SelectedItem.ToString(),
                });
                db.SaveChanges();
                ShowAllData();
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void ShowAllData()
        {
            productGrid.DataSource = db.Products.ToList();
            productGrid.Refresh();
        }

        private void ClearAll()
        {
            nameTxt.Text = String.Empty;
            codeTxt.Text = String.Empty;
            quantityTxt.Text = String.Empty;
            unitCombo.SelectedIndex = 0;
            priceTxt.Text = String.Empty;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}