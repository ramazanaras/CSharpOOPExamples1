using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//bunu yazdık.
namespace win11_generic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //esnek yapı sağlar.
            ArrayList list = new ArrayList();
            list.Add("ahmet");
            list.Add(123);
            list.Add(true);
            list.Add('a');   //aynı listeye bir çok türde eleman ekledik.  list içine object alır istediğini at.
            //list.Remove('a'); içindekini silmek için.

            string isim = (string)list[0];  //unboxing yaptık(objeden stringe çevirdik)sürekli objeyi unboxing yaparak uğraşıyoruz burdada.bunun daha iyisi var generic mimari

            //---------

            List<string> isimler = new List<string>();
            isimler.Add("ali");//içine sadece string yazabiliriz.

            List<int> sayilar = new List<int>();
            sayilar.Add(452); //içine sadece sayı yazabiliriz.

            int sayi = sayilar[0];


            //Ogrenci<string> o1 = new Ogrenci<string>();
            //o1.TemsiliTipi ="ramazan";  string alır.

           // Ogrenci<int> o2=new Ogrenci<int>();
           // o2.TemsiliTipi = 5;  int alır.

            //Not: int ,float struct tipindedir.
            //Not:string class tipindedir.

            //Not:   c# ta 5 temel  tip vardır
            //  struct,enum,class,delegate,interface


            Ogrenci<string, int, decimal> o1 = new Ogrenci<string, int, decimal>();


         //   Ogrenci<Ders, float, bool> o2 = new Ogrenci<Ders, float, bool>();

            Ogrenci<Ders<int>, float, bool> o2 = new Ogrenci<Ders<int>, float, bool>();

            //generic metot
            MetotGeneric mg = new MetotGeneric();
            mg.Add<int>(2);

            mg.Add<float>(10.25f);



        }
    }
}
