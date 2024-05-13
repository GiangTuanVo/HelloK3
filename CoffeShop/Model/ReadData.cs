using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop.Model
{
    public class ReadData
    {
        public static DataSet fileData = new DataSet();
        public ReadData(string path)
        {
            DataTable productData = new DataTable("Product");
            DataTable userData = new DataTable("User");
            CSVFile.FileToTBL(path, "product.csv", fileData, productData);
            CSVFile.FileToTBL(path, "user.csv", fileData, userData);
        }
    }
}
