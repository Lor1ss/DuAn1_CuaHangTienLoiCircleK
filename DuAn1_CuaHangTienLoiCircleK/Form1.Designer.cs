namespace DuAn1_CuaHangTienLoiCircleK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBoxKMSP = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxGiaSP = new TextBox();
            textBoxTenSP = new TextBox();
            textBoxIDSP = new TextBox();
            label1 = new Label();
            dgvSP = new DataGridView();
            buttonThem = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            label5 = new Label();
            textBoxTK = new TextBox();
            buttonLM = new Button();
            groupBox2 = new GroupBox();
            textBoxTenSPCT = new TextBox();
            textBoxDVT = new TextBox();
            textBoxMT = new TextBox();
            textBoxSL = new TextBox();
            textBoxHSD = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dgvCTSP = new DataGridView();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTSP).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxKMSP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxGiaSP);
            groupBox1.Controls.Add(textBoxTenSP);
            groupBox1.Controls.Add(textBoxIDSP);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvSP);
            groupBox1.Location = new Point(12, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(875, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản Phẩm";
            // 
            // comboBoxKMSP
            // 
            comboBoxKMSP.FormattingEnabled = true;
            comboBoxKMSP.Location = new Point(610, 259);
            comboBoxKMSP.Name = "comboBoxKMSP";
            comboBoxKMSP.Size = new Size(245, 28);
            comboBoxKMSP.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(610, 236);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 8;
            label4.Text = "Khuyến Mãi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(610, 166);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 7;
            label3.Text = "Giá Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(610, 98);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 6;
            label2.Text = "Tên Sản Phẩm";
            // 
            // textBoxGiaSP
            // 
            textBoxGiaSP.Location = new Point(610, 189);
            textBoxGiaSP.Name = "textBoxGiaSP";
            textBoxGiaSP.Size = new Size(245, 27);
            textBoxGiaSP.TabIndex = 4;
            // 
            // textBoxTenSP
            // 
            textBoxTenSP.Location = new Point(610, 121);
            textBoxTenSP.Name = "textBoxTenSP";
            textBoxTenSP.Size = new Size(245, 27);
            textBoxTenSP.TabIndex = 3;
            // 
            // textBoxIDSP
            // 
            textBoxIDSP.Location = new Point(610, 49);
            textBoxIDSP.Name = "textBoxIDSP";
            textBoxIDSP.ReadOnly = true;
            textBoxIDSP.Size = new Size(245, 27);
            textBoxIDSP.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(610, 26);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "ID Sản Phẩm";
            // 
            // dgvSP
            // 
            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP.Location = new Point(17, 26);
            dgvSP.Name = "dgvSP";
            dgvSP.RowHeadersWidth = 51;
            dgvSP.Size = new Size(574, 261);
            dgvSP.TabIndex = 0;
            dgvSP.CellClick += dgvSP_CellClick;
            // 
            // buttonThem
            // 
            buttonThem.Location = new Point(56, 149);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(123, 37);
            buttonThem.TabIndex = 1;
            buttonThem.Text = "Thêm Sản Phẩm";
            buttonThem.UseVisualStyleBackColor = true;
            buttonThem.Click += buttonThem_Click;
            // 
            // buttonSua
            // 
            buttonSua.Location = new Point(56, 204);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(123, 37);
            buttonSua.TabIndex = 2;
            buttonSua.Text = "Sửa Sản Phẩm";
            buttonSua.UseVisualStyleBackColor = true;
            buttonSua.Click += buttonSua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Location = new Point(56, 259);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(123, 37);
            buttonXoa.TabIndex = 3;
            buttonXoa.Text = "Xóa Sản Phẩm";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 26);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 10;
            label5.Text = "Tìm Kiếm";
            // 
            // textBoxTK
            // 
            textBoxTK.Location = new Point(16, 49);
            textBoxTK.Name = "textBoxTK";
            textBoxTK.Size = new Size(195, 27);
            textBoxTK.TabIndex = 10;
            textBoxTK.TextChanged += textBoxTK_TextChanged;
            // 
            // buttonLM
            // 
            buttonLM.Location = new Point(56, 90);
            buttonLM.Name = "buttonLM";
            buttonLM.Size = new Size(123, 37);
            buttonLM.TabIndex = 11;
            buttonLM.Text = "Làm Mới";
            buttonLM.UseVisualStyleBackColor = true;
            buttonLM.Click += buttonLM_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxTenSPCT);
            groupBox2.Controls.Add(textBoxDVT);
            groupBox2.Controls.Add(textBoxMT);
            groupBox2.Controls.Add(textBoxSL);
            groupBox2.Controls.Add(textBoxHSD);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(dgvCTSP);
            groupBox2.Location = new Point(12, 314);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1123, 377);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi Tiết Sản Phẩm";
            // 
            // textBoxTenSPCT
            // 
            textBoxTenSPCT.Location = new Point(838, 49);
            textBoxTenSPCT.Name = "textBoxTenSPCT";
            textBoxTenSPCT.ReadOnly = true;
            textBoxTenSPCT.Size = new Size(263, 27);
            textBoxTenSPCT.TabIndex = 20;
            // 
            // textBoxDVT
            // 
            textBoxDVT.Location = new Point(838, 260);
            textBoxDVT.Name = "textBoxDVT";
            textBoxDVT.Size = new Size(263, 27);
            textBoxDVT.TabIndex = 19;
            // 
            // textBoxMT
            // 
            textBoxMT.Location = new Point(838, 332);
            textBoxMT.Name = "textBoxMT";
            textBoxMT.Size = new Size(263, 27);
            textBoxMT.TabIndex = 18;
            // 
            // textBoxSL
            // 
            textBoxSL.Location = new Point(838, 191);
            textBoxSL.Name = "textBoxSL";
            textBoxSL.Size = new Size(263, 27);
            textBoxSL.TabIndex = 17;
            // 
            // textBoxHSD
            // 
            textBoxHSD.Location = new Point(838, 120);
            textBoxHSD.Name = "textBoxHSD";
            textBoxHSD.Size = new Size(263, 27);
            textBoxHSD.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(838, 309);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 14;
            label10.Text = "Mô Tả";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(838, 237);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 13;
            label9.Text = "Đơn Vị Tính";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(838, 168);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 12;
            label8.Text = "Số Lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(838, 97);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 11;
            label7.Text = "Hạn Sử Dụng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(838, 26);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 10;
            label6.Text = "Tên Sản Phẩm";
            // 
            // dgvCTSP
            // 
            dgvCTSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTSP.Location = new Point(17, 26);
            dgvCTSP.Name = "dgvCTSP";
            dgvCTSP.RowHeadersWidth = 51;
            dgvCTSP.Size = new Size(801, 333);
            dgvCTSP.TabIndex = 0;
            dgvCTSP.CellClick += dgvCTSP_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonSua);
            groupBox3.Controls.Add(buttonThem);
            groupBox3.Controls.Add(buttonLM);
            groupBox3.Controls.Add(buttonXoa);
            groupBox3.Controls.Add(textBoxTK);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(902, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(233, 307);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Công Cụ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 703);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Quản Lý Sản Phẩm";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTSP).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxKMSP;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxGiaSP;
        private TextBox textBoxTenSP;
        private TextBox textBoxIDSP;
        private Label label1;
        private DataGridView dgvSP;
        private Button buttonThem;
        private Button buttonSua;
        private Button buttonXoa;
        private Label label5;
        private TextBox textBoxTK;
        private Button buttonLM;
        private GroupBox groupBox2;
        private DataGridView dgvCTSP;
        private GroupBox groupBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBoxMT;
        private TextBox textBoxSL;
        private TextBox textBoxHSD;
        private Label label10;
        private TextBox textBoxDVT;
        private TextBox textBoxTenSPCT;
    }
}
