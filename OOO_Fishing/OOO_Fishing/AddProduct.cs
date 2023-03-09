using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOO_Fishing
{
    public partial class AddProduct : Form
    {
        static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog = Trade_dem_test; Data Source = DESKTOP-L9GHSSP\\SQLEXPRESS";
        SqlConnection connection = new SqlConnection(connectionString);
        string ProductArticle;
        bool AddRegime;
        public AddProduct()
        {
            AddRegime = true;
            InitializeComponent();
        }
        public AddProduct(string article)
        {
            ProductArticle = article;
            AddRegime = false;
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // если такого продукта нет то добавить, иначе изменить его
            if (AddRegime)
                ButtonAddProduct.Text = "Добавить";
            else
            {
                ButtonAddProduct.Text = "Изменить";
                connection.Open();
                SqlCommand commandGoodsInfo = connection.CreateCommand();
                commandGoodsInfo.CommandType = CommandType.StoredProcedure;
                commandGoodsInfo.CommandText = "ProductInfo";
                commandGoodsInfo.Parameters.AddWithValue("@article", ProductArticle);
                SqlDataReader readerInfo = commandGoodsInfo.ExecuteReader();
                if (readerInfo.HasRows)
                {
                    readerInfo.Read();
                    {
                        NameText.Text = readerInfo["ProductName"].ToString();
                        CategoryCombo.Text = readerInfo["ProductCategory"].ToString();
                        QuantityInStockText.Text = readerInfo["ProductQuantityInStock"].ToString();
                        MeasureText.Text = readerInfo["ProductMeasure"].ToString();
                        ProviderText.Text = readerInfo["ProductProvider"].ToString();
                        CostText.Text = readerInfo["ProductCost"].ToString();
                        DescriptionRich.Text = readerInfo["ProductDescription"].ToString();
                    }
                }
            }
            connection.Close();
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            // добавление продукта через процедуру если нет его
            connection.Open();
            SqlCommand commandAdd = connection.CreateCommand();
            if (AddRegime)
            {
                commandAdd.CommandText = "AddProduct";
                commandAdd.CommandType = CommandType.StoredProcedure;
                commandAdd.Parameters.AddWithValue("@name", NameText.Text);
                commandAdd.Parameters.AddWithValue("@category", CategoryCombo.Text);
                commandAdd.Parameters.AddWithValue("@quantity_in_stock", Convert.ToInt32(QuantityInStockText.Text));
                commandAdd.Parameters.AddWithValue("@measure", MeasureText.Text);
                commandAdd.Parameters.AddWithValue("@provider", ProviderText.Text);
                commandAdd.Parameters.AddWithValue("@cost", Convert.ToInt32(CostText.Text));
                commandAdd.Parameters.AddWithValue("@description", DescriptionRich.Text);

                try
                {
                    commandAdd.ExecuteNonQuery();
                    MessageBox.Show("Успешно!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
            // иначе изменить его
            else
            {
                commandAdd.CommandText = "UpdateProduct";
                commandAdd.CommandType = CommandType.StoredProcedure;
                commandAdd.Parameters.AddWithValue("@name", NameText.Text);
                commandAdd.Parameters.AddWithValue("@category", CategoryCombo.Text);
                commandAdd.Parameters.AddWithValue("@quantity_in_stock", Convert.ToInt32(QuantityInStockText.Text));
                commandAdd.Parameters.AddWithValue("@measure", MeasureText.Text);
                commandAdd.Parameters.AddWithValue("@provider", ProviderText.Text);
                commandAdd.Parameters.AddWithValue("@cost", Convert.ToInt32(CostText.Text));
                commandAdd.Parameters.AddWithValue("@description", DescriptionRich.Text);

                try
                {
                    commandAdd.ExecuteNonQuery();
                    MessageBox.Show("Успешно!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void CostText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // запрет ввода определенных символов
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-') || (e.KeyChar == ',') || (e.KeyChar == (char)Keys.Back))
                {
                    return;
                }
                e.Handled = true;
            }
        }
    }
}
