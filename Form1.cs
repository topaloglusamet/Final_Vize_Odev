using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalVizeÖdevUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float finalyüzde, vizeyüzde, ödevyüzde;
        float final, vize, ödev;

        private void otobtn_Click(object sender, EventArgs e)
        {
            finalorttxtbox.Text = "60";
            vizeorttxtbox.Text = "40";
        }

        

        float finalsonuç, vizesonuç, ödevsonuç;

     
      public static float sonuç;

       


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            gösterbtn.Visible = false;
            notugiriniztxt.Visible = false;

            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
      

            if (ödevorttxtbox.Text == "" || ödevtxtbox.Text == "")
            {
                ödevorttxtbox.Text = "0";
                ödevtxtbox.Text = "0";
            }
            if (vizeorttxtbox.Text == "" || vizetxtbox.Text == "")
            {
                vizeorttxtbox.Text = "0";
                vizetxtbox.Text = "0";
            }
            if (finalorttxtbox.Text == "" || finaltxtbox.Text == "")
            {
                finalorttxtbox.Text = "0";
                finaltxtbox.Text = "0";
            }
            finalorttxt.Text =  "Final Etki Oranınız: " +  finalorttxtbox.Text;
            vizeorttxt.Text = "Vize Etki Oranınız: " +  vizeorttxtbox.Text;
            ödevorttxt.Text = "Ödev Etki Oranınız: " + ödevorttxtbox.Text;

            finalyüzde = Convert.ToInt32(finalorttxtbox.Text);
            vizeyüzde = Convert.ToInt32(vizeorttxtbox.Text);
            ödevyüzde = Convert.ToInt32(ödevorttxtbox.Text);
            final = Convert.ToInt32(finaltxtbox.Text);
            vize = Convert.ToInt32(vizetxtbox.Text);
            ödev = Convert.ToInt32(ödevtxtbox.Text);

            finalsonuç = finalyüzde * final / 100;
            vizesonuç = vizeyüzde * vize / 100;
            ödevsonuç = ödevyüzde * ödev / 100;

            sonuç = finalsonuç + vizesonuç + ödevsonuç;

            finalvizeödevtxt.Text = "Final Ortalamanız: " + finalsonuç + " Vize Ortalamanız: " + vizesonuç + " Ödev Ortalamanız: " + ödevsonuç;
            sonuçtxt.Text = "Ortalamanız: " + sonuç;


         
            gösterbtn.Visible = false;
            derskayıtbtn.Visible = true;
            notugiriniztxt.Visible = false;
            dersigiriniztxt.Visible = true;

            if (kaçderstxtbox.Text == derseşittxt.Text)
            {
                gösterbtn.Visible = false;
                derskayıtbtn.Visible = false;
                notugiriniztxt.Visible = false;
                dersigiriniztxt.Visible = false;
            }

            sayaç++;
            dersigiriniztxt.Text = sayaç + ". Dersi Giriniz";
            notugiriniztxt.Text = sayaç + ". Notu Giriniz";

            listBox1.Items.Add(dersler + "  " + sonuç);
            listBox2.Items.Add(sonuç);

            MessageBox.Show("Kayıt Ekleme İşleminiz Gerçekleşti.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            temizle();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        int ders;

        string dersler;

       

        int sayaç = 1;

   

        private void kaçdersvarbtn_Click(object sender, EventArgs e)
        {
            ders = Convert.ToInt32(kaçderstxtbox.Text);
            kaçdersvartxt.Text = ders.ToString() + " Dersiniz var";
        }

        private void listboxtopla_Click(object sender, EventArgs e)
        {

        }

       
        private void derskayıtbtn_Click(object sender, EventArgs e)
        {
            if (kaçderstxtbox.Text == "")
            {
                MessageBox.Show("Öncelikle Kaç Dersiniz Olduğunu Giriniz", "Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                gösterbtn.Visible = true;
                derskayıtbtn.Visible = false;
                notugiriniztxt.Visible = true;
                dersigiriniztxt.Visible = false;

                derseşittxt.Text = sayaç.ToString();

                if (derskayıttxtbox.Text == "")
                {
                    derskayıttxtbox.Text = "--";
                }

                dersler = Convert.ToString(derskayıttxtbox.Text);
            }
          

           
        }

        private void harfaralıkbtn_Click(object sender, EventArgs e)
        {
            HarfAralık deneme = new HarfAralık();
            deneme.Show();
        }

        private void temizle ()
        {
            finalorttxtbox.Clear();
            vizeorttxtbox.Clear();
            ödevorttxtbox.Clear();

            finaltxtbox.Clear();
            vizetxtbox.Clear();
            ödevtxtbox.Clear();
            derskayıttxtbox.Clear();
        }


        string dersgüncelle;

        private void güncellebtn_Click(object sender, EventArgs e)
        {
            dersgüncelle = Convert.ToString(güncelletxtbox.Text);

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Öncelikle Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.Items.Add(dersgüncelle + "  " + sonuç);
            }

        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Öncelikle Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void toplabtn_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            double ortalama;

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox2.Items[i]);
            }

            ortalama = toplam / listBox2.Items.Count;

            listboxtopla.Text = "Toplam: " + toplam + " Ortalama: " + ortalama;
            listboxortalama.Text = "Toplam Sayı: " + listBox2.Items.Count.ToString();
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

        }

    }
}
