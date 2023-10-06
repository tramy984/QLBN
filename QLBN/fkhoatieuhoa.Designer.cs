namespace QLBN
{
    partial class fkhoatieuhoa
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
            menuStrip1 = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            thôgnTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            kiểmTraGiườngTrốngToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            dtgvkhoatieuhoa = new DataGridView();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvkhoatieuhoa).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, thôgnTinTàiKhoảnToolStripMenuItem, kiểmTraGiườngTrốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1044, 40);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(139, 36);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // thôgnTinTàiKhoảnToolStripMenuItem
            // 
            thôgnTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôgnTinTàiKhoảnToolStripMenuItem.Name = "thôgnTinTàiKhoảnToolStripMenuItem";
            thôgnTinTàiKhoảnToolStripMenuItem.Size = new Size(244, 36);
            thôgnTinTàiKhoảnToolStripMenuItem.Text = "Thôgn tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(342, 44);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(342, 44);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // kiểmTraGiườngTrốngToolStripMenuItem
            // 
            kiểmTraGiườngTrốngToolStripMenuItem.Name = "kiểmTraGiườngTrốngToolStripMenuItem";
            kiểmTraGiườngTrốngToolStripMenuItem.Size = new Size(271, 36);
            kiểmTraGiườngTrốngToolStripMenuItem.Text = "Kiểm tra giường trống";
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvkhoatieuhoa);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 583);
            panel1.TabIndex = 5;
            // 
            // dtgvkhoatieuhoa
            // 
            dtgvkhoatieuhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvkhoatieuhoa.Location = new Point(25, 76);
            dtgvkhoatieuhoa.Name = "dtgvkhoatieuhoa";
            dtgvkhoatieuhoa.RowHeadersWidth = 82;
            dtgvkhoatieuhoa.RowTemplate.Height = 41;
            dtgvkhoatieuhoa.Size = new Size(956, 484);
            dtgvkhoatieuhoa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(561, 37);
            label1.TabIndex = 0;
            label1.Text = "Danh sách bệnh nhân khoa tiêu hoá";
            // 
            // fkhoatieuhoa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 642);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "fkhoatieuhoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khoa Tiêu Hoá";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvkhoatieuhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem thôgnTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem kiểmTraGiườngTrốngToolStripMenuItem;
        private Panel panel1;
        private DataGridView dtgvkhoatieuhoa;
        private Label label1;
    }
}