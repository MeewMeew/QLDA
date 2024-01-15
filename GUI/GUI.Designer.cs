namespace GUI
{
    partial class GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMa = new System.Windows.Forms.TextBox();
            this.textBoxSoGD = new System.Windows.Forms.TextBox();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.dateTimeBD = new System.Windows.Forms.DateTimePicker();
            this.dateTimeKT = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.gridGiaiDoan = new System.Windows.Forms.DataGridView();
            this.maDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridGiaiDoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng giai đoạn dự án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã dự án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số giai đoạn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên giai đoạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày kết thúc";
            // 
            // textBoxMa
            // 
            this.textBoxMa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMa.Location = new System.Drawing.Point(204, 86);
            this.textBoxMa.Name = "textBoxMa";
            this.textBoxMa.Size = new System.Drawing.Size(200, 22);
            this.textBoxMa.TabIndex = 6;
            // 
            // textBoxSoGD
            // 
            this.textBoxSoGD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoGD.Location = new System.Drawing.Point(204, 123);
            this.textBoxSoGD.Name = "textBoxSoGD";
            this.textBoxSoGD.Size = new System.Drawing.Size(200, 22);
            this.textBoxSoGD.TabIndex = 7;
            // 
            // textBoxTen
            // 
            this.textBoxTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTen.Location = new System.Drawing.Point(204, 155);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(200, 22);
            this.textBoxTen.TabIndex = 8;
            // 
            // dateTimeBD
            // 
            this.dateTimeBD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBD.Location = new System.Drawing.Point(204, 192);
            this.dateTimeBD.Name = "dateTimeBD";
            this.dateTimeBD.Size = new System.Drawing.Size(200, 22);
            this.dateTimeBD.TabIndex = 9;
            // 
            // dateTimeKT
            // 
            this.dateTimeKT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeKT.Location = new System.Drawing.Point(204, 230);
            this.dateTimeKT.Name = "dateTimeKT";
            this.dateTimeKT.Size = new System.Drawing.Size(200, 22);
            this.dateTimeKT.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(574, 86);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(574, 133);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(574, 181);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Xoá";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.Location = new System.Drawing.Point(520, 227);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(181, 23);
            this.buttonReport.TabIndex = 14;
            this.buttonReport.Text = "Thông tin giai đoạn dự án";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // gridGiaiDoan
            // 
            this.gridGiaiDoan.AllowUserToAddRows = false;
            this.gridGiaiDoan.AllowUserToDeleteRows = false;
            this.gridGiaiDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGiaiDoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDA,
            this.soGD,
            this.tenGD,
            this.batdau,
            this.ketthuc});
            this.gridGiaiDoan.Location = new System.Drawing.Point(68, 291);
            this.gridGiaiDoan.Name = "gridGiaiDoan";
            this.gridGiaiDoan.ReadOnly = true;
            this.gridGiaiDoan.Size = new System.Drawing.Size(667, 246);
            this.gridGiaiDoan.TabIndex = 15;
            this.gridGiaiDoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridGiaiDoan_CellClick);
            // 
            // maDA
            // 
            this.maDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maDA.DataPropertyName = "MA_DA";
            this.maDA.HeaderText = "Mã dự án";
            this.maDA.Name = "maDA";
            this.maDA.ReadOnly = true;
            this.maDA.Width = 77;
            // 
            // soGD
            // 
            this.soGD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soGD.DataPropertyName = "SOGDOAN";
            this.soGD.HeaderText = "Số giai đoạn";
            this.soGD.Name = "soGD";
            this.soGD.ReadOnly = true;
            this.soGD.Width = 92;
            // 
            // tenGD
            // 
            this.tenGD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenGD.DataPropertyName = "TEN_GD";
            this.tenGD.HeaderText = "Tên giai đoạn";
            this.tenGD.Name = "tenGD";
            this.tenGD.ReadOnly = true;
            this.tenGD.Width = 98;
            // 
            // batdau
            // 
            this.batdau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.batdau.DataPropertyName = "NGAY_BD";
            this.batdau.HeaderText = "Ngày bắt đầu";
            this.batdau.Name = "batdau";
            this.batdau.ReadOnly = true;
            this.batdau.Width = 97;
            // 
            // ketthuc
            // 
            this.ketthuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ketthuc.DataPropertyName = "NGAY_KT";
            this.ketthuc.HeaderText = "Ngày kết thúc";
            this.ketthuc.Name = "ketthuc";
            this.ketthuc.ReadOnly = true;
            this.ketthuc.Width = 99;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.gridGiaiDoan);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimeKT);
            this.Controls.Add(this.dateTimeBD);
            this.Controls.Add(this.textBoxTen);
            this.Controls.Add(this.textBoxSoGD);
            this.Controls.Add(this.textBoxMa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGiaiDoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMa;
        private System.Windows.Forms.TextBox textBoxSoGD;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.DateTimePicker dateTimeBD;
        private System.Windows.Forms.DateTimePicker dateTimeKT;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.DataGridView gridGiaiDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn soGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn batdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketthuc;
    }
}

