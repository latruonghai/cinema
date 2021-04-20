using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Cinema.func
{
    public partial class AddTickets
    {
        DataSet dataset = new DataSet();
        DataTable dt, dtf, dtc, dtst;
        int seat;
        ListViewItem selectedItem;
        OpenFileDialog of;
        //DataGridViewRow row;
        DataRow[] dr;
        Dictionary<string, int[,]> dic = new Dictionary<string, int[,]>();
        Dictionary<string, Dictionary<string, int[,]>> dictionary = new Dictionary<string, Dictionary<string, int[,]>>();
        DataTable createCinemaDT()
        {

            DataTable dt = dataset.Tables.Add("Ticket");
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Time", typeof(string));
            dt.Columns.Add("Cinema", typeof(string));
            dt.Columns.Add("Buying Time", typeof(string));
            dt.Columns.Add("Seats", typeof(string));
            dt.Columns.Add("Price", typeof(int));
            return dt;
        }

        DataTable createRoomDT()
        {

            DataTable dtc = dataset.Tables.Add("Room");
            dtc.Columns.Add("ID", typeof(string));
            dtc.Columns.Add("Name", typeof(string));
            dtc.Columns.Add("Seats", typeof(int));
            //dtc.Columns.Add("Price", typeof(int));
            dtc.Columns.Add("Available", typeof(bool));

            return dtc;
        }
        DataTable createShowTimeDT()
        {
            dtst = dataset.Tables.Add("Show Time");
            //DataTable dtst = dataset.Tables.Add("Room");
            dtst.Columns.Add("STT", typeof(string));
            //dtst.Columns.Add("Name", typeof(string));

            dtst.Columns.Add("Time", typeof(string));
            dtst.Columns.Add("Film", typeof(string));
            dtst.Columns.Add("Room", typeof(string));
            //dtst.Columns.Add("Price", typeof(int));
            dtst.Columns.Add("Available", typeof(bool));
            return dtst;
        }

        DataTable createFilmDT()
        {

            DataTable dtf = dataset.Tables.Add("Film");
            dtf.Columns.Add("ID", typeof(string));
            dtf.Columns.Add("Name", typeof(string));
            dtf.Columns.Add("Status", typeof(string));
            dtf.Columns.Add("Direction", typeof(string));
            dtf.Columns.Add("Type", typeof(string));
            //dtf.Columns.Add("Time", typeof(string));
            //dtf.Columns.Add("Type", typeof(string));
            //dtf.Columns.Add("Description", typeof(string));
            //dtf.Columns.Add("ID Cinema", typeof(string));

            return dtf;
        }

        private int ToOrder()
        {

            try
            {
                string Text = seatTextbox1.Text;
                int length = Text.Length;
                string text = seatTextbox1.Text.Substring(1, length - 1);
                //char texta = text[text.Length - 1];            
                int a = Convert.ToInt32(text);
                return a;
            }
            catch
            {
                return -1;
            }

        }
        /*DataRow[] getDataRow(string key, string value, DataTable dt)
        {
            string s = key + "='" + value + "'";
            DataRow[] dr = dt.Select(s);
            return dr;
        }*/
        void editInformation(DataRow[] dr)
        {
            dr[0]["ID"] = idTextBox.Text;
            dr[0]["Name"] = nameTextbox.Text;
            dr[0]["Time"] = ShowTimeComboBox1.Text;
            dr[0]["Cinema"] = cinemaTextbox.Text;
            dr[0]["Buying Time"] = timebuyTextbox.Text;
            dr[0]["Seats"] = seatTextbox1.Text;
        }

        private void BrowseImage()
        {
            of = new OpenFileDialog();
            of.InitialDirectory = @"E:\C#-Project\NamBa\Cinema\img\listfilm";
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            of.FilterIndex = 1;
            of.RestoreDirectory = true;



            if (of.ShowDialog() == DialogResult.OK)
            {

                //imagePath1.Text = of.FileName;
                string pathFile = of.FileName;
                Feature.LoadFilm(filmImg1, listFilm1, pathFile);

            }
        }
        void resetInformation()
        {
            //idTextBox.Text = "";
            idTextBox.Text = "V" + numofTicket.ToString();
            /*nameTextbox.Text = "";
            cinemaTextbox.Text = "";
            dateTimePicker1.Text = "";
            timebuyTextbox.Text = "";
            ShowTimeComboBox1.Text = "";*/
        }
        bool checkExists(int order)
        {
            //
            //int order = ToOrder();
            //int tmp = ;
            if (listCinema1.Items[order].ImageIndex == 1)
            {
                return true;
            }
            else return false;
        }
        bool checkFill()
        {
            if (idTextBox.Text == ""
                || nameTextbox.Text == ""
                || ShowTimeComboBox1.Text == ""
                || cinemaComboBox2.Text == "")
            {
                return false;
            }

            return true;
        }
       
        bool checkValid(int order)
        {
            if (order < 0)
            {
                MessageBox.Show("Bạn chưa chọn chỗ ngồi cho bạn kìa", "Lỗi đặt vé");
                return false;
            }
            else if (checkFill())
            {
                if (checkExists(order))
                {
                    MessageBox.Show("Vé không hợp lệ", "Lỗi đặt vé");
                    idTextBox.ReadOnly = false;
                    //addFilm1.Enabled = false;
                    return false;
                }
                else { return true; }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
        }
 
        /*ListViewItem getItem(ListView listview)
        {
            int selectedItem = listview.SelectedIndices[0];
            ListViewItem item = listview.Items[selectedItem];
            return item;
        }*/

        void displayInformation(DataRow[] dr)
        {
            idTextBox.Text = dr[0]["ID"].ToString();
            filmTextBox1.Text = dr[0]["Name"].ToString();
            showtimeTextBox2.Text = dr[0]["Time"].ToString();
            cinemaTextbox.Text = dr[0]["Cinema"].ToString();
            timebuyTextbox.Text = dr[0]["Buying Time"].ToString();
            seatTextbox1.Text = dr[0]["Seats"].ToString();
            textBoxPay1.Text = dr[0]["Price"].ToString() + " VND";
        }
/*        private void addRowDTFilm(DataRow row)
        {
            string id = "M" + (dtf.Rows.Count + 1).ToString() ;
            row["ID"] = id;
            row["Name"] = 
            dtf.Rows.Add();
            *//*dtf.Rows.Add(id, namefilm, "");*//*
        }*/

        /*        void CreateRoomDatabase()
                {

                }*/
        private void showCinema(int numofRoom)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < numofRoom; i++)
            {
                string nameCinema = "Rạp " + alpha[i];
                Random ran = new Random();
                int num = ran.Next(6, 10)*10;
                //listRoom1.Items.Add("Rạp " + alpha[i], 0);
                Feature.AddRoomDictionary(dic, nameCinema, num, num-10, 2);
                dtc.Rows.Add("R" + i.ToString(), nameCinema, num, true);
            }
            //listRoom1.LargeImageList = roomImg1;
            //listRoom1.View = View.LargeIcon;

        }

        //private void 
        /*private void showCinema(DataRow[] dr)
        {
            string nameofRoom;
            foreach(DataRow row in dr)
            {
                nameofRoom = row["Name"].ToString();
                listCinema1.Items.Add(nameofRoom, 0);
            }
            listRoom1.LargeImageList = roomImg1;
            listRoom1.View = View.LargeIcon;
        }*/

        private void CreateCinemaDataRow(DataRow[] dr) 
        {
            //Dictionary<string, int[,]> di = dic;
            /*string[] arr;
            try
            {
                arr = dtst.AsEnumerable().Select(r => r.Field<string>("Film")).ToArray();
            }
            catch
            {
                dtst = createShowTimeDT();
                arr = dtst.AsEnumerable().Select(r => r.Field<string>("Film")).ToArray();
            }
            foreach(string film in arr)
            {
                try
                {
                    int a = dictionary[film].Count;
                    continue;
                }
                catch
                {
                    DataTable dtb = Feature.getDataRow("Film", film, dtst).CopyToDataTable();
                    string[] arr_cinema = dtb.AsEnumerable().Select(r => r.Field<string>("Room")).ToArray();
                    Feature.AddFilmRoomDictionary(dictionary, dic, film, arr_cinema);
       
                    
                }*/
            string nameFilm, showtime, key;
            if (dr == null)
            {
                return;
            }
            foreach(DataRow row in dr)
            {
                nameFilm = row["Film"].ToString();
                showtime = row["Time"].ToString();
                key = nameFilm + showtime;
                List<string> arr_cinema = new List<string>() { };
                arr_cinema.Add(row["Room"].ToString());
                Feature.AddFilmRoomDictionary(dictionary, dic, key, arr_cinema);
            }
            
        }
        /*void LoadFilm(ImageList filmImg1, ListView listFilm1)
        {

            string root = @"E:\C#-Project\NamBa\Cinema\img\listfilm\";
            //root = @root;
            DataRow row = dtf.NewRow();

            //string pattern = @"[\s\w]+(?=\.)";
            string nameFilm;
            string[] fileEntries = Directory.GetFiles(root);
            int a = fileEntries.Length;
            for (int i = 0; i < fileEntries.Length; i++)
            {
                string file = fileEntries[i];
                nameFilm = Feature.LoadFilm(filmImg1, listFilm1, file);
                //MessageBox.Show(file);
            }
            listFilm1.LargeImageList = filmImg1;
            //listCinema1.LargeImageList.Images[0] = cinemaImg1.Images[1];
            listFilm1.View = View.LargeIcon;

        }*/
/*        void showFilm(DataRow[] dr)
        {
            string nameFilm, file;
            foreach(DataRow row in dr)
            {
                file = row["Direction"].ToString();
                nameFilm = Feature.LoadFilm(filmImg1, listFilm1, file);
                addRowDTFilm(row);
            }
        }*/
       /* private void AutoLoadFilm(bool savefile = true)
        {
            string root = @"E:\C#-Project\NamBa\Cinema\img\listfilm\";
            //root = @root;
            //DataRow row = dtf.NewRow();

            //string pattern = @"[\s\w]+(?=\.)";
            string nameFilm;
            string[] fileEntries = Directory.GetFiles(root);
            string file;
            int a = fileEntries.Length;
            for(int i =0; i < a; i++)
            {
                file = fileEntries[i];
                nameFilm = Feature.LoadFilm(filmImg1, listFilm1, file);
                if (savefile)
                {

                }
            }
        }*/
        private void CheckFilmExists()
        {

        }
        private void ShowFilm()
        {

        }
        
        void getDisable(bool value)
        {
            idTextBox.ReadOnly = value;
            nameTextbox.ReadOnly = value;
            ShowTimeComboBox1.Enabled = value;
            //cinemaTextbox.ReadOnly = value;
            //idTextBox.ReadOnly = true;
        }

        private void createShowTimeRows()
        {
            
           
            ShowTimePickers stp = new ShowTimePickers(dtst);

            stp.ShowDialog();
             //if (stp.isSho)
            dtst = stp.dtst;
            numofSeats = stp.numofSeat;
            dr = stp.dr;
            /*DataRowCollection dr = dtst.Rows;
            for (int i = 0; i < dr.Count; i++)
            {
                ShowTimeComboBox1.Items.Insert(i, dr[i]["Time"].ToString());
            }*/
            
        }

        private void DrawCinema(int numSeats)
        {
            //listCinema1.Emp
        }
        private void CreateCinemaView(string nameofRoom, string nameofFilm="")
        {
            pictureBox2.Visible = true;
            int[,] arr;
            if (nameofFilm != "")
            {
                arr = dictionary[nameofFilm][nameofRoom];
            }
            else
            {
                arr = dic[nameofRoom];
            }
            int length = arr.GetLength(1);
            int lenStr = nameofRoom.Length;
            char id = nameofRoom[lenStr - 1];
            if (listCinema1.Items.Count > 0)
            {
                listCinema1.Items.Clear();
            }
            for (int seat= 0; seat< length; seat++)
            {

                listCinema1.Items.Add(id + seat.ToString(), arr[0, seat]);
            }
            
        }

        int  addInformation(int order)
        {
            /*
             Add data's ticket information to DataFilm.
            It includes information: (id, name, cinema, time, seat);
             */
            string id, name, cinema, time, seat;
            //bool isBooked = true;
            string dtime = DateTime.Now.ToString();

            id = idTextBox.Text;
            name = nameTextbox.Text;
            cinema = cinemaComboBox2.Text;
            time = ShowTimeComboBox1.Text;
            seat = seatTextbox1.Text;
            int price = dic[cinema][1, order];
            //DateTime a = DateTime.Parse(time);
            //time = a.ToString();
            //MessageBox.Show(time);
            //DateTime.
            //DataTable dt = dt;
            dt.Rows.Add(id, name, time, cinema, dtime, seat, price);
            return price;
        }
    }
}
