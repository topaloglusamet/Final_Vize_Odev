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
    public partial class HarfAralık : Form
    {
        public HarfAralık()
        {
            InitializeComponent();
        }

        float sonuç = Form1.sonuç;

        private void HarfAralık_Load(object sender, EventArgs e)
        {

            sonuçlbl.Text = sonuç.ToString();
        }



     

        private void otoyerleştirbtn_Click(object sender, EventArgs e)
        {
            aabaş.Text = "90"; aabit.Text = "100";
            babaş.Text = "85"; babit.Text = "89";
            bbbaş.Text = "80"; bbbit.Text = "84";
            cbbaş.Text = "75"; cbbit.Text = "79";
            ccbaş.Text = "65"; ccbit.Text = "74";
            dcbaş.Text = "58"; dcbit.Text = "64";
            ddbaş.Text = "50"; ddbit.Text = "57";
            fdbaş.Text = "40"; fdbit.Text = "49";
            ffbaş.Text = "39"; 

        }

        float aa, aa2;
        float ba, ba2;
        float bb, bb2;
        float cb, cb2;
        float cc, cc2;
        float dc, dc2;
        float dd, dd2;
        float fd, fd2;

     
        float ff;


        float kontrol;
        float harfnotsonuç;

        float kredi;

        float dersnotsonuç;
        float toplamnotsonuç;


        private void sonuçgösterbtn_Click(object sender, EventArgs e)
        {
            sonuç = Convert.ToInt32(sonuçtxtbox.Text);

            aa = Convert.ToInt32(aabaş.Text);
            aa2 = Convert.ToInt32(aabit.Text);
            ba = Convert.ToInt32(babaş.Text);
            ba2 = Convert.ToInt32(babit.Text);
            bb = Convert.ToInt32(bbbaş.Text);
            bb2 = Convert.ToInt32(bbbit.Text);
            cc = Convert.ToInt32(ccbaş.Text);
            cc2 = Convert.ToInt32(ccbit.Text);
            cb = Convert.ToInt32(cbbaş.Text);
            cb2 = Convert.ToInt32(cbbit.Text);
            dc = Convert.ToInt32(dcbaş.Text);
            dc2 = Convert.ToInt32(dcbit.Text);
            dd = Convert.ToInt32(ddbaş.Text);
            dd2 = Convert.ToInt32(ddbit.Text);
            fd = Convert.ToInt32(fdbaş.Text);
            fd2 = Convert.ToInt32(fdbit.Text);
            ff = Convert.ToInt32(ffbaş.Text);

            if (sonuç >= aa && sonuç <= aa2) { kontrol = 1; }
            if (sonuç >= ba && sonuç <= ba2) { kontrol = 2; }
            if (sonuç >= bb && sonuç <= bb2) { kontrol = 3; }
            if (sonuç >= cb && sonuç <= cb2) { kontrol = 4; }
            if (sonuç >= cc && sonuç <= cc2) { kontrol = 5; }
            if (sonuç >= dc && sonuç <= dc2) { kontrol = 6; }
            if (sonuç >= dd && sonuç <= dd2) { kontrol = 7; }
            if (sonuç >= fd && sonuç <= fd2) { kontrol = 8; }
            if (sonuç <= ff) { kontrol = 9; }

            if (kontrol == 1) { harfnotsonuç = 4.00f; harfnottxt.Text = "Harf Notunuz: AA"; }
            if (kontrol == 2) { harfnotsonuç = 3.50f; harfnottxt.Text = "Harf Notunuz: BA"; }
            if (kontrol == 3) { harfnotsonuç = 3.00f; harfnottxt.Text = "Harf Notunuz: BB"; }
            if (kontrol == 4) { harfnotsonuç = 2.50f; harfnottxt.Text = "Harf Notunuz: CB"; }
            if (kontrol == 5) { harfnotsonuç = 2.00f; harfnottxt.Text = "Harf Notunuz: CC"; }
            if (kontrol == 6) { harfnotsonuç = 1.50f; harfnottxt.Text = "Harf Notunuz: DC"; }
            if (kontrol == 7) { harfnotsonuç = 1.00f; harfnottxt.Text = "Harf Notunuz: DD"; }
            if (kontrol == 8) { harfnotsonuç = 0.50f; harfnottxt.Text = "Harf Notunuz: FD"; }
            if (kontrol == 9) { harfnotsonuç = 0.0f; harfnottxt.Text = "Harf Notunuz: FF"; }


            harfnotkarşılıkgelen.Text = "Harf Not Aralığında Notunuza " + sonuç + " Karşılık Gelen Not: " + harfnotsonuç;

            kredi = Convert.ToInt32(derskaçkreditxtbox.Text);

            notxkreditxtbox.Text = "Karşılık Gelen Notunuz: " + harfnotsonuç + " Ders Krediniz: " + kredi + " \n" + harfnotsonuç + "X" + kredi;


            dersnotsonuç = harfnotsonuç * kredi;
            toplamnotsonuç += harfnotsonuç * kredi;
            //    toplamnotsonuç = harfnotsonuç * kredi + toplamnotsonuç;

            dersnotorttxt.Text = "Ders Not Ortalamanız: " + dersnotsonuç;
            genelnotorttxt.Text = "Genel Not Ortalamanız: " + toplamnotsonuç;

            toplamderskredi += kredi;
            toplamderskreditxtbox.Text = toplamderskredi.ToString();


        }


        float toplamderskredi;
        float dönemnot;


        private void dönemnothesaplabtn_Click(object sender, EventArgs e)
        {
            dönemnot = toplamnotsonuç / toplamderskredi;
            dönemnottxt.Text = "Genel Not Ortalamanız: " + toplamnotsonuç + " /Derslerin Toplam Kredileri: " + toplamderskredi + " \n" + "Dönem Ortalamanız: " + dönemnot; 

        }

    }
}
