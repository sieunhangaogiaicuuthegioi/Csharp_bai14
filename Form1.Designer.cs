namespace Csharp_bai14
{
    partial class btnUSDtoVND
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
            this.components = new System.ComponentModel.Container();
            this.txtDoiTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTienQuiDoi = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnVNDtoUSD = new System.Windows.Forms.Button();
            this.btnVNDtoEUR = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEURtoVND = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDoiTien
            // 
            this.txtDoiTien.AutoSize = true;
            this.txtDoiTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoiTien.ForeColor = System.Drawing.Color.Coral;
            this.txtDoiTien.Location = new System.Drawing.Point(555, 84);
            this.txtDoiTien.Name = "txtDoiTien";
            this.txtDoiTien.Size = new System.Drawing.Size(317, 73);
            this.txtDoiTien.TabIndex = 0;
            this.txtDoiTien.Text = "ĐỔI TIỀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiền Qui Đổi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết Quả:";
            // 
            // txtTienQuiDoi
            // 
            this.txtTienQuiDoi.Location = new System.Drawing.Point(405, 220);
            this.txtTienQuiDoi.Name = "txtTienQuiDoi";
            this.txtTienQuiDoi.Size = new System.Drawing.Size(723, 20);
            this.txtTienQuiDoi.TabIndex = 3;
            this.txtTienQuiDoi.TextChanged += new System.EventHandler(this.txtTienQuiDoi_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(405, 474);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(731, 20);
            this.txtKetQua.TabIndex = 4;
            // 
            // btnVNDtoUSD
            // 
            this.btnVNDtoUSD.Location = new System.Drawing.Point(244, 345);
            this.btnVNDtoUSD.Name = "btnVNDtoUSD";
            this.btnVNDtoUSD.Size = new System.Drawing.Size(180, 35);
            this.btnVNDtoUSD.TabIndex = 5;
            this.btnVNDtoUSD.Text = "VNDtoUSD";
            this.btnVNDtoUSD.UseVisualStyleBackColor = true;
            this.btnVNDtoUSD.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVNDtoEUR
            // 
            this.btnVNDtoEUR.Location = new System.Drawing.Point(508, 345);
            this.btnVNDtoEUR.Name = "btnVNDtoEUR";
            this.btnVNDtoEUR.Size = new System.Drawing.Size(186, 35);
            this.btnVNDtoEUR.TabIndex = 6;
            this.btnVNDtoEUR.Text = "VNDtoEUR ";
            this.btnVNDtoEUR.UseVisualStyleBackColor = true;
            this.btnVNDtoEUR.Click += new System.EventHandler(this.btnVNDtoEUR_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(793, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "USDtoVND";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEURtoVND
            // 
            this.btnEURtoVND.Location = new System.Drawing.Point(1096, 345);
            this.btnEURtoVND.Name = "btnEURtoVND";
            this.btnEURtoVND.Size = new System.Drawing.Size(180, 35);
            this.btnEURtoVND.TabIndex = 8;
            this.btnEURtoVND.Text = "EURtoVND";
            this.btnEURtoVND.UseVisualStyleBackColor = true;
            this.btnEURtoVND.Click += new System.EventHandler(this.btnEURtoVND_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnUSDtoVND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 648);
            this.Controls.Add(this.btnEURtoVND);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnVNDtoEUR);
            this.Controls.Add(this.btnVNDtoUSD);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtTienQuiDoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDoiTien);
            this.Name = "btnUSDtoVND";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDoiTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTienQuiDoi;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnVNDtoUSD;
        private System.Windows.Forms.Button btnVNDtoEUR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEURtoVND;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

