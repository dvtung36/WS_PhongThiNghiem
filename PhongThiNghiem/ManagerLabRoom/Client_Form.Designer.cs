namespace ManagerLabRoom
{
    partial class Client_Form
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
            this.btnThietBi = new System.Windows.Forms.Button();
            this.btnQuaHan = new System.Windows.Forms.Button();
            this.btnBaiThiNghiem = new System.Windows.Forms.Button();
            this.btnToiHan = new System.Windows.Forms.Button();
            this.tbchungloai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tvIDGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDATA = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThietBi
            // 
            this.btnThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietBi.Location = new System.Drawing.Point(34, 128);
            this.btnThietBi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Size = new System.Drawing.Size(188, 84);
            this.btnThietBi.TabIndex = 0;
            this.btnThietBi.Text = "Thiết Bị";
            this.btnThietBi.UseVisualStyleBackColor = true;
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            // 
            // btnQuaHan
            // 
            this.btnQuaHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaHan.Location = new System.Drawing.Point(975, 264);
            this.btnQuaHan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuaHan.Name = "btnQuaHan";
            this.btnQuaHan.Size = new System.Drawing.Size(188, 86);
            this.btnQuaHan.TabIndex = 1;
            this.btnQuaHan.Text = "Thiết Bị Quá Hạn";
            this.btnQuaHan.UseVisualStyleBackColor = true;
            this.btnQuaHan.Click += new System.EventHandler(this.btnQuaHan_Click);
            // 
            // btnBaiThiNghiem
            // 
            this.btnBaiThiNghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaiThiNghiem.Location = new System.Drawing.Point(34, 264);
            this.btnBaiThiNghiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBaiThiNghiem.Name = "btnBaiThiNghiem";
            this.btnBaiThiNghiem.Size = new System.Drawing.Size(188, 86);
            this.btnBaiThiNghiem.TabIndex = 2;
            this.btnBaiThiNghiem.Text = "Bài Thí Nghiệm";
            this.btnBaiThiNghiem.UseVisualStyleBackColor = true;
            this.btnBaiThiNghiem.Click += new System.EventHandler(this.btnBaiThiNghiem_Click);
            // 
            // btnToiHan
            // 
            this.btnToiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToiHan.Location = new System.Drawing.Point(975, 97);
            this.btnToiHan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToiHan.Name = "btnToiHan";
            this.btnToiHan.Size = new System.Drawing.Size(188, 86);
            this.btnToiHan.TabIndex = 3;
            this.btnToiHan.Text = "Thiết Bị Tới Hạn";
            this.btnToiHan.UseVisualStyleBackColor = true;
            this.btnToiHan.Click += new System.EventHandler(this.btnToiHan_Click);
            // 
            // tbchungloai
            // 
            this.tbchungloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbchungloai.Location = new System.Drawing.Point(302, 156);
            this.tbchungloai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbchungloai.Name = "tbchungloai";
            this.tbchungloai.Size = new System.Drawing.Size(247, 45);
            this.tbchungloai.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "nhập chủng loại";
            // 
            // tvIDGV
            // 
            this.tvIDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvIDGV.Location = new System.Drawing.Point(302, 294);
            this.tvIDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvIDGV.Name = "tvIDGV";
            this.tvIDGV.Size = new System.Drawing.Size(247, 45);
            this.tvIDGV.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Giáo Viên";
            // 
            // dgvDATA
            // 
            this.dgvDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDATA.Location = new System.Drawing.Point(2, 412);
            this.dgvDATA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDATA.Name = "dgvDATA";
            this.dgvDATA.RowHeadersWidth = 51;
            this.dgvDATA.RowTemplate.Height = 24;
            this.dgvDATA.Size = new System.Drawing.Size(1366, 503);
            this.dgvDATA.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quản Lý Phòng Thí Nghiệm";
            // 
            // Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 919);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDATA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvIDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbchungloai);
            this.Controls.Add(this.btnToiHan);
            this.Controls.Add(this.btnBaiThiNghiem);
            this.Controls.Add(this.btnQuaHan);
            this.Controls.Add(this.btnThietBi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Client_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThietBi;
        private System.Windows.Forms.Button btnQuaHan;
        private System.Windows.Forms.Button btnBaiThiNghiem;
        private System.Windows.Forms.Button btnToiHan;
        private System.Windows.Forms.TextBox tbchungloai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tvIDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDATA;
        private System.Windows.Forms.Label label3;
    }
}

