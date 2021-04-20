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
    public partial class ShowTimePickers : Form
    {
        private List<DataRow> lst_dr = new List<DataRow> { };
        //public List<DataRow> lst_dr1 = new List<DataRow> { };
        public DataRow[] dr;
        public DataTable dtst = new DataTable();
        char[] alphabet = Feature.alpha;
        int stt_num = 1;
        public int numofSeat = 5;
        //public DataRow[] dr = new DataRow[] {};
        public ShowTimePickers(DataTable dt)
        {
            //dtst = createShowTimeDT();
            dtst = dt;
            InitializeComponent();
        }

        DataTable createShowTimeDT()
        {

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
        private void addComboBoxInfomation()
        {
            
            List<string> nameofFiles = Feature.GetNameOfFile();
            for (int i=0;i<nameofFiles.Count;i++)
            {
                comboBoxFilm1.Items.Insert(i, nameofFiles[i]);
            }
        }

        private void AddComboBoxRoomInformation(int numofRoom)
        {
            for (int i = 0; i < numofRoom; i++)
            {
                comboBoxRoom1.Items.Insert(i, Feature.getRoomName(alphabet[i]));
            }
        }
        private DataRow CreateRowInDataShowTime(string stt, string time, string film, string room, bool ava)
        {
            DataRow row = dtst.NewRow();
            row["STT"] = stt;
            row["Time"] = time;
            row["Film"] = film;
            row["Room"] = room;
            row["Available"] = ava;
            return row;


        }
        private void addShowTime(string stt, string time, string film, string room, bool ava)
        {
            DataRow row = CreateRowInDataShowTime(stt, time, film, room, ava);
            
            dtst.Rows.Add(row);

            lst_dr.Add(row);

        }
        private void addShowTimeButton1_Click(object sender, EventArgs e)
        {
            
            string stt, time, film, room;
            bool ava = true;
            stt = stt_num.ToString();
            film = comboBoxFilm1.Text;
            room = comboBoxRoom1.Text;
            time = showTimePicker1.Value.ToString();
            addShowTime(stt, time, film, room, ava);
            dataShowTimeGridView1.DataSource = dtst;
            stt_num++;

        }

        private void ShowTimePickers_Load(object sender, EventArgs e)
        {
            addComboBoxInfomation();
            AddComboBoxRoomInformation(numofSeat);
            dataShowTimeGridView1.DataSource = dtst;
            comboBoxFilm1.Text = comboBoxFilm1.Items[0].ToString();
            comboBoxRoom1.Text = comboBoxRoom1.Items[0].ToString();
        }

        private void buttonDone1_Click(object sender, EventArgs e)
        {
            dr = lst_dr.ToArray();
            DialogResult dlr = MessageBox.Show("Bạn đã nhập đủ thông tin. Nhấn 'OK' để quay lại màn hình chính",
                                                "Thông báo",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
            if(dlr == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
