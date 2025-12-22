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
    public partial class Goruntule : Form
    {
        public Goruntule()
        {
            InitializeComponent();
        }

        private void Goruntule_Load(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
                var liste = db.Bolumler.Select(b => new {
                    b.bolumID,
                    b.bolumAd,
                    FakulteAdi = b.Fakulte.fakulteAd
                }).ToList();

                dataGridView1.DataSource = liste;

                dataGridView1.Columns["bolumID"].HeaderText = "ID";
                dataGridView1.Columns["bolumAd"].HeaderText = "Bölüm Adı";
                dataGridView1.Columns["FakulteAdi"].HeaderText = "Bağlı Olduğu Fakülte";

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
