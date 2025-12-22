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
             
                var liste = db.Fakulteler.Select(f => new {
                    f.fakulteID,
                    f.fakulteAd
                }).ToList();

                dataGridView1.DataSource = liste;

                
                dataGridView1.Columns["fakulteID"].HeaderText = "No";
                dataGridView1.Columns["fakulteAd"].HeaderText = "Fakülte İsmi";
            }
        }
    }
}
