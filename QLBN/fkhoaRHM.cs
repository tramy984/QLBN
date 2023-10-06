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
    public partial class fkhoaRHM : Form
    {
        public fkhoaRHM()
        {
            InitializeComponent();
            LoadBenhNhanKhoaRHM();
        }

        public class Dataobject
        {
            public string Name { get; set; }
        }
        
        private void dtgvkhoaRHM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvkhoaRHM.Rows[e.RowIndex];

                Dataobject Data = new Dataobject
                {

                    Name = selectedRow.Cells["Name"].Value.ToString(),

                };


                fThongtin fThongtin = new fThongtin();
                fThongtin.ShowDialog();
            }
        }
        void LoadBenhNhanKhoaRHM()
        {
            string query = "SELECT MABenhNhan,Name FROM dbo.Benhnhan Where MaKhoa=11";
            DataProvider provider = new DataProvider();
            dtgvkhoaRHM.DataSource = provider.ExecuteQuery(query);
        }
    }
}
