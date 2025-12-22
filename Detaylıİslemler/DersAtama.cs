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

namespace OgrenciBilgiSistemi.Detaylıİslemler
{
    public partial class DersAtama : Form
    {
        public DersAtama()
        {
            InitializeComponent();
        }

        private void DersAtama_Load(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
                cmbOgrenciler.DataSource = db.Ogrenciler.Select(o => new {
                    o.ogrenciID,
                    AdSoyad = o.ad + " " + o.soyad
                }).ToList();
                cmbOgrenciler.DisplayMember = "AdSoyad";
                cmbOgrenciler.ValueMember = "ogrenciID";

                cmbDersler.DataSource = db.Dersler.ToList();
                cmbDersler.DisplayMember = "dersAd";
                cmbDersler.ValueMember = "dersID";

                cmbDersler.SelectedIndex = -1;
                cmbOgrenciler.SelectedIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbOgrenciler.SelectedValue == null || cmbDersler.SelectedValue == null ||
                cmbYariyil.SelectedItem == null || cmbYariyil.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm seçimleri yapınız!");
                return;
            }

            using (var db = new OkulContext())
            {
                int seciliOgrenciId = (int)cmbOgrenciler.SelectedValue;
                int seciliDersId = (int)cmbDersler.SelectedValue;
                string seciliYil = cmbYil.SelectedItem.ToString();
                string seciliYariyil = cmbYariyil.SelectedItem.ToString();

                bool varMi = db.OgrenciDersler.Any(od => od.ogrenciID == seciliOgrenciId &&
                                                          od.dersID == seciliDersId &&
                                                          od.yil == seciliYil &&
                                                          od.yariyil == seciliYariyil);
                if (varMi)
                {
                    MessageBox.Show("Bu öğrenci bu dersi bu dönem zaten alıyor!");
                    return;
                }
                var yeniAtama = new OgrenciDers
                {
                    ogrenciID = seciliOgrenciId,
                    dersID = seciliDersId,
                    yil = seciliYil,
                    yariyil = seciliYariyil,
                    vize = 0,
                    final = 0
                };
                db.OgrenciDersler.Add(yeniAtama);
                db.SaveChanges();

                MessageBox.Show("Ders atama işlemi başarıyla tamamlandı.");
            }
        }
    }
}
