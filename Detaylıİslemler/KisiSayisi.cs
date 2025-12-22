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
    public partial class KisiSayisi : Form
    {
        public KisiSayisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenYil = comboBox1.Text;
            string secilenDonem = comboBox2.Text;

            using (var db = new OkulContext())
            {
                var istatistik = db.OgrenciDersler
                    .Where(od => od.yil == secilenYil && od.yariyil == secilenDonem)
                    .GroupBy(od => od.Ders.dersAd) 
                    .Select(g => new {
                        DersAdi = g.Key,
                        OgrenciSayisi = g.Count()
                    }).ToList();

                dataGridView1.DataSource = istatistik;
            }
        }
    }
}
