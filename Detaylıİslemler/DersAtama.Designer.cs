namespace OgrenciBilgiSistemi.Detaylıİslemler
{
    partial class DersAtama
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
            this.cmbOgrenciler = new System.Windows.Forms.ComboBox();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYariyil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDersler = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(143, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenciyi Seçiniz...";
            // 
            // cmbOgrenciler
            // 
            this.cmbOgrenciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbOgrenciler.FormattingEnabled = true;
            this.cmbOgrenciler.Location = new System.Drawing.Point(400, 156);
            this.cmbOgrenciler.Name = "cmbOgrenciler";
            this.cmbOgrenciler.Size = new System.Drawing.Size(269, 37);
            this.cmbOgrenciler.TabIndex = 1;
            // 
            // cmbYil
            // 
            this.cmbYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024",
            "2024-2025",
            "2025-2026",
            "2027-2028"});
            this.cmbYil.Location = new System.Drawing.Point(400, 244);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(269, 37);
            this.cmbYil.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(180, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yıl Seçiniz...";
            // 
            // cmbYariyil
            // 
            this.cmbYariyil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbYariyil.FormattingEnabled = true;
            this.cmbYariyil.Items.AddRange(new object[] {
            "Güz",
            "Bahar"});
            this.cmbYariyil.Location = new System.Drawing.Point(400, 330);
            this.cmbYariyil.Name = "cmbYariyil";
            this.cmbYariyil.Size = new System.Drawing.Size(269, 37);
            this.cmbYariyil.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(143, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yarıyıl Seçiniz...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(116, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Atamak istediğiniz ders:";
            // 
            // cmbDersler
            // 
            this.cmbDersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Items.AddRange(new object[] {
            "Güz",
            "Bahar"});
            this.cmbDersler.Location = new System.Drawing.Point(400, 475);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(269, 37);
            this.cmbDersler.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(314, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dersi ata";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DersAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 866);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbDersler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbYariyil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbYil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOgrenciler);
            this.Controls.Add(this.label1);
            this.Name = "DersAtama";
            this.Text = "DersAtama";
            this.Load += new System.EventHandler(this.DersAtama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOgrenciler;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbYariyil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDersler;
        private System.Windows.Forms.Button button1;
    }
}