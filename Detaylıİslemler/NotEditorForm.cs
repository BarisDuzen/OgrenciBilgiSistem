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
    public partial class NotEditorForm : Form
    {
        public NotEditorForm()
        {
            InitializeComponent();
        }
        public int GelenOgrId, GelenDersId;
        public string GelenYil, GelenYariyil;
        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new OkulContext())
            {
                var kayit = db.OgrenciDersler.FirstOrDefault(od =>
                    od.ogrenciID == GelenOgrId &&
                    od.dersID == GelenDersId &&
                    od.yil == GelenYil &&
                    od.yariyil == GelenYariyil);

                if (kayit != null)
                {
                    kayit.vize = int.Parse(textBox1.Text);
                    kayit.final = int.Parse(textBox2.Text);
                    db.SaveChanges();
                    MessageBox.Show("Notlar kaydedildi!");
                    this.Close(); 
                }
            }
        }
    }
}
