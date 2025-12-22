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
    public partial class Sil : Form
    {
        public Sil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;

            int seciliBolumID = (int)comboBox1.SelectedValue;

            using (var db = new OkulContext())
            {
                var silinecekBolum = db.Bolumler.Find(seciliBolumID);

                if (silinecekBolum != null)
                {

                    DialogResult onay = MessageBox.Show($"{silinecekBolum.bolumAd} bölümünü silmek istediğinize emin misiniz?",
                                                        "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (onay == DialogResult.Yes)
                    {
                
                        db.Bolumler.Remove(silinecekBolum);

                       
                        db.SaveChanges();

                        MessageBox.Show("Bölüm başarıyla silindi!");
                        this.Close();
                    }
                }
            }
        }

        private void Sil_Load(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {

                comboBox1.DataSource = db.Bolumler.ToList();
                comboBox1.DisplayMember = "bolumAd";
                comboBox1.ValueMember = "bolumID";
            }
        }
    }
}
