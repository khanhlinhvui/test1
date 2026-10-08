namespace bai4
{
    partial class bai_5B
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
            this.txtnsn = new System.Windows.Forms.TextBox();
            this.btnnhap = new System.Windows.Forms.Button();
            this.lstDaySo = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btkt = new System.Windows.Forms.Button();
            this.btnxds = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btncsd = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btndc = new System.Windows.Forms.Button();
            this.btnptd = new System.Windows.Forms.Button();
            this.btnptc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ứng dụng xử lý dãy số ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnnhap);
            this.groupBox1.Controls.Add(this.txtnsn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-2, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số nguyên";
            // 
            // txtnsn
            // 
            this.txtnsn.Location = new System.Drawing.Point(165, 26);
            this.txtnsn.Name = "txtnsn";
            this.txtnsn.Size = new System.Drawing.Size(131, 27);
            this.txtnsn.TabIndex = 0;
            // 
            // btnnhap
            // 
            this.btnnhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnnhap.Location = new System.Drawing.Point(389, 26);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(133, 32);
            this.btnnhap.TabIndex = 1;
            this.btnnhap.Text = "Nhập số";
            this.btnnhap.UseVisualStyleBackColor = false;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // lstDaySo
            // 
            this.lstDaySo.FormattingEnabled = true;
            this.lstDaySo.ItemHeight = 16;
            this.lstDaySo.Location = new System.Drawing.Point(-2, 186);
            this.lstDaySo.Name = "lstDaySo";
            this.lstDaySo.Size = new System.Drawing.Size(368, 212);
            this.lstDaySo.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnptc);
            this.groupBox2.Controls.Add(this.btnptd);
            this.groupBox2.Controls.Add(this.btndc);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.btncsd);
            this.groupBox2.Controls.Add(this.btnTang2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(364, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 229);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btkt
            // 
            this.btkt.BackColor = System.Drawing.Color.Firebrick;
            this.btkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btkt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btkt.Location = new System.Drawing.Point(163, 415);
            this.btkt.Name = "btkt";
            this.btkt.Size = new System.Drawing.Size(168, 30);
            this.btkt.TabIndex = 4;
            this.btkt.Text = "Kết thúc ứng dụng";
            this.btkt.UseVisualStyleBackColor = false;
            // 
            // btnxds
            // 
            this.btnxds.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnxds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxds.Location = new System.Drawing.Point(434, 415);
            this.btnxds.Name = "btnxds";
            this.btnxds.Size = new System.Drawing.Size(168, 30);
            this.btnxds.TabIndex = 5;
            this.btnxds.Text = "xóa dãy số";
            this.btnxds.UseVisualStyleBackColor = false;
            this.btnxds.Click += new System.EventHandler(this.btnxds_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTang2.Location = new System.Drawing.Point(81, 19);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(276, 31);
            this.btnTang2.TabIndex = 0;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = false;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btncsd
            // 
            this.btncsd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btncsd.Location = new System.Drawing.Point(81, 56);
            this.btncsd.Name = "btncsd";
            this.btncsd.Size = new System.Drawing.Size(276, 28);
            this.btncsd.TabIndex = 0;
            this.btncsd.Text = "Chọn số chẵn đầu";
            this.btncsd.UseVisualStyleBackColor = false;
            this.btncsd.Click += new System.EventHandler(this.btncsd_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.Location = new System.Drawing.Point(81, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(276, 33);
            this.button6.TabIndex = 0;
            this.button6.Text = "Chọn số chẵn cuối";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btndc
            // 
            this.btndc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btndc.Location = new System.Drawing.Point(81, 129);
            this.btndc.Name = "btndc";
            this.btndc.Size = new System.Drawing.Size(276, 31);
            this.btndc.TabIndex = 0;
            this.btndc.Text = "Xóa phần tử đang chọn";
            this.btndc.UseVisualStyleBackColor = false;
            this.btndc.Click += new System.EventHandler(this.btndc_Click);
            // 
            // btnptd
            // 
            this.btnptd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnptd.Location = new System.Drawing.Point(81, 166);
            this.btnptd.Name = "btnptd";
            this.btnptd.Size = new System.Drawing.Size(276, 28);
            this.btnptd.TabIndex = 0;
            this.btnptd.Text = "Xóa phần tử đầu";
            this.btnptd.UseVisualStyleBackColor = false;
            this.btnptd.Click += new System.EventHandler(this.btnptd_Click);
            // 
            // btnptc
            // 
            this.btnptc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnptc.Location = new System.Drawing.Point(81, 200);
            this.btnptc.Name = "btnptc";
            this.btnptc.Size = new System.Drawing.Size(276, 29);
            this.btnptc.TabIndex = 0;
            this.btnptc.Text = "Xóa phần tử cuối";
            this.btnptc.UseVisualStyleBackColor = false;
            this.btnptc.Click += new System.EventHandler(this.btnptc_Click);
            // 
            // bai_5B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxds);
            this.Controls.Add(this.btkt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstDaySo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "bai_5B";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.TextBox txtnsn;
        private System.Windows.Forms.ListBox lstDaySo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btkt;
        private System.Windows.Forms.Button btnxds;
        private System.Windows.Forms.Button btnptc;
        private System.Windows.Forms.Button btnptd;
        private System.Windows.Forms.Button btndc;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btncsd;
        private System.Windows.Forms.Button btnTang2;
    }
}