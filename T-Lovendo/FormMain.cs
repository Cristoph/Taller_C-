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




            DataTable myDataTable = new DataTable();
            Product product = new Product();
            myDataTable = product.get_all();

            dataGridView_Product.DataSource = null;
            dataGridView_Product.DataSource = myDataTable;


        }

    }
}
