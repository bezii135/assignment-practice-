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
    public partial class UpdatePage : Form
    {
        public UpdatePage()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          // string  query= "update "
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = @"Data Source= DESKTOP-O3IASDH\MSSQLSERVER02; Initial Catalog=xx; Integrated security=true;";

                SqlConnection co = new SqlConnection(connectionString);
                co.Open();

                MessageBox.Show("Connected!");

                String query = "select * from Product where id='" + textBox1 + "'";
                SqlCommand cmd = new SqlCommand(query, co);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    txtNum.Text = da.GetValue(0).ToString();
                    txtId.Text = da.GetValue(1).ToString();
                    txtName.Text = da.GetValue(2).ToString();
                    txtManu.Text = da.GetValue(3).ToString();
                    txtExp.Text = da.GetValue(4).ToString();
                    tt.Text = da.GetValue(5).ToString();
                    txtPrice.Text = da.GetValue(6).ToString();
                }
                

                var result= cmd.ExecuteReader();

                while (result.Read())
                {
                    ProductList card = new ProductList();


                }
                List<Product> c = new List<Product>();



            }

            catch
            {
                MessageBox.Show("Unable to connect, mtsm!");

            }
        }

        private void productList2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
               
                string query = "delete from [dbo].[Cosmo] where name='" + textBox3.Text + "' ";
                Connection_Class.tie(query);



        }
    }
}
