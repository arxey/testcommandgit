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
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOO_Fishing
{
    public partial class Goods : Form
    {
        static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog = Trade_dem_test; Data Source = DESKTOP-L9GHSSP\\SQLEXPRESS";
        SqlConnection connection = new SqlConnection(connectionString);
        string selectedArticle;
        public Goods()
        {
            InitializeComponent();
        }

        private void Goods_Load(object sender, EventArgs e)
        {
            // загрузка данных из базы в форму 
            connection.Open();
            SqlCommand commandLoadGoods = connection.CreateCommand();
            commandLoadGoods.CommandText = "SELECT ProductArticleNumber as Артикул, ProductName as Наименование, ProductDescription as Описание, ProductCategory as Категория, ProductPhoto as Изображение, ProductManufacturer as Производитель, ProductProvider as Поставщик, ProductCost as Стоимость, ProductDiscountAmount as Размер_текущей_скидки, ProductDiscountMax as Размер_максимально_возможной_скидки, ProductQuantityInStock as Количество_на_складе, ProductMeasure as Единица_измерения FROM Product";
            SqlDataAdapter adapterLoads = new SqlDataAdapter(commandLoadGoods);
            DataSet datasetLoads = new DataSet();
            adapterLoads.Fill(datasetLoads);
            GoodsView.DataSource = datasetLoads.Tables[0];
            GoodsView.Columns[0].Visible = false;
            LabelAll.Text = (GoodsView.Rows.Count - 1).ToString();
            change_count();
            connection.Close();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            // Реализация поиска
            (GoodsView.DataSource as DataTable).DefaultView.RowFilter = $"Наименование LIKE '%{SearchText.Text}%'";
        }

        private void ComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //фильтрация по производителю
            switch (ComboBoxFilter.SelectedIndex)
            {
                case 0:
                    (GoodsView.DataSource as DataTable).DefaultView.RowFilter = "";
                    break;
                case 1:
                    (GoodsView.DataSource as DataTable).DefaultView.RowFilter = $"Производитель == SevereLand";
                    break;
                case 2:
                    (GoodsView.DataSource as DataTable).DefaultView.RowFilter = $"Производитель == Kuusamo";
                    break;
                case 3:
                    (GoodsView.DataSource as DataTable).DefaultView.RowFilter = $"Производитель == Gamma";
                    break;
                case 4:
                    (GoodsView.DataSource as DataTable).DefaultView.RowFilter = $"Производитель == Westin";
                    break;
                case 5:
                    (GoodsView.DataSource as DataTable).DefaultView.RowFilter = $"Производитель == Aquatech";
                    break;
                case 6:
                    (GoodsView.DataSource as DataTable).DefaultView.RowFilter = $"Производитель == Stinger";
                    break;
                case 7:
                    (GoodsView.DataSource as DataTable).DefaultView.RowFilter = $"Производитель == LumiCom";
                    break;
                case 8:
                    (GoodsView.DataSource as DataTable).DefaultView.RowFilter = $"Производитель == Usami";
                    break;
                case 9:
                    (GoodsView.DataSource as DataTable).DefaultView.RowFilter = $"Производитель == Ultron";
                    break;
                case 10:
                    (GoodsView.DataSource as DataTable).DefaultView.RowFilter = $"Производитель == Balsax";
                    break;
                case 11:
                    (GoodsView.DataSource as DataTable).DefaultView.RowFilter = $"Производитель == Momoi";
                    break;
            }
            change_count();
        }

        public void change_count()
        {
            LabelCount.Text = (GoodsView.Rows.Count - 1).ToString();
        }

        private void GoodsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // При нажатии отображается информация о товаре
            LabelAvailable.Text = GoodsView.CurrentRow.Cells[10].Value.ToString();
            LabelName.Text = GoodsView.CurrentRow.Cells[1].Value.ToString();
            LabelDescription.Text = GoodsView.CurrentRow.Cells[2].Value.ToString();
            LabelManufacturer.Text = GoodsView.CurrentRow.Cells[5].Value.ToString();
            LabelPrice.Text = GoodsView.CurrentRow.Cells[7].Value.ToString();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            // переход на форму добавления продукта
            if (Application.OpenForms["AddProduct"] == null)
            {
                AddProduct fm = new AddProduct();
                this.Hide();
                fm.ShowDialog();
                this.Show();
            }
        }

        private void GoodsView_MouseDown(object sender, MouseEventArgs e)
        {
            // при наведении открывается контекстное меню с кнопкой изменения товара
            if (e.Button == MouseButtons.Right)
            {
                var hit = GoodsView.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    GoodsView.ClearSelection();
                    GoodsView.Rows[hit.RowIndex].Selected = true;
                    ContextMenuOrder.Show(GoodsView, e.Location);
                    selectedArticle = GoodsView.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
        }

        private void ToolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            Form Form3 = new AddProduct(selectedArticle);
            Hide();
            Form3.ShowDialog();
            this.Show();
        }

        private void Goods_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
