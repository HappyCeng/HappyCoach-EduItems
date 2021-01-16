
namespace AddListApp
{
    partial class SoundList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSarkiGirdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstBoxSarkiListesi = new System.Windows.Forms.ListBox();
            this.txtSanatciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSarkiGirdi
            // 
            this.txtSarkiGirdi.Location = new System.Drawing.Point(12, 12);
            this.txtSarkiGirdi.Name = "txtSarkiGirdi";
            this.txtSarkiGirdi.Size = new System.Drawing.Size(207, 23);
            this.txtSarkiGirdi.TabIndex = 0;
            this.txtSarkiGirdi.Text = "Lütfen Şarkı Adı Giriniz";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 70);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(207, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstBoxSarkiListesi
            // 
            this.lstBoxSarkiListesi.FormattingEnabled = true;
            this.lstBoxSarkiListesi.ItemHeight = 15;
            this.lstBoxSarkiListesi.Location = new System.Drawing.Point(13, 101);
            this.lstBoxSarkiListesi.Name = "lstBoxSarkiListesi";
            this.lstBoxSarkiListesi.Size = new System.Drawing.Size(207, 334);
            this.lstBoxSarkiListesi.TabIndex = 2;
            this.lstBoxSarkiListesi.Sorted = true;
            // 
            // txtSanatciAdi
            // 
            this.txtSanatciAdi.Location = new System.Drawing.Point(12, 41);
            this.txtSanatciAdi.Name = "txtSanatciAdi";
            this.txtSanatciAdi.Size = new System.Drawing.Size(207, 23);
            this.txtSanatciAdi.TabIndex = 3;
            this.txtSanatciAdi.Text = "Lütfen Sanatçı Adını Giriniz";
            // 
            // SoundList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 450);
            this.Controls.Add(this.txtSanatciAdi);
            this.Controls.Add(this.lstBoxSarkiListesi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSarkiGirdi);
            this.Name = "SoundList";
            this.Text = "Müzik Listesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtSarkiGirdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstBoxSarkiListesi;
        public System.Windows.Forms.TextBox txtSanatciAdi;
    }
}

