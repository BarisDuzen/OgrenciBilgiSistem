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
    public partial class BolumForm : Form
    {
        public BolumForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sil frm = new Sil();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekle frm = new Ekle();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Goruntule frm = new Goruntule();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guncelle frm = new Guncelle();
            frm.Show();
        }

        private void BolumForm_Load(object sender, EventArgs e)
        {

        }
    }
}
