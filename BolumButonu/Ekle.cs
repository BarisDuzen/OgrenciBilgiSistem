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
               
                var fakulteler = db.Fakulteler.ToList();
                comboBox1.DataSource = fakulteler;
                comboBox1.DisplayMember = "fakulteAd"; 
                comboBox1.ValueMember = "fakulteID"; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
                var yeniBolum = new Bolum();
                yeniBolum.bolumAd = textBox1.Text;
                yeniBolum.fakulteID = (int)comboBox1.SelectedValue;

                db.Bolumler.Add(yeniBolum);
                db.SaveChanges();

                MessageBox.Show("Bölüm başarıyla eklendi!");
                this.Close();
            }
        }
    }
}
