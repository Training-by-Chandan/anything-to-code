using DesktopApp.Service;
using DesktopApp.ViewModels;
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
        private readonly ProductService productService;

        public ManageProduct()
        {
            productService = new ProductService();

            InitializeComponent();
            productGrid.SelectionChanged += ProductGrid_SelectionChanged;
            editBtn.Click += EditBtn_Click;
            deleteBtn.Click += DeleteBtn_Click;
            searchTxt.KeyDown += SearchTxt_KeyDown; ;
        }

        private void SearchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowAllData(searchTxt.Text);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var result = productService.Delete(Convert.ToInt32(lblSelectedId.Text));
            if (result.Item1)
            {
                ShowAllData();
                ClearWithRemovingVisibility();
            }
            else
            {
                MessageBox.Show(result.Item2);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var product = new ProductViewModel()
            {
                Id = Convert.ToInt32(lblSelectedId.Text),
                Name = nameTxt.Text,
                Code = codeTxt.Text,
                Price = Convert.ToDecimal(priceTxt.Text),
                Quantity = Convert.ToInt32(quantityTxt.Text),
                Unit = unitCombo.SelectedItem.ToString(),
            };
            var result = productService.Edit(product);
            if (result.Item1)
            {
                ShowAllData();
                ClearWithRemovingVisibility();
            }
            else
            {
                MessageBox.Show(result.Item2);
            }
        }

        private void ProductGrid_SelectionChanged(object sender, EventArgs e)
        {
            var SelectedRows = productGrid.SelectedRows;
            if (SelectedRows.Count > 0)
            {
                var row = SelectedRows[0];
                PopulateRecords(row);
            }
            else
            {
                ClearWithRemovingVisibility();
            }
        }

        private void PopulateRecords(DataGridViewRow row)
        {
            nameTxt.Text = row.Cells["Name"].Value.ToString();
            codeTxt.Text = row.Cells["Code"].Value.ToString();
            priceTxt.Text = row.Cells["Price"].Value.ToString();
            quantityTxt.Text = row.Cells["Quantity"].Value.ToString();
            unitCombo.SelectedItem = row.Cells["Unit"].Value.ToString();
            lblSelectedId.Text = row.Cells["Id"].Value.ToString();

            editBtn.Visible = true;
            deleteBtn.Visible = true;
        }

        private void ClearWithRemovingVisibility()
        {
            ClearAll();
            lblSelectedId.Text = String.Empty;
            editBtn.Visible = false;
            deleteBtn.Visible = false;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var product = new ProductViewModel()
            {
                Name = nameTxt.Text,
                Code = codeTxt.Text,
                Price = Convert.ToDecimal(priceTxt.Text),
                Quantity = Convert.ToInt32(quantityTxt.Text),
                Unit = unitCombo.SelectedItem.ToString(),
            };
            var result = productService.Create(product);
            if (result.Item1)
            {
                ShowAllData();
                ClearAll();
            }
            else
            {
                MessageBox.Show(result.Item2);
            }
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void ShowAllData(string querydata = "")
        {
            var data = productService.GetAll(querydata);
            productGrid.DataSource = data.ToList();
            productGrid.Refresh();

            GenerateChart(data);
        }

        private void GenerateChart(List<ProductViewModel> data)
        {
            chart1.DataSource = data.ToList();
            chart1.Series["Records"].Points.Clear();
            chart1.Series["Records"].Color = Color.Red;
            foreach (var item in data)
            {
                chart1.Series["Records"].Points.AddXY(item.Code, item.Quantity);
            }
            chart1.Titles.Add("Chart 1");
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