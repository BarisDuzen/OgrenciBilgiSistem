using OgrenciBilgiSistemi.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OgrenciBilgiSistemi.OgrenciButonu
{
    public partial class Sil : Form
    {
        public Sil()
        {
            InitializeComponent();
        }

        private void Sil_Load(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
               
                var ogrenciListesi = db.Ogrenciler.Select(o => new
                {
                    o.ogrenciID,
                    AdSoyad = o.ad + " " + o.soyad 
                }).ToList();

                comboBox1.DataSource = ogrenciListesi;

                
                comboBox1.DisplayMember = "AdSoyad";
                comboBox1.ValueMember = "ogrenciID";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;

            int seciliID = (int)comboBox1.SelectedValue;

            using (var db = new OkulContext())
            {
                var silinecekOgrenci = db.Ogrenciler.Find(seciliID);

                if (silinecekOgrenci != null)
                {
                    DialogResult onay = MessageBox.Show($"{silinecekOgrenci.ad} {silinecekOgrenci.soyad} isimli öğrenciyi ve tüm kayıtlarını silmek istediğinize emin misiniz?",
                                                        "Kayıt Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (onay == DialogResult.Yes)
                    {
                        try
                        {
                            db.Ogrenciler.Remove(silinecekOgrenci);
                            db.SaveChanges();

                            MessageBox.Show("Öğrenci kaydı başarıyla silindi.");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bu öğrenciyi silemezsiniz! Önce öğrenciye atanmış olan dersleri silmeniz gerekmektedir.\nHata: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
