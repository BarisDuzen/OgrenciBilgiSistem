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
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }

        private void Listele_Load(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
                var liste = db.Dersler.Select(d => new {
                    d.dersID,
                    d.dersAd
                }).ToList();

                dataGridView1.DataSource = liste;
                dataGridView1.Columns["dersID"].HeaderText = "Ders ID";
                dataGridView1.Columns["dersAd"].HeaderText = "Ders Adı";

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
