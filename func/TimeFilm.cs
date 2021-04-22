using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.func
{
    public partial class TimeFilm : Form
    {
        DataTable dtb = new DataTable();
        public TimeFilm(DataTable dt)
        {
            dtb = dt;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimeFilm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtb;
        }
    }
}
