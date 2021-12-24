
namespace dogumTarihi
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
            this.lblDogumTarihiniz = new System.Windows.Forms.Label();
            this.dtpDogumGunu = new System.Windows.Forms.DateTimePicker();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblYasiniz = new System.Windows.Forms.Label();
            this.lblBurcunuz = new System.Windows.Forms.Label();
            this.lblYasadiginizGun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDogumTarihiniz
            // 
            this.lblDogumTarihiniz.AutoSize = true;
            this.lblDogumTarihiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihiniz.Location = new System.Drawing.Point(83, 9);
            this.lblDogumTarihiniz.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDogumTarihiniz.Name = "lblDogumTarihiniz";
            this.lblDogumTarihiniz.Size = new System.Drawing.Size(204, 29);
            this.lblDogumTarihiniz.TabIndex = 0;
            this.lblDogumTarihiniz.Text = "Doğum Tarihiniz";
            // 
            // dtpDogumGunu
            // 
            this.dtpDogumGunu.Location = new System.Drawing.Point(48, 41);
            this.dtpDogumGunu.Name = "dtpDogumGunu";
            this.dtpDogumGunu.Size = new System.Drawing.Size(260, 26);
            this.dtpDogumGunu.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(100, 82);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(146, 38);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yaşınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yaşadığınız Gün:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Burcunuz:";
            // 
            // lblYasiniz
            // 
            this.lblYasiniz.Location = new System.Drawing.Point(167, 168);
            this.lblYasiniz.Name = "lblYasiniz";
            this.lblYasiniz.Size = new System.Drawing.Size(110, 20);
            this.lblYasiniz.TabIndex = 3;
            // 
            // lblBurcunuz
            // 
            this.lblBurcunuz.Location = new System.Drawing.Point(167, 253);
            this.lblBurcunuz.Name = "lblBurcunuz";
            this.lblBurcunuz.Size = new System.Drawing.Size(110, 20);
            this.lblBurcunuz.TabIndex = 3;
            // 
            // lblYasadiginizGun
            // 
            this.lblYasadiginizGun.Location = new System.Drawing.Point(167, 209);
            this.lblYasadiginizGun.Name = "lblYasadiginizGun";
            this.lblYasadiginizGun.Size = new System.Drawing.Size(110, 20);
            this.lblYasadiginizGun.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(356, 301);
            this.Controls.Add(this.lblBurcunuz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblYasiniz);
            this.Controls.Add(this.lblYasadiginizGun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dtpDogumGunu);
            this.Controls.Add(this.lblDogumTarihiniz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Burç,Yaş,Gün Hesapla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDogumTarihiniz;
        private System.Windows.Forms.DateTimePicker dtpDogumGunu;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblYasiniz;
        private System.Windows.Forms.Label lblBurcunuz;
        private System.Windows.Forms.Label lblYasadiginizGun;
    }
}

