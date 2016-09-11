using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_oopgiris
{
    public partial class Form1 : Form//Form sınıfı .Form1 e miras veriyor. Form sınıfındaki özellikler Form1 sınıfına aktarılır.

    {
        public Form1()
        {
            InitializeComponent();
        }

        //string[] personeller =new string[100];//bunu yapmak yerine aşağıdaki diziyi tanımlamak daha mantıklı
        Personel[] personeller = new Personel[100];//sınıf tipinde dizi oluşturuyoruz
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();//personel sınıfı oluşturduk.(nesne oluşturduk.)
             p.Adi = textBox1.Text;
            p.Soyadi = textBox2.Text;
             p.DogumTarihi = dateTimePicker1.Value;
            p.TCKN = textBox3.Text;
            //PersonelEkle(p); //PersonelEkle(ad, soyad, dogumtarihi,tckn); böyle tek tek  yapmak yerine sınıf atadık içine
             
            p.PersonelEkle();  //sınıf parametresini göndermeyedebiliriz
           
            personeller[sayac] = p;//personelleri tutan bir sayaç
            sayac++;

        }


       
    }
}
