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


namespace _30_Augest_2022
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

           /* string connectionString = @"Data Source= DESKTOP-O3IASDH\MSSQLSERVER02; Initial Catalog=xx; Integrated security=true;";

            SqlConnection co = new SqlConnection(connectionString);*/
            string query = " insert into [dbo].[Cosmo](number, id, name, manufDate, expireDate, qunatity, price) values('" + txtNumber.Text+"','"+txtId.Text+"','"+txtName.Text+"','"+dtpManu.Text.ToString()+"','"+dtpExpire.Text.ToString()+"','"+int.Parse(txtQuantity.Text)+"','"+int.Parse(txtPrice.Text)+"')";
            //String query = "Insert into test values('" + txtNumber.Text + "','" + txtName.Text + "')";
             Connection_Class.tie(query);
           

            Product p = new Product();

            p.name = txtName.Text;
            p.number = txtNumber.Text;
            p.id = txtId.Text;
            p.price = int.Parse(txtPrice.Text);
            p.quantity =int.Parse( txtQuantity.Text);
            p.manu_Date = dtpManu.Text;
            p.exp_date = dtpExpire.Text;

            p.save();
            List<Product> Data = new List<Product>();
            View_All v = new View_All();
            
               
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = @"Data Source= DESKTOP-O3IASDH\MSSQLSERVER02; Initial Catalog=Products; Integrated security=true;";

                SqlConnection co = new SqlConnection(connectionString);
                co.Open();

                //MessageBox.Show("Connected!");
            }

            catch
            {
                MessageBox.Show("Unable to connect, mtsm!");

            }
        }

        void getProductList()
        {

        }
    }
}
