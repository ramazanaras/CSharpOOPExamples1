using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win13_IEnumeratoruygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global 
        Takim tkm = new Takim();  

        private void button1_Click(object sender, EventArgs e)
        {
            Oyuncu o = new Oyuncu();
            o.Adi = textBox1.Text;
            o.DogumTarihi = DateTime.Now;
            o.FormaNo = 10;
            o.Mevkii = "Ön libero";
            o.SoyAdi = "Sırkıntı";
            o.Uyrugu = "Papua yeni Gine";
         
            //ekleme yapmadan önce new'lemek gerekiyordu Takim sınıfında new'ledik.
            tkm.Oyuncular.Add(o);  //Oyuncu tipinde bir değer istiyordu bizden o 'yu atadık.

            listBox1.Items.Add(o.Adi);//Oyuncuları ekliyoruz listboxa
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tkm.Adi = "B404 Spor";
            tkm.KurulusYili = Convert.ToDateTime("25.09.2015");
            tkm.StadIsmi = "B Sınıfı";

            //tkm.Oyuncular = new List<Oyuncu>(); burdada new leyebiliriz yada Takim Sınıfındaki Constructor metotdada new'leme işlemi yapabiliriz.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Oyuncu o in tkm.Oyuncular)
            {
                listBox2.Items.Add(o.Adi);
            }
        }

    }
}
