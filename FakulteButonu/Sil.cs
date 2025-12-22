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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OgrenciBilgiSistemi.FakulteButonu
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
                
                var liste = db.Fakulteler.ToList();

                comboBox1.DataSource = liste;
                comboBox1.DisplayMember = "fakulteAd"; 
                comboBox1.ValueMember = "fakulteID";   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int seciliID = (int)comboBox1.SelectedValue;

            using (var db = new OkulContext())
            {
                
                var silinecek = db.Fakulteler.Find(seciliID);

                if (silinecek != null)
                {
                    
                    DialogResult sonuc = MessageBox.Show($"{silinecek.fakulteAd} isimli fakülteyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                    if (sonuc == DialogResult.Yes)
                    {
                       
                        db.Fakulteler.Remove(silinecek);

                       
                        db.SaveChanges();

                        MessageBox.Show("Fakülte başarıyla silindi!");
                        this.Close();
                    }
                }
            }
        }
    }
}
