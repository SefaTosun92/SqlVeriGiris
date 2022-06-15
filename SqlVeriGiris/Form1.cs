using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlVeriGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6BEODCN;Initial Catalog=Kayitlar;Integrated Security=True");

        public void VerileriGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Gelenler",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["Adsoyad"].ToString();
                ekle.SubItems.Add(oku["Firma"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Semt"].ToString());
                ekle.SubItems.Add(oku["id"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }

        private void VerileriKaydet()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Gelenler (Adsoyad,Firma,Telefon,Semt,id) Values ('"+ textBoxAdSoyad.Text.ToString() +"','"+textBoxFirma.Text.ToString()+"','"+textBoxTelefon.Text.ToString()+"','"+comboBoxSemt.Text.ToString()+"','"+textBoxid.Text.ToString()+"')", baglanti); 
            

            komut.ExecuteNonQuery();
            baglanti.Close();

            

        }

        int id = 0; 
        private void VerileriSil()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Gelenler where id = ("+id+")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            listView1.Items.Clear();
            TextBoxlariTemizle();
            VerileriGetir();

        }
        private void VerileriGuncelle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Gelenler set id ='" + textBoxid.Text.ToString() + "',Adsoyad='"+textBoxAdSoyad.Text.ToString()+"',Firma='"+textBoxFirma.Text.ToString()+"',Telefon='"+textBoxTelefon.Text.ToString()+"',Semt='"+comboBoxSemt.Text.ToString()+"' where id =" +id+ "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void TextBoxlariTemizle()
        {
            textBoxAdSoyad.Clear();
            textBoxFirma.Clear();
            textBoxTelefon.Clear();
            comboBoxSemt.SelectedIndex = -1;
            textBoxid.Clear();
        }

        private void buttonVerileriGetir_Click(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void buttonKayıt_Click(object sender, EventArgs e)
        {
            VerileriKaydet();
            TextBoxlariTemizle();
            listView1.Items.Clear();
            VerileriGetir();
        }

        

        private void buttonSil_Click(object sender, EventArgs e)
        {
            VerileriSil();
            TextBoxlariTemizle();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text);
            textBoxid.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBoxAdSoyad.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBoxFirma.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxTelefon.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBoxSemt.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            VerileriGuncelle();
            TextBoxlariTemizle();
            listView1.Items.Clear();
            VerileriGetir();
        }

        
    }
}
