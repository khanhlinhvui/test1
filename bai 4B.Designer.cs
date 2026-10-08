namespace bai4
{
    partial class bai_4B
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.rdoln = new System.Windows.Forms.RadioButton();
            this.rdonn = new System.Windows.Forms.RadioButton();
            this.btntim = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.rdonn);
            this.groupBox2.Controls.Add(this.rdoln);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(527, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.btnthoat);
            this.groupBox3.Controls.Add(this.btntim);
            this.groupBox3.Controls.Add(this.txtkq);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 167);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số nguyên a :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số nguyên b :";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(154, 32);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(214, 27);
            this.txta.TabIndex = 2;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(157, 97);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(211, 27);
            this.txtb.TabIndex = 3;
            // 
            // txtkq
            // 
            this.txtkq.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtkq.Location = new System.Drawing.Point(226, 71);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(177, 27);
            this.txtkq.TabIndex = 0;
            // 
            // rdoln
            // 
            this.rdoln.AutoSize = true;
            this.rdoln.Location = new System.Drawing.Point(66, 57);
            this.rdoln.Name = "rdoln";
            this.rdoln.Size = new System.Drawing.Size(87, 24);
            this.rdoln.TabIndex = 0;
            this.rdoln.TabStop = true;
            this.rdoln.Text = "USCLN";
            this.rdoln.UseVisualStyleBackColor = true;
            this.rdoln.CheckedChanged += new System.EventHandler(this.rdoln_CheckedChanged);
            // 
            // rdonn
            // 
            this.rdonn.AutoSize = true;
            this.rdonn.Location = new System.Drawing.Point(66, 126);
            this.rdonn.Name = "rdonn";
            this.rdonn.Size = new System.Drawing.Size(89, 24);
            this.rdonn.TabIndex = 1;
            this.rdonn.TabStop = true;
            this.rdonn.Text = "BSCNN";
            this.rdonn.UseVisualStyleBackColor = true;
            // 
            // btntim
            // 
            this.btntim.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btntim.Location = new System.Drawing.Point(502, 45);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 31);
            this.btntim.TabIndex = 1;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = false;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnthoat.Location = new System.Drawing.Point(502, 101);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 30);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // bai_4B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "bai_4B";
            this.Text = "Tìm UCLN vad BSCNN của số nguyên a và b";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdonn;
        private System.Windows.Forms.RadioButton rdoln;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txtkq;
    }
}