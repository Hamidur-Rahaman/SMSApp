using System;
using SMSApp.Models;
using SMSApp.DAL;
using SMSApp.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SMSApp
{
    public partial class StockOutUi : Form
    {
        SqlFactory _sqlFactory = new SqlFactory();
        StockOutManager _stockOutManager = new StockOutManager();
        private List<StockOut> stockOut = new List<StockOut>();
        private List<Item> itemQuantity = new List<Item>();
        
        public StockOutUi()
        {
            InitializeComponent();
            dataGridView.DataSource = null;
            LoadCompanyData();
        }

        public void LoadCompanyData()
        {
            companyBindingSource6.DataSource = null;
            companyBindingSource6.DataSource = _stockOutManager.GetCompany();
        }
        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = new Item();
            itemBindingSource2.DataSource = null;
            item.CompanyID = Convert.ToInt32(companyComboBox.SelectedValue);
            itemBindingSource2.DataSource = _stockOutManager.GetItem(item);
        }

        private int i = 0;
        private int j = 0;

        public bool Exsit()
        {
            bool isExsit = false;
            for (int k = 0; k < stockOut.Count; k++)
            {
                if (stockOut[k].CompanyID == (int)companyComboBox.SelectedValue && stockOut[k].ItemID == (int)itemComboBox.SelectedValue)
                {
                    isExsit = true;
                }
            }
            return isExsit;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (companyComboBox.SelectedValue != null && itemComboBox.SelectedValue != null && stockOutQuantityTextBox.Text != "")
            {
                StockOut stock = new StockOut();
                Item item = new Item();
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = null;
                stock.CompanyID = Convert.ToInt32(companyComboBox.SelectedValue);
                stock.ItemID = Convert.ToInt32(itemComboBox.SelectedValue);
                stock.StockOutDate = DateTime.Now;
                stock.StockOutQuantity = Convert.ToDecimal(stockOutQuantityTextBox.Text);
                item.AvailableQuantity = (Convert.ToDecimal(abailableQuantityTextBox.Text));
                stock.CompanyName = companyComboBox.Text;
                stock.ItemName = itemComboBox.Text;
                if (Convert.ToDecimal(abailableQuantityTextBox.Text) < stock.StockOutQuantity)
                {
                    MessageBox.Show("Please AbailableQuntity less then Stock Out Quantity!!");
                    dataGridView.DataSource = stockOut;
                    return;
                }
                if (Exsit())
                {
                    MessageBox.Show("Company And Item Allready Exsit!!");
                    dataGridView.DataSource = stockOut;
                    return;
                }
                stockOut.Add(stock);
                dataGridView.DataSource = stockOut;
                while (j <= i)
                {
                    item.AvailableQuantity -= stock.StockOutQuantity;
                    item.ID = stock.ItemID;
                    itemQuantity.Add(item);
                    j++;
                }
                i++;
                
            }
            else
            {
                MessageBox.Show("Please All Field Required");
            }
            
            
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            bool isSave = false;
            _sqlFactory = new SqlFactory();
            foreach (var list in stockOut)
            {
                list.Status = "S";
            }
            _stockOutManager.SaveStockOut(stockOut, itemQuantity);
            if (!isSave)
            {
                MessageBox.Show("Save Success!!");
                dataGridView.DataSource = null;
                stockOut = new List<StockOut>();
                SaveClearData();
            }
            else
            {
                MessageBox.Show("Not Save Success!!");
                SaveClearData();
            }
        }

        // Damage Save
        private void DamageButton_Click(object sender, EventArgs e)
        {
            bool isSave = false;
            _sqlFactory = new SqlFactory();
            foreach (var list in stockOut)
            {
                list.Status = "D";
            }
            _stockOutManager.SaveStockOut(stockOut, itemQuantity);
            if (!isSave)
            {
                MessageBox.Show("Save Success!!");
                dataGridView.DataSource = null;
                stockOut = new List<StockOut>();
                SaveClearData();
            }
            else
            {
                MessageBox.Show("Not Save Success!!");
                SaveClearData();
            }
        }

        //Lost 

        private void LostButton_Click(object sender, EventArgs e)
        {
            bool isSave = false;
            _sqlFactory = new SqlFactory();
            foreach (var list in stockOut)
            {
                list.Status = "L";
            }
            _stockOutManager.SaveStockOut(stockOut, itemQuantity);
            if (!isSave)
            {
                MessageBox.Show("Save Success!!");
                dataGridView.DataSource = null;
                stockOut = new List<StockOut>();
                SaveClearData();
            }
            else
            {
                MessageBox.Show("Not Save Success!!");
                SaveClearData();
            }
        }
        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockOut stockOut = new StockOut();
            Item item = new Item();
            stockOut.ItemID = Convert.ToInt32(itemComboBox.SelectedValue);
            item = _stockOutManager.GetFieldData(stockOut);
            if (item.ReorderLevel != null || item.AvailableQuantity != null)
            {
                reorderLevelTextBox.Text = item.ReorderLevel.ToString();
                abailableQuantityTextBox.Text = item.AvailableQuantity.ToString();
            }
            else
            {
                reorderLevelTextBox.Text = "0";
                abailableQuantityTextBox.Text = "0";
            }


        }

        public void Clear()
        {
            stockOutQuantityTextBox.Text = "";
        }
        public void SaveClearData()
        {
            companyComboBox.SelectedValue = 0;
            itemComboBox.SelectedValue = 0;
            itemComboBox.Text = "";
            stockOutQuantityTextBox.Text = "";
            reorderLevelTextBox.Text = "";
            abailableQuantityTextBox.Text = "";
            dataGridView.DataSource = null;
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
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




        




        //int row = 0;
        //dataGridView.Rows.Add();
        //row = dataGridView.Rows.Count - 2;
        //dataGridView["CompanyID", row].Value = stock.CompanyID;
        //dataGridView["ItemID", row].Value = stock.ItemID;
        //dataGridView["StockOutQuantity", row].Value = stock.StockOutQuantity;


    }
}
