using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi.Detaylıİslemler
{
    public partial class DetayForm : Form
    {
        public DetayForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DersAtama frm=new DersAtama();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listeleme frm=new Listeleme();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SilVeGuncelle frm= new SilVeGuncelle();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Notİslemleri frm = new Notİslemleri();
            frm.Show();
        }

        private void DetayForm_Load(object sender, EventArgs e)
        {

        }
    }
}
