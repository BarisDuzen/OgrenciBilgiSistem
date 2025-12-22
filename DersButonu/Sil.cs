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
                
                var dersListesi = db.Dersler.ToList();

            
                comboBox1.DataSource = dersListesi;

                
                comboBox1.DisplayMember = "dersAd";

                comboBox1.ValueMember = "dersID";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seciliID = (int)comboBox1.SelectedValue;

            using (var db = new OkulContext())
            {
            
                var silinecekDers = db.Dersler.Find(seciliID);

                if (silinecekDers != null)
                {
                 
                    DialogResult onay = MessageBox.Show($"{silinecekDers.dersAd} dersini silmek istediğinize emin misiniz?",
                                                        "Ders Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (onay == DialogResult.Yes)
                    {
                   
                        db.Dersler.Remove(silinecekDers);

                      
                        db.SaveChanges();

                        MessageBox.Show("Ders başarıyla silindi!");
                        this.Close(); 
                    }
                }
            }
        }
    }
}
