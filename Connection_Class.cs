using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _30_Augest_2022
{
    internal class Connection_Class
    {

       public static void tie()
        {
            
            try
            {

                string connectionString = @"Data Source= DESKTOP-O3IASDH\MSSQLSERVER02; Initial Catalog=xx; Integrated security=true;";

                SqlConnection co = new SqlConnection(connectionString);
                co.Open();

                MessageBox.Show("Connected!");
                co.Close();

                
            }

            catch
            {
                MessageBox.Show("Unable to connect, mtsm!");
                
            }
            
        }
        public static void tie(String q)
        {

            try
            {
                //MessageBox.Show("aaaaa");
                string connectionString = @"Data Source= DESKTOP-O3IASDH\MSSQLSERVER02; Initial Catalog=Products; Integrated security=true;";

                SqlConnection co = new SqlConnection(connectionString);
                co.Open();
                //MessageBox.Show("bbbbbb");
                SqlCommand cmd = new SqlCommand(q, co);
                MessageBox.Show("ccccc");
                int result = cmd.ExecuteNonQuery();
                MessageBox.Show("Connected!");
                co.Close();


            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                //MessageBox.Show("Unable to connect, mtsm!");

            }
        }
        }
    }
