using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_Augest_2022
{
    public partial class View_All : Form
    {
        public View_All()
        {
            InitializeComponent();


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void load()
        {
            ProductList card = new ProductList();
            foreach (var item in Product.getAllProduct())
            {

                Product p = new Product();
                string x = (p.quantity).ToString();
                string y = (p.price).ToString();

                
                card.Number = item.number;
                card.Id = item.id;
                card.Name = item.name;
                card.manu = item.manu_Date;
                card.Exp = item.exp_date;
                card.Quantity = x;
                card.Price=y;

                

            }
            flowLayoutPanel1.Controls.Add(card);
            card.Show();

        }

        private void View_All_Load(object sender, EventArgs e)
        {

        }
    }
}
