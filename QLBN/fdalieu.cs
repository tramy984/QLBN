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
    public partial class fdalieu : Form
    {
        public fdalieu()
        {
            InitializeComponent();
            LoadBenhNhanKhoaDaLieu();
        }
        public class Dataobject
        {
            public string Name { get; set; }
        }
        private void dtgvkhoadalieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvkhoadalieu.Rows[e.RowIndex];

                Dataobject Data = new Dataobject
                {

                    Name = selectedRow.Cells["Name"].Value.ToString(),

                };


                fThongtin fThongtin = new fThongtin();
                fThongtin.ShowDialog();
            }
        }
        void LoadBenhNhanKhoaDaLieu()
        {
            string query = "SELECT MABenhNhan,Name FROM dbo.Benhnhan Where MaKhoa=21";
            DataProvider provider = new DataProvider();
            dtgvkhoadalieu.DataSource = provider.ExecuteQuery(query);
        }
    }
}

