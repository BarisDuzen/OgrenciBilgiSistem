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

namespace OgrenciBilgiSistemi.OgrenciButonu
{
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }

        private void Guncelle_Load(object sender, EventArgs e)
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

               
                comboBox2.DataSource = db.Bolumler.ToList();
                comboBox2.DisplayMember = "bolumAd";
                comboBox2.ValueMember = "bolumID";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;

            int seciliID = (int)comboBox1.SelectedValue;

            using (var db = new OkulContext())
            {
                var guncellenecek = db.Ogrenciler.Find(seciliID);
                if (guncellenecek != null)
                {
                    guncellenecek.ad = textBox1.Text;
                    guncellenecek.soyad = textBox2.Text;
                    guncellenecek.bolumID = (int)comboBox2.SelectedValue;

                    db.SaveChanges();
                    MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi!");
                    this.Close();
                }
            }
        }
    }
}
