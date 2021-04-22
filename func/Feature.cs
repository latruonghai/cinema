using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace Cinema.func
{
    static public class Feature
    {
        static string root = @"E:\C#-Project\NamBa\Cinema\img\listfilm\";
        public static char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public static string getMatch(string text, string pattern= @"[\s\w]+(?=\.)")
        {
            MatchCollection mc = Regex.Matches(text, pattern);
            return mc[0].ToString();
        }
        public static string LoadFilm(ImageList filmImg1, ListView listFilm1, string nameFile)
        {
            string nameFilm;
            filmImg1.Images.Add(Image.FromFile(nameFile));
            nameFilm = getMatch(nameFile);
            listFilm1.Items.Add(nameFilm, listFilm1.Items.Count);
            return nameFilm;
        }

        public static void AutoLoadFilm(ImageList imglst1, ListView lstview1, bool savefile = false, DataTable dt= null)
        {
            string root = @"E:\C#-Project\NamBa\Cinema\img\listfilm\";
            //root = @root;
            //DataRow row = dtf.NewRow();

            //string pattern = @"[\s\w]+(?=\.)";
            string nameFilm;
            lstview1.LargeImageList = imglst1;
            lstview1.View = View.LargeIcon;
            string[] fileEntries = Directory.GetFiles(root);
            string file;
            int a = fileEntries.Length;
            for (int i = 0; i < a; i++)
            {
                file = fileEntries[i];
                nameFilm = LoadFilm(imglst1, lstview1, file);
                if (savefile)
                {
                    DataRow row = dt.NewRow();
                    string id;
                    id = "F" + dt.Rows.Count.ToString();
                    Tuple<string, string, string, string> tup = new Tuple<string, string, string, string>(nameFilm, file, "Available", "");

                    AddRowDTFilm(dt, row, tup);
                }
            }
        }

        public static string getRoomName(char a)
        {
            string roomName = "Rạp " + a;
            return roomName;
        }

        
        public static void GetComboBoxCollection(DataRow[] rows, ComboBox cbb, string columsName)
        {
            //cbb.DataSource = new string[] { };
            List<string> a = new List<string> { };
            foreach(DataRow row in rows)
            {
                string b = row[columsName].ToString();
                if (a.Contains(b))
                {
                    continue;
                }
                else a.Add(b);
            }
           
            cbb.DataSource = a;
            if (a.Count == 0)
            {
                cbb.Text = "";
            }
            
        }
        //static public string[]
        public static List<string> GetNameOfFile()
        {
            string nameFilm;
            List<string> nameFilms = new List<string>();
            string[] fileEntries = Directory.GetFiles(root);
            foreach (string file in fileEntries)
            {
                nameFilm = getMatch(file);
                nameFilms.Add(nameFilm);
            }
            return nameFilms;
        }

        private static  bool CheckExistsIn(Dictionary<string, Dictionary<string, int[,]>> dic, string s)
        {
            string[] ar = dic.Keys.ToArray();
            return (ar.Contains(s));
        }
        public static void ShowOneFilm(ImageList imglst, ListView lstview1, DataRow row)
        {
            /*
             Show one film in "DataRow" onto ListView with ImageList
             */
            string nameFile;
            try
            {
                nameFile = row["Direction"].ToString();
                LoadFilm(imglst, lstview1, nameFile);
                
            }
            catch
            {
                return;
            }
        }
        public static void ShowAllFilm(ImageList imglst, ListView lstview1, DataRow[] dr, bool add = true, bool remove = false, List<int> rm_list= null)
        {
            if (add)
            {
                for (int i = 0; i < dr.Length; i++)
                {
                    ShowOneFilm(imglst, lstview1, dr[i]);
                }
            }
            if (remove)
            {
                DeleteDataFilmRow(rm_list, lstview1);
            }
        }
        private static void SetDefaultValue(int[,] a, int length, int exceptIndex = -1, int exceptValue = -1)
        {
            if (exceptIndex == -1)
            {
                for (int i = 0; i < length; i++)
                {
                    // Status Seat
                    a[0,i] = 0;
                    // Price of Seat
                    a[1,i] = 60000;

                }
            }
            else
            {
                int i;
                /*for (i = 0; i< exceptIndex; i++)
                {
                    a[0,i] = 0;
                    a[1, i] = 60000;
                }*/
                for (i=exceptIndex; i < length; i++)
                {
                    a[0,i] = exceptValue;
                    a[1, i] = 110000;
                }
            }
        }
        public static void AddRowDTFilm(DataTable dtf, DataRow row, Tuple<string, string, string, string> c)
        {

            string id = "M" + (dtf.Rows.Count + 1).ToString();
            row["ID"] = id;
            row["Name"] = c.Item1;
            row["Direction"] = c.Item2;
            row["Status"] = c.Item3;
            row["Type"] = c.Item4;
            dtf.Rows.Add(row);
            DataRow[] dr = dtf.AsEnumerable().ToArray();
            /*dtf.Rows.Add(id, namefilm, "");*/
        }
        public static void AddRowDTFilm(DataTable dtf, DataRow row, Tuple<string, string, string, string> c, List<DataRow> lst)
        {
            
            string id = "M" + (dtf.Rows.Count + 1).ToString();
            row["ID"] = id;
            row["Name"] = c.Item1;
            row["Direction"] = c.Item2;
            row["Status"] = c.Item3;
            row["Type"] = c.Item4;
            dtf.Rows.Add(row);
            lst.Add(row);
            DataRow[] dr = dtf.AsEnumerable().ToArray();
            /*dtf.Rows.Add(id, namefilm, "");*/
        }

        public static void AddRoomDictionary(Dictionary<string, int[,]> dic, string nameCinema, int num, int exceptIndex, int exceptValue)
        {
            int[,] arr = new int[2, num];
            SetDefaultValue(arr, num, exceptIndex, exceptValue);
            dic.Add(nameCinema, arr);
        }
        /*private static DataRow[] getDataRow(DataTable dt, string key1, string key2, string value1, string value2) 
        {
            string key = key1 + "='" + value1 + "' AND " + key2 + "='" + value2 + "'";
            DataRow[] dr = dt.Select(key);
            return dr;
        }
        public static void CheckValidInformationAdded(DataTable dt, Tuple<string, string, string, string> tup)
        {
            DataRow[] dr = getDataRow(dt, tup.Item1, tup.Item2, tup.Item3, tup.Item4);
            dr[]
        }*/

        private static void DeleteDataFilmRow(List<int> index, ListView lstview)
        {
            foreach (int i in index) 
            {
                //ListViewItem item = lstview.Items[i];
                lstview.Items[i].Remove();
            }
                    
        }
        public static void AddFilmRoomDictionary(Dictionary< string, Dictionary<string, int[,]>> dic, Dictionary<string, int[,]> d, string nameFilm, List<string> nameCinema)
       
        {
            

            Dictionary<string, int[,]> dict = new Dictionary<string, int[,]>();
            foreach (string name in nameCinema)
            {
                int length = d[name].GetLength(1);
                //d[name].CopyTo(de);
                int[,] de = new int[2, length];
                //de = d[name];
                SetDefaultValue(de, length, length -10, 2);
                if (CheckExistsIn(dic, nameFilm))
                {
                    dic[nameFilm].Add(name, de);
                }
                else
                {
                    try
                    {
                        dict.Add(name, de);
                    }
                    catch (ArgumentException e)
                    {
                        DialogResult dlr = MessageBox.Show("Dữ liệu của bạn vừa bị lỗi. Chương trình sẽ khởi động lại", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dlr == DialogResult.OK)
                        {
                            Application.Restart();
                        }
                    }

                    dic.Add(nameFilm, dict);
                }
            }

        }

        public static int[] GetSeatStatus(Dictionary<string, int[]> dic, string key)
        {
            return dic["key"];
        }

        public static ListViewItem getItem(ListView listview)
        {
            int selectedItem = listview.SelectedIndices[0];
            ListViewItem item = listview.Items[selectedItem];
            return item;
        }

        public static DataRow[] getDataRow(string key, string value, DataTable dt)
        {
            string s = key + "='" + value + "'";
            DataRow[] dr = dt.Select(s);
            return dr;
        }
    }
}
