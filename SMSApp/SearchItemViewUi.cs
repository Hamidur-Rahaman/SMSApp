using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SMSApp.BLL;
using SMSApp.Models;

namespace SMSApp
{
    public partial class SearchItemViewUi : Form
    {

        private static string _conStr = ConfigurationManager.ConnectionStrings["SMSDbContext"].ToString();
        private static SqlConnection _con = new SqlConnection(_conStr);
        private SqlCommand _cmd = new SqlCommand("", _con);

        ItemController _itemController = new ItemController();
        private DataTable dataTable;
        public SearchItemViewUi()
        {
            InitializeComponent();
            DataTable category = _itemController.GetLoadCategoryCombo();
            CategorycomboBox.DataSource = category;
            DataTable company = _itemController.GetLoadCompanyCombo();
            CompanycomboBox.DataSource = company;
        }
        

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        private void CompanycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            DataTable viewList = new DataTable();
            dataGridView.AutoGenerateColumns = false;
            int companyID = (int)CompanycomboBox.SelectedValue;
            int categoryID = (int)CategorycomboBox.SelectedValue;
            viewList = _itemController.SearchItem(companyID, categoryID);
            dataGridView.DataSource = viewList;
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
