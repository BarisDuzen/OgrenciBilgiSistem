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
    public partial class Notİslemleri : Form
    {
        public Notİslemleri()
        {
            InitializeComponent();
        }

        private void Notİslemleri_Load(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
                var dersListesi = db.Dersler.ToList();

                comboBox1.DataSource = dersListesi;
                comboBox1.DisplayMember = "dersAd";
                comboBox1.ValueMember = "dersID";
                comboBox1.SelectedIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox2.SelectedItem == null) return;

            int seciliDersId = (int)comboBox1.SelectedValue;
            string yil = comboBox2.Text;
            string yariyil = comboBox3.Text;

            using (var db = new OkulContext())
            {
                var liste = db.OgrenciDersler
                    .Where(od => od.dersID == seciliDersId && od.yil == yil && od.yariyil == yariyil)
                    .Select(od => new {
                        od.ogrenciID,
                        Öğrenci = od.Ogrenci.ad + " " + od.Ogrenci.soyad,
                        Vize = od.vize,
                        Final = od.final
                    }).ToList();

                dataGridView1.DataSource = liste;
                dataGridView1.Columns["ogrenciID"].Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                NotEditorForm frm = new NotEditorForm();

                
                frm.GelenOgrId = (int)dataGridView1.Rows[e.RowIndex].Cells["ogrenciID"].Value;
                frm.GelenDersId = (int)comboBox1.SelectedValue;
                frm.GelenYil = comboBox2.Text;
                frm.GelenYariyil = comboBox3.Text;

                
                frm.ShowDialog();

                
                button1_Click(null, null);
            }
        }
    }
}
