using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win7_enumeration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //enum:sayılı liste
            /*
            ingiliz anahtarı: özellik(property)
            pembe kutucuk :method 
            sarı şimşek :event (olay)
            iki sarı kutu :seçenek listesidir.içinde seçenekler var.(enum tipleri seçenek listesidir.)       
             * 
             * 
             */

            //alanı 0 sayısaldır ,1 sözeldir,2 eşit ağırlıktır,3 dil bölümüdür
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Ahmet";
            ogr.Alani = Alan.Sayisal;
           // ogr.Alani =20 ; //sözeldir

            ogr.Alani = (Alan)10; //cast ettik(Alan tipinde cast ettik.) ekrana Sayisal yazar.
            MessageBox.Show(Enum.GetName(typeof(Alan), ogr.Alani));//ekrana Sayisal yazar.

          string[] alanlar  =Enum.GetNames(typeof(Alan));
            //alanlar içerisinde sayisal,sozel,eşit ağırlık gibi değerler vardır.

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Alani = Alan.Sayisal;  //Alan tipinde
            ogr2.Cinsiyet = Cinsiyet.Erkek;

            int sys = (int)Alan.Sayisal; //sys=0 olmuş olur index numarasını attık.

            //Button btn = new Button();
            //btn.FlatStyle = FlatStyle.Flat; //Flatstyle tipinde(enum)

        }
       

    }
}
