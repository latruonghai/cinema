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
    public partial class ListFilm : Form
    {
        
        public ListFilm(DataTable dtb)
        {
            dt = dtb;
            InitializeComponent();
        }

/*        private void browseFilmBtn1_Click(object sender, EventArgs e)
        {
            
        }*/

        private void ListFilm_Load(object sender, EventArgs e)
        {
            listFilm1.LargeImageList = imageFilmList1;
            listFilm1.View = View.LargeIcon;
            Feature.ShowAllFilm(imageFilmList1, listFilm1,dt.AsEnumerable().ToArray());
            //dt = createFilmDT();

        }

        private void browseFilmBtn1_Click_1(object sender, EventArgs e)
        {
            BrowseImage();
            obj = GetObjectName(sender);
        }

        private void buttonDelFilm1_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa bộ phim này khỏi dữ liệu?",
                                                "Xác nhận xóa",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlr == DialogResult.Yes)
            {
                DeleteDataFilmRow(row);
            }
            else
            {
                return;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Thông tin của bạn sẽ được thay đổi. Bạn có muốn tiếp tục?",
                                                "Xác nhận thay đổi thông tin",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                 
                EditDataFilmRow(row);
            }
            else return;

        }

        private void listFilm1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listFilm1.SelectedIndices.Count > 0)
            {
                string status, type, name, nameofItem;
                selectedItem = Feature.getItem(listFilm1);
                nameofItem = selectedItem.Text;
                DataRow[] dr = Feature.getDataRow("Name", nameofItem, dt);
                row = dr[0];
                type = typeTextBox1.Text;
                status = statusCombobox1.Text;
                selectedItem = Feature.getItem(listFilm1);
                imagePath1.Text = selectedItem.Text;
                typeTextBox1.Text = row["Type"].ToString();
                statusCombobox1.Text = row["Status"].ToString();
                
                //string nameofItem = selectedItem.Text;
                
                EditDataFilmRow(row);
            }
        }
    }
}
