using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Cinema.func
{
    public partial class  ListFilm
    {
        //FolderBrowserDialog fd;
        string obj;
        ListViewItem selectedItem;
        OpenFileDialog of;
        //string pathFile;
        DataTable dt;
        DataRow row;

/*        DataTable createFilmDT()
        {

            //DataTable dt = dataset.Tables.Add("Film");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Direction", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            //dtf.Columns.Add("Time", typeof(string));
            //dtf.Columns.Add("Type", typeof(string));
            //dtf.Columns.Add("Description", typeof(string));
            //dtf.Columns.Add("ID Cinema", typeof(string));

            return dt;
        }*/
        private void BrowseImage()
        {
            of = new OpenFileDialog();
            of.InitialDirectory = @"E:\C#-Project\NamBa\Cinema\img\listfilm";
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            of.FilterIndex = 1;
            of.RestoreDirectory = true;



            if (of.ShowDialog() == DialogResult.OK)
            {

                string direction, film, status, type;

                
                direction = of.FileName;
                //imagePath1.Text = direction;
                //id = "P" + listFilm1.Items.Count.ToString();
                //film = imagePath1.Text;
                status = "Đang chiếu";
                type = typeTextBox1.Text;
                film = Feature.LoadFilm(imageFilmList1, listFilm1, direction);

                Tuple<string, string, string, string> tup = new Tuple<string, string, string, string>(film, direction, status, type);
                Feature.AddRowDTFilm(dt, dt.NewRow(), tup);
            }
        }

        private string GetObjectName(object sender)
        {
            string name;
            name = sender.ToString().Split(":")[1];
            return name;
        }

        private void DeleteDataFilmRow(DataRow row)
        {
            row.Delete();
            selectedItem.Remove();
        }

        private void EditDataFilmRow(DataRow row)
        {
            string nameofItem = selectedItem.Text;
            
            row["Name"] = imagePath1.Text;
            row["Type"] = typeTextBox1.Text;
            row["Status"] = statusCombobox1.Text;
        }
/*        private  void showFilm(DataRow dr)
        {
            string imgPath = dr["Direction"].ToString();
            Feature.showFilm(imageFilmList1, listFilm1, imgPath);

        }*/
        
       /* private void showAllFilm(DataRow[] dr)
        {
            listFilm1.Items.Clear();
            foreach(DataRow row in dr)
            {
                showFilm(row);
            }
        }*/
    }
}
