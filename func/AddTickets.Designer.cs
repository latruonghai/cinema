
namespace Cinema.func
{
    partial class AddTickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTickets));
            this.funcBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPay1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filmView1 = new System.Windows.Forms.Button();
            this.delFilm1 = new System.Windows.Forms.Button();
            this.editFilm1 = new System.Windows.Forms.Button();
            this.addFilm1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.infoFilm1 = new System.Windows.Forms.GroupBox();
            this.showtimeTextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filmTextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timebuyTextbox = new System.Windows.Forms.TextBox();
            this.textBoxPay1 = new System.Windows.Forms.TextBox();
            this.timeTicket1 = new System.Windows.Forms.Label();
            this.seatTextbox1 = new System.Windows.Forms.TextBox();
            this.labelMoney1 = new System.Windows.Forms.Label();
            this.seatLabel1 = new System.Windows.Forms.Label();
            this.cinemaTextbox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameCinema1 = new System.Windows.Forms.Label();
            this.idFilm1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowTimeComboBox1 = new System.Windows.Forms.ComboBox();
            this.timeFilm1 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameFilm1 = new System.Windows.Forms.Label();
            this.listCinema1 = new System.Windows.Forms.ListView();
            this.cinemaImg1 = new System.Windows.Forms.ImageList(this.components);
            this.listFilm1 = new System.Windows.Forms.ListView();
            this.listRoom1 = new System.Windows.Forms.ListView();
            this.filmImg1 = new System.Windows.Forms.ImageList(this.components);
            this.roomImg1 = new System.Windows.Forms.ImageList(this.components);
            this.labelSeatAva2 = new System.Windows.Forms.Label();
            this.groupBoxFilms1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.typeComboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEditFilm2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cinemaComboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.funcBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.infoFilm1.SuspendLayout();
            this.groupBoxFilms1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcBox2
            // 
            this.funcBox2.Controls.Add(this.buttonPay1);
            this.funcBox2.Controls.Add(this.pictureBox1);
            this.funcBox2.Controls.Add(this.filmView1);
            this.funcBox2.Controls.Add(this.delFilm1);
            this.funcBox2.Controls.Add(this.editFilm1);
            this.funcBox2.Controls.Add(this.addFilm1);
            this.funcBox2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.funcBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.funcBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.funcBox2.Location = new System.Drawing.Point(13, 13);
            this.funcBox2.Name = "funcBox2";
            this.funcBox2.Size = new System.Drawing.Size(371, 243);
            this.funcBox2.TabIndex = 0;
            this.funcBox2.TabStop = false;
            this.funcBox2.Text = "Tác vụ";
            // 
            // buttonPay1
            // 
            this.buttonPay1.FlatAppearance.BorderSize = 10;
            this.buttonPay1.Location = new System.Drawing.Point(188, 191);
            this.buttonPay1.Name = "buttonPay1";
            this.buttonPay1.Size = new System.Drawing.Size(116, 34);
            this.buttonPay1.TabIndex = 5;
            this.buttonPay1.Text = "Thanh toán";
            this.buttonPay1.UseVisualStyleBackColor = true;
            this.buttonPay1.Click += new System.EventHandler(this.buttonPay1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema.Properties.Resources.film04;
            this.pictureBox1.Location = new System.Drawing.Point(176, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // filmView1
            // 
            this.filmView1.FlatAppearance.BorderSize = 10;
            this.filmView1.Location = new System.Drawing.Point(6, 175);
            this.filmView1.Name = "filmView1";
            this.filmView1.Size = new System.Drawing.Size(116, 27);
            this.filmView1.TabIndex = 3;
            this.filmView1.Text = "Xem thông tin phim";
            this.filmView1.UseVisualStyleBackColor = true;
            this.filmView1.Click += new System.EventHandler(this.filmView1_Click);
            // 
            // delFilm1
            // 
            this.delFilm1.FlatAppearance.BorderSize = 10;
            this.delFilm1.Location = new System.Drawing.Point(6, 131);
            this.delFilm1.Name = "delFilm1";
            this.delFilm1.Size = new System.Drawing.Size(116, 26);
            this.delFilm1.TabIndex = 2;
            this.delFilm1.Text = "Xóa";
            this.delFilm1.UseVisualStyleBackColor = true;
            this.delFilm1.Click += new System.EventHandler(this.delFilm1_Click);
            // 
            // editFilm1
            // 
            this.editFilm1.FlatAppearance.BorderSize = 10;
            this.editFilm1.Location = new System.Drawing.Point(6, 74);
            this.editFilm1.Name = "editFilm1";
            this.editFilm1.Size = new System.Drawing.Size(116, 34);
            this.editFilm1.TabIndex = 1;
            this.editFilm1.Text = "Sửa thông tin";
            this.editFilm1.UseVisualStyleBackColor = true;
            this.editFilm1.Click += new System.EventHandler(this.editFilm1_Click);
            // 
            // addFilm1
            // 
            this.addFilm1.FlatAppearance.BorderSize = 10;
            this.addFilm1.Location = new System.Drawing.Point(6, 22);
            this.addFilm1.Name = "addFilm1";
            this.addFilm1.Size = new System.Drawing.Size(116, 34);
            this.addFilm1.TabIndex = 0;
            this.addFilm1.Text = "Đặt vé";
            this.addFilm1.UseVisualStyleBackColor = true;
            this.addFilm1.Click += new System.EventHandler(this.addFilm1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // infoFilm1
            // 
            this.infoFilm1.Controls.Add(this.showtimeTextBox2);
            this.infoFilm1.Controls.Add(this.label4);
            this.infoFilm1.Controls.Add(this.filmTextBox1);
            this.infoFilm1.Controls.Add(this.label5);
            this.infoFilm1.Controls.Add(this.timebuyTextbox);
            this.infoFilm1.Controls.Add(this.textBoxPay1);
            this.infoFilm1.Controls.Add(this.timeTicket1);
            this.infoFilm1.Controls.Add(this.seatTextbox1);
            this.infoFilm1.Controls.Add(this.labelMoney1);
            this.infoFilm1.Controls.Add(this.seatLabel1);
            this.infoFilm1.Controls.Add(this.cinemaTextbox);
            this.infoFilm1.Controls.Add(this.idTextBox);
            this.infoFilm1.Controls.Add(this.nameCinema1);
            this.infoFilm1.Controls.Add(this.idFilm1);
            this.infoFilm1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoFilm1.Location = new System.Drawing.Point(12, 262);
            this.infoFilm1.Name = "infoFilm1";
            this.infoFilm1.Size = new System.Drawing.Size(372, 245);
            this.infoFilm1.TabIndex = 2;
            this.infoFilm1.TabStop = false;
            this.infoFilm1.Text = "Thông tin vé";
            // 
            // showtimeTextBox2
            // 
            this.showtimeTextBox2.Location = new System.Drawing.Point(74, 111);
            this.showtimeTextBox2.Name = "showtimeTextBox2";
            this.showtimeTextBox2.Size = new System.Drawing.Size(111, 23);
            this.showtimeTextBox2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Suất chiếu";
            // 
            // filmTextBox1
            // 
            this.filmTextBox1.Location = new System.Drawing.Point(245, 67);
            this.filmTextBox1.Name = "filmTextBox1";
            this.filmTextBox1.Size = new System.Drawing.Size(111, 23);
            this.filmTextBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(173, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tên phim";
            // 
            // timebuyTextbox
            // 
            this.timebuyTextbox.Location = new System.Drawing.Point(129, 206);
            this.timebuyTextbox.Name = "timebuyTextbox";
            this.timebuyTextbox.ReadOnly = true;
            this.timebuyTextbox.Size = new System.Drawing.Size(145, 23);
            this.timebuyTextbox.TabIndex = 11;
            // 
            // textBoxPay1
            // 
            this.textBoxPay1.Location = new System.Drawing.Point(74, 161);
            this.textBoxPay1.Name = "textBoxPay1";
            this.textBoxPay1.ReadOnly = true;
            this.textBoxPay1.Size = new System.Drawing.Size(93, 23);
            this.textBoxPay1.TabIndex = 13;
            // 
            // timeTicket1
            // 
            this.timeTicket1.AutoSize = true;
            this.timeTicket1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeTicket1.Location = new System.Drawing.Point(7, 212);
            this.timeTicket1.Name = "timeTicket1";
            this.timeTicket1.Size = new System.Drawing.Size(116, 17);
            this.timeTicket1.TabIndex = 10;
            this.timeTicket1.Text = "Thời gian xuất vé";
            // 
            // seatTextbox1
            // 
            this.seatTextbox1.Location = new System.Drawing.Point(74, 67);
            this.seatTextbox1.Name = "seatTextbox1";
            this.seatTextbox1.ReadOnly = true;
            this.seatTextbox1.Size = new System.Drawing.Size(93, 23);
            this.seatTextbox1.TabIndex = 12;
            // 
            // labelMoney1
            // 
            this.labelMoney1.AutoSize = true;
            this.labelMoney1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMoney1.Location = new System.Drawing.Point(0, 167);
            this.labelMoney1.Name = "labelMoney1";
            this.labelMoney1.Size = new System.Drawing.Size(75, 17);
            this.labelMoney1.TabIndex = 12;
            this.labelMoney1.Text = "Thành tiền";
            // 
            // seatLabel1
            // 
            this.seatLabel1.AutoSize = true;
            this.seatLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seatLabel1.Location = new System.Drawing.Point(1, 68);
            this.seatLabel1.Name = "seatLabel1";
            this.seatLabel1.Size = new System.Drawing.Size(64, 17);
            this.seatLabel1.TabIndex = 11;
            this.seatLabel1.Text = "Chỗ ngồi";
            // 
            // cinemaTextbox
            // 
            this.cinemaTextbox.Location = new System.Drawing.Point(245, 29);
            this.cinemaTextbox.Name = "cinemaTextbox";
            this.cinemaTextbox.Size = new System.Drawing.Size(111, 23);
            this.cinemaTextbox.TabIndex = 8;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(74, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(93, 23);
            this.idTextBox.TabIndex = 5;
            // 
            // nameCinema1
            // 
            this.nameCinema1.AutoSize = true;
            this.nameCinema1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameCinema1.Location = new System.Drawing.Point(208, 29);
            this.nameCinema1.Name = "nameCinema1";
            this.nameCinema1.Size = new System.Drawing.Size(31, 17);
            this.nameCinema1.TabIndex = 3;
            this.nameCinema1.Text = "Rạp";
            // 
            // idFilm1
            // 
            this.idFilm1.AutoSize = true;
            this.idFilm1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idFilm1.Location = new System.Drawing.Point(7, 23);
            this.idFilm1.Name = "idFilm1";
            this.idFilm1.Size = new System.Drawing.Size(22, 17);
            this.idFilm1.TabIndex = 0;
            this.idFilm1.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số ghế trống:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShowTimeComboBox1
            // 
            this.ShowTimeComboBox1.FormattingEnabled = true;
            this.ShowTimeComboBox1.Location = new System.Drawing.Point(45, 94);
            this.ShowTimeComboBox1.Name = "ShowTimeComboBox1";
            this.ShowTimeComboBox1.Size = new System.Drawing.Size(136, 23);
            this.ShowTimeComboBox1.TabIndex = 14;
            this.ShowTimeComboBox1.SelectedIndexChanged += new System.EventHandler(this.ShowTimeComboBox1_SelectedIndexChanged);
            this.ShowTimeComboBox1.TextChanged += new System.EventHandler(this.ShowTimeComboBox1_TextChanged);
            // 
            // timeFilm1
            // 
            this.timeFilm1.AutoSize = true;
            this.timeFilm1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeFilm1.Location = new System.Drawing.Point(4, 97);
            this.timeFilm1.Name = "timeFilm1";
            this.timeFilm1.Size = new System.Drawing.Size(35, 15);
            this.timeFilm1.TabIndex = 13;
            this.timeFilm1.Text = "Ngày";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(69, 64);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(111, 23);
            this.nameTextbox.TabIndex = 6;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // nameFilm1
            // 
            this.nameFilm1.AutoSize = true;
            this.nameFilm1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameFilm1.Location = new System.Drawing.Point(3, 68);
            this.nameFilm1.Name = "nameFilm1";
            this.nameFilm1.Size = new System.Drawing.Size(58, 15);
            this.nameFilm1.TabIndex = 1;
            this.nameFilm1.Text = "Tên phim";
            // 
            // listCinema1
            // 
            this.listCinema1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCinema1.HideSelection = false;
            this.listCinema1.LargeImageList = this.cinemaImg1;
            this.listCinema1.Location = new System.Drawing.Point(390, 410);
            this.listCinema1.Name = "listCinema1";
            this.listCinema1.Size = new System.Drawing.Size(609, 288);
            this.listCinema1.TabIndex = 1;
            this.listCinema1.UseCompatibleStateImageBehavior = false;
            this.listCinema1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listCinema1_ItemSelectionChanged);
            this.listCinema1.SelectedIndexChanged += new System.EventHandler(this.listCinema1_SelectedIndexChanged);
            // 
            // cinemaImg1
            // 
            this.cinemaImg1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.cinemaImg1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cinemaImg1.ImageStream")));
            this.cinemaImg1.TransparentColor = System.Drawing.Color.Transparent;
            this.cinemaImg1.Images.SetKeyName(0, "images.jpg");
            this.cinemaImg1.Images.SetKeyName(1, "pngtree-friend-watching-movie-cartoon-illustration-png-image_1742562.jpg");
            this.cinemaImg1.Images.SetKeyName(2, "68696955-auditorium-and-two-red-comfortable-armchairs-in-the-cinema-drinks-and-po" +
        "pcorn-glasses-for-movie-flat.png");
            // 
            // listFilm1
            // 
            this.listFilm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFilm1.HideSelection = false;
            this.listFilm1.LargeImageList = this.cinemaImg1;
            this.listFilm1.Location = new System.Drawing.Point(390, 13);
            this.listFilm1.Name = "listFilm1";
            this.listFilm1.Size = new System.Drawing.Size(320, 391);
            this.listFilm1.TabIndex = 3;
            this.listFilm1.UseCompatibleStateImageBehavior = false;
            this.listFilm1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listFilm1_ItemSelectionChanged);
            this.listFilm1.DoubleClick += new System.EventHandler(this.listFilm1_DoubleClick);
            // 
            // listRoom1
            // 
            this.listRoom1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRoom1.HideSelection = false;
            this.listRoom1.LargeImageList = this.cinemaImg1;
            this.listRoom1.Location = new System.Drawing.Point(716, 12);
            this.listRoom1.Name = "listRoom1";
            this.listRoom1.Size = new System.Drawing.Size(283, 392);
            this.listRoom1.TabIndex = 4;
            this.listRoom1.UseCompatibleStateImageBehavior = false;
            this.listRoom1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listRoom1_ItemSelectionChanged);
            // 
            // filmImg1
            // 
            this.filmImg1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.filmImg1.ImageSize = new System.Drawing.Size(80, 80);
            this.filmImg1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // roomImg1
            // 
            this.roomImg1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.roomImg1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("roomImg1.ImageStream")));
            this.roomImg1.TransparentColor = System.Drawing.Color.Transparent;
            this.roomImg1.Images.SetKeyName(0, "film02.png");
            // 
            // labelSeatAva2
            // 
            this.labelSeatAva2.AutoSize = true;
            this.labelSeatAva2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSeatAva2.Location = new System.Drawing.Point(127, 591);
            this.labelSeatAva2.Name = "labelSeatAva2";
            this.labelSeatAva2.Size = new System.Drawing.Size(0, 17);
            this.labelSeatAva2.TabIndex = 15;
            // 
            // groupBoxFilms1
            // 
            this.groupBoxFilms1.Controls.Add(this.label6);
            this.groupBoxFilms1.Controls.Add(this.typeComboBox3);
            this.groupBoxFilms1.Controls.Add(this.label2);
            this.groupBoxFilms1.Controls.Add(this.buttonEditFilm2);
            this.groupBoxFilms1.Controls.Add(this.comboBox1);
            this.groupBoxFilms1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxFilms1.Location = new System.Drawing.Point(12, 513);
            this.groupBoxFilms1.Name = "groupBoxFilms1";
            this.groupBoxFilms1.Size = new System.Drawing.Size(180, 185);
            this.groupBoxFilms1.TabIndex = 6;
            this.groupBoxFilms1.TabStop = false;
            this.groupBoxFilms1.Text = "Danh mục phim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Thể loại";
            // 
            // typeComboBox3
            // 
            this.typeComboBox3.FormattingEnabled = true;
            this.typeComboBox3.Items.AddRange(new object[] {
            "Đang chiếu",
            "Sắp chiếu",
            "Ngưng chiếu"});
            this.typeComboBox3.Location = new System.Drawing.Point(74, 115);
            this.typeComboBox3.Name = "typeComboBox3";
            this.typeComboBox3.Size = new System.Drawing.Size(93, 23);
            this.typeComboBox3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Trạng thái";
            // 
            // buttonEditFilm2
            // 
            this.buttonEditFilm2.FlatAppearance.BorderSize = 10;
            this.buttonEditFilm2.Location = new System.Drawing.Point(7, 22);
            this.buttonEditFilm2.Name = "buttonEditFilm2";
            this.buttonEditFilm2.Size = new System.Drawing.Size(95, 34);
            this.buttonEditFilm2.TabIndex = 16;
            this.buttonEditFilm2.Text = "Xem thông tin";
            this.buttonEditFilm2.UseVisualStyleBackColor = true;
            this.buttonEditFilm2.Click += new System.EventHandler(this.buttonEditFilm2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Đang chiếu",
            "Sắp chiếu",
            "Ngưng chiếu"});
            this.comboBox1.Location = new System.Drawing.Point(74, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 23);
            this.comboBox1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cinemaComboBox2);
            this.groupBox1.Controls.Add(this.ShowTimeComboBox1);
            this.groupBox1.Controls.Add(this.timeFilm1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nameTextbox);
            this.groupBox1.Controls.Add(this.nameFilm1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(198, 513);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 185);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục suất chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rạp";
            // 
            // cinemaComboBox2
            // 
            this.cinemaComboBox2.FormattingEnabled = true;
            this.cinemaComboBox2.Location = new System.Drawing.Point(70, 123);
            this.cinemaComboBox2.Name = "cinemaComboBox2";
            this.cinemaComboBox2.Size = new System.Drawing.Size(111, 23);
            this.cinemaComboBox2.TabIndex = 19;
            this.cinemaComboBox2.SelectedIndexChanged += new System.EventHandler(this.cinemaComboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Xem thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1003, 710);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxFilms1);
            this.Controls.Add(this.labelSeatAva2);
            this.Controls.Add(this.listRoom1);
            this.Controls.Add(this.listFilm1);
            this.Controls.Add(this.listCinema1);
            this.Controls.Add(this.infoFilm1);
            this.Controls.Add(this.funcBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTickets";
            this.Text = "Đặt Vé";
            this.Load += new System.EventHandler(this.AddTickets_Load);
            this.funcBox2.ResumeLayout(false);
            this.funcBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.infoFilm1.ResumeLayout(false);
            this.infoFilm1.PerformLayout();
            this.groupBoxFilms1.ResumeLayout(false);
            this.groupBoxFilms1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox funcBox2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button filmView1;
        private System.Windows.Forms.Button delFilm1;
        private System.Windows.Forms.Button editFilm1;
        private System.Windows.Forms.Button addFilm1;
        private System.Windows.Forms.GroupBox infoFilm1;
        private System.Windows.Forms.Label idFilm1;
        private System.Windows.Forms.Label nameCinema1;
        private System.Windows.Forms.Label nameFilm1;
        private System.Windows.Forms.TextBox cinemaTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listCinema1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList cinemaImg1;
        private System.Windows.Forms.TextBox seatTextbox1;
        private System.Windows.Forms.Label seatLabel1;
        private System.Windows.Forms.ListView listRoom1;
        private System.Windows.Forms.ListView listFilm1;
        private System.Windows.Forms.ImageList filmImg1;
        private System.Windows.Forms.ImageList roomImg1;
        private System.Windows.Forms.Label timeFilm1;
        private System.Windows.Forms.ComboBox ShowTimeComboBox1;
        private System.Windows.Forms.TextBox textBoxPay1;
        private System.Windows.Forms.Label labelMoney1;
        private System.Windows.Forms.Button buttonPay1;
        private System.Windows.Forms.Label labelSeatAva2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxFilms1;
        private System.Windows.Forms.Button buttonEditFilm2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox timebuyTextbox;
        private System.Windows.Forms.Label timeTicket1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox showtimeTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filmTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox typeComboBox3;
        private System.Windows.Forms.ComboBox cinemaComboBox2;
        private System.Windows.Forms.Label label3;
    }
}