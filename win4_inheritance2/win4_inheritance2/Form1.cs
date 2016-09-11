using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win4_inheritance2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EtYemekleri ey = new EtYemekleri();
            MessageBox.Show(ey.SunumSekli());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SebzeYemekleri sy = new SebzeYemekleri();
            MessageBox.Show(sy.SunumSekli());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AraSicaklar ara=new AraSicaklar();
            MessageBox.Show(ara.SunumSekli());
        }
    }
}
