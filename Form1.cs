using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLAyer;
using LogicLayer;
using System.Data.SqlClient;

namespace LayeredProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PersList = LogicPersonel.LLPerosnelListesi();
            dataGridView1.DataSource = PersList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtad.Text;    
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Maas= short.Parse(txtmaas.Text);    
            ent.Görev= txtgörev.Text;
            LogicPersonel.LlPersonelEkle(ent);
            MessageBox.Show("Eklendi...");


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id=Convert.ToInt32(txtid.Text);
            LogicPersonel.LlPerosnelSil(ent.Id);
            MessageBox.Show("Silindi...");

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtid.Text);
            ent.Ad=txtad.Text;
            ent.Soyad= txtsoyad.Text;
            ent.Sehir= txtsehir.Text;
            ent.Maas = short.Parse(txtmaas.Text) ;
            ent.Görev=txtgörev.Text;
            LogicPersonel.LlPersonelGüncelle(ent);
            MessageBox.Show("Güncellendi...");

        }
    }
}
