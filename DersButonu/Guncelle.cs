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

namespace OgrenciBilgiSistemi.DersButonu
{
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seciliID = (int)comboBox1.SelectedValue;

            using (var db = new OkulContext())
            {
               
                var guncellenecekDers = db.Dersler.Find(seciliID);

                if (guncellenecekDers != null)
                {
                    guncellenecekDers.dersAd = textBox1.Text;

                    db.SaveChanges(); 
                    MessageBox.Show("Ders başarıyla güncellendi!");
                    this.Close();
                }
            }
        }

        private void Guncelle_Load(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
                
                var dersListesi = db.Dersler.ToList();

               
                comboBox1.DataSource = dersListesi;

             
                comboBox1.DisplayMember = "dersAd";

              
                comboBox1.ValueMember = "dersID";
            }
        }
    }
}
