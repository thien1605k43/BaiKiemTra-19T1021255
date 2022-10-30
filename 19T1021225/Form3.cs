using _19T1021225.ModelView;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            NapDSNhom();
        }
        void NapDSNhom()
        {
            var list = NhomViewModel.GetList();
            for (int i = 0; i < list.Count; i++)
            {
                cbxChonNhom.Items.Add(list[i].TenNhom);
            }

        }
        private void ShowForm1()
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var list = NhomViewModel.GetList();
            var id = 0;
            var chimuc = cbxChonNhom.SelectedIndex;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == chimuc)
                {
                    id = list[i].ID;
                }
            }
            var nguoi = new Nguoi
            {
                TenGoi = txtTenGoi.Text,
                Email = txtEmail.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                IDNhom = id,

            };
            NguoiViewModel.ThemNguoi(nguoi);
            Thread thread = new Thread(new ThreadStart(ShowForm1));
            thread.Start();
            this.Close();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            void NapDSNhom()
            {
                var list = NhomViewModel.GetList();
                for (int i = 0; i < list.Count; i++)
                {
                    cbxChonNhom.Items.Add(list[i].TenNhom);
                }

            }
        }
    }
}
