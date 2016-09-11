using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win5_polymorphizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EtYemekleri ey = new EtYemekleri();
            //MessageBox.Show(ey.SunumSekli());
            YemekSunumSekliGoster(ey);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SebzeYemekleri sy = new SebzeYemekleri();
            //MessageBox.Show(sy.SunumSekli());
            YemekSunumSekliGoster(sy);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AraSicaklar ara = new AraSicaklar();
           // MessageBox.Show(ara.SunumSekli());
            YemekSunumSekliGoster(ara);
        }

        //metod
        void YemekSunumSekliGoster(Yemek ymk) {
            MessageBox.Show(ymk.SunumSekli());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
