
namespace TeamManagement
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBoPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visualStyleManager1 = new Janus.Windows.Common.VisualStyleManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxBoPhan = new System.Windows.Forms.ComboBox();
            this.buttonHuyEdit = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonXacNhan = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxTenTeam = new System.Windows.Forms.TextBox();
            this.textBoxMaTeam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTeam,
            this.TenTeam,
            this.TenBoPhan});
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // MaTeam
            // 
            this.MaTeam.DataPropertyName = "TeamId";
            this.MaTeam.HeaderText = "Mã Team";
            this.MaTeam.MinimumWidth = 6;
            this.MaTeam.Name = "MaTeam";
            this.MaTeam.Width = 125;
            // 
            // TenTeam
            // 
            this.TenTeam.DataPropertyName = "TeamName";
            this.TenTeam.HeaderText = "Tên Team";
            this.TenTeam.MinimumWidth = 6;
            this.TenTeam.Name = "TenTeam";
            this.TenTeam.Width = 125;
            // 
            // TenBoPhan
            // 
            this.TenBoPhan.DataPropertyName = "DepartmentName";
            this.TenBoPhan.HeaderText = "Tên Bộ Phận";
            this.TenBoPhan.MinimumWidth = 6;
            this.TenBoPhan.Name = "TenBoPhan";
            this.TenBoPhan.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxBoPhan);
            this.groupBox1.Controls.Add(this.buttonHuyEdit);
            this.groupBox1.Controls.Add(this.buttonHuy);
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Controls.Add(this.buttonSua);
            this.groupBox1.Controls.Add(this.buttonCapNhat);
            this.groupBox1.Controls.Add(this.buttonXacNhan);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Controls.Add(this.textBoxTenTeam);
            this.groupBox1.Controls.Add(this.textBoxMaTeam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(592, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(369, 388);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxBoPhan
            // 
            this.comboBoxBoPhan.FormattingEnabled = true;
            this.comboBoxBoPhan.Location = new System.Drawing.Point(91, 192);
            this.comboBoxBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBoPhan.Name = "comboBoxBoPhan";
            this.comboBoxBoPhan.Size = new System.Drawing.Size(205, 24);
            this.comboBoxBoPhan.TabIndex = 3;
            // 
            // buttonHuyEdit
            // 
            this.buttonHuyEdit.BackColor = System.Drawing.Color.Red;
            this.buttonHuyEdit.Location = new System.Drawing.Point(228, 324);
            this.buttonHuyEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHuyEdit.Name = "buttonHuyEdit";
            this.buttonHuyEdit.Size = new System.Drawing.Size(100, 28);
            this.buttonHuyEdit.TabIndex = 2;
            this.buttonHuyEdit.Text = "Hủy";
            this.buttonHuyEdit.UseVisualStyleBackColor = false;
            this.buttonHuyEdit.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.Red;
            this.buttonHuy.Location = new System.Drawing.Point(228, 288);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(100, 28);
            this.buttonHuy.TabIndex = 2;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.Red;
            this.buttonXoa.Location = new System.Drawing.Point(228, 252);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(100, 28);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.Orange;
            this.buttonSua.Location = new System.Drawing.Point(120, 252);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(100, 28);
            this.buttonSua.TabIndex = 2;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonCapNhat.Location = new System.Drawing.Point(12, 324);
            this.buttonCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(100, 28);
            this.buttonCapNhat.TabIndex = 2;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = false;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonXacNhan.Location = new System.Drawing.Point(12, 288);
            this.buttonXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(100, 28);
            this.buttonXacNhan.TabIndex = 2;
            this.buttonXacNhan.Text = "Xác Nhận";
            this.buttonXacNhan.UseVisualStyleBackColor = false;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonThem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonThem.Location = new System.Drawing.Point(12, 252);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(100, 28);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // textBoxTenTeam
            // 
            this.textBoxTenTeam.Location = new System.Drawing.Point(91, 114);
            this.textBoxTenTeam.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenTeam.Name = "textBoxTenTeam";
            this.textBoxTenTeam.Size = new System.Drawing.Size(205, 22);
            this.textBoxTenTeam.TabIndex = 1;
            // 
            // textBoxMaTeam
            // 
            this.textBoxMaTeam.Location = new System.Drawing.Point(91, 36);
            this.textBoxMaTeam.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaTeam.Name = "textBoxMaTeam";
            this.textBoxMaTeam.Size = new System.Drawing.Size(205, 22);
            this.textBoxMaTeam.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bộ phận  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Team ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Team ";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(40, 13);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(276, 22);
            this.textBoxTimKiem.TabIndex = 2;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(322, 9);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(91, 31);
            this.buttonTimKiem.TabIndex = 3;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(432, 9);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(119, 31);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Report Result";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBoPhan;
        private Janus.Windows.Common.VisualStyleManager visualStyleManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox textBoxTenTeam;
        private System.Windows.Forms.TextBox textBoxMaTeam;
        private System.Windows.Forms.ComboBox comboBoxBoPhan;
        private System.Windows.Forms.Button buttonXacNhan;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonHuyEdit;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonReport;
    }
}

