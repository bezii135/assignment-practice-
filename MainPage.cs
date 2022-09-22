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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            dashboard db = new dashboard();
            Form active = this.ActiveMdiChild;

            if (active != null)
            {
                active.Close();
            }
          
            db.MdiParent = this;
            db.Show();

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void btnL_Click(object sender, EventArgs e)
        {

        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            AddProduct db = new AddProduct();

            if (active != null)
            {
                active.Close();
            }

            db.MdiParent = this;
            db.Show();

        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            View_All db = new View_All();

            if (active != null)
            {
                active.Close();
            }

            db.MdiParent = this;
            db.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mp = new Form1();

            mp.Show();
            this.Close();
        }

        private void updateRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form active = this.ActiveMdiChild;
            UpdatePage up = new UpdatePage();

            if (active != null)
            {
                active.Close();
            }

            up.MdiParent = this;
            up.Show();


        }
    }
}
