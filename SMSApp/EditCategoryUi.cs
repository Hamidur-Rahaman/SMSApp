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
using SMSApp.Models;
using SMSApp.BLL;

namespace SMSApp
{
    public partial class EditCategoryUi : Form
    {
        private Category category;
        CategoryController _categoryController = new CategoryController();
        public int ID;
        public EditCategoryUi()
        {
            InitializeComponent();
        }
        private void UpdateButton_Click_1(object sender, EventArgs e)
        {
            category = new Category();
            category.CategoryName = editCategoryNameTextBox.Text;
            category.ID = ID;
            if (!String.IsNullOrEmpty(editCategoryNameTextBox.Text))
            {
                bool isSaved = _categoryController.UpdateCategory(category);

                if (isSaved)
                {
                    MessageBox.Show("Information Updated Successfully!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Information Not Updated!");
                }
            }
            else
            {
                MessageBox.Show("Name Can't Be Empty, Enter a Name");
            }
            
        }

        private void Clear()
        {
            editCategoryNameTextBox.Text = "";

        }

        

        
    }
}
