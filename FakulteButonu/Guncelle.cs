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

namespace OgrenciBilgiSistemi.FakulteButonu
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
                // Tüm fakülteleri çekiyoruz
                var liste = db.Fakulteler.ToList();

                comboBox1.DataSource = liste;
                comboBox1.DisplayMember = "fakulteAd"; 
                comboBox1.ValueMember = "fakulteID";   
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int seciliID = (int)comboBox1.SelectedValue;

            using (var db = new OkulContext())
            {
                
                var guncellenecek = db.Fakulteler.Find(seciliID);

                if (guncellenecek != null)
                {
                    
                    guncellenecek.fakulteAd = textBox1.Text;

                    
                    db.SaveChanges();

                    MessageBox.Show("Fakülte adı başarıyla güncellendi!");
                    this.Close();
                }
            }
        }
    }
}
