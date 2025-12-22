using OgrenciBilgiSistemi.BolumButonu;
using OgrenciBilgiSistemi.DersButonu;
using OgrenciBilgiSistemi.Detaylıİslemler;
using OgrenciBilgiSistemi.OgrenciButonu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FakulteForm frm = new FakulteForm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BolumForm frm = new BolumForm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DersForm frm = new DersForm();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrenciForm frm= new OgrenciForm();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetayForm frm = new DetayForm();
            frm.Show();
        }
    }
}
