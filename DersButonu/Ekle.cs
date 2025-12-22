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
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
                Ders yeniDers = new Ders();
                yeniDers.dersAd = textBox1.Text;

                db.Dersler.Add(yeniDers);
                db.SaveChanges();

                MessageBox.Show("Ders başarıyla eklendi!");
                this.Close();
            }
        }
    }
}
