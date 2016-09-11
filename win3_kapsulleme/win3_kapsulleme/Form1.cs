using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win3_kapsulleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            //u.AdiYaz("Admin");
            //MessageBox.Show(u.Adi);

            u.Adi = "Ramazan";  //set ile değer atıyoruz.
            MessageBox.Show(u.Adi);//get deki değer okunuyor.

            u.Fiyat = 10;       
            //u.KvdliFiyat = 12;  //böyle yazamayız çünkü sadece okunabilir yaptık.
            MessageBox.Show(u.KvdliFiyat.ToString());
                
        }
    }
}
