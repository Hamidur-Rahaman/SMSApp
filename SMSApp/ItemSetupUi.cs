using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMSApp.BLL;
using SMSApp.Models;

namespace SMSApp
{
    public partial class ItemSetupUi : Form
    {
        
        ItemController _itemController = new ItemController();
        Item item = new Item();
        Category category = new Category();
        Company company = new Company();
        public ItemSetupUi()
        {
            InitializeComponent();
            catagoryComboBox.DataSource = _itemController.GetLoadCategoryCombo();
            companyComboBox.DataSource = _itemController.GetLoadCompanyCombo();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool isSave = false;
            item.ItemName = itemTextBox.Text;
            item.ReorderLevel = Convert.ToDecimal(reorderLevelTextBox.Text);
            item.CategoryID = (int)catagoryComboBox.SelectedValue;
            item.CompanyID = (int)companyComboBox.SelectedValue;
            item.AvailableQuantity = 0;
            isSave = _itemController.SaveItem(item);
            if (isSave)
            {
                MessageBox.Show("Successfully Saved");
                Clear();
            }
            else
            {
                MessageBox.Show("not Saved");
            }
        }

        private void Clear()
        {
            catagoryComboBox.Text = "";
            companyComboBox.Text = "";
            itemTextBox.Text = "";
            reorderLevelTextBox.Text = "0";
        }

        private void StockINButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StockInUi().ShowDialog();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CategorySetupUi().ShowDialog();
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CompanySetupUi().ShowDialog();
        }

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StockOutUi().ShowDialog();
        }

        private void StockInSearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchSalesViewUi().ShowDialog();
        }

        private void DateWiseSearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchSalesViewUi().ShowDialog();
        }

    }
}
