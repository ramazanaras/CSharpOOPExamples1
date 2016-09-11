using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win2_constructor_yapici_metot_
{
    public partial class Form1 : Form
    {
        //Form1'in constructoru
        public Form1()
        {
            InitializeComponent();//nesne ramde üretilirken formun özellikleri tanımlanmış
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Personel sınıfından örnek üretme kısmıdır
            //Bir sınıftan örnek üretmek instance diye adlandırılır.
            Personel p = new Personel();//varsayılan constructor metodu çağrılır.ramde yeni bir alan açar.
            Personel p2 = new Personel("Ramazan");

            Personel p3 = new Personel("Ramazan", "Aras", DateTime.Now, "324234");

            //Object  Initializer(Constructora gerek kalmıyor)
            Personel p4 = new Personel
            { 
            Adi="Hasan",
            DogumTarihi=DateTime.Now,
            TCKN="11231",
            KayitTarihi=DateTime.Now,
            Soyadi="Korkmaz"
            };

            Personel p5 = new Personel { 
            Adi="Mustafa"
            };

            
        }
    }
}
