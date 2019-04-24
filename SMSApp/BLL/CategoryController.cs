using System;
using SMSApp.Models;
using SMSApp.DAL;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSApp.BLL
{
    public class CategoryController
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        DataTable _dt;
        public bool SaveCategory(Category category)
        {
            bool isSave = true;
            if (category.ID > 0)
            {
                isSave = _categoryRepository.SaveCategory(category);
            }
            else
            {
                bool isCheck = Exists(category);
                if (!isCheck)
                {
                    isSave = _categoryRepository.SaveCategory(category);
                }
                else
                {
                    MessageBox.Show("All Ready Exsit!!");
                }
            }
            
            return isSave;
        }

        public bool UpdateCategory(Category category)
        {
            bool isUpdate= true;
            isUpdate = _categoryRepository.UpdateCategory(category);
            return isUpdate;
        }

        public DataTable GetCategory()
        {
            _dt = new DataTable();
            _dt = _categoryRepository.GetCategory();
            return _dt;
        }

        public bool Exists(Category category)
        {
            bool isExists = false;
            isExists = _categoryRepository.Exists(category);
            return isExists;
        }
    }
}
