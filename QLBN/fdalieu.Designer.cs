﻿namespace QLBN
{
    partial class fdalieu
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
            panel1 = new Panel();
            dtgvkhoadalieu = new DataGridView();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            thôgnTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            kiểmTraGiườngTrốngToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvkhoadalieu).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvkhoadalieu);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 583);
            panel1.TabIndex = 6;
            // 
            // dtgvkhoadalieu
            // 
            dtgvkhoadalieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvkhoadalieu.Location = new Point(25, 76);
            dtgvkhoadalieu.Name = "dtgvkhoadalieu";
            dtgvkhoadalieu.RowHeadersWidth = 82;
            dtgvkhoadalieu.RowTemplate.Height = 41;
            dtgvkhoadalieu.Size = new Size(956, 484);
            dtgvkhoadalieu.TabIndex = 1;
            dtgvkhoadalieu.CellContentClick += dtgvkhoadalieu_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(541, 37);
            label1.TabIndex = 0;
            label1.Text = "Danh sách bệnh nhân khoa da liễu";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, thôgnTinTàiKhoảnToolStripMenuItem, kiểmTraGiườngTrốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1028, 40);
            menuStrip1.TabIndex = 7;
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
            // fdalieu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 643);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Name = "fdalieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khoa Da Liễu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvkhoadalieu).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgvkhoadalieu;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem thôgnTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem kiểmTraGiườngTrốngToolStripMenuItem;
    }
}