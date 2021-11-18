namespace ds_in_bu
{
    partial class FrmDS
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
            this.LbSerial = new System.Windows.Forms.Label();
            this.TxbSerial = new System.Windows.Forms.TextBox();
            this.LbSothe = new System.Windows.Forms.Label();
            this.TxbSLThe = new System.Windows.Forms.TextBox();
            this.TxbSLTam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTaoDS = new System.Windows.Forms.Button();
            this.BtnXuatFile = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LsbDS = new System.Windows.Forms.ListBox();
            this.BtnXoaDS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbSerial
            // 
            this.LbSerial.AutoSize = true;
            this.LbSerial.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSerial.Location = new System.Drawing.Point(29, 31);
            this.LbSerial.Name = "LbSerial";
            this.LbSerial.Size = new System.Drawing.Size(95, 22);
            this.LbSerial.TabIndex = 0;
            this.LbSerial.Text = "Serial Thẻ";
            // 
            // TxbSerial
            // 
            this.TxbSerial.Location = new System.Drawing.Point(163, 31);
            this.TxbSerial.Name = "TxbSerial";
            this.TxbSerial.Size = new System.Drawing.Size(182, 20);
            this.TxbSerial.TabIndex = 1;
            // 
            // LbSothe
            // 
            this.LbSothe.AutoSize = true;
            this.LbSothe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSothe.Location = new System.Drawing.Point(29, 65);
            this.LbSothe.Name = "LbSothe";
            this.LbSothe.Size = new System.Drawing.Size(112, 22);
            this.LbSothe.TabIndex = 2;
            this.LbSothe.Text = "SL Thẻ/Tấm";
            // 
            // TxbSLThe
            // 
            this.TxbSLThe.Location = new System.Drawing.Point(163, 65);
            this.TxbSLThe.Name = "TxbSLThe";
            this.TxbSLThe.Size = new System.Drawing.Size(182, 20);
            this.TxbSLThe.TabIndex = 3;
            // 
            // TxbSLTam
            // 
            this.TxbSLTam.Location = new System.Drawing.Point(163, 100);
            this.TxbSLTam.Name = "TxbSLTam";
            this.TxbSLTam.Size = new System.Drawing.Size(182, 20);
            this.TxbSLTam.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "SL Tấm Thẻ";
            // 
            // BtnTaoDS
            // 
            this.BtnTaoDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTaoDS.Location = new System.Drawing.Point(27, 145);
            this.BtnTaoDS.Name = "BtnTaoDS";
            this.BtnTaoDS.Size = new System.Drawing.Size(127, 38);
            this.BtnTaoDS.TabIndex = 6;
            this.BtnTaoDS.Text = "Tạo Danh Sách";
            this.BtnTaoDS.UseVisualStyleBackColor = true;
            this.BtnTaoDS.Click += new System.EventHandler(this.BtnTaoDS_Click);
            // 
            // BtnXuatFile
            // 
            this.BtnXuatFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXuatFile.Location = new System.Drawing.Point(167, 145);
            this.BtnXuatFile.Name = "BtnXuatFile";
            this.BtnXuatFile.Size = new System.Drawing.Size(113, 38);
            this.BtnXuatFile.TabIndex = 7;
            this.BtnXuatFile.Text = "Xuất File";
            this.BtnXuatFile.UseVisualStyleBackColor = true;
            this.BtnXuatFile.Click += new System.EventHandler(this.BtnXuatFile_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThoat.Location = new System.Drawing.Point(293, 145);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(113, 38);
            this.BtnThoat.TabIndex = 8;
            this.BtnThoat.Text = "Exit";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(351, 31);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(61, 89);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LsbDS
            // 
            this.LsbDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LsbDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsbDS.FormattingEnabled = true;
            this.LsbDS.ItemHeight = 19;
            this.LsbDS.Location = new System.Drawing.Point(163, 215);
            this.LsbDS.Name = "LsbDS";
            this.LsbDS.Size = new System.Drawing.Size(215, 327);
            this.LsbDS.TabIndex = 11;
            // 
            // BtnXoaDS
            // 
            this.BtnXoaDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoaDS.Location = new System.Drawing.Point(27, 215);
            this.BtnXoaDS.Name = "BtnXoaDS";
            this.BtnXoaDS.Size = new System.Drawing.Size(127, 44);
            this.BtnXoaDS.TabIndex = 12;
            this.BtnXoaDS.Text = "Xóa Danh Sách";
            this.BtnXoaDS.UseVisualStyleBackColor = true;
            this.BtnXoaDS.Click += new System.EventHandler(this.BtnXoaDS_Click);
            // 
            // FrmDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 569);
            this.Controls.Add(this.BtnXoaDS);
            this.Controls.Add(this.LsbDS);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnXuatFile);
            this.Controls.Add(this.BtnTaoDS);
            this.Controls.Add(this.TxbSLTam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbSLThe);
            this.Controls.Add(this.LbSothe);
            this.Controls.Add(this.TxbSerial);
            this.Controls.Add(this.LbSerial);
            this.Name = "FrmDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbSerial;
        private System.Windows.Forms.TextBox TxbSerial;
        private System.Windows.Forms.Label LbSothe;
        private System.Windows.Forms.TextBox TxbSLThe;
        private System.Windows.Forms.TextBox TxbSLTam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTaoDS;
        private System.Windows.Forms.Button BtnXuatFile;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.ListBox LsbDS;
        private System.Windows.Forms.Button BtnXoaDS;
    }
}

