namespace WindowsFormsApplication1
{
    partial class frmGiaHePT
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
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntThuchien = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(231, 336);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(175, 36);
            this.bntThoat.TabIndex = 6;
            this.bntThoat.Text = "thoat";
            this.bntThoat.UseVisualStyleBackColor = true;
            // 
            // bntThuchien
            // 
            this.bntThuchien.Location = new System.Drawing.Point(237, 218);
            this.bntThuchien.Name = "bntThuchien";
            this.bntThuchien.Size = new System.Drawing.Size(179, 37);
            this.bntThuchien.TabIndex = 4;
            this.bntThuchien.Text = "giai";
            this.bntThuchien.UseVisualStyleBackColor = true;
            this.bntThuchien.Click += new System.EventHandler(this.bntThuchien_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(227, 287);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(186, 20);
            this.txtKQ.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ket qua";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(231, 182);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(199, 20);
            this.txtc.TabIndex = 3;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(231, 140);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(199, 20);
            this.txtb.TabIndex = 2;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(231, 99);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(199, 20);
            this.txta.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "HE SO C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "HE SO B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "HE SO A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "BÀI TẬP SỐ 1";
            // 
            // frmGiaHePT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 407);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntThuchien);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGiaHePT";
            this.Text = "frmGiaHePT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntThuchien;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}