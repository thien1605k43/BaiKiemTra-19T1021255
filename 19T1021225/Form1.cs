using _19T1021225.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19T1021225
{
    public partial class Form1 : Form
    {
        int manhom = 0;
        int masinhvien = 0;

        public Form1()
        {
            InitializeComponent();
            NapDanhSachNhom();
        }
        void NapDanhSachNhom()
        {
            var list = NhomViewModel.GetList();
            dataGridViewNhom.DataSource = list;
        }
        void NapDanhSachNguoi(int id)
        {

            var list = NguoiViewModel.GetListByID(id);
            dataGridViewNguoi.DataSource = list;
        }
        private void ShowForm2()
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baiKiemTraDataSet1.Nguoi' table. You can move, or remove it, as needed.
            this.nguoiTableAdapter.Fill(this.baiKiemTraDataSet1.Nguoi);
            // TODO: This line of code loads data into the 'baiKiemTraDataSet.Nhom' table. You can move, or remove it, as needed.
            this.nhomTableAdapter.Fill(this.baiKiemTraDataSet.Nhom);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewNhom.Rows[e.RowIndex];
            string tennhom = Convert.ToString(row.Cells["TenNhom"].Value);
            var list = NhomViewModel.GetList();
            int id = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].TenNhom.Equals(tennhom))
                {
                    id = list[i].ID;
                    manhom = id;
                }
            }
            NapDanhSachNguoi(manhom);
        }

        private void dataGridViewNguoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewNguoi.Rows[e.RowIndex];
            txtTenGoi.Text = Convert.ToString(row.Cells["TenGoi"].Value);
            txtEmail.Text = Convert.ToString(row.Cells["Email"].Value);
            txtSDT.Text = Convert.ToString(row.Cells["SDT"].Value);
            string email = Convert.ToString(row.Cells["Email"].Value);

            var list = NguoiViewModel.GetListAll();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Email.Equals(email))
                {
                    txtDiaChi.Text = list[i].DiaChi;
                    masinhvien = list[i].ID;
                }
            }
        }

        private void clickThemNhom_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(ShowForm2));
            thread.Start();
            this.Close();
        }
        private void ShowForm3()
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
        private void clickXoaNhom_Click(object sender, EventArgs e)
        {
            if (manhom != 0)
            {
                var rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NhomViewModel.XoaNhom(manhom);
                    NapDanhSachNhom();
                }
            }
        }

        private void clickThemLienLac_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm3));
            thread.Start();
            this.Close();
        }

        private void clickXoaLienLac_Click(object sender, EventArgs e)
        {
            if (masinhvien != 0)
            {
                var rs = MessageBox.Show("Bạn có chắc chắn muốn xóa không? ?", "Chú ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    NguoiViewModel.XoaNguoi(masinhvien);
                    NapDanhSachNhom();
                    NapDanhSachNguoi(manhom);
                }
            }
        }
    }
}
