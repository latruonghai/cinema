
namespace Cinema.func
{
    partial class ShowTimePickers
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
            this.showTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.showTimeLabel1 = new System.Windows.Forms.Label();
            this.dataShowTimeGridView1 = new System.Windows.Forms.DataGridView();
            this.addShowTimeButton1 = new System.Windows.Forms.Button();
            this.delShowTimebutton1 = new System.Windows.Forms.Button();
            this.editShowTimeButton2 = new System.Windows.Forms.Button();
            this.ShowTime2 = new System.Windows.Forms.Label();
            this.filmLabel1 = new System.Windows.Forms.Label();
            this.comboBoxFilm1 = new System.Windows.Forms.ComboBox();
            this.comboBoxRoom1 = new System.Windows.Forms.ComboBox();
            this.labelRoom1 = new System.Windows.Forms.Label();
            this.buttonDone1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataShowTimeGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showTimePicker1
            // 
            this.showTimePicker1.AllowDrop = true;
            this.showTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm";
            this.showTimePicker1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.showTimePicker1.Location = new System.Drawing.Point(95, 94);
            this.showTimePicker1.Name = "showTimePicker1";
            this.showTimePicker1.Size = new System.Drawing.Size(141, 22);
            this.showTimePicker1.TabIndex = 16;
            this.showTimePicker1.UseWaitCursor = true;
            this.showTimePicker1.Value = new System.DateTime(2021, 3, 31, 0, 0, 0, 0);
            // 
            // showTimeLabel1
            // 
            this.showTimeLabel1.AutoSize = true;
            this.showTimeLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showTimeLabel1.Location = new System.Drawing.Point(22, 91);
            this.showTimeLabel1.Name = "showTimeLabel1";
            this.showTimeLabel1.Size = new System.Drawing.Size(67, 17);
            this.showTimeLabel1.TabIndex = 15;
            this.showTimeLabel1.Text = "Suất chiếu";
            // 
            // dataShowTimeGridView1
            // 
            this.dataShowTimeGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataShowTimeGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShowTimeGridView1.EnableHeadersVisualStyles = false;
            this.dataShowTimeGridView1.Location = new System.Drawing.Point(22, 161);
            this.dataShowTimeGridView1.Name = "dataShowTimeGridView1";
            this.dataShowTimeGridView1.ReadOnly = true;
            this.dataShowTimeGridView1.RowHeadersVisible = false;
            this.dataShowTimeGridView1.RowTemplate.Height = 25;
            this.dataShowTimeGridView1.Size = new System.Drawing.Size(534, 268);
            this.dataShowTimeGridView1.TabIndex = 17;
            // 
            // addShowTimeButton1
            // 
            this.addShowTimeButton1.Location = new System.Drawing.Point(292, 91);
            this.addShowTimeButton1.Name = "addShowTimeButton1";
            this.addShowTimeButton1.Size = new System.Drawing.Size(83, 25);
            this.addShowTimeButton1.TabIndex = 18;
            this.addShowTimeButton1.Text = "Thêm";
            this.addShowTimeButton1.UseVisualStyleBackColor = true;
            this.addShowTimeButton1.Click += new System.EventHandler(this.addShowTimeButton1_Click);
            // 
            // delShowTimebutton1
            // 
            this.delShowTimebutton1.Location = new System.Drawing.Point(381, 91);
            this.delShowTimebutton1.Name = "delShowTimebutton1";
            this.delShowTimebutton1.Size = new System.Drawing.Size(83, 25);
            this.delShowTimebutton1.TabIndex = 19;
            this.delShowTimebutton1.Text = "Xóa";
            this.delShowTimebutton1.UseVisualStyleBackColor = true;
            // 
            // editShowTimeButton2
            // 
            this.editShowTimeButton2.Location = new System.Drawing.Point(470, 91);
            this.editShowTimeButton2.Name = "editShowTimeButton2";
            this.editShowTimeButton2.Size = new System.Drawing.Size(83, 25);
            this.editShowTimeButton2.TabIndex = 20;
            this.editShowTimeButton2.Text = "Sửa";
            this.editShowTimeButton2.UseVisualStyleBackColor = true;
            // 
            // ShowTime2
            // 
            this.ShowTime2.AutoSize = true;
            this.ShowTime2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowTime2.Location = new System.Drawing.Point(110, 9);
            this.ShowTime2.Name = "ShowTime2";
            this.ShowTime2.Size = new System.Drawing.Size(324, 54);
            this.ShowTime2.TabIndex = 21;
            this.ShowTime2.Text = "Thêm Suất Chiếu";
            // 
            // filmLabel1
            // 
            this.filmLabel1.AutoSize = true;
            this.filmLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filmLabel1.Location = new System.Drawing.Point(22, 132);
            this.filmLabel1.Name = "filmLabel1";
            this.filmLabel1.Size = new System.Drawing.Size(67, 17);
            this.filmLabel1.TabIndex = 22;
            this.filmLabel1.Text = "Suất chiếu";
            // 
            // comboBoxFilm1
            // 
            this.comboBoxFilm1.FormattingEnabled = true;
            this.comboBoxFilm1.Location = new System.Drawing.Point(96, 132);
            this.comboBoxFilm1.Name = "comboBoxFilm1";
            this.comboBoxFilm1.Size = new System.Drawing.Size(140, 23);
            this.comboBoxFilm1.TabIndex = 23;
            // 
            // comboBoxRoom1
            // 
            this.comboBoxRoom1.FormattingEnabled = true;
            this.comboBoxRoom1.Location = new System.Drawing.Point(366, 132);
            this.comboBoxRoom1.Name = "comboBoxRoom1";
            this.comboBoxRoom1.Size = new System.Drawing.Size(97, 23);
            this.comboBoxRoom1.TabIndex = 25;
            // 
            // labelRoom1
            // 
            this.labelRoom1.AutoSize = true;
            this.labelRoom1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoom1.Location = new System.Drawing.Point(292, 132);
            this.labelRoom1.Name = "labelRoom1";
            this.labelRoom1.Size = new System.Drawing.Size(31, 17);
            this.labelRoom1.TabIndex = 24;
            this.labelRoom1.Text = "Rạp";
            // 
            // buttonDone1
            // 
            this.buttonDone1.Location = new System.Drawing.Point(473, 35);
            this.buttonDone1.Name = "buttonDone1";
            this.buttonDone1.Size = new System.Drawing.Size(83, 25);
            this.buttonDone1.TabIndex = 26;
            this.buttonDone1.Text = "Xong";
            this.buttonDone1.UseVisualStyleBackColor = true;
            this.buttonDone1.Click += new System.EventHandler(this.buttonDone1_Click);
            // 
            // ShowTimePickers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 441);
            this.Controls.Add(this.buttonDone1);
            this.Controls.Add(this.comboBoxRoom1);
            this.Controls.Add(this.labelRoom1);
            this.Controls.Add(this.comboBoxFilm1);
            this.Controls.Add(this.filmLabel1);
            this.Controls.Add(this.ShowTime2);
            this.Controls.Add(this.editShowTimeButton2);
            this.Controls.Add(this.delShowTimebutton1);
            this.Controls.Add(this.addShowTimeButton1);
            this.Controls.Add(this.dataShowTimeGridView1);
            this.Controls.Add(this.showTimePicker1);
            this.Controls.Add(this.showTimeLabel1);
            this.Name = "ShowTimePickers";
            this.Text = "CinemaList";
            this.Load += new System.EventHandler(this.ShowTimePickers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataShowTimeGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker showTimePicker1;
        private System.Windows.Forms.Label showTimeLabel1;
        private System.Windows.Forms.DataGridView dataShowTimeGridView1;
        private System.Windows.Forms.Button addShowTimeButton1;
        private System.Windows.Forms.Button delShowTimebutton1;
        private System.Windows.Forms.Button editShowTimeButton2;
        private System.Windows.Forms.Label ShowTime2;
        private System.Windows.Forms.Label filmLabel1;
        private System.Windows.Forms.ComboBox comboBoxFilm1;
        private System.Windows.Forms.ComboBox comboBoxRoom1;
        private System.Windows.Forms.Label labelRoom1;
        private System.Windows.Forms.Button buttonDone1;
    }
}