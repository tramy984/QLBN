using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBN.DAO;

namespace QLBN
{
    public partial class fkhoacapcuu : Form
    {
        public fkhoacapcuu()
        {
            InitializeComponent();
            LoadBenhNhanKhoaCapCuu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public class Dataobject
        {
            public string Name { get; set; }
        }
        private void dtgvkhoacapcuu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvkhoacapcuu.Rows[e.RowIndex];

                Dataobject Data = new Dataobject
                {

                    Name = selectedRow.Cells["Name"].Value.ToString(),

                };


                fThongtin fThongtin = new fThongtin();
                fThongtin.ShowDialog();
            }
        }
        void LoadBenhNhanKhoaCapCuu()
        {
            string query = "SELECT MABenhNhan,Name FROM dbo.Benhnhan Where MaKhoa=10";
            DataProvider provider = new DataProvider();
            dtgvkhoacapcuu.DataSource = provider.ExecuteQuery(query);
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftableAccount f = new ftableAccount();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kiểmTraGiườngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fgiuongtrong f=new fgiuongtrong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
