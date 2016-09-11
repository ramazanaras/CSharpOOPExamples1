using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win9_abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gitar gtr = new Gitar();
            //MessageBox.Show(gtr.Cal());
            MuzikAletiCal(gtr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Keman kmn = new Keman();    
           // MessageBox.Show(kmn.Cal());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bateri btr = new Bateri();
            //MessageBox.Show(btr.Cal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  MuzikAletleri ma = new MuzikAletleri();//abstract sınıftan instance alınmaz.hata verir.
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        //metot
        private void MuzikAletiCal(MuzikAletleri ma) {
            MessageBox.Show(ma.Cal());  
        }

    }
}
