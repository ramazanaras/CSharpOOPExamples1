using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win10_interfaceuygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Not:interfaceler sınıflara yetenek kazandırmak için kullanılan sınıflara rehber olan yapıdır.
        private void Form1_Load(object sender, EventArgs e)
        {
            Fernandao f = new Fernandao();
            MessageBox.Show(SutCek(f,20.15f,45));//float olduğu için 20.15f yazdık.

            //ServetCetin sc = new ServetCetin();
            //MessageBox.Show(SutCek(sc,15,30));//hata verir çünkü servet çetin de ISutCekebilable interface 'i implemente edilmemiş.
        }
        private string SutCek(ISutCekebilable sut,float hiz,float mesafe) 
        {
            return sut.SutCek(hiz,mesafe);
        }

    }
}
