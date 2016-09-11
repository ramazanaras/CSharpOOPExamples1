using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win8_static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             MessageBox.Show(); statice güzel bir örnektir
             * Çünkü MessageBox bir sınıf ve bundan instance almaya gerek kalmadan . nokta ile metotlarına ulaştık.
             */
            //MessageBox msg = new MessageBox();
            //msg.show();
            //yukarıdaki gibi yapmadık çünkü static olduğu için aşağıdaki gibi yapıyoruz.(instance a gerek yok.)
         //   MessageBox.Show("rasda");

            Ogrenci o1 = new Ogrenci();//new diyince constructor çalışır ve TanimliOgrenciSayisi bir artar.
            o1.Adi = "Ali";
            //MessageBox.Show(o1.TanimliOgrenciSayisi.ToString()); //TanimliOgrenciSayisi=1 oluyor(sınıf oluştururken(yani new Ogrenci derken) constructorda 1 artırdık bu değeri)

            MessageBox.Show(Ogrenci.TanimliOgrenciSayisi.ToString());//TanimliOgrenciSayisi=1 static yaptık çünkü

            Ogrenci o2 = new Ogrenci();//new diyince constructor çalışır ve TanimliOgrenciSayisi bir artar.
            o2.Adi = "Veli";
            //MessageBox.Show(o2.TanimliOgrenciSayisi.ToString());////TanimliOgrenciSayisi=1 burdada 1 oluyor.2 olmasını sağlamak için static yapmamız gerekir.

            MessageBox.Show(Ogrenci.TanimliOgrenciSayisi.ToString());//TanimliOgrenciSayisi=2 oluyor.



          //  Ogrenci.Ekle();//Ekle metodu static olduğu böyle çağırdık



            Ogrenci.TanimliOgrenciSayisi = 5;
            MessageBox.Show(Ogrenci.Ekle().ToString());//sonuc 5 döner.


          //  Ders d = new Ders(); //static sınıftan instance alınamaz hata verir


        }
    }
}
