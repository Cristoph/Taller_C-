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
        private DataTable product_DataTable_Stock = new DataTable();
        private DataTable product_DataTable_Price = new DataTable();
        private DataTable provider_DataTable = new DataTable();
        private Product product = new Product();
        private Provider provider = new Provider();

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
            //Provider_Init();
            //Load Ranking
            Ranking_Init_Stock();
            Ranking_Init_Price();
 
        }

        //-------------------- Init Tab --------------------//
        public void Ranking_Init_Stock()
        {   
            Product product1 = new Product();
            product_DataTable_Stock = product.GetAll();
            dataGridView_Stock.DataSource = null;
            dataGridView_Stock.DataSource = product_DataTable_Stock;
            dataGridView_Stock.Columns[2].Visible = false;//buyValue
            dataGridView_Stock.Columns[3].Visible = false;//sellValue
            dataGridView_Stock.Columns[7].Visible = false;//status
            dataGridView_Stock.Columns[8].Visible = false;//provider
            comboBox_Filter_stock.SelectedIndex = 0;
        }
        public void Ranking_Init_Price()
        {
            Product product2 = new Product();
            product_DataTable_Price = product.GetAll();
            dataGridView_Price.DataSource = null;
            dataGridView_Price.DataSource = product_DataTable_Price;
            dataGridView_Price.Columns[5].Visible = false;//stockMin
            dataGridView_Price.Columns[6].Visible = false;//stockMax
            dataGridView_Price.Columns[7].Visible = false;//status
            dataGridView_Price.Columns[8].Visible = false;//provider
            comboBox_Filter_price.SelectedIndex = 0;
        }
        private void Product_Init()
        {
            // Not Yet Implemented
            comboBox_Product_Provider.Enabled = false;
            label_product_prov_filter.ForeColor = System.Drawing.Color.Gray;
            comboBox_Product_Provider.ResetText();
            // #####################

            //Product product = new Product();
            product_DataTable = product.GetAll();
            dataGridView_Product.DataSource = null;
            dataGridView_Product.DataSource = product_DataTable;
            
            //dataGridView_Product.Rows[0].Selected = false; // fix row selected in load
            clearTexBox_Product();

            disableTexBox_Product(true);
            
            comboBox_Status.SelectedIndex = 2; //todos
            //comboBox_Product_Provider.SelectedIndex = 0;
            
            textBox_Prroduct_Search.Clear();
            textBox_Prroduct_Search.Focus();
            buttonSwinger_Product("new");

        }

        private void Provider_Init()
        {
            provider_DataTable = provider.GetAll();
            dataGridView_Provider.DataSource = null;
            dataGridView_Provider.DataSource = provider_DataTable;

            clearTexBox_Provider();

            disableTexBox_Provider(true);

            textBox_Provider_search.Clear();
            textBox_Provider_search.Focus();
            buttonSwinger_Product("new");
        }

        //-------------------- Load SelectedRow in TextBox --------------------//

        private void dataGridView_Product_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_Product.SelectedRows)
            {
                textBox_Code.Text = row.Cells[0].Value.ToString();
                textBox_Description.Text = row.Cells[1].Value.ToString();
                textBox_buyValue.Text = row.Cells[2].Value.ToString();
                textBox_sellValue.Text = row.Cells[3].Value.ToString();
                textBox_Stock.Text = row.Cells[4].Value.ToString();
                textBox_stockMin.Text = row.Cells[5].Value.ToString();
                textBox_stockMax.Text = row.Cells[6].Value.ToString();
                if(row.Cells[7].Value.ToString() == "True"){
                    comboBox_Product_status.SelectedIndex = 1;
                }
                //else if (row.Cells[7].Value.ToString() == "False")
                else
                {
                    comboBox_Product_status.SelectedIndex = 0;
                }
                //Console.WriteLine("cell: {0} - comb: {1}", row.Cells[7].Value, comboBox_Product_status.SelectedIndex); /// WHY??????
           
                textBox_Provider.Text = row.Cells[8].Value.ToString();   
            }
            //double a = product.sellValue_calculate(int.Parse(textBox_buyValue.Text));
            //Console.WriteLine(a);
            //textBox_sellValue.Text = a.ToString();

            disableTexBox_Product(true);
            buttonSwinger_Provider("edit");
        }

        

        private void dataGridView_Provider_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_Provider.SelectedRows)
            {
                textBox_Provider_rut.Text = row.Cells[0].Value.ToString();
                textBox_Provider_dv.Text = row.Cells[1].Value.ToString();
                textBox_Provider_name.Text = row.Cells[2].Value.ToString();
                textBox_Provider_lastname.Text = row.Cells[3].Value.ToString();
                textBox_Provider_desc.Text = row.Cells[4].Value.ToString();
                textBox_Provider_address.Text = row.Cells[5].Value.ToString();
                textBox_Provider_phone.Text = row.Cells[6].Value.ToString();
            }
            
            disableTexBox_Provider(true);
            buttonSwinger_Provider("edit");
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
            comboBox_Product_status.Enabled = !value;
            textBox_Provider.ReadOnly = value;
        }

        private void disableTexBox_Provider(bool value)
        {
            textBox_Provider_rut.ReadOnly = value;
            textBox_Provider_dv.ReadOnly = value;
            textBox_Provider_name.ReadOnly = value;
            textBox_Provider_lastname.ReadOnly = value;
            textBox_Provider_desc.ReadOnly = value;
            textBox_Provider_address.ReadOnly = value;
            textBox_Provider_phone.ReadOnly = value;
        }
        //-------------------- Enable/Disable Button --------------------//
        private void clearTexBox_Product()
        {
            textBox_Code.Clear();
            textBox_Description.Clear();
            textBox_buyValue.Clear();
            textBox_sellValue.Clear();
            textBox_Stock.Clear();
            textBox_stockMin.Clear();
            textBox_stockMax.Clear();
            comboBox_Product_status.ResetText();
            textBox_Provider.Clear();
        }
        private void clearTexBox_Provider()
        {
            textBox_Provider_rut.Clear();
            textBox_Provider_dv.Clear();
            textBox_Provider_name.Clear();
            textBox_Provider_lastname.Clear();
            textBox_Provider_desc.Clear();
            textBox_Provider_address.Clear();
            textBox_Provider_phone.Clear();
        }
        //-------------------- Enable/Disable Button --------------------//
        public void buttonSwinger_Product(string mode)
        {
            if(mode == "new")
            {
                button_Product_edit.Enabled = false;
                button_Product_delete.Enabled = false;
                button_Product_new.Enabled = true;
            }
            else if(mode == "edit")
            {
                button_Product_edit.Text = "Editar";
                button_Product_delete.Text = "Eliminar";
                button_Product_edit.Enabled = true;
                button_Product_delete.Enabled = true;
                button_Product_new.Enabled = true;
            }
            else if (mode == "save")
            {
                button_Product_edit.Text = "Guardar";
                button_Product_delete.Text = "Cancelar";
                button_Product_new.Enabled = false;
                button_Product_edit.Enabled = true;
                button_Product_delete.Enabled = true;
     
            }
        }

        public void buttonSwinger_Provider(string mode)
        {
            if (mode == "new")
            {
                button_Provider_edit_save.Enabled = false;
                button_Provider_del_can.Enabled = false;
                button_Provider_new.Enabled = true;
            }
            else if (mode == "edit")
            {
                button_Provider_edit_save.Text = "Editar";
                button_Provider_del_can.Text = "Eliminar";
                button_Provider_edit_save.Enabled = true;
                button_Provider_del_can.Enabled = true;
                button_Provider_new.Enabled = true;
            }
            else if (mode == "save")
            {
                button_Provider_edit_save.Text = "Guardar";
                button_Provider_del_can.Text = "Cancelar";
                button_Provider_new.Enabled = false;
                button_Provider_edit_save.Enabled = true;
                button_Provider_del_can.Enabled = true;

            }
        }
        //--------------------  Search --------------------//
        private void textBox_ProductSearch_TextChanged(object sender, EventArgs e)
        {
            
            product_DataTable = product.Search(textBox_Prroduct_Search.Text);
            dataGridView_Product.DataSource = null;
            dataGridView_Product.DataSource = product_DataTable;
            // other way
            //DataView product_DataView = product_DataTable.DefaultView;
            //product_DataView.RowFilter = "codigo LIKE '%" + textBox_Prroduct_Search.Text + "%' OR stock LIKE '%";
        }

        private void textBox_Provider_search_TextChanged(object sender, EventArgs e)
        {
            provider_DataTable = provider.Search(textBox_Provider_search.Text);
            dataGridView_Provider.DataSource = null;
            dataGridView_Provider.DataSource = provider_DataTable;
        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView product_DataView = product_DataTable.DefaultView;
            //Console.WriteLine("filter: {0}", comboBox_Status.SelectedIndex);
            if (comboBox_Status.SelectedIndex == 2)
            {
                product_DataView.RowFilter = "";
            }
            else
            {
                product_DataView.RowFilter = "estado = " + comboBox_Status.SelectedIndex + "";
            }
        }

        private void comboBox_Filter_stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView product_Filter_Stock_DataView = product_DataTable_Stock.DefaultView;
            if (comboBox_Filter_stock.SelectedIndex == 0)//Productos Bajo Stock 
            {
                product_Filter_Stock_DataView.RowFilter = "cantidadStock < stockMaximo";
            }
            else if (comboBox_Filter_stock.SelectedIndex == 1) //Productos Sobre Stock
            {
                product_Filter_Stock_DataView.RowFilter = "cantidadStock > stockMaximo";
            }
        }

        private void comboBox_Filter_price_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView product_Filter_Price_DataView = product_DataTable_Price.DefaultView;
            if (comboBox_Filter_price.SelectedIndex == 0)//Productos mas Caros
            {
                product_Filter_Price_DataView.Sort = "valorVenta DESC";
            }
            else if (comboBox_Filter_price.SelectedIndex == 1) //Productos mas Baratos 
            {
                product_Filter_Price_DataView.Sort = "valorVenta ASC";
            }
        }


        //--------------------  Reset --------------------//
        private void button_Product_refresh_Click(object sender, EventArgs e)
        {
            Product_Init();
        }
        private void button_Provider_reset_Click(object sender, EventArgs e)
        {
            Provider_Init();
        }
        private void button_Product_stock_Click(object sender, EventArgs e)
        {
            Ranking_Init_Stock();
        }
        private void button_Product_price_Click(object sender, EventArgs e)
        {
            Ranking_Init_Price();
        }

        private void tabControl_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_Main.SelectedIndex == 1)
            {
                Product_Init();
            }
            else if (tabControl_Main.SelectedIndex == 2)
            {
                Provider_Init();
            }
            else if (tabControl_Main.SelectedIndex == 0)
            {
                Ranking_Init_Stock();
                Ranking_Init_Price();
            }
        }
        // ----------------------------------------------------------------------------- //
        // Product new
        private void button_Product_new_Click(object sender, EventArgs e)
        {
            clearTexBox_Product();
            buttonSwinger_Product("save");
            disableTexBox_Product(false);
        }
        // Provider new
        private void button_Provider_new_Click(object sender, EventArgs e)
        {
            clearTexBox_Provider();
            buttonSwinger_Provider("save");
            disableTexBox_Provider(false);
        }

        //Product delete
        private void button_Product_delete_Click(object sender, EventArgs e)
        {
            if (button_Product_delete.Text == "Eliminar")
            {

                DialogResult dialogResult = MessageBox.Show("Desea eliminar: " + textBox_Description.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (product.Delete(textBox_Code.Text))
                    {
                        MessageBox.Show("Producto Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Product_Init();
                    }
                }
            }
            if (button_Product_delete.Text == "Cancelar")
            {
                buttonSwinger_Product("edit");
                disableTexBox_Product(true);
                textBox_Prroduct_Search.Focus();
            }
        }

        //Provider delete
        private void button_Provider_del_can_Click(object sender, EventArgs e)
        {
            if (button_Provider_del_can.Text == "Eliminar")
            {

                DialogResult dialogResult = MessageBox.Show("Desea eliminar: " + textBox_Provider_rut.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (provider.Delete(textBox_Provider_rut.Text))
                    {
                        MessageBox.Show("Producto Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Provider_Init();
                    }
                }
            }
            if (button_Provider_del_can.Text == "Cancelar")
            {
                buttonSwinger_Provider("edit");
                disableTexBox_Provider(true);
                textBox_Provider_search.Focus();
            }
        }

        //Product edit
        private void button_Product_edit_Click(object sender, EventArgs e)
        {
            if (button_Product_edit.Text == "Editar")
            {
                buttonSwinger_Product("save");
                disableTexBox_Product(false);

            }else if (button_Product_edit.Text == "Guardar")
            {
                Product product= new Product(int.Parse(textBox_Code.Text), textBox_Description.Text, int.Parse(textBox_buyValue.Text), int.Parse(textBox_sellValue.Text), 
                                            int.Parse(textBox_Stock.Text), int.Parse(textBox_stockMin.Text), int.Parse(textBox_stockMax.Text), 
                                            comboBox_Product_status.SelectedIndex, int.Parse(textBox_Provider.Text));
                if (product.UpdateOrInsert())
                {
                    MessageBox.Show("Productos Actualizados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //buttonSwinger_Product("edit");
                    //disableTexBox_Product(true);
                    //textBox_Prroduct_Search.Focus();
                    Product_Init();
                }
            }
        }

        //Provider edit
        private void button_Provider_edit_save_Click(object sender, EventArgs e)
        {
            if (button_Provider_edit_save.Text == "Editar")
            {
                buttonSwinger_Provider("save");
                disableTexBox_Provider(false);

            }
            else if (button_Provider_edit_save.Text == "Guardar")
            {
                Provider provider = new Provider(int.Parse(textBox_Provider_rut.Text), char.Parse(textBox_Provider_dv.Text), textBox_Provider_name.Text, textBox_Provider_lastname.Text, 
                                                    textBox_Description.Text, textBox_Provider_address.Text, textBox_Provider_phone.Text);
                if (provider.UpdateOrInsert())
                {
                    MessageBox.Show("Proveedor Actualizado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Provider_Init();
                }
            }
        }
        
        //Product sellValue Calcucale
        private void textBox_buyValue_Leave(object sender, EventArgs e)
        {
            if (textBox_buyValue.Text != "")
            {
                int sellValue = product.sellValue_calculate(int.Parse(textBox_buyValue.Text));
                textBox_sellValue.Text = sellValue.ToString();
            }
        }


















    }
}
