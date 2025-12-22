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
    public partial class Listeleme : Form
    {
        public Listeleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KisiSayisi frm=new KisiSayisi();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DersSorgula frm=new DersSorgula();
            frm.Show();
        }
    }
}
