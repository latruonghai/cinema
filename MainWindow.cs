using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.func;

namespace Cinema
{
    public partial class MainWindow : Form
    {
        DataTable dt = new DataTable();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddTickets new_mdi_child = new AddTickets(60);
            
            //new_mdi_child.
            //new_mdi_child.Text = "Cửa sổ con";
            //new_mdi_child.MdiParent = this;
            new_mdi_child.Show();


        }
    }
}
