using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class GUI : Form
    {
        private readonly BUS_GiaiDoan bus_gd = new BUS_GiaiDoan();
        public GUI()
        {
            InitializeComponent();
        }

        private void ShowData()
        {
            DataTable dt = bus_gd.LoadGD();
            gridGiaiDoan.DataSource = dt;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string maDA = textBoxMa.Text;
            bus_gd.Delete(new GiaiDoanDA { MaDA = maDA });
            MessageBox.Show("Xóa thành công");
            ShowData();
            CleanBox();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string maDA = textBoxMa.Text;
            int soGD = int.Parse(textBoxSoGD.Text);
            string tenGD = textBoxTen.Text;
            DateTime ngayBatDau = dateTimeBD.Value;
            DateTime ngayKetThuc = dateTimeKT.Value;

            if (gridGiaiDoan.CurrentRow != null)
            {
                if (ngayBatDau >= ngayKetThuc)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                    return;
                }

                if (maDA == "" || soGD == 0 || tenGD == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                GiaiDoanDA gd = new GiaiDoanDA(maDA, soGD, tenGD, ngayBatDau, ngayKetThuc);
                bus_gd.Update(gd);
                MessageBox.Show("Cập nhật thành công");
                ShowData();
                CleanBox();
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string maDA = textBoxMa.Text;
            int soGD = int.Parse(textBoxSoGD.Text);
            string tenGD = textBoxTen.Text;
            DateTime ngayBatDau = dateTimeBD.Value;
            DateTime ngayKetThuc = dateTimeKT.Value;
            DataTable dt = bus_gd.LoadGD(
                "select * from GIAIDOAN_DA where MA_DA = @MaDA", 
                new System.Data.SqlClient.SqlParameter[] { 
                    new System.Data.SqlClient.SqlParameter("@MaDA", maDA) 
                }
            );
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã dự án đã tồn tại");
                return;
            }
            if (ngayBatDau >= ngayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                return;
            }
            if (maDA == "" || soGD == 0 || tenGD == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            GiaiDoanDA gd = new GiaiDoanDA(maDA, soGD, tenGD, ngayBatDau, ngayKetThuc);
            bus_gd.Insert(gd);
            MessageBox.Show("Thêm thành công");
            ShowData();
            CleanBox();
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            if (gridGiaiDoan.CurrentRow != null && textBoxMa.Text != "")
            {
                DataGridViewRow row = gridGiaiDoan.CurrentRow;
                string MaDA = row.Cells[0].Value.ToString();
                FormReport f = new FormReport(MaDA);
                f.Show();
                CleanBox();
            } else { 
                MessageBox.Show("Vui lòng chọn 1 dự án bên dưới");
            }
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void CleanBox() {
            textBoxMa.Text = "";
            textBoxSoGD.Text = "";
            textBoxTen.Text = "";
        }

        private void GridGiaiDoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridGiaiDoan.CurrentRow != null)
            {
                DataGridViewRow row = gridGiaiDoan.CurrentRow;
                textBoxMa.Text = row.Cells[0].Value.ToString();
                textBoxSoGD.Text = row.Cells[1].Value.ToString();
                textBoxTen.Text = row.Cells[2].Value.ToString();
                dateTimeBD.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                dateTimeKT.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            }
        }
    }
}
