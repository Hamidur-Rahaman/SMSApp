using System;
using SMSApp.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMSApp.Models;

namespace SMSApp
{
    public partial class CategorySetupUi : Form
    {
        CategoryController _categoryController = new CategoryController();
        private Category category;
        private DataTable _dt;
        public int editCategoryId;
        private int id = 0;
        public CategorySetupUi()
        {
            InitializeComponent();
            LoadCategory();
            SaveButton.Text = "Save";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            category = new Category();
            if (!String.IsNullOrEmpty(categorySetupTextBox.Text))
            {
                category.Name = categorySetupTextBox.Text;
                category.ID = id;
                bool isSaved = _categoryController.SaveCategory(category);
                if (isSaved)
                {
                    MessageBox.Show("Category Information Saved.");
                    LoadCategory();
                    SaveButton.Text = "Save";
                    Clear();

                }
                else
                {
                    MessageBox.Show("Category Information Not Saved.");
                }

                LoadCategory();
            }
            else
            {
                MessageBox.Show("Name Can't be Empty, Enter A Name!");
            }

        }
        

        private void Clear()
        {
            categorySetupTextBox.Text = "";
            id = 0;
        }

        public void CategorySetupUi_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        public void LoadCategory()
        {
            _dt = new DataTable();
            showDataGridView.AutoGenerateColumns = false;
            _dt = _categoryController.GetCategory();
            showDataGridView.DataSource = _dt;
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CompanySetupUi().ShowDialog();
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ItemSetupUi().ShowDialog();
        }

        private void StockINButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StockInUi().ShowDialog();
        }
        private void StockInSearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchItemViewUi().ShowDialog();
        }

        private void DateWiseSearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchSalesViewUi().ShowDialog();
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.showDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StockOutUi().ShowDialog();
        }

        private void showDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                category = new Category();
                showDataGridView.CurrentRow.Selected = true;
                id = Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells["ID"].FormattedValue);
                categorySetupTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                SaveButton.Text = "Update";
            }
        }

        
       
    }
}
