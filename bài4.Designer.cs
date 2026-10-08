namespace bai4
{
    partial class Form1
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
            this.lblSoTien = new System.Windows.Forms.Label();
            this.btndongy = new System.Windows.Forms.Button();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.txtcsd = new System.Windows.Forms.TextBox();
            this.txtcsc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉ số đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "TÍNH TIỀN ĐIỆN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chỉ số cuối";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.Location = new System.Drawing.Point(92, 309);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(207, 29);
            this.lblSoTien.TabIndex = 0;
            this.lblSoTien.Text = "Số tiền phải đóng:";
            // 
            // btndongy
            // 
            this.btndongy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndongy.Location = new System.Drawing.Point(197, 374);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(103, 39);
            this.btndongy.TabIndex = 1;
            this.btndongy.Text = "Đồng Ý";
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // btnlamlai
            // 
            this.btnlamlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlamlai.Location = new System.Drawing.Point(370, 374);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(123, 39);
            this.btnlamlai.TabIndex = 1;
            this.btnlamlai.Text = "Làm Lại";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // txtcsd
            // 
            this.txtcsd.Location = new System.Drawing.Point(277, 167);
            this.txtcsd.Name = "txtcsd";
            this.txtcsd.Size = new System.Drawing.Size(216, 22);
            this.txtcsd.TabIndex = 2;
            // 
            // txtcsc
            // 
            this.txtcsc.Location = new System.Drawing.Point(277, 235);
            this.txtcsc.Name = "txtcsc";
            this.txtcsc.Size = new System.Drawing.Size(216, 22);
            this.txtcsc.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcsc);
            this.Controls.Add(this.txtcsd);
            this.Controls.Add(this.btnlamlai);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính tiền điện";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Button btndongy;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.TextBox txtcsd;
        private System.Windows.Forms.TextBox txtcsc;
    }
}

