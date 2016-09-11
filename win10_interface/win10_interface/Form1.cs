using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win10_interface
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
             sınıfa yetenek ve özellik kazandırır.bu sınıf yapabilir edebilir gibi özellikler kazandırır.
             * örneğin bir sınıfa sipariş edebilir,yemek yapabilir ,hesap alabilir interfacelerini verirsek bu sınıf bu özellikleri kazanır.
             * başka sınıflara rehber olmak için üretiriz interfaceleri.
             */
            Oyuncu o = new Oyuncu();
            o.Adi = "Çağlar";
            o.Yasi = 23;
            o.YasamDegeri = 100;

            //Kanas kns = new Kanas();
            //o.Silahi = kns;

            o.Silahi = new Kanas();//yukarıdakiyle aynı     //Not:Kanasta Silah tipinde olduğu için atama yapabiliriz.
            MessageBox.Show(o.NisanAl());
        }
    }
}
