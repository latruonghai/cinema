
namespace Cinema.func
{
    partial class ListFilm

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
            this.imageFilmList1 = new System.Windows.Forms.ImageList(this.components);
            this.listFilm1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDelFilm1 = new System.Windows.Forms.Button();
            this.browseFilmBtn1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeTextBox1 = new System.Windows.Forms.TextBox();
            this.nameFilm1 = new System.Windows.Forms.Label();
            this.imagePath1 = new System.Windows.Forms.TextBox();
            this.statusCombobox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageFilmList1
            // 
            this.imageFilmList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageFilmList1.ImageSize = new System.Drawing.Size(128, 214);
            this.imageFilmList1.Tag = "Fine";
            this.imageFilmList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listFilm1
            // 
            this.listFilm1.HideSelection = false;
            this.listFilm1.Location = new System.Drawing.Point(274, 12);
            this.listFilm1.Name = "listFilm1";
            this.listFilm1.Size = new System.Drawing.Size(514, 426);
            this.listFilm1.TabIndex = 8;
            this.listFilm1.UseCompatibleStateImageBehavior = false;
            this.listFilm1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listFilm1_ItemSelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonDelFilm1);
            this.groupBox1.Controls.Add(this.browseFilmBtn1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.Location = new System.Drawing.Point(15, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 24;
            this.button1.Text = "Sửa phim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelFilm1
            // 
            this.buttonDelFilm1.FlatAppearance.BorderSize = 10;
            this.buttonDelFilm1.Location = new System.Drawing.Point(15, 82);
            this.buttonDelFilm1.Name = "buttonDelFilm1";
            this.buttonDelFilm1.Size = new System.Drawing.Size(95, 34);
            this.buttonDelFilm1.TabIndex = 23;
            this.buttonDelFilm1.Text = "Xóa phim";
            this.buttonDelFilm1.UseVisualStyleBackColor = true;
            this.buttonDelFilm1.Click += new System.EventHandler(this.buttonDelFilm1_Click);
            // 
            // browseFilmBtn1
            // 
            this.browseFilmBtn1.FlatAppearance.BorderSize = 10;
            this.browseFilmBtn1.Location = new System.Drawing.Point(15, 32);
            this.browseFilmBtn1.Name = "browseFilmBtn1";
            this.browseFilmBtn1.Size = new System.Drawing.Size(95, 30);
            this.browseFilmBtn1.TabIndex = 20;
            this.browseFilmBtn1.Text = "Thêm phim";
            this.browseFilmBtn1.UseVisualStyleBackColor = true;
            this.browseFilmBtn1.Click += new System.EventHandler(this.browseFilmBtn1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.typeTextBox1);
            this.groupBox2.Controls.Add(this.nameFilm1);
            this.groupBox2.Controls.Add(this.imagePath1);
            this.groupBox2.Controls.Add(this.statusCombobox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 181);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tình trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Thể loại";
            // 
            // typeTextBox1
            // 
            this.typeTextBox1.Location = new System.Drawing.Point(96, 69);
            this.typeTextBox1.Name = "typeTextBox1";
            this.typeTextBox1.Size = new System.Drawing.Size(144, 23);
            this.typeTextBox1.TabIndex = 26;
            // 
            // nameFilm1
            // 
            this.nameFilm1.AutoSize = true;
            this.nameFilm1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameFilm1.Location = new System.Drawing.Point(15, 28);
            this.nameFilm1.Name = "nameFilm1";
            this.nameFilm1.Size = new System.Drawing.Size(66, 17);
            this.nameFilm1.TabIndex = 25;
            this.nameFilm1.Text = "Tên phim";
            // 
            // imagePath1
            // 
            this.imagePath1.Location = new System.Drawing.Point(96, 27);
            this.imagePath1.Name = "imagePath1";
            this.imagePath1.Size = new System.Drawing.Size(144, 23);
            this.imagePath1.TabIndex = 23;
            // 
            // statusCombobox1
            // 
            this.statusCombobox1.FormattingEnabled = true;
            this.statusCombobox1.Items.AddRange(new object[] {
            "Đang chiếu",
            "Sắp chiếu",
            "Ngừng chiếu"});
            this.statusCombobox1.Location = new System.Drawing.Point(96, 112);
            this.statusCombobox1.Name = "statusCombobox1";
            this.statusCombobox1.Size = new System.Drawing.Size(114, 23);
            this.statusCombobox1.TabIndex = 24;
            this.statusCombobox1.SelectedIndexChanged += new System.EventHandler(this.statusCombobox1_SelectedIndexChanged);
            // 
            // ListFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listFilm1);
            this.Name = "ListFilm";
            this.Text = "ListFilm";
            this.Load += new System.EventHandler(this.ListFilm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageFilmList1;
        private System.Windows.Forms.ListView listFilm1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDelFilm1;
        private System.Windows.Forms.Button browseFilmBtn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox imagePath1;
        private System.Windows.Forms.ComboBox statusCombobox1;
        private System.Windows.Forms.Label nameFilm1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeTextBox1;
    }
}