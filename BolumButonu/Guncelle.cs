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

namespace OgrenciBilgiSistemi.BolumButonu
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
                
                comboBox1.DataSource = db.Bolumler.ToList();
                comboBox1.DisplayMember = "bolumAd";
                comboBox1.ValueMember = "bolumID";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;

            int seciliBolumID = (int)comboBox1.SelectedValue;

            using (var db = new OkulContext())
            {
                
                var guncellenecekBolum = db.Bolumler.Find(seciliBolumID);

                if (guncellenecekBolum != null)
                {
                  
                    guncellenecekBolum.bolumAd = textBox1.Text;

                    db.SaveChanges();
                    MessageBox.Show("Bölüm başarıyla güncellendi!");
                    this.Close();
                }
            }
        }
    }
}
