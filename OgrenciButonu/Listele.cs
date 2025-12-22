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
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }

        private void Listele_Load(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
                var ogrenciListesi = db.Ogrenciler.Select(o => new
                {
                    OgrenciNumarasi = o.ogrenciID,
                    o.ad,
                    o.soyad,
                    Bolum = o.Bolum.bolumAd
                }).ToList();

                dataGridView1.DataSource = ogrenciListesi;

                dataGridView1.Columns["OgrenciNumarasi"].HeaderText = "Öğrenci Numarası";
                dataGridView1.Columns["ad"].HeaderText = "Ad";
                dataGridView1.Columns["soyad"].HeaderText = "Soyad";
                dataGridView1.Columns["Bolum"].HeaderText = "Bölümü";

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
