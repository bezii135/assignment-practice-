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
    public partial class ProductList : UserControl
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
             
        }

       


        private string numb;

       Product p = new Product();

        public Panel Central_Panel;
        private string _Username;


        public string Name
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }
        //  get { return Name; }// => lblName.Text;
        //set { lblName.Text = value; lblName.Text = Name;}

        public string Number
        {
            get => lblNum.Text;
            set => lblNum.Text = value;
        }

        public string Id
        {
            get => lblId.Text;
            set => lblId.Text = value;
        }

        public string rep
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public string manu
        {
            get => lblManu.Text;
            set => lblManu.Text = value;
        }

        public string Exp
        {
            get => lblEx.Text;
            set => lblEx.Text = value;
        }


        public string Quantity
        {
            get => lblQuantity.Text;
            set => lblQuantity.Text = value;
        }

        public string Price
        {
            get => lblPrice.Text;
            set => lblPrice.Text = value;
        }

        private void ProductList_Load(object sender, EventArgs e)
        {

        }
    }
    }

