using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Lovendo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private DataTable product_DataTable = new DataTable();
        private DataTable provider_DataTable = new DataTable();

        //-------------------- MAIN --------------------//
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Date in status bar
            StatusLabel_DateTime.Text = DateTime.Now.ToLongDateString();
            // Test DBConnect
            ConexionBD cnn = new ConexionBD();
            if (cnn.compruebaConexion())
            {
                StatusLabel_status.Text = "OK";
            }
            else
            {
                StatusLabel_status.Text = "NOK";
            }
       
            //Inital in Ranking, fix for rigth align
            tabControl_Main.SelectedIndex = 2;
            // Load ranking

            //Load Product 
            Product_Init();
            //Load Provider
 
        }

        //-------------------- Init Tab --------------------//
        private void Ranking_Init()
        {
        }

        private void Product_Init()
        {
            Product product = new Product();
            product_DataTable = product.GetAll();
            dataGridView_Product.DataSource = null;
            dataGridView_Product.DataSource = product_DataTable;
           
            disableTexBox_Product(true);
            
            textBox_Prroduct_Search.Clear();
            
            comboBox_Status.SelectedIndex = 0;
            comboBox_Product_Provider.SelectedIndex = 0;
        }

        private void Provider_Init()
        {
        }

        //-------------------- Load SelectedRow in TextBox --------------------//

        private void dataGridView_Product_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_Product.SelectedRows)
            {
                textBox_Code.Text = row.Cells[0].Value.ToString();
                textBox_Description.Text = row.Cells[1].Value.ToString();
                textBox_buyValue.Text = row.Cells[2].Value.ToString();
                textBox_Stock.Text = row.Cells[3].Value.ToString();
                textBox_stockMin.Text = row.Cells[4].Value.ToString();
                textBox_stockMax.Text = row.Cells[5].Value.ToString();
                textBox_Status.Text = row.Cells[6].Value.ToString();
                textBox_Provider.Text = row.Cells[7].Value.ToString();   
            }
        }

        private void dataGridView_Provider_SelectionChanged(object sender, EventArgs e)
        {
        }

        //--------------------  Enable/Disable TexBox --------------------//
        private void disableTexBox_Product(bool value)
        {
            textBox_Code.ReadOnly = value;
            textBox_Description.ReadOnly = value;
            textBox_buyValue.ReadOnly = value;
            textBox_Stock.ReadOnly = value;
            textBox_stockMin.ReadOnly = value;
            textBox_stockMax.ReadOnly = value;
            textBox_Status.ReadOnly = value;
            textBox_Provider.ReadOnly = value;
        }

        private void disableTexBox_Provider(bool value)
        {
        }

        //--------------------  Search --------------------//
        private void textBox_ProductSearch_TextChanged(object sender, EventArgs e)
        {
            Product product = new Product();
            product_DataTable = product.Search(textBox_Prroduct_Search.Text);
            dataGridView_Product.DataSource = null;
            dataGridView_Product.DataSource = product_DataTable;
            // other way
            //DataView product_DataView = product_DataTable.DefaultView;
            //product_DataView.RowFilter = "codigo LIKE '%" + textBox_Prroduct_Search.Text + "%' OR stock LIKE '%";
        }

        private void textBox_ProviderSearch_TextChanged(object sender, EventArgs e)
        {
        }
        
        //--------------------  Reset --------------------//
        private void button_Product_refresh_Click(object sender, EventArgs e)
        {
            Product_Init();
        }

        private void button_Provider_refresh_Click(object sender, EventArgs e)
        {
            Provider_Init();
        }
        
    }
}
