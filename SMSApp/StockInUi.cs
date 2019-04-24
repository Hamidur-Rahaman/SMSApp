using System;
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
using SMSApp.BLL;
using SMSApp.Models;

namespace SMSApp
{
    
    public partial class StockInUi : Form
    {
        Company company = new Company();
        StockOutManager _stockOutManager = new StockOutManager();
        StockInController _stockInController = new StockInController();
        public StockInUi()
        {
            InitializeComponent();
            companyBindingSource.DataSource = null;
            companyBindingSource.DataSource = _stockOutManager.GetCompany();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool isSave = false;
            StockIN stockIn = new StockIN();
            DateTime toDateTime = DateTime.Now;
            stockIn.StockInQuantity = Convert.ToDecimal(stockInQuantityTextBox.Text);
            stockIn.CompanyID = Convert.ToInt32(companyComboBox.SelectedValue);
            stockIn.ItemID = Convert.ToInt32(itemComboBox.SelectedValue);
            stockIn.StockINDate = toDateTime;
            Item item = new Item();
            item.ID = stockIn.ItemID;
            item.AvailableQuantity = Convert.ToDecimal(availableQuantityTextBox.Text) + stockIn.StockInQuantity;

            isSave = _stockInController.SaveStockIN(stockIn, item);
            if (isSave)
            {
                MessageBox.Show("Stock In Save!!");
                Clear();
            }
            else
            {
                MessageBox.Show("Stock In Not Save!!");
            }
        }
        private void Clear()
        {
            companyComboBox.Text = "";
            itemComboBox.Text = "";
            reOrderLevelTextBox.Text = "";
            availableQuantityTextBox.Text = "";
            stockInQuantityTextBox.Text = "";
        }
        private void companyComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Item item = new Item();
            itemBindingSource.DataSource = null;
            item.CompanyID = Convert.ToInt32(companyComboBox.SelectedValue);
            itemBindingSource.DataSource = _stockOutManager.GetItem(item);
        }

        private void ItemComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            StockOut stockOut = new StockOut();
            Item item = new Item();
            stockOut.ItemID = Convert.ToInt32(itemComboBox.SelectedValue);
            item = _stockOutManager.GetFieldData(stockOut);
            if (item.ReorderLevel != null || item.AvailableQuantity != null)
            {
                reOrderLevelTextBox.Text = item.ReorderLevel.ToString();
                availableQuantityTextBox.Text = item.AvailableQuantity.ToString();
            }
            else
            {
                reOrderLevelTextBox.Text = "0";
                availableQuantityTextBox.Text = "0";
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CategorySetupUi().ShowDialog();
        }
        private void ItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ItemSetupUi().ShowDialog();
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CompanySetupUi().ShowDialog();
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

        private void StockOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StockOutUi().ShowDialog();
        }
    }
}
