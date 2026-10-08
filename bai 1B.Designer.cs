namespace bai4
{
    partial class Hóa_đơn_tiền_điện
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbomk = new System.Windows.Forms.ComboBox();
            this.rdocn = new System.Windows.Forms.RadioButton();
            this.txtcsm = new System.Windows.Forms.TextBox();
            this.txtcsc = new System.Windows.Forms.TextBox();
            this.txtkw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtrdocq = new System.Windows.Forms.RadioButton();
            this.txttk = new System.Windows.Forms.TextBox();
            this.txttt = new System.Windows.Forms.TextBox();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntinhtien = new System.Windows.Forms.Button();
            this.btntieptuc = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(251, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG TÍNH TIỀN ĐIỆN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttc);
            this.groupBox1.Controls.Add(this.txtvat);
            this.groupBox1.Controls.Add(this.txttt);
            this.groupBox1.Controls.Add(this.txttk);
            this.groupBox1.Controls.Add(this.txtrdocq);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtkw);
            this.groupBox1.Controls.Add(this.txtcsc);
            this.groupBox1.Controls.Add(this.txtcsm);
            this.groupBox1.Controls.Add(this.rdocn);
            this.groupBox1.Controls.Add(this.cbomk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chỉ số mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chỉ số cũ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số kw tiêu thụ";
            // 
            // cbomk
            // 
            this.cbomk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomk.FormattingEnabled = true;
            this.cbomk.Location = new System.Drawing.Point(166, 29);
            this.cbomk.Name = "cbomk";
            this.cbomk.Size = new System.Drawing.Size(167, 28);
            this.cbomk.TabIndex = 1;
            this.cbomk.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rdocn
            // 
            this.rdocn.AutoSize = true;
            this.rdocn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdocn.Location = new System.Drawing.Point(166, 72);
            this.rdocn.Name = "rdocn";
            this.rdocn.Size = new System.Drawing.Size(92, 24);
            this.rdocn.TabIndex = 2;
            this.rdocn.TabStop = true;
            this.rdocn.Text = "Cá nhân";
            this.rdocn.UseVisualStyleBackColor = true;
            // 
            // txtcsm
            // 
            this.txtcsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcsm.Location = new System.Drawing.Point(166, 102);
            this.txtcsm.Name = "txtcsm";
            this.txtcsm.Size = new System.Drawing.Size(167, 27);
            this.txtcsm.TabIndex = 3;
            // 
            // txtcsc
            // 
            this.txtcsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcsc.Location = new System.Drawing.Point(166, 152);
            this.txtcsc.Name = "txtcsc";
            this.txtcsc.Size = new System.Drawing.Size(167, 27);
            this.txtcsc.TabIndex = 3;
            // 
            // txtkw
            // 
            this.txtkw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkw.Location = new System.Drawing.Point(166, 198);
            this.txtkw.Name = "txtkw";
            this.txtkw.Size = new System.Drawing.Size(167, 27);
            this.txtkw.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên khách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Thành tiền";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Thuế VAT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tổng cộng";
            // 
            // txtrdocq
            // 
            this.txtrdocq.AutoSize = true;
            this.txtrdocq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrdocq.Location = new System.Drawing.Point(388, 72);
            this.txtrdocq.Name = "txtrdocq";
            this.txtrdocq.Size = new System.Drawing.Size(92, 24);
            this.txtrdocq.TabIndex = 5;
            this.txtrdocq.TabStop = true;
            this.txtrdocq.Text = "Cơ quan";
            this.txtrdocq.UseVisualStyleBackColor = true;
            // 
            // txttk
            // 
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.Location = new System.Drawing.Point(494, 34);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(154, 27);
            this.txttk.TabIndex = 6;
            // 
            // txttt
            // 
            this.txttt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttt.Location = new System.Drawing.Point(499, 98);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(149, 27);
            this.txttt.TabIndex = 6;
            // 
            // txtvat
            // 
            this.txtvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvat.Location = new System.Drawing.Point(499, 146);
            this.txtvat.Name = "txtvat";
            this.txtvat.Size = new System.Drawing.Size(149, 27);
            this.txtvat.TabIndex = 6;
            // 
            // txttc
            // 
            this.txttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttc.Location = new System.Drawing.Point(499, 192);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(149, 27);
            this.txttc.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btntieptuc);
            this.groupBox2.Controls.Add(this.btntinhtien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(183, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thực hiện";
            // 
            // btntinhtien
            // 
            this.btntinhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinhtien.ForeColor = System.Drawing.Color.Firebrick;
            this.btntinhtien.Location = new System.Drawing.Point(109, 29);
            this.btntinhtien.Name = "btntinhtien";
            this.btntinhtien.Size = new System.Drawing.Size(88, 35);
            this.btntinhtien.TabIndex = 0;
            this.btntinhtien.Text = "Tính tiền";
            this.btntinhtien.UseVisualStyleBackColor = true;
            this.btntinhtien.Click += new System.EventHandler(this.btntinhtien_Click);
            // 
            // btntieptuc
            // 
            this.btntieptuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntieptuc.ForeColor = System.Drawing.Color.Firebrick;
            this.btntieptuc.Location = new System.Drawing.Point(220, 29);
            this.btntieptuc.Name = "btntieptuc";
            this.btntieptuc.Size = new System.Drawing.Size(112, 35);
            this.btntieptuc.TabIndex = 0;
            this.btntieptuc.Text = "tiếp tục";
            this.btntieptuc.UseVisualStyleBackColor = true;
            this.btntieptuc.Click += new System.EventHandler(this.btntieptuc_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Firebrick;
            this.btnthoat.Location = new System.Drawing.Point(361, 29);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(94, 35);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Hóa_đơn_tiền_điện
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Hóa_đơn_tiền_điện";
            this.Text = "Hóa đơn tiền điện";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbomk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtkw;
        private System.Windows.Forms.TextBox txtcsc;
        private System.Windows.Forms.TextBox txtcsm;
        private System.Windows.Forms.RadioButton rdocn;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtvat;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.RadioButton txtrdocq;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntieptuc;
        private System.Windows.Forms.Button btntinhtien;
    }
}