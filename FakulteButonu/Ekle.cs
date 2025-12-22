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
    public partial class Ekle : Form
    {
        OkulContext db = new OkulContext();
        public Ekle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
                
                var yeni = new Fakulte { fakulteAd = textBox1.Text };

              
                db.Fakulteler.Add(yeni);

               
                db.SaveChanges();

                MessageBox.Show("Yeni fakülte başarıyla eklendi!");
                this.Close(); 
            }
        }
    }
}
