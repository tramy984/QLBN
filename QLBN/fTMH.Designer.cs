﻿namespace QLBN
{
    partial class fTMH
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
            dtgvkhoaTMH = new DataGridView();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            thôgnTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            kiểmTraGiườngTrốngToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvkhoaTMH).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvkhoaTMH);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 583);
            panel1.TabIndex = 6;
            // 
            // dtgvkhoaTMH
            // 
            dtgvkhoaTMH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvkhoaTMH.Location = new Point(25, 76);
            dtgvkhoaTMH.Name = "dtgvkhoaTMH";
            dtgvkhoaTMH.RowHeadersWidth = 82;
            dtgvkhoaTMH.RowTemplate.Height = 41;
            dtgvkhoaTMH.Size = new Size(956, 484);
            dtgvkhoaTMH.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(668, 37);
            label1.TabIndex = 0;
            label1.Text = "Danh sách bệnh nhân khoa tai - mũi - họng";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, thôgnTinTàiKhoảnToolStripMenuItem, kiểmTraGiườngTrốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1050, 40);
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
            // fTMH
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 643);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Name = "fTMH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khoa Tai - Mũi - Họng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvkhoaTMH).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgvkhoaTMH;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem thôgnTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem kiểmTraGiườngTrốngToolStripMenuItem;
    }
}