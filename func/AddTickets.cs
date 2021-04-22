using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Cinema.func;

namespace Cinema.func
{
    
    public partial class AddTickets : Form
    {

        static int numofTicket = 0;
        int numofSeats;
        int price = 0;
        public AddTickets(int num)
        {

            dt = createCinemaDT();
            dtc = createRoomDT();
            dtf = createFilmDT();
            dtst = createShowTimeDT();
            //dt.Columns.Add("Status", typeof(bool));
            //Num = num;
            
            InitializeComponent();
        }

        private void addFilm1_Click(object sender, EventArgs e)
        {
            //idTextBox.Text = "V" + numofTicket.ToString();
            int order = ToOrder();
            if (checkValid(order))
            {
                MessageBox.Show("Bạn đã đặt vé thành công!!\nChúc bạn xem phim vui vẻ!!", "Xác nhận đặt vé");
                price += addInformation(order);
                //dataFilm1.DataSource = dt;
                //dataFilm1.
                numofTicket++;
                string nameFilm = nameTextbox.Text;
                string cinemaName = cinemaComboBox2.Text;
                idTextBox.Text = "V" + numofTicket.ToString();
                //Dictionary<string, int[,]> temp = dictionary[nameFilm];
                dictionary[nameTextbox.Text + ShowTimeComboBox1.Text][cinemaComboBox2.Text][0, order] = 1;
                Dictionary<string, Dictionary<string, int[,]>> d = dictionary;
                ListViewItem item = listCinema1.Items[order];
                
                item.ImageIndex = 1;
                //item.Text = idTextBox.Text;
                //
                seats -= 1;
                textBoxNumOfSeats1.Text = seats.ToString();

                getDisable(true);
                
                
            }

            else
            {
                return;
            }

        }

        private void AddTickets_Load(object sender, EventArgs e)
        {
            //string b = String.Join("","10001".Split('0'));
            Feature.AutoLoadFilm(filmImg1, listFilm1, true, dtf);
            //showFilm(filmImg1, listFilm1);
            showCinema(4);
            CreateCinemaDataRow(dr);
            //MessageBox.Show(filmImg1.Images.Count.ToString());
            idTextBox.ReadOnly = true;
            idTextBox.Text = "V" + numofTicket.ToString();

        }

        private void listCinema1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listCinema1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //MessageBox.Show(e.ToString());
                if (listCinema1.SelectedIndices.Count > 0)
            {
                //int selectedItem = listCinema1.SelectedIndices[0];
                selectedItem = Feature.getItem(listCinema1);
                string key = selectedItem.Text;
                //string key = getTextFromItem(listCinema1);
                int imgIndex = selectedItem.ImageIndex;
                if (imgIndex == 0 || imgIndex ==2)
                {
                    addFilm1.Enabled = true;
                    delFilm1.Enabled = false;
                    editFilm1.Enabled = false;
                    if (idFilm1.Enabled == false || idTextBox.ReadOnly == true)
                    {
                        idFilm1.Enabled = true;
                        //idFilm1.
                        getDisable(true);
                    }
                    resetInformation();
                    seatTextbox1.Text = key;

                }
                //DataRow dr = dt.Rows[selectedItem];
                else if (imgIndex == 1)
                {
                    addFilm1.Enabled = false;
                    delFilm1.Enabled = true;
                    editFilm1.Enabled = true;

                    getDisable(false);
                    try
                    {
                        /*string s = "Seats='" + key + "'";
                        DataRow[] dr = dt.Select(s);*/
                        /*DataRow[]*/ dr = Feature.getDataRow("Seats", key, dt);
                        //addFilm1.Enabled = false;
                        displayInformation(dr);
                        getDisable(true);
                    }
                    catch
                    {
                        MessageBox.Show("Data bị lỗi", "Thông báo");
                    }
                }
                
            }

        }
        private void listFilm1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listFilm1.SelectedIndices.Count > 0)
            {

                selectedItem = Feature.getItem(listFilm1);
                ShowTimeComboBox1.Text = "";
                cinemaComboBox2.Text = "";
                nameTextbox.Text = selectedItem.Text;

                /*DataRow[]*/ dr = Feature.getDataRow("Film", nameTextbox.Text, dtst);
                /*try
                {
                    dr = Feature.getDataRow("Time", showtimeTextBox2.Text, dr.CopyToDataTable());
                }
                catch(InvalidOperationException a)
                {
                    return;
                }*/
                Feature.GetComboBoxCollection(dr ,ShowTimeComboBox1, "Time");
                //Feature.GetComboBoxCollection(dr ,ShowTimeComboBox1, "Time");
                dr = Feature.getDataRow("Name", nameTextbox.Text, dtf);
                comboBox1.Text = dr[0]["Status"].ToString();
                typeComboBox3.Text = dr[0]["Type"].ToString();
                //Feature.GetComboBoxCollection(dr ,cinemaComboBox2, "Room");
                //optionGroupBox1.Visible = true;
                if (ShowTimeComboBox1.Text == "")
                {
                    listCinema1.Items.Clear();
                    cinemaComboBox2.DataSource = new List<string> { };
                    pictureBox2.Visible = false;
                }
            }
            else
            {
                //optionAddBtn1.Visible = false;
            }
        }

        private void listFilm1_DoubleClick(object sender, EventArgs e)
        {/*
            ListFilm new_mdi_child = new ListFilm(dtf);
            new_mdi_child.Show();*/
        }

        private void editFilm1_Click(object sender, EventArgs e)
        {
            //int order = ToOrder();
            DialogResult dlr = MessageBox.Show("Thông tin vé của bạn sẽ thay đổi. Bạn có muốn tiếp tục?",
                                                "Xác nhận thay đổi",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int order = ToOrder();
                string seat = seatTextbox1.Text;
                /*string s = "Seats='" + seat+ "'";
                DataRow[] dr = dt.Select(s);*/
                /*DataRow[]*/ dr = Feature.getDataRow("Seats", seat, dt);
                editInformation(dr);
                MessageBox.Show("Thông tin của bạn đã được thay đổi thành công");
                getDisable(true);
            }

           /* if (!checkValid(order))
            {
                string s = "Seat='" + seat + "'";
                DataRow[] dr = dt.Select(s);
            }*/
        }



        private void filmView1_Click(object sender, EventArgs e)
        {
            ListFilm lf = new ListFilm(dtf);
            lf.ShowDialog();

        }

        private void listRoom1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
           /* if (listRoom1.SelectedIndices.Count > 0)
            {
                
                ListViewItem item = Feature.getItem(listRoom1);
                comboBox1.Text = item.Text;
            }*/
        }

        private void ShowTimeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showtimeTextBox2.Text = ShowTimeComboBox1.Text;
            if (ShowTimeComboBox1.Text != "")
            {
                string showTime = ShowTimeComboBox1.Text;
                
                int selectedIndex = ShowTimeComboBox1.SelectedIndex;
                string cinemaName, filmName;
                dr = Feature.getDataRow("Time", showTime, dtst);

                DataRow[] d = Feature.getDataRow("Film", nameTextbox.Text, dr.CopyToDataTable());
                Feature.GetComboBoxCollection(d, cinemaComboBox2, "Room");
                //cinemaName = d[selectedIndex]["Room"].ToString();
                filmName = nameTextbox.Text + showTime;
                /*cinemaTextbox.Text = cinemaName;*/
                cinemaName = cinemaComboBox2.Text;
                //dr = getDataRow("Name", cinemaName, dtc);

                CreateCinemaView(cinemaName, filmName);
            }
            
        }

        private void delFilm1_Click(object sender, EventArgs e)
        {
            /*DataRow[]*/ dr = Feature.getDataRow("Seats", seatTextbox1.Text, dt);
            int order = ToOrder();
            DialogResult dlr = MessageBox.Show("Bạn sẽ xóa thông tin vé này?", "Xác nhận xóa vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                dr[0].Delete();
                int[,] arr = dictionary[nameTextbox.Text + showtimeTextBox2.Text][cinemaTextbox.Text];
                int lenght = arr.GetLength(1);
                arr[0, order] = (order < lenght-11)?0:2;
                selectedItem.ImageIndex = arr[0,order];
                numofTicket -= 1;
                price -= addInformation(order);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPay1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã mua " +
                             numofTicket.ToString() +
                             " vé. Số tiền thanh toán của bạn là '" +
                             price.ToString() + " VND'", "Xác nhận thanh toán",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
        }

        
        private void ShowTimeComboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {
            filmTextBox1.Text = nameTextbox.Text;
            /*ShowTimeComboBox1.Text = "";
            cinemaComboBox2.Text = "";*/
            if (cinemaComboBox2.Text != "" && nameTextbox.Text != "" && showtimeTextBox2.Text != "")
            {
                filmTextBox1.Text = nameTextbox.Text;
                try
                {
                    int[,] arr = dictionary[nameTextbox.Text + ShowTimeComboBox1.Text][cinemaComboBox2.Text];
                    seats = Feature.CountElement(arr);
                    textBoxNumOfSeats1.Text = seats.ToString();
                }


                catch (KeyNotFoundException a)
                {
                    MessageBox.Show("Hiện tại chưa có suất chiếu cho phim này");
                    return;
                }
            }
            else if (cinemaComboBox2.Text == "") labelSeatAva2.Text = "";


        }

        private void addFilmInfoBTN1_Click(object sender, EventArgs e)
        {
            BrowseImage();
        }

        private void buttonEditFilm2_Click(object sender, EventArgs e)
        {
            ListFilm lstfilm = new ListFilm(dtf);
            lstfilm.ShowDialog();
            dtf = lstfilm.dt;
            dr = dtf.Select();
            //List<int> lst_rm = lstfilm.lst_rmv;
            Feature.ShowAllFilm(filmImg1, listFilm1, dr,delAll:true);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createShowTimeRows();
            CreateCinemaDataRow(dr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cinemaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cinemaName, filmName;
            
            cinemaName = cinemaComboBox2.Text;
            cinemaTextbox.Text = cinemaName;
            filmName = nameTextbox.Text + ShowTimeComboBox1.Text;
            CreateCinemaView(cinemaName, filmName);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void buttonList2_Click(object sender, EventArgs e)
        {
            TimeFilm tf = new TimeFilm(dt);
            tf.Show();
        }
    }
}
