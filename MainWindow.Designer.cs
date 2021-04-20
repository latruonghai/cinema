
namespace Cinema
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.timeFilm1 = new System.Windows.Forms.Button();
            this.cinemaMap1 = new System.Windows.Forms.Button();
            this.listFilm1 = new System.Windows.Forms.Button();
            this.functionBox = new System.Windows.Forms.GroupBox();
            this.addTick1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.informationBox1 = new System.Windows.Forms.GroupBox();
            this.functionBox.SuspendLayout();
            this.informationBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "chair01.png");
            this.imageList1.Images.SetKeyName(1, "chair02.png");
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(256, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(541, 426);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // timeFilm1
            // 
            this.timeFilm1.Location = new System.Drawing.Point(9, 105);
            this.timeFilm1.Name = "timeFilm1";
            this.timeFilm1.Size = new System.Drawing.Size(107, 23);
            this.timeFilm1.TabIndex = 1;
            this.timeFilm1.Text = "Xem suất chiếu";
            this.timeFilm1.UseVisualStyleBackColor = true;
            // 
            // cinemaMap1
            // 
            this.cinemaMap1.Location = new System.Drawing.Point(9, 63);
            this.cinemaMap1.Name = "cinemaMap1";
            this.cinemaMap1.Size = new System.Drawing.Size(107, 23);
            this.cinemaMap1.TabIndex = 3;
            this.cinemaMap1.Text = "Sơ đồ rạp chiếu";
            this.cinemaMap1.UseVisualStyleBackColor = true;
            // 
            // listFilm1
            // 
            this.listFilm1.Location = new System.Drawing.Point(9, 146);
            this.listFilm1.Name = "listFilm1";
            this.listFilm1.Size = new System.Drawing.Size(107, 23);
            this.listFilm1.TabIndex = 4;
            this.listFilm1.Text = "Danh sách phim";
            this.listFilm1.UseVisualStyleBackColor = true;
            // 
            // functionBox
            // 
            this.functionBox.Controls.Add(this.listFilm1);
            this.functionBox.Controls.Add(this.cinemaMap1);
            this.functionBox.Controls.Add(this.timeFilm1);
            this.functionBox.Controls.Add(this.addTick1);
            this.functionBox.Location = new System.Drawing.Point(12, 250);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(238, 188);
            this.functionBox.TabIndex = 1;
            this.functionBox.TabStop = false;
            this.functionBox.Text = "Thao tác";
            // 
            // addTick1
            // 
            this.addTick1.Location = new System.Drawing.Point(9, 22);
            this.addTick1.Name = "addTick1";
            this.addTick1.Size = new System.Drawing.Size(107, 23);
            this.addTick1.TabIndex = 0;
            this.addTick1.Text = "Đặt Vé";
            this.addTick1.UseVisualStyleBackColor = true;
            this.addTick1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phim";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin rạp";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số ghế";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 23);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên phim";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(100, 150);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(105, 23);
            this.textBox4.TabIndex = 7;
            // 
            // informationBox1
            // 
            this.informationBox1.Controls.Add(this.textBox4);
            this.informationBox1.Controls.Add(this.label4);
            this.informationBox1.Controls.Add(this.textBox3);
            this.informationBox1.Controls.Add(this.label3);
            this.informationBox1.Controls.Add(this.textBox2);
            this.informationBox1.Controls.Add(this.label2);
            this.informationBox1.Controls.Add(this.textBox1);
            this.informationBox1.Controls.Add(this.label1);
            this.informationBox1.Location = new System.Drawing.Point(12, 12);
            this.informationBox1.Name = "informationBox1";
            this.informationBox1.Size = new System.Drawing.Size(238, 222);
            this.informationBox1.TabIndex = 0;
            this.informationBox1.TabStop = false;
            this.informationBox1.Text = "Thông tin";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.functionBox);
            this.Controls.Add(this.informationBox1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.functionBox.ResumeLayout(false);
            this.informationBox1.ResumeLayout(false);
            this.informationBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button timeFilm1;
        private System.Windows.Forms.Button cinemaMap1;
        private System.Windows.Forms.Button listFilm1;
        private System.Windows.Forms.GroupBox functionBox;
        private System.Windows.Forms.Button addTick1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox informationBox1;
    }
}

