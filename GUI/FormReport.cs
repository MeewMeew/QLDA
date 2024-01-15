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

namespace GUI
{
    public partial class FormReport : Form
    {
        private BUS_GiaiDoan bus_gd = new BUS_GiaiDoan();
        private string MaDA;
        public FormReport(string MaDA) 
        {
            InitializeComponent();
            this.MaDA = MaDA;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // join 2 table THAM_GIA and NHANVIEN by MA_NV and MA_DA
            string sql = "SELECT GIAIDOAN_DA.TEN_GD, NHANVIEN.MA_NV, NHANVIEN.TEN_NV, FORMAT(NHANVIEN.NGAY_SINH, 'dd/MM/yyyy'), NHANVIEN.DCHI, NHANVIEN.MA_DONVI, THAM_GIA.DANHGIA" +
                "\r\nFROM GIAIDOAN_DA\r\nJOIN THAM_GIA ON GIAIDOAN_DA.MA_DA = THAM_GIA.MA_DA" +
                "\r\nJOIN NHANVIEN ON THAM_GIA.MA_NV = NHANVIEN.MA_NV" +
                "\r\nWHERE GIAIDOAN_DA.MA_DA = '" + MaDA + "'";
            DataTable dt = bus_gd.LoadGD(sql);
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = @"E:\\Project\\Persional\\csharp\\Desktop\\TestingEndOfTheTerm\\GUI\\ReportGD.rdlc";
            if (dt.Rows.Count > 0)
            {
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();
                rds.Name = "DataSetGD";
                rds.Value = dt;
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
