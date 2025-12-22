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

namespace OgrenciBilgiSistemi.Detaylıİslemler
{
    public partial class DersSorgula : Form
    {
        public DersSorgula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ogrNo = int.Parse(textBox1.Text);

            using (var db = new OkulContext())
            {
                var dersler = db.OgrenciDersler
                    .Where(od => od.ogrenciID == ogrNo)
                    .Select(od => new {
                        od.Ders.dersAd,
                        od.yil,
                        od.yariyil,
                        od.vize,
                        od.final
                    }).ToList();

                dataGridView1.DataSource = dersler;
            }
        }
    }
}
