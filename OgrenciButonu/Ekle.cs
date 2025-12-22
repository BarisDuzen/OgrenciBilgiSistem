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
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }

        private void Ekle_Load(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
                var bolumler = db.Bolumler.ToList();

                comboBox1.DataSource = bolumler;
                comboBox1.DisplayMember = "bolumAd"; 
                comboBox1.ValueMember = "bolumID"; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Lütfen ad ve soyad alanlarını doldurun!");
                return;
            }

            using (var db = new OkulContext())
            {
                var yeniOgrenci = new Ogrenci();

                yeniOgrenci.ad = textBox1.Text;
                yeniOgrenci.soyad = textBox2.Text;
                yeniOgrenci.bolumID = (int)comboBox1.SelectedValue;

                db.Ogrenciler.Add(yeniOgrenci);
                db.SaveChanges();

                MessageBox.Show($"{yeniOgrenci.ad} {yeniOgrenci.soyad} başarıyla kaydedildi!");

                this.Close();
            }
        }
    }
}
