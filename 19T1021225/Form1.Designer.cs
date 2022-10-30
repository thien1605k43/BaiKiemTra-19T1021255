namespace _19T1021225
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.clickThemNhom = new System.Windows.Forms.ToolStripLabel();
            this.clickXoaNhom = new System.Windows.Forms.ToolStripLabel();
            this.clickThemLienLac = new System.Windows.Forms.ToolStripLabel();
            this.clickXoaLienLac = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewNhom = new System.Windows.Forms.DataGridView();
            this.dataGridViewNguoi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenGoi = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.baiKiemTraDataSet = new _19T1021225.BaiKiemTraDataSet();
            this.nhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomTableAdapter = new _19T1021225.BaiKiemTraDataSetTableAdapters.NhomTableAdapter();
            this.baiKiemTraDataSet1 = new _19T1021225.BaiKiemTraDataSet1();
            this.nguoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiTableAdapter = new _19T1021225.BaiKiemTraDataSet1TableAdapters.NguoiTableAdapter();
            this.TenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiKiemTraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiKiemTraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickThemNhom,
            this.clickXoaNhom,
            this.clickThemLienLac,
            this.clickXoaLienLac});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1072, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // clickThemNhom
            // 
            this.clickThemNhom.Name = "clickThemNhom";
            this.clickThemNhom.Size = new System.Drawing.Size(92, 22);
            this.clickThemNhom.Text = " Thêm nhóm";
            this.clickThemNhom.Click += new System.EventHandler(this.clickThemNhom_Click);
            // 
            // clickXoaNhom
            // 
            this.clickXoaNhom.Name = "clickXoaNhom";
            this.clickXoaNhom.Size = new System.Drawing.Size(84, 22);
            this.clickXoaNhom.Text = " Xoá Nhóm";
            this.clickXoaNhom.Click += new System.EventHandler(this.clickXoaNhom_Click);
            // 
            // clickThemLienLac
            // 
            this.clickThemLienLac.Name = "clickThemLienLac";
            this.clickThemLienLac.Size = new System.Drawing.Size(103, 22);
            this.clickThemLienLac.Text = "Thêm Liên Lạc";
            this.clickThemLienLac.Click += new System.EventHandler(this.clickThemLienLac_Click);
            // 
            // clickXoaLienLac
            // 
            this.clickXoaLienLac.Name = "clickXoaLienLac";
            this.clickXoaLienLac.Size = new System.Drawing.Size(92, 22);
            this.clickXoaLienLac.Text = "Xoá Liên Lạc";
            this.clickXoaLienLac.Click += new System.EventHandler(this.clickXoaLienLac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(697, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = " Nhập từ cần tìm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(821, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 22);
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewNguoi);
            this.panel1.Controls.Add(this.dataGridViewNhom);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenGoi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 588);
            this.panel1.TabIndex = 3;
            // 
            // dataGridViewNhom
            // 
            this.dataGridViewNhom.AutoGenerateColumns = false;
            this.dataGridViewNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNhom});
            this.dataGridViewNhom.DataSource = this.nhomBindingSource;
            this.dataGridViewNhom.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewNhom.Name = "dataGridViewNhom";
            this.dataGridViewNhom.RowHeadersWidth = 51;
            this.dataGridViewNhom.RowTemplate.Height = 24;
            this.dataGridViewNhom.Size = new System.Drawing.Size(404, 588);
            this.dataGridViewNhom.TabIndex = 0;
            this.dataGridViewNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewNguoi
            // 
            this.dataGridViewNguoi.AutoGenerateColumns = false;
            this.dataGridViewNguoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNguoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenGoi,
            this.Email,
            this.SDT});
            this.dataGridViewNguoi.DataSource = this.nguoiBindingSource;
            this.dataGridViewNguoi.Location = new System.Drawing.Point(423, 0);
            this.dataGridViewNguoi.Name = "dataGridViewNguoi";
            this.dataGridViewNguoi.RowHeadersWidth = 51;
            this.dataGridViewNguoi.RowTemplate.Height = 24;
            this.dataGridViewNguoi.Size = new System.Drawing.Size(646, 244);
            this.dataGridViewNguoi.TabIndex = 1;
            this.dataGridViewNguoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNguoi_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "[Tên gọi]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = " Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = " Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = " Số điện thoại";
            // 
            // txtTenGoi
            // 
            this.txtTenGoi.AutoSize = true;
            this.txtTenGoi.Location = new System.Drawing.Point(604, 310);
            this.txtTenGoi.Name = "txtTenGoi";
            this.txtTenGoi.Size = new System.Drawing.Size(10, 16);
            this.txtTenGoi.TabIndex = 1;
            this.txtTenGoi.Text = " ";
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Location = new System.Drawing.Point(604, 492);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(0, 16);
            this.txtSDT.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Location = new System.Drawing.Point(604, 374);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(0, 16);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(604, 425);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(10, 16);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = " ";
            // 
            // baiKiemTraDataSet
            // 
            this.baiKiemTraDataSet.DataSetName = "BaiKiemTraDataSet";
            this.baiKiemTraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhomBindingSource
            // 
            this.nhomBindingSource.DataMember = "Nhom";
            this.nhomBindingSource.DataSource = this.baiKiemTraDataSet;
            // 
            // nhomTableAdapter
            // 
            this.nhomTableAdapter.ClearBeforeFill = true;
            // 
            // baiKiemTraDataSet1
            // 
            this.baiKiemTraDataSet1.DataSetName = "BaiKiemTraDataSet1";
            this.baiKiemTraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nguoiBindingSource
            // 
            this.nguoiBindingSource.DataMember = "Nguoi";
            this.nguoiBindingSource.DataSource = this.baiKiemTraDataSet1;
            // 
            // nguoiTableAdapter
            // 
            this.nguoiTableAdapter.ClearBeforeFill = true;
            // 
            // TenGoi
            // 
            this.TenGoi.DataPropertyName = "TenGoi";
            this.TenGoi.HeaderText = "TenGoi";
            this.TenGoi.MinimumWidth = 6;
            this.TenGoi.Name = "TenGoi";
            this.TenGoi.Width = 170;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 250;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 170;
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "TenNhom";
            this.TenNhom.MinimumWidth = 6;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.Width = 360;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiKiemTraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baiKiemTraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel clickThemNhom;
        private System.Windows.Forms.ToolStripLabel clickXoaNhom;
        private System.Windows.Forms.ToolStripLabel clickThemLienLac;
        private System.Windows.Forms.ToolStripLabel clickXoaLienLac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewNguoi;
        private System.Windows.Forms.DataGridView dataGridViewNhom;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label txtTenGoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private BaiKiemTraDataSet baiKiemTraDataSet;
        private System.Windows.Forms.BindingSource nhomBindingSource;
        private BaiKiemTraDataSetTableAdapters.NhomTableAdapter nhomTableAdapter;
        private BaiKiemTraDataSet1 baiKiemTraDataSet1;
        private System.Windows.Forms.BindingSource nguoiBindingSource;
        private BaiKiemTraDataSet1TableAdapters.NguoiTableAdapter nguoiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
    }
}

