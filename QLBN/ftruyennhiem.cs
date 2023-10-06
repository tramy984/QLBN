using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBN.DAO;

namespace QLBN
{
    public partial class ftruyennhiem : Form
    {
        public ftruyennhiem()
        {
            InitializeComponent();
            LoadBenhNhanKhoaTruyenNhiem();
        }
        private void dtgvkhoatruyennhiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public class Dataobject
        {
            public string Name { get; set; }
        }
        private void dtgvkhoanhi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvkhoatruyennhiem.Rows[e.RowIndex];

                Dataobject Data = new Dataobject
                {

                    Name = selectedRow.Cells["Name"].Value.ToString(),

                };


                fThongtin fThongtin = new fThongtin();
                fThongtin.ShowDialog();
            }
        }
        void LoadBenhNhanKhoaTruyenNhiem()
        {
            string query = "SELECT MABenhNhan,Name FROM dbo.Benhnhan Where MaKhoa=22";
            DataProvider provider = new DataProvider();
            dtgvkhoatruyennhiem.DataSource = provider.ExecuteQuery(query);
        }
    }
    }

