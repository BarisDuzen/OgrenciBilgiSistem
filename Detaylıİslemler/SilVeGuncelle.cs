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
    public partial class SilVeGuncelle : Form
    {
        public SilVeGuncelle()
        {
            InitializeComponent();
        }

        int seciliDersID = -1;
        string seciliYil = "";
        string seciliDonem = "";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                
                seciliDersID = (int)dataGridView1.Rows[e.RowIndex].Cells["dersID"].Value;
                seciliYil = dataGridView1.Rows[e.RowIndex].Cells["yil"].Value.ToString();
                seciliDonem = dataGridView1.Rows[e.RowIndex].Cells["yariyil"].Value.ToString();

                
                comboBox1.Text = seciliYil;
                comboBox2.Text = seciliDonem;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue == null)
            {
                MessageBox.Show("Lütfen önce bir öğrenci seçiniz!");
                return;
            }

            
            int seciliOgrId = (int)comboBox3.SelectedValue;
            string yil = comboBox1.Text;
            string yariyil = comboBox2.Text;

            using (var db = new OkulContext())
            {
                var dersler = db.OgrenciDersler
                    .Where(od => od.ogrenciID == seciliOgrId && od.yil == yil && od.yariyil == yariyil)
                    .Select(od => new
                    {
                        od.dersID,
                        DersAdi = od.Ders.dersAd,
                        Yil = od.yil,
                        Yariyil = od.yariyil
                    }).ToList();

                dataGridView1.DataSource = dersler;
            }
        }

        private void SilVeGuncelle_Load(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
                
                var ogrenciler = db.Ogrenciler.Select(o => new
                {
                    o.ogrenciID,
                    AdSoyad = o.ad + " " + o.soyad
                }).ToList();

               
                comboBox3.DataSource = ogrenciler;
                comboBox3.DisplayMember = "AdSoyad"; 
                comboBox3.ValueMember = "ogrenciID"; 

              
                comboBox3.SelectedIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
               
                if (comboBox3.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen önce bir öğrenci seçiniz!");
                    return;
                }
                if (seciliDersID == -1)
                {
                    MessageBox.Show("Lütfen tablodan silmek istediğiniz dersi seçiniz!");
                    return;
                }

                int ogrID = (int)comboBox3.SelectedValue;

                using (var db = new OkulContext())
                {
                    
                    var silinecekKayit = db.OgrenciDersler.FirstOrDefault(od =>
                        od.ogrenciID == ogrID &&
                        od.dersID == seciliDersID &&
                        od.yil == seciliYil &&
                        od.yariyil == seciliDonem);

                    if (silinecekKayit != null)
                    {
                        var onay = MessageBox.Show("Bu ders atamasını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (onay == DialogResult.Yes)
                        {
                            db.OgrenciDersler.Remove(silinecekKayit);
                            db.SaveChanges();
                            MessageBox.Show("Ders ataması başarıyla silindi.");

                            
                            button1_Click(null, null);
                            seciliDersID = -1; 
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (comboBox3.SelectedValue == null || seciliDersID == -1)
            {
                MessageBox.Show("Lütfen bir öğrenci seçin ve tablodan güncellenecek dersi işaretleyin!");
                return;
            }

            int ogrID = (int)comboBox3.SelectedValue;

            using (var db = new OkulContext())
            {
                
                var guncellenecekKayit = db.OgrenciDersler.FirstOrDefault(od =>
                    od.ogrenciID == ogrID &&
                    od.dersID == seciliDersID &&
                    od.yil == seciliYil &&
                    od.yariyil == seciliDonem);

                if (guncellenecekKayit != null)
                {
                
                    guncellenecekKayit.yil = comboBox1.Text;
                    guncellenecekKayit.yariyil = comboBox2.Text;

                    db.SaveChanges();
                    MessageBox.Show("Dersin dönem bilgileri başarıyla güncellendi.");

                    
                    button1_Click(null, null);
                }
            }
        }
    }
    }
