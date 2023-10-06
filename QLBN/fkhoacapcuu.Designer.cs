namespace QLBN
{
    partial class fkhoacapcuu
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
            dtgvkhoacapcuu = new DataGridView();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvkhoacapcuu).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, thôgnTinTàiKhoảnToolStripMenuItem, kiểmTraGiườngTrốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1047, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(139, 38);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // thôgnTinTàiKhoảnToolStripMenuItem
            // 
            thôgnTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôgnTinTàiKhoảnToolStripMenuItem.Name = "thôgnTinTàiKhoảnToolStripMenuItem";
            thôgnTinTàiKhoảnToolStripMenuItem.Size = new Size(244, 38);
            thôgnTinTàiKhoảnToolStripMenuItem.Text = "Thôgn tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(359, 44);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(359, 44);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // kiểmTraGiườngTrốngToolStripMenuItem
            // 
            kiểmTraGiườngTrốngToolStripMenuItem.Name = "kiểmTraGiườngTrốngToolStripMenuItem";
            kiểmTraGiườngTrốngToolStripMenuItem.Size = new Size(271, 38);
            kiểmTraGiườngTrốngToolStripMenuItem.Text = "Kiểm tra giường trống";
            kiểmTraGiườngTrốngToolStripMenuItem.Click += kiểmTraGiườngTrốngToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvkhoacapcuu);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 583);
            panel1.TabIndex = 2;
            // 
            // dtgvkhoacapcuu
            // 
            dtgvkhoacapcuu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvkhoacapcuu.Location = new Point(25, 76);
            dtgvkhoacapcuu.Name = "dtgvkhoacapcuu";
            dtgvkhoacapcuu.RowHeadersWidth = 82;
            dtgvkhoacapcuu.RowTemplate.Height = 41;
            dtgvkhoacapcuu.Size = new Size(956, 484);
            dtgvkhoacapcuu.TabIndex = 1;
            dtgvkhoacapcuu.CellContentClick += dtgvkhoacapcuu_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(562, 37);
            label1.TabIndex = 0;
            label1.Text = "Danh sách bệnh nhân khoa cấp cứu";
            label1.Click += label1_Click;
            // 
            // fkhoacapcuu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 645);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "fkhoacapcuu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khoa Cấp Cứu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvkhoacapcuu).EndInit();
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
        private Label label1;
        private DataGridView dtgvkhoacapcuu;
    }
}